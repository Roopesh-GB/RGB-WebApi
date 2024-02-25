using NammaDinner.ApplicationCore;
using NammaDinner.ApplicationCore.Services.Authentication;
using NammaDinnerAPI.Helper;
using NammaDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers().AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
    });

    builder.Services
        .AddApplication()
        .AddInfrastructure();
}


var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}


