using System;

namespace bsp03
{
	public class WheaterChangeEvent:EventArgs
	{

		public double humidty;
		public double temperture;
		public double pressure;

		public WheaterChangeEvent (float humidty,float temperture,float pressure)
		{
			this.humidty = humidty;
			this.temperture = temperture;
			this.pressure = pressure;
		}
	}
}

