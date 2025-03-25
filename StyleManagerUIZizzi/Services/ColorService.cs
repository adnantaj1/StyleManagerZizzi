using StyleManagerUIZizzi.Models;

namespace StyleManagerUIZizzi.Services
{
    public class ColorService
    {
        private readonly HttpClient _http;

        public ColorService(HttpClient http)
        {
            _http = http;
        }

        public async Task<HttpResponseMessage> CreateColor(ColorDto dto)
        {
            return await _http.PostAsJsonAsync("api/colors", dto);
        }
    }
}
