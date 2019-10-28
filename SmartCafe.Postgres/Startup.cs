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
using Microsoft.OpenApi.Models;
using NodaTime;
using Npgsql;
using SmartCafe.Postgres.Hubs;
using AutoMapper;
using SmartCafe.Postgres.DAL;

namespace SmartCafe.Postgres
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public static IConfiguration StaticConfig { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            StaticConfig = configuration;
        }

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
                    builder => builder.AllowAnyOrigin());
            });

            services.AddSignalR();

            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "SmartCafe API", Version = "v1" });
            });

            services.AddScoped<IUsersDal, Users>();
            services.AddScoped<ITablesDal, Tables>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Smart Cafe API v1");

                // to serve Swagger UI at the app root
                s.RoutePrefix = string.Empty;
            });

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
