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
		private double air_pressure;

		public double getTemperature() 
		{ 
			return temperature;
		}

		public double getHumidity() 
		{
			return humidity; 
		}


		public double getAir_pressure() 
		{ 
			return air_pressure;
		}

		public void setData(double temperature, double humidity, double air_pressure)
		{ 
			this.temperature = temperature;
			this.humidity = humidity;
			this.air_pressure = air_pressure;
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
				o.update(new WheaterChangeEvent(humidity,temperature,air_pressure));
			}
		}

	
	}
}

