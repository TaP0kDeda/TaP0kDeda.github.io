using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Region
    {
        public string Name { get; set;  }
        public int Population {  get; set; }
        public int Crimes {  get; set; }

        public Region(string name, int population, int crimes) // конструктор
        {
            Name = name;
            Population = population;
            Crimes = crimes;
        }

        public double CrimeRatePercent
        {
            get
            {
                if (Population <= 0) return 0;
                return (Crimes / (double)(Population * 10));
            }
        }
    }
}
