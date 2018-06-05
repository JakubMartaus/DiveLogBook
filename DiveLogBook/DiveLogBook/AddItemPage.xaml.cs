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



		 

        }

	    private void SaveButton_OnClicked(object sender, EventArgs e)
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

	        Database.SaveItemAsync(item);
	    
        }
	}
}