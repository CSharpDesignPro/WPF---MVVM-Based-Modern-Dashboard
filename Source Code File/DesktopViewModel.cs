
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using ModernDashboard.Model;

namespace ModernDashboard.ViewModel
{
    public class DesktopViewModel : INotifyPropertyChanged
    {
        private readonly CollectionViewSource DesktopItemsCollection;
        public ICollectionView DesktopSourceCollection => DesktopItemsCollection.View;

        public DesktopViewModel()
        {            
            ObservableCollection<DesktopItems> desktopItems = new ObservableCollection<DesktopItems>
            {
                new DesktopItems { DesktopName = "File", DesktopImage = @"Assets/file_icon.png" },
                new DesktopItems { DesktopName = "Music", DesktopImage = @"Assets/musical_icon.png" },
                new DesktopItems { DesktopName = "Pictures", DesktopImage = @"Assets/picture_icon.png" },
                new DesktopItems { DesktopName = "Analytics", DesktopImage = @"Assets/analytics_icon.png" },
                new DesktopItems { DesktopName = "Webcam", DesktopImage = @"Assets/webcam_icon.png" },
                new DesktopItems { DesktopName = "Printer", DesktopImage = @"Assets/printer_icon.png" },
                new DesktopItems { DesktopName = "Services", DesktopImage = @"Assets/services_icon.png" },               
                new DesktopItems { DesktopName = "Chart", DesktopImage = @"Assets/chart_icon.png" },
                new DesktopItems { DesktopName = "Film", DesktopImage = @"Assets/film_icon.png" },
                new DesktopItems { DesktopName = "Alarm", DesktopImage = @"Assets/alarm_icon.png" },
                new DesktopItems { DesktopName = "Headphone", DesktopImage = @"Assets/headphone_icon.png" },
                new DesktopItems { DesktopName = "Password", DesktopImage = @"Assets/password_icon.png" },
                new DesktopItems { DesktopName = "Calendar", DesktopImage = @"Assets/calendar_icon.png" }

            };

            DesktopItemsCollection = new CollectionViewSource { Source = desktopItems };
            DesktopItemsCollection.Filter += MenuItems_Filter;

        }

        private string filterText;
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                DesktopItemsCollection.View.Refresh();
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

            DesktopItems _item = e.Item as DesktopItems;
            if (_item.DesktopName.ToUpper().Contains(FilterText.ToUpper()))
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
