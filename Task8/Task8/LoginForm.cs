using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class LoginForm : Form
    {
        public string Login { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Login = txtLogin.Text.Trim();
            if (string.IsNullOrEmpty(Login))
                Login = "Guest";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
