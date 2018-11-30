using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Library
{
    public class Processor
    {
        public string Family;
        public string Model;
        public string Socket;
        public double Cores;
        public bool HasGraphics;
        public double Freq;
        public bool HasMultiplier;

        public override string ToString()
        {
            return string.Format("{0} {1} | Socket: {2} | Ядер: {3} | Частота: {4} MHz| [{5}, {6}]\r\n",
                Family, Model, Socket,
                Cores, Freq,
                HasMultiplier ? "Є помножувач" : "Немає помножувача",
                HasGraphics ? "Є інтегрована карта" : "Немає інтегрованої карти"); ;
        }
    }
}
