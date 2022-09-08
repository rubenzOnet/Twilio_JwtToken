using Twilio.Core.SMS.Repositories;
using Twilio.Core.SMS.Services;
using Twilio.Core.WhatsApp.Repositories;
using Twilio.Core.WhatsApp.Services;

namespace TwilioCore_WebApi
{
    public class Startup
    {

        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddScoped<ITwilioSMS, TwilioSMS>();
            services.AddScoped<ITwilioWhatsApp, TwilioWhatsApp>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

    }
}
