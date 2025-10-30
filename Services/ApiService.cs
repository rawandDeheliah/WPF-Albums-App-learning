using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp2.Models;

namespace WpfApp2.Services
{
    public class ApiService
    {
        private readonly HttpClient _client= new HttpClient();
        public  async Task<List<Album>>GetAlbumsAsync()
        {
            var response = await _client.GetAsync("https://jsonplaceholder.typicode.com/albums");

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Album>>(json)!;

        }

        public async Task<List<Post>> GetPostsAsync()
        {
            var response = await _client.GetAsync("https://jsonplaceholder.typicode.com/posts");

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Post>>(json)!;

        }

        public async Task<Album> GetAlbumByIdAsync(int id)
        {
            var response = await _client.GetAsync($"https://jsonplaceholder.typicode.com/albums/{id}");

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Album>(json)!;
        }

    }
}
