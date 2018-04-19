using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.IO;
using WebSocketSharp;
namespace Tapp
{
    
    public partial class MainView : Form
    {
        public long VehicleID;
        public long StreamingID;
        public string OptionCodes;
        public string VehicleType;
        public string Email;
        public string StreamingToken;
        public MainView()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void MainView_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://owner-api.teslamotors.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Console.WriteLine("Lit");
                string accessToken = Login.ToInsecureString(Login.DecryptString(Properties.Settings.Default.AccessToken));
                var Reqcontent = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("Authorization", $"Bearer {accessToken}")

                });
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                Console.WriteLine("K");
                try
                {
                    var result = await client.GetAsync("/api/1/vehicles/");
                    Console.WriteLine("Await");
                    if (result.IsSuccessStatusCode)
                    {
                        string responseString = await result.Content.ReadAsStringAsync();
                        dynamic response = JsonConvert.DeserializeObject(responseString);
                        Console.WriteLine(response);
                        Int64 id = response.response[0].id_s;
                        OptionCodes = response.response[0].option_codes;
                        VehicleID = id;
                        StreamingID = response.response[0].vehicle_id;
                    }
                    else
                    {

                    }
                } catch
                {
                    Console.WriteLine("Failed to load data");
                }
            }
            var request = WebRequest.Create($"https://www.tesla.com/configurator/compositor/?model=ms&view=STUD_SIDE&options={OptionCodes}&bkba_opt=1&size=1920");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                vehicleImage.Image = Bitmap.FromStream(stream);
            }
                                                                                                                                  
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdBattery_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdClimate_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdLocation_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdSettings_Click(object sender, EventArgs e)
        {
            
        }
        
        private void tabView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private async void Flashlights_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://owner-api.teslamotors.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Login.ToInsecureString(Login.DecryptString(Properties.Settings.Default.AccessToken)));
                Console.WriteLine(VehicleID);
                try
                {
                    var result = await client.PostAsync($"/api/1/vehicles/{VehicleID}/command/flash_lights", null);
                    if (result.IsSuccessStatusCode)
                    {
                        Console.WriteLine(result.StatusCode);
                    }
                    else
                    {
                        string responseString = await result.Content.ReadAsStringAsync();
                        dynamic response = JsonConvert.DeserializeObject(responseString);
                        Console.WriteLine(result.StatusCode);
                    }
                } catch
                {
                    Console.WriteLine("Failure");
                }
            }
        }

        private void MainView_Shown(object sender, EventArgs e)
        {
            
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        /*private void CmdHomelink_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.Timeout = TimeSpan.FromMilliseconds(400);
                var requestUri = $"https://streaming.vn.teslamotors.com/connect/{StreamingID}";
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", $"{Base64Encode($"{Email}:{Login.ToInsecureString(Login.DecryptString(Properties.Settings.Default.AccessToken))}")}");
                //var formUrlEncodedContent = new FormUrlEncodedContent(
                //new List<KeyValuePair<string, string>>() {
                //new KeyValuePair<string, string>("userId", "1000") });

                //formUrlEncodedContent.Headers.ContentType =
                //new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded")
            }
            using (var ws = new WebSocket($"wss://streaming.vn.teslamotors.com/connect/{VehicleID}"))
            {
                ws.OnMessage += (sendr, eb) =>
                    Console.WriteLine("Server says: " + eb.Data);
                ws.SetCredentials("bugrocco@gmail.com", Login.ToInsecureString(Login.DecryptString(Properties.Settings.Default.AccessToken)), false);
                ws.Connect();
                ws.Send("Ping");
                Console.ReadKey(true);
            }
        }*/

        private void CmdLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Exit();
        }

        private async void CmdHorn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://owner-api.teslamotors.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Login.ToInsecureString(Login.DecryptString(Properties.Settings.Default.AccessToken)));
                try
                {
                    var result = await client.PostAsync($"/api/1/vehicles/{VehicleID}/command/honk_horn", null);
                    if (result.IsSuccessStatusCode)
                    {
                        Console.WriteLine(result.StatusCode);
                    }
                    else
                    {
                        string responseString = await result.Content.ReadAsStringAsync();
                        dynamic response = JsonConvert.DeserializeObject(responseString);
                        Console.WriteLine(result.StatusCode);
                    }
                } catch
                {
                    Console.WriteLine("Failure");
                }
            }
        }

        private async void CmdChargePort_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://owner-api.teslamotors.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Login.ToInsecureString(Login.DecryptString(Properties.Settings.Default.AccessToken)));
                Console.WriteLine(VehicleID);
                try {
                    var result = await client.PostAsync($"/api/1/vehicles/{VehicleID}/command/charge_port_door_open", null);

                    if (result.IsSuccessStatusCode)
                    {
                        Console.WriteLine(result.StatusCode);
                    }
                    else
                    {
                        string responseString = await result.Content.ReadAsStringAsync();
                        dynamic response = JsonConvert.DeserializeObject(responseString);
                        Console.WriteLine(result.StatusCode);
                    }
                } catch
                {
                    Console.WriteLine("Failure");
                }
            }
        }

        private async void CmdDoorLocks_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://owner-api.teslamotors.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Login.ToInsecureString(Login.DecryptString(Properties.Settings.Default.AccessToken)));
                Console.WriteLine(VehicleID);
                try
                {
                    var result = await client.PostAsync($"/api/1/vehicles/{VehicleID}/command/door_unlock", null);
                    if (result.IsSuccessStatusCode)
                    {
                        Console.WriteLine(result.StatusCode);
                    }
                    else
                    {
                        string responseString = await result.Content.ReadAsStringAsync();
                        dynamic response = JsonConvert.DeserializeObject(responseString);
                        Console.WriteLine(result.StatusCode);
                    }
                } catch
                {
                    Console.WriteLine("Failure");
                }
            }
        }
    }
}
