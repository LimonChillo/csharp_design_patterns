/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;
using System.Collections.Generic;

namespace bsp03
{
	public class Weatherstation:ISubject
	{
		public Weatherstation ()
		{
		}

		private List<IObserver> allObservers = new List<IObserver>();

		private double temperature; 
		private double humidity;
		private double air_pressure;

		public void setData(double temperature, double humidity, double air_pressure)
		{ 
			this.temperature = temperature;
			this.humidity = humidity;
			this.air_pressure = air_pressure;
			notifyObservers();
		}

		public void registerObserver(IObserver o) 
		{ 
			allObservers.Add(o);
		}

		public bool removeObserver(IObserver o) 
		{ 
			return allObservers.Remove(o);
		}

		public void notifyObservers() 
		{
			foreach (IObserver o in allObservers) 
			{
				o.update(new WheaterChangeEvent(humidity,temperature,air_pressure));
			}
		}
	}
}

