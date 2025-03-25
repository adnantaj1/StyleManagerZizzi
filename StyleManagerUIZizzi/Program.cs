
using StyleManagerUIZizzi.Data;
using StyleManagerUIZizzi.Services;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddHttpClient<ColorService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7041");
});
builder.Services.AddHttpClient<SizeService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7041"); 
});
builder.Services.AddHttpClient<StyleService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7041");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
