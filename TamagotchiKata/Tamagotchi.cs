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

        public void Feed()
        {
            Hungriness--;
            Fullness++;
        }
    }
}
