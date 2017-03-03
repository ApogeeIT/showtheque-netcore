using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShowTheque.Business;
using ShowTheque.DataEf;

namespace ShowTheque.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddDbContext<ShowDbContext>(options =>
            {
                options.UseNpgsql("User ID=show;Host=localhost;Port=15101;Database=show;Password=show;Pooling=true;");
            });

            //services.AddSingleton<IShowRepository, ShowRepository>();
            services.AddScoped<IShowRepository, EfShowRepository>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
