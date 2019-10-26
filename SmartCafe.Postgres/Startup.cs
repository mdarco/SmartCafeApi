using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NodaTime;
using Npgsql;
using SmartCafe.Postgres.Hubs;
using AutoMapper;

namespace SmartCafe.Postgres
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
            var connectionString = Configuration["Postgres:ConnectionString"];

            services.AddAutoMapper(typeof(Startup));

            services.AddSingleton<IClock>(SystemClock.Instance);

            // services.AddDbContext<Models.SmartCafeContext>(options => options.UseNpgsql(connectionString, sql => sql.UseNodaTime()));
            services.AddDbContext<Models.SmartCafeContext>(options => options.UseNpgsql(connectionString).EnableSensitiveDataLogging());

            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin().AllowCredentials());
            });

            services.AddSignalR();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // must be between UseRouting and UseEndpoints
            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SmartCafeHub>("/smart-cafe-hub");
                endpoints.MapControllers();
            });
        }
    }
}
