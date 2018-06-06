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
    public partial class MasterDetailPages : MasterDetailPage
    {
        public static MasterDetailPages Instance;
        public MasterDetailPages()
        {
            InitializeComponent();
            Instance = this;
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPagesMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
        public static void CustomNavigationTo()
        {
            Instance.Detail = new NavigationPage(new MasterDetailPagesDetail());
        }
    }
}