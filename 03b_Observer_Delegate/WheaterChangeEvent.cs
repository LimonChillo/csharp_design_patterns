/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03b
{
	public class WheaterChangeEvent:EventArgs
	{

		public double humidty;
		public double temperture;
		public double pressure;

		public WheaterChangeEvent (double humidty,double temperture,double pressure)
		{
			this.humidty = humidty;
			this.temperture = temperture;
			this.pressure = pressure;
		}
	}
}

