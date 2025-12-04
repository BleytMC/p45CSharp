using System.Threading.Channels;

namespace _25_Instruments
{
    internal class SymphonicInstrument : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("La-La");
        }
    }
}
