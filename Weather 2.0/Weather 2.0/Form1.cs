using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.Net;
using Newtonsoft.Json;

namespace Weather_2._0
{
    public partial class Weather : Form
    {
        string API = "7d49eb565d9d429866f0b4b9e7a4b6c4";

        public Weather()
        {
            InitializeComponent();

            
        }

        public void GetWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format($"https://api.openweathermap.org/data/2.5/weather?q={city.Text}&appid={API}");
                    string json = web.DownloadString(url);
                    WeatherInfo.Root info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);
                    labelImage.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                    labelContry.Text = info.sys.country;
                    labelSunrise.Text = DateTimeOffset.FromUnixTimeSeconds(info.sys.sunrise).ToLocalTime().ToString();
                    labelWindSpeed.Text = info.wind.speed.ToString();
                    labelTemperature.Text = ( Math.Round( (info.main.temp - 273.15),2)).ToString();
                    labelFeelsLike.Text = (Math.Round((info.main.feels_like - 273.15), 2)).ToString();
                    labelHumidity.Text = info.main.humidity.ToString();
                    labelMain.Text = info.weather[0].main;
                    labelSunset.Text = DateTimeOffset.FromUnixTimeSeconds(info.sys.sunset).ToLocalTime().ToString();


                }
                    catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (city.Text != "")
                GetWeather();
            else
                MessageBox.Show("Enter name of the city!!!");
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void labelHumidity_Click(object sender, EventArgs e)
        {

        }
    }
}
