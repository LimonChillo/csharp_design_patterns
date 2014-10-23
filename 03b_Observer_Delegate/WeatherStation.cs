using System;

namespace b_Observer_Delegate
{
	public class WeatherStation
	{


		private double temperature; 
		private double humidity;
		private double air_pressure;

		public delegate void AskWeatherChangeDelegate(WeatherChangeEvent w);

		public event AskWeatherChangeDelegate AskWeatherChanged;

		public WeatherChangeEvent AskWeather
		{

			set { 

				temperature = Convert.ToDouble(value.ToString());
				AskWeatherChanged(new WeatherChangeEvent(humidity,temperature,air_pressure)); 
			}
		}
	}
}

