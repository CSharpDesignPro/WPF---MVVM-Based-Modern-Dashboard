
using ModernDashboard.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace ModernDashboard.ViewModel
{
    public class PCViewModel : INotifyPropertyChanged
    {
        private readonly CollectionViewSource PCItemsCollection;
        public ICollectionView PCSourceCollection => PCItemsCollection.View;

        public PCViewModel()
        {
            ObservableCollection<PCItems> pcItems = new ObservableCollection<PCItems>
            {
                new PCItems { PCName = "Local Disk (C:)", PCImage = @"Assets/drive_icon.png" },
                new PCItems { PCName = "Local Disk (D:)", PCImage = @"Assets/drive_icon.png" },
                new PCItems { PCName = "Local Disk (E:)", PCImage = @"Assets/drive_icon.png" },
                new PCItems { PCName = "Local Disk (F:)", PCImage = @"Assets/drive_icon.png" }

            };

            PCItemsCollection = new CollectionViewSource { Source = pcItems };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
