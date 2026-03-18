using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Login;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        private string AvatarPath = "";
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    AvatarPath = ofd.FileName;
                    pictureBox1.Image = System.Drawing.Image.FromFile(AvatarPath);
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин или пароль не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string avatar_url = "";
                if (!string.IsNullOrEmpty(AvatarPath))
                {
                    byte[] fileBytes = File.ReadAllBytes(AvatarPath);
                    string fileName = $"{username}_avatar{Path.GetExtension(AvatarPath)}";

                    await SupabaseClass.Client.Storage.From("avatars").Upload(fileBytes, fileName);
                    avatar_url = SupabaseClass.Client.Storage.From("avatars").GetPublicUrl(fileName);
                }

                var newUser = new NewUser { username = username, password = password, avatar_url = avatar_url };
                await SupabaseClass.Client.From<NewUser>().Insert(newUser);

                MessageBox.Show("Регистрация успешна, пройдите на окно входа", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
