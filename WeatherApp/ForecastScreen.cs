using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            // displays current temperature, high,low, weather conditions, and the date and location
            cityOutput.Text = Form1.days[0].location;
            dateLabel.Text = Form1.days[0].date;
            conditionLabel.Text = Form1.days[0].condition;
            currentTemp.Text = Form1.days[0].currentTemp;
            maxLabel.Text = Form1.days[0].tempHigh;
            minLabel.Text = Form1.days[0].tempLow;

            if (Convert.ToInt32(Form1.days[0].weather) <= 232)
            {
                weatherImage.Image = Properties.Resources.rain;
                BackgroundImage = Properties.Resources.RainBackground;
            }
            else if (Convert.ToInt32(Form1.days[0].weather) <= 531)
            {
                weatherImage.Image = Properties.Resources.rain;
                BackgroundImage = Properties.Resources.RainBackground;
            }
            else if (Convert.ToInt32(Form1.days[0].weather) <= 622)
            {
                weatherImage.Image = Properties.Resources.snow;
                BackgroundImage = Properties.Resources.SnowStorm;
            }
            else if (Convert.ToInt32(Form1.days[0].weather) <= 781)
            {
                weatherImage.Image = Properties.Resources.misty;
                BackgroundImage = Properties.Resources.MistyBackground;
            }
            else if (Convert.ToInt32(Form1.days[0].weather) <= 804)
            {
                weatherImage.Image = Properties.Resources.cloudy;
                BackgroundImage = Properties.Resources.CloudySkies;
            }
        }
    }
}
