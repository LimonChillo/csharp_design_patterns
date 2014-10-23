using System;

namespace bsp03
{
	public class Program
	{
		static void Main(string[] args)
		{
			Weatherstation w1 = new Weatherstation();

			View temperatureView = new View("temperatureView");
			View humidityView = new View("humidityView");

			w1.registerObserver(temperatureView);
			w1.registerObserver(humidityView);

			w1.setData(24, 40, 380);

			w1.removeObserver(humidityView);

			w1.setData(25, 45, 385);
		}
	}
}

