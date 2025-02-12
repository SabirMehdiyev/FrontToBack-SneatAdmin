using FrontToBack_Practice.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();
            

            app.UseStaticFiles();

            app.UseRouting();


            app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}