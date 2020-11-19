using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLWeather
{
    public partial class Background : UserControl
    {
        public static List<BackImage> days = new List<BackImage>();

        public Background()
        {
            InitializeComponent();
            ExtractForecast();
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                BackImage b = new BackImage();

                //TODO: fill day object with required data
                reader.ReadToFollowing("symbol");
                b.range = reader.GetAttribute("number");

                //TODO: if day object not null add to the days list
                days.Add(b);
            }
        }

        private void forecastButton_Click(object sender, EventArgs e)
        {
            currentButton.Visible = forecastButton.Visible = label1.Visible = false;

            ForecastScreen fs = new ForecastScreen();
            this.Controls.Add(fs);
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            currentButton.Visible = forecastButton.Visible = label1.Visible = false;

            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }
    }
}