namespace RealTimeChat.Extensions;

public static class CorsExtension
{
    public static IServiceCollection AddAppCors(this IServiceCollection services)
    {

        services.AddCors(options =>
         {
            options.AddPolicy("CorsPolicy", builder =>
            {
                builder
                    .WithOrigins(
                        "http://localhost:4200",  
                        "https://localhost:4200",
                        "https://orange-mud-0a599b003.3.azurestaticapps.net")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .SetIsOriginAllowed(_ => true);
            });
         });
        return services;
    }
}
