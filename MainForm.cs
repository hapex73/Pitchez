//  THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//  PURPOSE.
//
//  This material may not be duplicated in whole or in part, except for 
//  personal use, without the express written consent of the author. 
//
//  Email:  ianier@hotmail.com
//
//  Copyright (C) 1999-2003 Ianier Munoz. All Rights Reserved.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace cswavrec
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.OpenFileDialog OpenDlg;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.StartButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.OpenDlg = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(8, 12);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(72, 24);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Start";
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.Location = new System.Drawing.Point(88, 12);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(72, 24);
			this.StopButton.TabIndex = 1;
			this.StopButton.Text = "Stop";
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// OpenDlg
			// 
			this.OpenDlg.DefaultExt = "wav";
			this.OpenDlg.Filter = "WAV files|*.wav";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(250, 47);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.StopButton,
																		  this.StartButton});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Full-duplex audio sample";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private WaveLib.WaveOutPlayer m_Player;
		private WaveLib.WaveInRecorder m_Recorder;
		private WaveLib.FifoStream m_Fifo = new WaveLib.FifoStream();

		private byte[] m_PlayBuffer;
		private byte[] m_RecBuffer;

		private void Filler(IntPtr data, int size)
		{
			if (m_PlayBuffer == null || m_PlayBuffer.Length < size)
				m_PlayBuffer = new byte[size];
			if (m_Fifo.Length >= size)
				m_Fifo.Read(m_PlayBuffer, 0, size);
			else
				for (int i = 0; i < m_PlayBuffer.Length; i++)
					m_PlayBuffer[i] = 0;
			System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
		}

		private void DataArrived(IntPtr data, int size)
		{
			if (m_RecBuffer == null || m_RecBuffer.Length < size)
				m_RecBuffer = new byte[size];
			System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
			m_Fifo.Write(m_RecBuffer, 0, m_RecBuffer.Length);
		}

		private void Stop()
		{
			if (m_Player != null)
				try
				{
					m_Player.Dispose();
				}
				finally
				{
					m_Player = null;
				}
			if (m_Recorder != null)
				try
				{
					m_Recorder.Dispose();
				}
				finally
				{
					m_Recorder = null;
				}
			m_Fifo.Flush(); // clear all pending data
		}

		private void Start()
		{
			Stop();
			try
			{
				WaveLib.WaveFormat fmt = new WaveLib.WaveFormat(44100, 16, 2);
				m_Player = new WaveLib.WaveOutPlayer(-1, fmt, 16384, 3, new WaveLib.BufferFillEventHandler(Filler));
				m_Recorder = new WaveLib.WaveInRecorder(-1, fmt, 16384, 3, new WaveLib.BufferDoneEventHandler(DataArrived));
			}
			catch
			{
				Stop();
				throw;
			}
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Stop();
		}

		private void StartButton_Click(object sender, System.EventArgs e)
		{
			Start();
		}

		private void StopButton_Click(object sender, System.EventArgs e)
		{
			Stop();
		}
	}
}
