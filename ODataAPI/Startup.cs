using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OData.Edm;
using ODataAPI.Models;

namespace ODataAPI
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

            services.AddControllers(mvcOptions => mvcOptions.EnableEndpointRouting = false);
            services.AddOData();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();
            app.UseAuthorization();
            app.UseMvc(builder =>
            {
                builder.Select().Expand().Filter().OrderBy()
                  .MaxTop(1000).Count();
                builder.MapODataServiceRoute("odata", "odata", GetEdmModel());
                builder.MapRoute(
                  name: "Default",
                  template: "{controller=Home}/{action=Index}/{id?}");
            });


        }

        private static IEdmModel GetEdmModel()
        {
            var edmBuilder = new ODataConventionModelBuilder();
            edmBuilder.EntitySet<Product>("Products");
            edmBuilder.EntitySet<ProductReview>("ProductReviews");

            return edmBuilder.GetEdmModel();
        }
    }
}
