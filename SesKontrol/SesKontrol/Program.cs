using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;

namespace SesKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            synthesizer.Volume = 100;  // 0...100

            synthesizer.Rate = -2;     // -10...10

            // Synchronous
            synthesizer.Speak("My Name is Orhan");

            // Asynchronous
          //  synthesizer.SpeakAsync("Hello World");



        }
    }
}
