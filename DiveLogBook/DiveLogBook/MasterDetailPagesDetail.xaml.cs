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
    public partial class MasterDetailPagesDetail : ContentPage
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
        public MasterDetailPagesDetail()
        {
            InitializeComponent();

            var itemsFromDb = Database.GetItemsNotDoneAsync();
            // test.Text = itemsFromDb.ToString();
            PeopleListViewFormatted.ItemsSource = itemsFromDb;
        }
    }
}