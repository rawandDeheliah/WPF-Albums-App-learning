using Microsoft.Extensions.DependencyInjection;
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
using System.Windows.Shapes;
using WpfApp2.ModelViews;
using WpfApp2.Views;

namespace WpfApp2.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _vm;
        private readonly IServiceProvider _serviceProvider;

        public MainWindow(MainViewModel vm , IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _vm = vm;
            _vm.MainFrame = MainFrame;
            _serviceProvider = serviceProvider;
            DataContext= _vm;
            _vm.NavigateTo(_serviceProvider.GetRequiredService<StaticPage>());
        }
        public void StaticPage_Click(object sender, RoutedEventArgs e)
        {
            var staticPage = _serviceProvider.GetRequiredService<StaticPage>();
            _vm.NavigateTo(staticPage);
        }
        public void AlbumsPage_Click(object sender, RoutedEventArgs e)
        {
            var page = _serviceProvider.GetRequiredService<AlbumsPage>();
            _vm.NavigateTo(page);
        }
        // another way best practise in wpf
        public void ContactPage_Click(object sender, RoutedEventArgs e)
        {
            var contactPage = _serviceProvider.GetRequiredService<ContactUsPage>();
           
            _vm.NavigateTo(contactPage);
        }
        public void PostsPage_Click(object sender, RoutedEventArgs e)
        {
            var postsPage = _serviceProvider.GetRequiredService<PostsPage>();

            _vm.NavigateTo(postsPage);
        }
    }
}
