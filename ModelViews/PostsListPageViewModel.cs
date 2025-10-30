using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfApp2.Models;
using WpfApp2.Services;
namespace WpfApp2.ModelViews
{
    public class PostsListPageViewModel
    {
        private readonly Services.ApiService _apiService;
        private ObservableCollection<Post> _Posts = new();

        public ObservableCollection<Post> Posts
        {
            get => _Posts;
            set
            {
                _Posts = value;
                OnPropertyChanged();
            }
        }

        public ApiService ApiService => _apiService;

        public event PropertyChangedEventHandler PropertyChanged;

        private async Task LoadPostsAsync()
        {
            var posts = await _apiService.GetPostsAsync();
            foreach (var post in posts)
                Posts.Add(post);
        }

        public PostsListPageViewModel(ApiService apiService)
        {
            _apiService = apiService;
            _ = LoadPostsAsync();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
