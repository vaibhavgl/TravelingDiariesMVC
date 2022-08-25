using Microsoft.EntityFrameworkCore;
using TravelingDiaries.Models;
using Microsoft.AspNetCore.Identity;
using Stripe;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//services for the DI of repository
builder.Services.AddScoped<IPlaceRepository, PlaceRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

//stripepaymentgateway
builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));

//shopping cart constructor
builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


//AppDBContext connetion
string connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();


//adding httpscontext and seesion service
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
//

var app = builder.Build();
//





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//using sessions
app.UseSession();


app.UseRouting();
StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();



app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
