using CaseProject.Business.Services;
using CaseProject.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient(); //Bu metod, uygulama taraf�ndan kullan�lacak HttpClient nesnesini yap�land�rmak i�in kullan�l�r.
builder.Services.AddScoped<NewsService>(); //Bu metod, haber i�lemlerini ger�ekle�tiren NewsService s�n�f�n� tan�mlar.
builder.Services.AddScoped<NewsRepository>(); //Bu metod, haber verilerini almak i�in kullan�lan NewsRepository s�n�f�n� tan�mlar.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=News}/{action=Index}/{id?}");

app.Run();
