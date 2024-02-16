using Shared.Repositories;
using BLL = BLL_Cinema;
using DAL = DAL_Cinema;

namespace ASP_cinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = builder.Configuration.GetConnectionString("DB-Projet-Cinema");


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Ajout services par injection de d�pendance BLL:
            builder.Services.AddScoped<ICinemaPlaceRepository<BLL.Entities.CinemaPlace>, BLL.Services.CinemaPlaceService>();
            builder.Services.AddScoped<ICinemaRoomRepository<BLL.Entities.CinemaRoom>, BLL.Services.CinemaRoomService>();
            builder.Services.AddScoped<IMovieRepository<BLL.Entities.Movie>, BLL.Services.MovieService>();
            builder.Services.AddScoped<IDiffusionRepository<BLL.Entities.Diffusion>, BLL.Services.DiffusionService>();


            // Ajout services par injection de d�pendance DAL:
            builder.Services.AddScoped<ICinemaPlaceRepository<DAL.Entities.CinemaPlace>, DAL.Services.CinemaPlaceService>();
            builder.Services.AddScoped<ICinemaRoomRepository<DAL.Entities.CinemaRoom>, DAL.Services.CinemaRoomService>();
            builder.Services.AddScoped<IMovieRepository<DAL.Entities.Movie>, DAL.Services.MovieService>();
            builder.Services.AddScoped<IDiffusionRepository<DAL.Entities.Diffusion>, DAL.Services.DiffusionService>();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=CinemaPlace}/{action=Index}/{id?}");

            app.Run();
        }
    }
}