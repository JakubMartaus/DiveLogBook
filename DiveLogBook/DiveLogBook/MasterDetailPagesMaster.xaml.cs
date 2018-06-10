using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiveLogBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPagesMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailPagesMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPagesMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPagesMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPagesMenuItem> MenuItems { get; set; }
            
            public MasterDetailPagesMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPagesMenuItem>(new[]
                {
                    new MasterDetailPagesMenuItem { Id = 0, Title = "Dives", TargetType = typeof(MasterDetailPagesDetail)},
                    new MasterDetailPagesMenuItem { Id = 1, Title = "Add Dive", TargetType = typeof(AddItemPage)},
               
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}