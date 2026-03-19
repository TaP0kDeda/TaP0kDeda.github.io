using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            this.Hide();
            regForm.ShowDialog();
            this.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                label3.Text = "Все поля должны быть заполнены!";
                label3.Visible = true;
                return;
            }

            try
            {
                var response = await SupabaseClass.Client.From<NewUser>()
                .Filter("username", Supabase.Postgrest.Constants.Operator.Equals, username)
                .Filter("password", Supabase.Postgrest.Constants.Operator.Equals, password)
                .Get();

                var user = response.Models.FirstOrDefault();

                if (user != null)
                {
                    label3.Visible= true;
                    string a = $"Здравствуйте, {username}!";
                    label3.Text = a;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    if (!string.IsNullOrEmpty(user.avatar_url))
                    {
                        try
                        {
                            pictureBox1.LoadAsync(user.avatar_url);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не удалось загрузить аватарку. " + ex.Message, "Внимание");
                        }
                    }
                }
                else
                {
                    label3.Text = "Пользователь не найден!";
                    label3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Ошибка входа! " + ex.Message;
                label3.Visible = true;
            }
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            await SupabaseClass.InitializeAsync();
            if (SupabaseClass.Client == null)
            {
                label3.Text = "Инициализация не удалась";
            }
        }
    }
}
