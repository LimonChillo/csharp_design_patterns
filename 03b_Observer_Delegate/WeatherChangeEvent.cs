/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace b_Observer_Delegate
{
	public class WeatherChangeEvent:EventArgs
	{

		public double humidty;
		public double temperture;
		public double pressure;

		public WeatherChangeEvent (double humidty,double temperture,double pressure)
		{
			this.humidty = humidty;
			this.temperture = temperture;
			this.pressure = pressure;
		}
	}
}

