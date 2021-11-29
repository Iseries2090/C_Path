using System;

namespace MyUtilities
{
	public class WeatherUtilities
	{
		public WeatherUtilities()
		{
		}

		static float FahrenheitToCelisius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }

		static float CelsiusToFahrenheit ( float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }
		//The lower the index the more comfortable it is
		static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
			//Probably not a very reliable formula
			
			return (temperatureFahrenheit + humidityPercent) / 4; 
		}

		public static void Report(string location, float temperatureCelsius, float humidity)
        {
			var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
			Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
	}


}
