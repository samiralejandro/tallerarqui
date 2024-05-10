using Grpc.Net.Client;
using System;
using System.Threading.Tasks;
using WeatherNamespace;

class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5000");
        var client = new WeatherService.WeatherServiceClient(channel);

        // Request weather forecast
        var weatherResponse = await client.GetWeatherForecastAsync(new WeatherRequest { Days = 5 });
        foreach (var forecast in weatherResponse.Forecasts)
        {
            Console.WriteLine($"Date: {forecast.Date}, Temp: {forecast.TemperatureC}C, Summary: {forecast.Summary}");
        }

        // Send data to Project B
        var response = await client.SendToBAsync(new DataRequest { Data = "Sample data to send" });
        Console.WriteLine($"Response from Project B: {response.Response}");
    }
}
