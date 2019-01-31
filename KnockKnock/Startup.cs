using Algorithms;
using Algorithms.Abstract;
using KnockKnock.middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Converters;

namespace KnockKnock
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
            services.AddTransient<IFibonacci, Fibonacci>();
            services.AddTransient<IReverseWord, ReverseWord>();
            services.AddTransient<ITriangleType, TrinagleType>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                             new Swashbuckle.AspNetCore.Swagger.Info
                             {

                                 Contact = new Swashbuckle.AspNetCore.Swagger.Contact() { Name = "Musaab Algailani", Email = "masaabmushtaq@gmail.com", Url = "Fumycoder.com" },
                                 Description = "This API is contains solutions for Readify Test",
                                 Title = "Developer",
                                 Version = "v1"
                             });

                var xmlPath = System.AppDomain.CurrentDomain.BaseDirectory + "KnockKnock.xml";
                c.IncludeXmlComments(xmlPath);
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(options => 
            {
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();

     

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMiddleware(typeof(ExceptionHandlingMiddleware));
            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.RoutePrefix = "api/docs";
            });
        }
    }
}
