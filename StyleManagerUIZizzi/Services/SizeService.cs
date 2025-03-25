using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using StyleManagerUIZizzi.Models;

namespace StyleManagerUIZizzi.Services
{
    public class SizeService
    {
        private readonly HttpClient _http;

        public SizeService(HttpClient http)
        {
            _http = http;
        }

        public async Task<HttpResponseMessage> CreateSize(SizeDto dto)
        {
            return await _http.PostAsJsonAsync("api/sizes", dto);
        }
    }
}
