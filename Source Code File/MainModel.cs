
/// <summary>
/// Model [ "The Content Creator" ]
/// The model class holds the data. The model can be referred to as the data file for the front-end of the application.
/// </summary>

namespace ModernDashboard.Model
{
    // Main Menu Items
    public class MenuItems
    {
        public string MenuName { get; set; }
        public string MenuImage { get; set; }
    }

    // Home Page
    public class HomeItems
    {
        public string HomeName { get; set; }
        public string HomeImage { get; set; }
    }

    // PC Page
    public class PCItems
    {
        public string PCName { get; set; }
        public string PCImage { get; set; }
    }

    // Desktop Page
    public class DesktopItems
    {
        public string DesktopName { get; set; }
        public string DesktopImage { get; set; }
    }

    // Document Page
    public class DocumentItems
    {
        public string DocumentName { get; set; }
        public string DocumentImage { get; set; }
    }

    // Download Page
    public class DownloadItems
    {
        public string DownloadName { get; set; }
        public string DownloadImage { get; set; }
    }

    // Picture Page
    public class PictureItems
    {
        public string PictureName { get; set; }
        public string PictureImage { get; set; }
    }

    // Music Page
    public class MusicItems
    {
        public string MusicName { get; set; }
        public string MusicImage { get; set; }
    }

    // Movie Page
    public class MovieItems
    {
        public string MovieName { get; set; }
        public string MovieImage { get; set; }
    }

    // Trash Page
    public class TrashItems
    {
        public string TrashName { get; set; }
        public string TrashImage { get; set; }
    }
}
