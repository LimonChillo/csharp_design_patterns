using System;
using System.IO;
using System.Text;

namespace bsp03
{
	public class View:IObserver
	{

		private string name; 


		private double temperature; 
		private double humidity;
		private double air_pressure;


		public View (string name)
		{
			this.name = name;
		}

		public void update(WheaterChangeEvent w)
		{
			this.temperature = w.temperture;
			this.humidity = w.humidty;
			this.air_pressure = w.pressure;
			printWeather ();
		}

		public void printWeather()
		{
			Console.WriteLine ("New Changes! View: " + name + "| temperture: " + temperature + " humidity: " + humidity + " airpressure: " + air_pressure);
		}
	}
}

