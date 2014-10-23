using System;

namespace a_Observer
{
	public class WheaterChangeEvent:EventArgs
	{

		float humidty;
		float temperture;
		float pressure;

		public WheaterChangeEvent (float humidty,float temperture,float pressure)
		{
			this.humidty = humidty;
			this.temperture = temperture;
			this.pressure = pressure;
		}
	}
}

