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
    public partial class ForecastScreen : UserControl
    {
        string[] thunder = { "200", "201", "202", "210", "211", "212", "221", "230", "231", "232" };
        string[] rain = { "300", "301", "302", "310", "311", "312", "313", "314", "321", "500", "501", "502", "503", "504", "511", "520", "521", "522", "531" };
        string[] snow = { "600", "601", "602", "611", "612", "613", "615", "616", "620", "621", "622" };
        string[] clouds = { "801", "802", "803", "804" };

        Image thunderstorm = Properties.Resources.thunderstorm;
        Image rainy = Properties.Resources.rainy;
        Image cloudy = Properties.Resources.cloudy;
        Image snowy = Properties.Resources.snow;
        Image sunny = Properties.Resources.sunny;
        Image sunnyCloudy = Properties.Resources.sunnyCloudy;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Visible = max1.Visible = min1.Visible = temp1.Visible = day1.Visible = true;
            date2.Visible = max2.Visible = min2.Visible = temp2.Visible = day2.Visible = true;
            date3.Visible = max3.Visible = min3.Visible = temp3.Visible = day3.Visible = true;
            date4.Visible = max4.Visible = min4.Visible = temp4.Visible = day4.Visible = true;
            date5.Visible = max5.Visible = min5.Visible = temp5.Visible = day5.Visible = true;
            date6.Visible = max6.Visible = min6.Visible = temp6.Visible = day6.Visible = cityOutput.Visible = true;

            #region location
            date1.Parent = max1.Parent = min1.Parent = temp1.Parent = day1;
            date2.Parent = max2.Parent = min2.Parent = temp2.Parent = day2;
            date3.Parent = max3.Parent = min3.Parent = temp3.Parent = day3;
            date4.Parent = max4.Parent = min4.Parent = temp4.Parent = day4;
            date5.Parent = max5.Parent = min5.Parent = temp5.Parent = day5;
            date6.Parent = max6.Parent = min6.Parent = temp6.Parent = day6;

            date1.Location = date2.Location = date3.Location = date4.Location = date5.Location = date6.Location = new Point(19, 4);
            max1.Location = max2.Location = max3.Location = max4.Location = max5.Location = max6.Location = new Point(16, 36);
            min1.Location = min2.Location = min3.Location = min4.Location = min5.Location = min6.Location = new Point(16, 60);
            temp1.Location = temp2.Location = temp3.Location = temp4.Location = temp5.Location = temp6.Location = new Point(44, 36);

            cityOutput.Text = Form1.days[0].location;
            #endregion

            #region display forecast
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            temp1.Text = Form1.days[1].temp;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;
            temp2.Text = Form1.days[2].temp;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            temp3.Text = Form1.days[3].temp;

            date4.Text = Form1.days[4].date;
            min4.Text = Form1.days[4].tempLow;
            max4.Text = Form1.days[4].tempHigh;
            temp4.Text = Form1.days[4].temp;

            date5.Text = Form1.days[5].date;
            min5.Text = Form1.days[5].tempLow;
            max5.Text = Form1.days[5].tempHigh;
            temp5.Text = Form1.days[5].temp;

            date6.Text = Form1.days[6].date;
            min6.Text = Form1.days[6].tempLow;
            max6.Text = Form1.days[6].tempHigh;
            temp6.Text = Form1.days[6].temp;
            #endregion

            #region day 1 display
            if (thunder.Contains(Background.days[1].range))
            {
                day1.BackgroundImage = thunderstorm;
            }
            else if (rain.Contains(Background.days[1].range))
            {
                day1.BackgroundImage = rainy;
            }
            else if (clouds.Contains(Background.days[1].range))
            {
                day1.BackgroundImage = cloudy;
            }
            else if (snow.Contains(Background.days[1].range))
            {
                day1.BackgroundImage = snowy;
            }
            else if (Background.days[1].range == "800")
            {
                day1.BackgroundImage = sunny;
            }
            else
            {
                day1.BackgroundImage = sunnyCloudy;
            }
            #endregion

            #region day 2 display
            if (thunder.Contains(Background.days[2].range))
            {
                day2.BackgroundImage = thunderstorm;
            }
            else if (rain.Contains(Background.days[2].range))
            {
                day2.BackgroundImage = rainy;
            }
            else if (clouds.Contains(Background.days[2].range))
            {
                day2.BackgroundImage = cloudy;
            }
            else if (snow.Contains(Background.days[2].range))
            {
                day2.BackgroundImage = snowy;
            }
            else if (Background.days[2].range == "800")
            {
                day2.BackgroundImage = sunny;
            }
            else
            {
                day2.BackgroundImage = sunnyCloudy;
            }
            #endregion

            #region day 3 display
            if (thunder.Contains(Background.days[3].range))
            {
                day3.BackgroundImage = thunderstorm;
            }
            else if (rain.Contains(Background.days[3].range))
            {
                day3.BackgroundImage = rainy;
            }
            else if (clouds.Contains(Background.days[3].range))
            {
                day3.BackgroundImage = cloudy;
            }
            else if (snow.Contains(Background.days[3].range))
            {
                day3.BackgroundImage = snowy;
            }
            else if (Background.days[3].range == "800")
            {
                day3.BackgroundImage = sunny;
            }
            else
            {
                this.BackgroundImage = sunnyCloudy;
            }
            #endregion

            #region day4 display
            if (thunder.Contains(Background.days[4].range))
            {
                day4.BackgroundImage = thunderstorm;
            }
            else if (rain.Contains(Background.days[4].range))
            {
                day4.BackgroundImage = rainy;
            }
            else if (clouds.Contains(Background.days[4].range))
            {
                day4.BackgroundImage = cloudy;
            }
            else if (snow.Contains(Background.days[4].range))
            {
                day4.BackgroundImage = snowy;
            }
            else if (Background.days[4].range == "800")
            {
                day4.BackgroundImage = sunny;
            }
            else
            {
                day4.BackgroundImage = sunnyCloudy;
            }
            #endregion

            #region day5 display
            if (thunder.Contains(Background.days[5].range))
            {
                day5.BackgroundImage = thunderstorm;
            }
            else if (rain.Contains(Background.days[5].range))
            {
                day5.BackgroundImage = rainy;
            }
            else if (clouds.Contains(Background.days[5].range))
            {
                day5.BackgroundImage = cloudy;
            }
            else if (snow.Contains(Background.days[5].range))
            {
                day5.BackgroundImage = snowy;
            }
            else if (Background.days[5].range == "800")
            {
                day5.BackgroundImage = sunny;
            }
            else
            {
                day5.BackgroundImage = sunnyCloudy;
            }
            #endregion

            #region day6 display
            if (thunder.Contains(Background.days[6].range))
            {
                day6.BackgroundImage = thunderstorm;
            }
            else if (rain.Contains(Background.days[6].range))
            {
                day6.BackgroundImage = rainy;
            }
            else if (clouds.Contains(Background.days[6].range))
            {
                day6.BackgroundImage = cloudy;
            }
            else if (snow.Contains(Background.days[6].range))
            {
                day6.BackgroundImage = snowy;
            }
            else if (Background.days[6].range == "800")
            {
                day6.BackgroundImage = sunny;
            }
            else
            {
                day6.BackgroundImage = sunnyCloudy;
            }
            #endregion
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            date1.Visible = max1.Visible = min1.Visible = temp1.Visible = day1.Visible = false;
            date2.Visible = max2.Visible = min2.Visible = temp2.Visible = day2.Visible = false;
            date3.Visible = max3.Visible = min3.Visible = temp3.Visible = day3.Visible = false;
            date4.Visible = max4.Visible = min4.Visible = temp4.Visible = day4.Visible = false;
            date5.Visible = max5.Visible = min5.Visible = temp5.Visible = day5.Visible = false;
            date6.Visible = max6.Visible = min6.Visible = temp6.Visible = day6.Visible = cityOutput.Visible = false;
            daysLabel.Visible = todayLabel.Visible = label4.Visible = false;

            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }
    }
}
