using System;

namespace b_Observer_Delegate
{
	public class Program
	{
		static void Main(string[] args)
		{
			View v1 = new View ();x
			WeatherStation w1 = new WeatherStation ();

			WeatherStation.AskWeatherChangeDelegate aDelegate = new WeatherStation.AskWeatherChangeDelegate (v1.AskWeatherChanged);

			w1.AskWeatherChanged += aDelegate;


			w1.AskWeather = 1; 


			w1.AskWeatherChanged -= aDelegate;

		}
	}
}

