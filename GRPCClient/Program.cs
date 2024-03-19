using Grpc.Net.Client;
using GRPCMessage;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/waether", GetWeather);

async Task<WeatherState> GetWeather()
{
    var channel = GrpcChannel.ForAddress("http://localhost:5289");
    var client = new WeatherT.WeatherTClient(channel);
    return await client.GetWeatherAsync(new WeatherCity() { Name = "shenzhen" });
}

app.Run();
