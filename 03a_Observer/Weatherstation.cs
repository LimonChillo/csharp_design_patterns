﻿using System;

namespace a_Observer
{
	public class Weatherstation
	{
		public Weatherstation ()
		{
		}

		private List<IObserver> observers = new ArrayList<IObserver>();
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

		public void registerObserver(WeatherObserver o) 
		{ 
			observers.add(o);
		}

		public boolean removeObserver(WeatherObserver o) 
		{ 
			return observers.remove(o);
		}

		private void notifyObservers() 
		{
			for (WeatherObserver o : observers) 
			{
				o.update();
			}
		}

	
	}
}
