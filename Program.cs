var builder = WebApplication.CreateBuilder(args);

// Configure logging before building the app
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configure the routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "artists",
    pattern: "artists/{action=ListArtists}/{id?}",
    defaults: new { controller = "Artists" });

app.MapControllerRoute(
    name: "profile",
    pattern: "artists/profile/{alias}",
    defaults: new { controller = "Artists", action = "Profile" });

app.Run();
