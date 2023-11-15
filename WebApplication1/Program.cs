using CrudInAsp.netCore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc().AddRazorRuntimeCompilation();

// Add services to the container.
builder.Services.AddControllersWithViews();

//dependency injection for dbcontext
builder.Services.AddDbContext<TransactionDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Transactions}/{action=Index}/{id?}");

app.Run();
