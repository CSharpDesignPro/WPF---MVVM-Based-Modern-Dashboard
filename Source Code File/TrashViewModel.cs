
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using ModernDashboard.Model;

namespace ModernDashboard.ViewModel
{
    public class TrashViewModel : INotifyPropertyChanged
    {
        private CollectionViewSource TrashItemsCollection;
        public ICollectionView TrashSourceCollection => TrashItemsCollection.View;

        public TrashViewModel()
        {           
            ObservableCollection<TrashItems> trashItems = new ObservableCollection<TrashItems>
            {

                new TrashItems { TrashName = "Data.txt", TrashImage = @"Assets/notepad_icon.png" }

            };

            TrashItemsCollection = new CollectionViewSource { Source = trashItems };
            TrashItemsCollection.Filter += MenuItems_Filter;

        }

        private string filterText;
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                TrashItemsCollection.View.Refresh();
                OnPropertyChanged("FilterText");
            }
        }

        private void MenuItems_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(FilterText))
            {
                e.Accepted = true;
                return;
            }

            TrashItems _item = e.Item as TrashItems;
            if (_item.TrashName.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
