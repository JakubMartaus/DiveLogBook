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
                    new MasterDetailPagesMenuItem { Id = 0, Title = "Ponory", TargetType = typeof(MasterDetailPagesDetail)},
                    new MasterDetailPagesMenuItem { Id = 1, Title = "Přidat ponor", TargetType = typeof(AddItemPage)},
                    new MasterDetailPagesMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailPagesMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailPagesMenuItem { Id = 4, Title = "Page 5" },
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