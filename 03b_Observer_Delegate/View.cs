/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace b_Observer_Delegate
{
	public class View
	{
		private WeatherChangeEvent weather;
		public delegate void WeatherDataChangedHandler(object sender, WeatherDataChangedEventArgs e);
		public event WeatherDataChangedHandler WeatherDataChanged;
	
		public void PrintWeatherData(object sender, WeatherDataChangedEventArgs e)
		{
			Console.WriteLine("Temperatur: " + e.getData.getTemperature());
			Console.WriteLine("Luftdruck: " + e.getData.getPressure());
			Console.WriteLine("Luftfeuchtigkeit: " + e.getData.getHumidity());
		}

		public WeatherChangeEvent SetData
		{
			set
			{
				weather = value;
				OnWeatherDataChanged();
			}
		}

		protected void OnWeatherDataChanged()
		{
			if (WeatherDataChanged != null)
			{
				WeatherDataChanged(this, new WeatherDataChangedEventArgs(weather));
			}
		}

		public class WeatherDataChangedEventArgs : EventArgs
		{
			private WeatherChangeEvent weathercopy;

			public WeatherDataChangedEventArgs(WeatherChangeEvent weather)
			{
				weathercopy = weather;
			}

			public WeatherChangeEvent getData
			{
				get
				{
					return weathercopy;
				}
			}
		}
	}
}

