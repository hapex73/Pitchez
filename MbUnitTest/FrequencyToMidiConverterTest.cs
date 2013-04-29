
namespace MbUnitTest
{
    using System;

    using MbUnitTest;
    using MbUnit.Framework;
    using Pitchez;

    public class FrequencyToMidiConverterTest
    {
        [Test]
        void TestA4()
        {
            Assert.AreEqual(69, FrequencyToMidiConverter.ConvertToMidiNoteNumber(440));
            Assert.AreEqual("A4", FrequencyToMidiConverter.ConvertToMidiToNoteText(440));
        }

    }
}
