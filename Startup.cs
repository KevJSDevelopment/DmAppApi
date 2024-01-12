using DMApp.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;

namespace DMApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DMAppContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DmAppConnection")));

            services.AddControllers().AddNewtonsoftJson(s => {
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                s.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<ICampaignRepo, SqlCampaignRepo>();
            services.AddScoped<ICampaignSessionRepo, SqlCampaignSessionRepo>();
            services.AddScoped<ICharacterRepo, SqlCharacterRepo>();
            services.AddScoped<ICharacterTokenRepo, SqlCharacterTokenRepo>();
            services.AddScoped<IClassRepo, SqlClassRepo>();
            services.AddScoped<IRaceRepo, SqlCharacterRaceRepo>();
            services.AddScoped<IFeatureRepo, SqlFeatureRepo>();
            services.AddScoped<ITraitRepo, SqlTraitRepo>();
            services.AddScoped<IOrganizationRepo, SqlOrganizationRepo>();
            services.AddScoped<ISpellRepo, SqlSpellRepo>();
            services.AddScoped<IItemRepo, SqlItemRepo>();

            services.AddCors(opt => opt.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DmApp", Version = "v1" });
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DmApp v1"));
            }

            //must be before UseHttpsRedirection
            app.UseCors();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
