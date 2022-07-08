using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_7_1_lab
{
    [Serializable]
    public class Computer
    {
        public int Cores { get; set; }
        public double Frequency { get; set; }
        public int Memory { get; set; }
        public int Hdd { get; set; }
        public Computer(int cores = 0, double frequency = 0, int memory = 0, int hdd = 0)
        {
            Cores = cores;
            Frequency = frequency;
            Memory = memory;
            Hdd = hdd;
        }
        
        public override string ToString()
        {
            return $"\nCores : {Cores},  Frequency : {Frequency}, Memory : {Memory}, Hdd : {Hdd}";
        }

       
    }
}
