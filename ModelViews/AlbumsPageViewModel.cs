using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;
using WpfApp2.Services;

namespace WpfApp2.ModelViews
{
    public class AlbumsPageViewModel : INotifyPropertyChanged
    {
        private readonly Services.ApiService _apiService;
        private ObservableCollection<Album> _albums = new();
        
        public ObservableCollection<Album> Albums 
        { 
            get => _albums; 
            set 
            { 
                _albums = value; 
                OnPropertyChanged(); 
            } 
        }
        
        public ApiService ApiService => _apiService;
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        public AlbumsPageViewModel(ApiService apiService)
        {
            _apiService = apiService;
           _=LoadAlbumsAsync();
        }
        
        private async Task LoadAlbumsAsync()
        {
            var albums = await _apiService.GetAlbumsAsync();
            foreach (var album in albums)
                Albums.Add(album);
        }
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
