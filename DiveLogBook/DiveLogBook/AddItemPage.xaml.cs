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
	public partial class AddItemPage : ContentPage
	{
	    private static TodoItemDatabase _database;
	    public static TodoItemDatabase Database
	    {
	        get
	        {
	            if (_database == null)
	            {
	                _database = new TodoItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
	            }
	            return _database;
	        }
	    }
        public AddItemPage ()
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
            GaugeIcon.Source = ImageSource.FromFile("gauge.png");
            DepthIcon.Source = ImageSource.FromFile("Depth.png");


		 

        }

	    private void SaveButton_OnClicked(object sender, EventArgs e)
	    {
	        if (CountryEntry.Text == null || LocationEntry.Text == null || DatePick.Date == null || TimePick.Time == null || BuddyEntry.Text == null || WeatherPick.Items == null || WavesPick.Items == null || BoatPick.Items == null || NumberPicker.Text == null || DepthPicker.Text == null)
	        {
	            DisplayAlert("Alert", "You must fill all fields!", "OK");
            }
	        else
	        {
	          
	
	            TodoItem item = new TodoItem();
	            item.Country = CountryEntry.Text;
	            item.Location = LocationEntry.Text;
	            item.Date = DatePick.Date.ToString();
	            item.Time = TimePick.Time.ToString();
	            item.Buddy = BuddyEntry.Text;
	            item.Weather = WeatherPick.SelectedItem.ToString();
	            item.Waves = WavesPick.SelectedItem.ToString();
	            item.Boat = BoatPick.SelectedItem.ToString();
	            item.Depth = DepthPicker.Text + "m".ToString();
	            item.Press = NumberPicker.Text.ToString() + "bars";

	            Database.SaveItemAsync(item);

	            MasterDetailPages.CustomNavigationTo();
            }

	      
        }
	}
}