namespace InterviewPractice
{

    // Dependencies (IWeatherProvider and ILogger)
    public interface IWeatherProvider {
        public string GetWeather(string city);
    }

    public interface ILogger {
        public void Log(string message);
    }

    // Concrete classes (Implementations)
    public class OpenWeatherProvider : IWeatherProvider {
        public string GetWeather(string city) {
            return $"Sunny in {city}";
        }
    }

    public class ConsoleLogger : ILogger {
        public void Log(string message) {
            Console.WriteLine($"LOG: {message}");
        }
    }

    // Main service that "fetches" data and logs.
    public class WeatherService
    {
        private readonly IWeatherProvider _provider;
        private readonly ILogger _logger;
        public WeatherService(IWeatherProvider weatherProvider, ILogger logger) {
            _provider = weatherProvider;
            _logger = logger;
        }

        public void FetchWeather(string city) {
            _logger.Log($"Fetching weather for {city}"); // Scoped.
            string result = _provider.GetWeather(city); // Transient.
            _logger.Log(result);
        }

    }
}
