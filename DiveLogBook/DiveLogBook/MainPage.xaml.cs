using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiveLogBook
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    



        }
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
        private void Test_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushModalAsync(new AddItemPage());

	    }
	}
}
