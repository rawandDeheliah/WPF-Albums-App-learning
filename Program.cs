using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ModelViews;
using WpfApp2.Services;
using WpfApp2.Views;

namespace WpfApp2
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            
            var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        // Register services
        services.AddSingleton<ApiService>();

        // Register ViewModels
        services.AddSingleton<MainViewModel>();
        services.AddTransient<StaticPageViewModel>();

        services.AddTransient<PostsListPageViewModel>();
        services.AddTransient<AlbumsPageViewModel>();

        // Register Views
        services.AddSingleton<MainWindow>();
        services.AddTransient<StaticPage>();
        services.AddTransient<AlbumsPage>();
        services.AddTransient<PostsPage>();
        services.AddTransient<ContactUsPage>();
    })
    .Build();

            var app = new App();
            // app.InitializeComponent();

            // Run with DI-created MainWindow
            var mainWindow = host.Services.GetRequiredService<MainWindow>();
            app.Run(mainWindow);

        }
    }
}


// example
//    public class MainWindow
//{
//    private ApiService api;

//    public MainWindow()
//    {
//        api = new ApiService(); // MainWindow يصنع ApiService بنفسه
//    }
//}



//public class MainWindow
//{
//    private ApiService api;

//    public MainWindow(ApiService api) // ApiService يُعطى من برا
//    {
//        this.api = api;
//    }
//}
