using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Implementacao;
using BusinessLayer.Interface;
using DataAccess;
using DataAccess.DataAccessObject;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Api
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
            services.AddDbContext<BancoDeDados>(options =>
                options.UseSqlServer("Data Source = localhost; Initial Catalog = computador; persist security info = True; user id = sa; password = Admin14253678"));
            
            services.AddMvc();
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new Info { Title = "APIs de gerencia de computador", Version = "v1" });
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "Api.xml");
                options.IncludeXmlComments(xmlPath);
            });
            services.AddTransient<IComputadorDao, ComputadorDao>();
            services.AddTransient<IComputadorBll, ComputadorBll>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(options => 
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Gerencia Computador")
            );
            app.UseMvc();
        }
    }
}
