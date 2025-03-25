using StyleManagerUIZizzi.Models;

namespace StyleManagerUIZizzi.Services;
public class StyleService
{
    private readonly HttpClient _http;

    public StyleService(HttpClient http)
    {
        _http = http;
    }

    public async Task<HttpResponseMessage> CreateStyle(CreateStyleDto dto)
    {
        return await _http.PostAsJsonAsync("api/styles", dto);
    }

    public async Task<List<ColorDto>> GetColors()
    {
        return await _http.GetFromJsonAsync<List<ColorDto>>("api/colors") ?? new();
    }

    public async Task<List<SizeDto>> GetSizes()
    {
        return await _http.GetFromJsonAsync<List<SizeDto>>("api/sizes") ?? new();
    }

    public async Task<List<StyleDto>> GetAllStyles()
    {
        return await _http.GetFromJsonAsync<List<StyleDto>>("api/styles") ?? new();
    }
}
