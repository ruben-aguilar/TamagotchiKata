using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiKata
{
    public class Tamagotchi
    {
        public int Hungriness { get; set; }
        public int Fullness { get; set; }
        public int Happiness { get; set; }
        public int Tiredness { get; set; }

        public void Feed()
        {
            Hungriness--;
            Fullness++;
        }

        public void Play()
        {
            Happiness++;
            Tiredness++;
        }

        public void PutToBed()
        {
            Tiredness--;
        }
    }
}
