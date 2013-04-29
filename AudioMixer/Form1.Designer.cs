namespace AudioMerger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AudioMergerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MixAudioButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilenameGrid = new System.Windows.Forms.DataGridView();
            this.FilenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteBtnColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.AudioMergerMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilenameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AudioMergerMenuStrip
            // 
            this.AudioMergerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.AudioMergerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AudioMergerMenuStrip.Name = "AudioMergerMenuStrip";
            this.AudioMergerMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.AudioMergerMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AudioMergerMenuStrip.Size = new System.Drawing.Size(481, 24);
            this.AudioMergerMenuStrip.TabIndex = 0;
            this.AudioMergerMenuStrip.Text = "AudioMergerMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // AddFileMenuItem
            // 
            this.AddFileMenuItem.Name = "AddFileMenuItem";
            this.AddFileMenuItem.Size = new System.Drawing.Size(163, 22);
            this.AddFileMenuItem.Text = "&Add audio file(s)";
            this.AddFileMenuItem.Click += new System.EventHandler(this.FileAddMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.HelpAboutMenuItem_Click);
            // 
            // MixAudioButton
            // 
            this.MixAudioButton.AutoSize = true;
            this.MixAudioButton.Location = new System.Drawing.Point(154, 27);
            this.MixAudioButton.Name = "MixAudioButton";
            this.MixAudioButton.Size = new System.Drawing.Size(81, 23);
            this.MixAudioButton.TabIndex = 1;
            this.MixAudioButton.Text = "Perform mix";
            this.MixAudioButton.UseVisualStyleBackColor = true;
            this.MixAudioButton.Click += new System.EventHandler(this.MergeAudioButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FilenameGrid
            // 
            this.FilenameGrid.AllowDrop = true;
            this.FilenameGrid.AllowUserToAddRows = false;
            this.FilenameGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilenameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FilenameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilenameColumn,
            this.DeleteBtnColumn});
            this.FilenameGrid.Location = new System.Drawing.Point(0, 56);
            this.FilenameGrid.Name = "FilenameGrid";
            this.FilenameGrid.ReadOnly = true;
            this.FilenameGrid.RowHeadersVisible = false;
            this.FilenameGrid.ShowCellErrors = false;
            this.FilenameGrid.Size = new System.Drawing.Size(480, 190);
            this.FilenameGrid.TabIndex = 3;
            this.FilenameGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilenameGrid_DragEnter);
            this.FilenameGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilenameGrid_DragDrop);
            this.FilenameGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilenameGrid_CellContentClick);
            // 
            // FilenameColumn
            // 
            this.FilenameColumn.FillWeight = 300F;
            this.FilenameColumn.HeaderText = "Filename";
            this.FilenameColumn.Name = "FilenameColumn";
            this.FilenameColumn.ReadOnly = true;
            this.FilenameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteBtnColumn
            // 
            this.DeleteBtnColumn.FillWeight = 50F;
            this.DeleteBtnColumn.HeaderText = "";
            this.DeleteBtnColumn.Name = "DeleteBtnColumn";
            this.DeleteBtnColumn.ReadOnly = true;
            this.DeleteBtnColumn.Text = "Remove";
            this.DeleteBtnColumn.ToolTipText = "Click to remove this audio file";
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(251, 27);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(75, 23);
            this.ClearListButton.TabIndex = 4;
            this.ClearListButton.Text = "Clear list";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 273);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.FilenameGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MixAudioButton);
            this.Controls.Add(this.AudioMergerMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 300);
            this.MinimumSize = new System.Drawing.Size(489, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Audio File Mixer";
            this.AudioMergerMenuStrip.ResumeLayout(false);
            this.AudioMergerMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilenameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AudioMergerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button MixAudioButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.DataGridView FilenameGrid;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilenameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtnColumn;
    }
}

