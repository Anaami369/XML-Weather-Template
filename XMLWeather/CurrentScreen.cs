using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        string[] thunder = {"200", "201", "202", "210", "211", "212", "221", "230", "231", "232"};
        string[] rain = {"300", "301", "302", "310", "311", "312", "313", "314", "321", "500", "501", "502", "503", "504", "511", "520", "521", "522", "531"};
        string[] snow = {"600", "601", "602", "611", "612", "613", "615", "616", "620", "621", "622"};
        string[] clouds = { "801", "802", "803", "804" };

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Visible = temp.Visible = min.Visible = max.Visible = date.Visible = true;

            cityOutput.Text = Form1.days[0].location;
            temp.Text = Form1.days[0].temp;
            min.Text = Form1.days[0].tempLow;
            max.Text = Form1.days[0].tempHigh;
            date.Text = Form1.days[0].date;

            string range1 = Form1.days[0].range;

            if (thunder.Contains(range1))
            {
                this.BackgroundImage = Properties.Resources.thunderstorm;
            }
            else if (rain.Contains(range1))
            {
                this.BackgroundImage = Properties.Resources.rainy;
            }
            else if (clouds.Contains(range1))
            {
                this.BackgroundImage = Properties.Resources.cloudy;
            }
            else if (snow.Contains(range1))
            {
                this.BackgroundImage = Properties.Resources.snow;
            }
            else if (range1 == "800")
            {
                this.BackgroundImage = Properties.Resources.sunny;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.sunnyCloudy;
            }
        }

        private void daysLabel_Click(object sender, EventArgs e)
        {
           label3.Visible = daysLabel.Visible = todayLabel.Visible = label1.Visible = cityOutput.Visible = temp.Visible = min.Visible = max.Visible = date.Visible = false;

            ForecastScreen fs = new ForecastScreen();
            this.Controls.Add(fs);
        }
    }
}
