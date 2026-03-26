using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ArrayRegion
    {
        private List<Region> regions = new List<Region>();
        public int Year { get; set; }
        public int Count
        {
            get { return regions.Count; }
        }

        public Region this[int index]
        {
            get { return regions[index]; }
        }
        public void Add(Region region)
        {
            regions.Add(region);
        }

        public void Clear()
        {
            regions.Clear();
        }

        public IEnumerable<Region> GetAll() => regions;

        public Region GetHighestCrimePercent()
        {
            if (regions.Count == 0) return null;
            return regions.OrderByDescending(r => r.CrimeRatePercent).First();
        }

    }
}
