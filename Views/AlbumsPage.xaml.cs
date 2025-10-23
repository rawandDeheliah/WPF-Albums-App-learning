using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.ModelViews;

namespace WpfApp2.Views
{
    /// <summary>
    /// Interaction logic for AlbumsPage.xaml
    /// </summary>
    public partial class AlbumsPage : Page
    {
        private readonly AlbumsPageViewModel _albumsPageViewModel;

        public AlbumsPage()
        {
            InitializeComponent();
        }

        public AlbumsPage(AlbumsPageViewModel albumsPageViewModel)
        {
            InitializeComponent();
            _albumsPageViewModel = albumsPageViewModel;
            DataContext = albumsPageViewModel;
        }

        private void UserID_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Hyperlink hyperlink && hyperlink.Tag is int albumId)
            {
                // Navigate to AboutPage with the album ID
                var aboutPage = new AboutPage();
                aboutPage.DataContext = new AboutPageViewModel(_albumsPageViewModel.ApiService, albumId);
                NavigationService.Navigate(aboutPage);
            }
        }
    }
}
