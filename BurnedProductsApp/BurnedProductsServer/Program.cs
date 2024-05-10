using Grpc.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using WeatherNamespace;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to use HTTP/2
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5000, o => o.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2);
});

// Add gRPC services to the container
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.MapGrpcService<WeatherServiceImplementation>();

app.Run();

public class WeatherServiceImplementation : WeatherService.WeatherServiceBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public override Task<WeatherForecastResponse> GetWeatherForecast(WeatherRequest request, ServerCallContext context)
    {
        var rng = new Random();
        var forecasts = Enumerable.Range(1, request.Days).Select(index => new WeatherData
        {
            Date = DateTime.Now.AddDays(index).ToString("yyyy-MM-dd"),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToList();

        var response = new WeatherForecastResponse();
        response.Forecasts.AddRange(forecasts);

        return Task.FromResult(response);
    }

    public override Task<DataResponse> SendToB(DataRequest request, ServerCallContext context)
    {
        return Task.FromResult(new DataResponse { Response = $"Datos recibidos: {request.Data}" });
    }
}
