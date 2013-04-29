
namespace Pitchez
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public static class FrequencyToMidiConverter
    {
        /// <summary>
        /// The log10_of2
        /// </summary>
        private static readonly double log10_of2 = Math.Log10(2.0);

        /// <summary>
        /// The tune base hz
        /// </summary>
        private static double tuneBaseHz = 440.0;

        /// <summary>
        /// The note names
        /// </summary>
        private static readonly string[] NoteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B#" };

        /// <summary>
        /// Gets or sets the tune base hz.
        /// </summary>
        /// <value>
        /// The tune base hz.
        /// </value>
        public static double TuneBaseHz
        {
            get
            {
                return FrequencyToMidiConverter.tuneBaseHz;
            }
            set
            {
                FrequencyToMidiConverter.tuneBaseHz = value;
            }
        }


        /// <summary>
        /// Converts the index of to midi note number.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        /// <returns></returns>
        public static int ConvertToMidiNoteNumber(float frequency)
        {
            return (int)((12 * (Math.Log10(frequency / FrequencyToMidiConverter.TuneBaseHz) / FrequencyToMidiConverter.log10_of2) + 69.0) + 0.5);
        }

        /// <summary>
        /// Converts to midi to note text. For example C4 or C#4. 
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        /// <returns></returns>
        public static string ConvertToMidiToNoteText(float frequency)
        {
            int noteIndex = FrequencyToMidiConverter.ConvertToMidiNoteNumber(frequency);

            return FrequencyToMidiConverter.NoteNames[noteIndex % 12] + ((noteIndex / 12) - 1);
        }
    }
}
