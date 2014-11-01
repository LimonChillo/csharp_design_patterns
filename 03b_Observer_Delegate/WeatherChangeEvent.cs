/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace b_Observer_Delegate
{
	public class WeatherChangeEvent:EventArgs
	{

		private double humidity;
		private double temperture;
		private double pressure;

		public WeatherChangeEvent (double humidity,double temperture,double pressure)
		{
			this.humidity = humidity;
			this.temperture = temperture;
			this.pressure = pressure;
		}

		public double getTemperature()
		{
			return temperture;
		}

		public double getHumidity()
		{
			return humidity;
		}

		public double getPressure()
		{
			return pressure;
		}
	}
}

