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

namespace WinFormsApp1
{
    internal class SupabaseClass
    {
        public static Supabase.Client Client { get; private set; }

        public static async Task InitializeAsync()
        {
            if (Client == null)
            {
                var url = "https://xmmpmhccabplsalfbgjz.Client.co";
                var key = "sb_publishable_vJLXEsqgg4aeLPdjlL7GlQ_FAtbZQzC";
                var options = new Supabase.SupabaseOptions
                {
                    AutoConnectRealtime = true
                };
                var Client = new Supabase.Client(url, key, options);
                await Client.InitializeAsync();
            }
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
    
}
