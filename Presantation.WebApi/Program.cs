
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using PostModule.Query;
using Presantation.WebApi.Utility;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
var local = configuration.GetConnectionString("Local");
Post_Bootstrapper.Config(services, local);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
#region Versioning
services.AddApiVersioning(option =>
{
    option.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    option.AssumeDefaultVersionWhenUnspecified = true;
    option.ReportApiVersions = true;
});

services.AddVersionedApiExplorer(option =>
{
    option.GroupNameFormat = "'v'VVVV";
});
#endregion
#region Swagger
services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerPostDocument>();
services.AddSwaggerGen();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(x =>
    {
        var provider = app.Services.CreateScope().ServiceProvider.GetRequiredService<IApiVersionDescriptionProvider>();

        foreach (var item in provider.ApiVersionDescriptions)
        {
            x.SwaggerEndpoint($"/swagger/{item.GroupName}/swagger.json", item.GroupName.ToString());
        }

        //x.SwaggerEndpoint("/swagger/VilaOpenApi/swagger.json", "Vila Open Api");
        x.RoutePrefix = "";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
