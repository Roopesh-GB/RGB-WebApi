using NammaDinner.ApplicationCore.Services.Authentication;
using NammaDinnerAPI.Helper;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers().AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
    });

    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
}


var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}


