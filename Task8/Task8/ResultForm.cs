using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class ResultForm : Form
    {
        private string login;
        private List<GameResult> allResults;
        public ResultForm(string currentLogin)
        {
            InitializeComponent();
            login = currentLogin;
            LoadResults();
        }

        private void LoadResults()
        {
            string file = "results.dat";
            if (File.Exists(file))
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    allResults = (List<GameResult>)bf.Deserialize(fs);
                }
            }
            else
                allResults = new List<GameResult>();

            var myResults = allResults.FindAll(r => r.Login.Equals(login, StringComparison.OrdinalIgnoreCase));
            listBoxResults.DataSource = myResults;
            listBoxResults.DisplayMember = "ToString";
        }
    }
}
