using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class SupContact
    {
        public static Supabase.Client Client { get; private set; }

        public static async Task InitializeAsync()
        {
            if (Client == null)
            {
                var url = Environment.GetEnvironmentVariable("https://xmmpmhccabplsalfbgjz.supabase.co");
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
    }
}
