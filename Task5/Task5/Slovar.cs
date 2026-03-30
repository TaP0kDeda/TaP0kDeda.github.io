using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Slovar
    {
        private List<string> words = new List<string>();
        private string filename;
        private int count;

        public Slovar() { }

        public Slovar(string filename)
        {
            this.filename = filename;
            LoadDictionary(filename);
            count = words.Count;
        }

        public int Count { get { return count; } }

        public void LoadDictionary(string path)
        {
            try
            {
                words.Clear();
                using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            words.Add(line.Trim());
                    }
                }
                count = words.Count;
            }
            catch (Exception ex)
            {
                throw new Exception("Error accessing file: " + ex.Message);
            }
        }

        public void SaveDictionary(string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    foreach (string word in words)
                        writer.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving file: " + ex.Message);
            }
        }

        public bool AddWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return false;
            string trimmed = word.Trim();
            if (!words.Contains(trimmed))
            {
                words.Add(trimmed);
                count = words.Count;
                return true;
            }
            return false;
        }

        public bool DeleteWord(string word)
        {
            if (words.Remove(word))
            {
                count = words.Count;
                return true;
            }
            return false;
        }

        public List<string> GetAllWords() => new List<string>(words);

        public bool Contains(string word) => words.Contains(word);

        public List<string> GetWordsStartingWith(string prefix)
        {
            if (string.IsNullOrEmpty(prefix))
                return GetAllWords();
            return words.Where(w => w.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length, m = t.Length;
            int[,] d = new int[n + 1, m + 1];
            if (n == 0) return m;
            if (m == 0) return n;

            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 0; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (s[i - 1] == t[j - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            return d[n, m];
        }

        public List<string> FuzzySearch(string pattern, int maxDistance = 3)
        {
            if (string.IsNullOrEmpty(pattern))
                return new List<string>();

            return words.Where(w => LevenshteinDistance(w, pattern) <= maxDistance).ToList();
        }

        public List<string> FindWordForms(string pattern)
        {
            if (string.IsNullOrEmpty(pattern))
                return new List<string>();

            List<string> result = new List<string>();
            int patternLen = pattern.Length;

            foreach (string word in words)
            {
                bool found = false;
                int wordLen = word.Length;

                for (int subLen = patternLen - 1; subLen <= patternLen + 1; subLen++)
                {
                    if (subLen < 1 || subLen > wordLen) continue;

                    for (int start = 0; start <= wordLen - subLen; start++)
                    {
                        string sub = word.Substring(start, subLen);
                        if (LevenshteinDistance(pattern, sub) <= 1)
                        {
                            result.Add(word);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
            }
            return result;
        }
    }
}
