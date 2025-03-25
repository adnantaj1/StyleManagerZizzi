using StyleManagerUIZizzi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register HttpClient once as a named client
builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7041");
});

// Inject services using the shared named client
builder.Services.AddScoped<ColorService>(sp =>
{
    var clientFactory = sp.GetRequiredService<IHttpClientFactory>();
    return new ColorService(clientFactory.CreateClient("ApiClient"));
});
builder.Services.AddScoped<SizeService>(sp =>
{
    var clientFactory = sp.GetRequiredService<IHttpClientFactory>();
    return new SizeService(clientFactory.CreateClient("ApiClient"));
});
builder.Services.AddScoped<StyleService>(sp =>
{
    var clientFactory = sp.GetRequiredService<IHttpClientFactory>();
    return new StyleService(clientFactory.CreateClient("ApiClient"));
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
