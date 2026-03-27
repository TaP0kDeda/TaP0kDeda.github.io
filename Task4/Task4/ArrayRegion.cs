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
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Year);
                writer.WriteLine(regions.Count);
                foreach (var r in regions)
                {
                    writer.WriteLine(r.Name);
                    writer.WriteLine(r.Population);
                    writer.WriteLine(r.Crimes);
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            regions.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                Year = int.Parse(reader.ReadLine());
                int count = int.Parse(reader.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string name = reader.ReadLine();
                    int pop = int.Parse(reader.ReadLine());
                    int crimes = int.Parse(reader.ReadLine());
                    regions.Add(new Region(name, pop, crimes));
                }
            }
        }

    }
}
