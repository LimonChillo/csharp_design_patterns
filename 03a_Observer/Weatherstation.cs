using System;
using System.Collections.Generic;

namespace bsp03
{
	public class Weatherstation
	{
		public Weatherstation ()
		{
		}

		private List<IObserver> allObservers = new List<IObserver>();
		private double temperature; 
		private double humidity;

		public double getTemperature() 
		{ 
			return temperature;
		}

		public double getHumidity() 
		{
			return humidity; 
		}

		public void setData(double temperature, double humidity)
		{ 
			this.temperature = temperature;
			this.humidity = humidity;
			notifyObservers();
		}

		public void registerObserver(View v) 
		{ 
			allObservers.Add(v);
		}

		public bool removeObserver(View v) 
		{ 
			return allObservers.Remove(v);
		}

		private void notifyObservers() 
		{
			foreach (View o in allObservers) 
			{
				o.update();
			}
		}

	
	}
}

