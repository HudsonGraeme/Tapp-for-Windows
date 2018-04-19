using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security;
using System.Configuration;
namespace Tapp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private async void CmdLogin_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CmdLogin");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://owner-api.teslamotors.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Console.WriteLine("Lit");
                var Reqcontent = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("client_id", "81527cff06843c8634fdc09e8ac0abefb46ac849f38fe1e431c2ef2106796384"),
                new KeyValuePair<string, string>("client_secret", "c7257eb71a564034f9419ee651c7d0e5f7aa6bfbd18bafb5c5c033b093bb2fa3"),
                new KeyValuePair<string, string>("email",TxtEmail.Text),
                new KeyValuePair<string, string>("password", TxtPassword.Text)
                });
                Console.WriteLine("K");
                var result = await client.PostAsync("/oauth/token", Reqcontent);
                Console.WriteLine("Await");
                if(result.IsSuccessStatusCode)
                {
                    LblError.Text = "Success!";
                    LblError.Visible = true;
                    Console.WriteLine(result.StatusCode);
                    string responseString = await result.Content.ReadAsStringAsync();
                    dynamic response = JsonConvert.DeserializeObject(responseString);
                    Console.WriteLine(response);
                    string accessToken = response.access_token;
                    var AppSettings = Properties.Settings.Default;
                    AppSettings.AccessToken = EncryptString(ToSecureString(accessToken));
                    AppSettings.Save();
                    Console.WriteLine(ToInsecureString(DecryptString(AppSettings.AccessToken)));
                    this.Hide();
                    MainView f = new MainView();
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                } else
                {
                    Console.WriteLine(result.StatusCode);
                }
            }
            
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("Salt Is Not A Password");

        public static string EncryptString(SecureString input)
        {
            byte[] encryptedData = System.Security.Cryptography.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)),
                entropy,
                System.Security.Cryptography.DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = System.Security.Cryptography.ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    entropy,
                    System.Security.Cryptography.DataProtectionScope.CurrentUser);
                return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));
            }
            catch (System.Security.Cryptography.CryptographicException e)
            {
                Console.WriteLine(e);
                return new SecureString();
            }
        }

        public static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            var AppSettings = Properties.Settings.Default;
            if (AppSettings.AccessToken != String.Empty)
            {
                Console.WriteLine(AppSettings.AccessToken);
                string token = ToInsecureString(DecryptString(AppSettings.AccessToken));
                Console.WriteLine($"Saved Sucessfully, Token is {token}");
                LblError.Text = "You are logged in!";
                this.Hide();
                MainView f = new MainView();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }
    }
}
