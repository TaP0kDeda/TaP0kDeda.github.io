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

namespace Supabase
{


    public partial class Login : Form
    {
        public static Supabase.Client Client { get; private set; }

        public static async Task InitializeAsync()
        {
            if (Client == null)
            {
                var url = Environment.GetEnvironmentVariable("https://xmmpmhccabplsalfbgjz.Client.co");
                var key = Environment.GetEnvironmentVariable("sb_publishable_vJLXEsqgg4aeLPdjlL7GlQ_FAtbZQzC");
                var options = new Supabase.SupabaseOptions
                {
                    AutoConnectRealtime = true
                };
                var Client = new Supabase.Client(url, key, options);
                await Client.InitializeAsync();
            }
        }

        [Table("users")]
        public class NewUser : BaseModel
        {
            [Column("username")]
            public string username { get; set; }

            [Column("password")]
            public string password { get; set; }

            [Column("avatar_url")]
            public string avatar_url { get; set; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                var response = await Login.Client.From<NewUser>()
                .Filter("username", Supabase.Postgrest.Constants.Operator.Equals, username)
                .Filter("password", Supabase.Postgrest.Constants.Operator.Equals, password)
                .Get();

                var user = response.Models.FirstOrDefault();

                if (user != null)
                {
                    label3.Text = $"Здравствуйте, {username}!";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    if (!string.IsNullOrEmpty(user.avatar_url))
                    {
                        try
                        {
                            pictureBox1.LoadAsync(user.avatar_url);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не удалось загрузить аватарку.", "Внимание");
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
                label3.Text = "Ошибка входа!";
                label3.Visible = true;
            }
        }
    }
}
