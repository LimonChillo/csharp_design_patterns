/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03
{
	public class WeatherChangeEvent:EventArgs
	{

		public double humidty;
		public double temperature;
		public double pressure;

		public WeatherChangeEvent (double humidty,double temperture,double pressure)
		{
			this.humidty = humidty;
			this.temperature = temperture;
			this.pressure = pressure;
		}
	}
}

