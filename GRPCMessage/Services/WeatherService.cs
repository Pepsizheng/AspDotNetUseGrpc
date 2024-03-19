using Grpc.Core;
using GRPCMessage;

public class WeatherSerive : WeatherT.WeatherTBase
{
    public override Task<WeatherState> GetWeather(WeatherCity request, ServerCallContext context)
    {
        WeatherState state = new WeatherState
        {
            IsHot = "true",
            IsRain = "false"
        };
        return Task.FromResult(state);
    }
}