using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Models;
using WpfApp2.Services;

namespace WpfApp2.ModelViews
{
    public class AboutPageViewModel : INotifyPropertyChanged
    {
        private readonly ApiService _apiService;
        private Album _selectedAlbum;
        public int AlbumId { get; set; }

        public Album SelectedAlbum
        {
            get => _selectedAlbum;
            set
            {
                _selectedAlbum = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public AboutPageViewModel(ApiService apiService, int albumId)
        {
            _apiService = apiService;
            AlbumId = albumId;
            LoadAlbumDetails();
        }

        private async void LoadAlbumDetails()
        {
            try
            {
                SelectedAlbum = await _apiService.GetAlbumByIdAsync(AlbumId);
            }
            catch (Exception ex)
            {
                // Handle error - you might want to show a message to the user
                System.Diagnostics.Debug.WriteLine($"Error loading album: {ex.Message}");
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
