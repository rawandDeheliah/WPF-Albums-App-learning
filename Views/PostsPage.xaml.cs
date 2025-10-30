using System;
using System.Collections.Generic;
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
    /// Interaction logic for PostsPage.xaml
    /// </summary>
    public partial class PostsPage : Page
    {
        private readonly PostsListPageViewModel _postsPageViewModel;
        public PostsPage()
        {
            InitializeComponent();

        }

        public PostsPage(PostsListPageViewModel postsPageViewModel)
        {
            InitializeComponent();
            _postsPageViewModel = postsPageViewModel;
            DataContext = postsPageViewModel;
        }
    }
}
