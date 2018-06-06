using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiveLogBook
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiveDetail : ContentPage
	{
		public DiveDetail (TodoItem todoItem)
		{
			InitializeComponent ();
            CountryIcon.Source = ImageSource.FromFile("earth.png");
            LocationIcon.Source = ImageSource.FromFile("placeholder.png");
            DateIcon.Source = ImageSource.FromFile("calendar.png");
            TimeIcon.Source = ImageSource.FromFile("clock.png");
            BuddyIcon.Source = ImageSource.FromFile("user.png");
            WeatherIcon.Source = ImageSource.FromFile("DarkCloud.png");
            SeaIcon.Source = ImageSource.FromFile("seaWaves.png");
            BoatIcon.Source = ImageSource.FromFile("boat.png");

            
            CountryLabel.Text = todoItem.Country;
        }
	}
}