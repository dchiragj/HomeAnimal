using HomeAnimals.Repository;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HomeAnimals
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
            //services.AddDbContext<HomeAnimalsDbContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("HomeAnimalsConn")));
            services.AddScoped<IOwnersRepository, OwnersRepository>();
            services.AddScoped<HomeAnimalsDbContext>((s) =>
            {
                var options = new DbContextOptionsBuilder<HomeAnimalsDbContext>().UseSqlServer(Configuration.GetConnectionString("HomeAnimalsConn"),
                assembly => assembly.MigrationsAssembly(typeof(HomeAnimalsDbContext).Assembly.FullName));

                return new HomeAnimalsDbContext(options.Options);
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, HomeAnimalsDbContext dataContext)
        {

            // Create Database and migrate any database changes on startup (includes initial db creation)
            dataContext.Database.EnsureCreated();

            // migrate any database changes on startup (includes initial db creation)
            //dataContext.Database.Migrate();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
