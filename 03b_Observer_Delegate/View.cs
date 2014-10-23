/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;
using System.IO;
using System.Text;

namespace bsp03
{
	public class View:IObserver
	{

		private string name; 

		protected double temperature; 
		protected double humidity;
		protected double air_pressure;

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

		public virtual void printWeather()
		{
			Console.Write("Changes detected! " + name + " : ");
		}
	}
}

