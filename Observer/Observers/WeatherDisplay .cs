namespace Observer.Observers
{
    public class WeatherDisplay : IObserver
    {
        public void Update(float temperature, float humidity)
        {
            Console.WriteLine($"Current Weather Conditions: {temperature}°C and {humidity}% humidity");
        }
    }

}
