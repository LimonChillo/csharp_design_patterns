/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace b_Observer_Delegate
{
	public class Program
	{
		static void Main(string[] args)
		{
			View view = new View();
			view.WeatherDataChanged +=  new View.WeatherDataChangedHandler(view.PrintWeatherData);
			WeatherChangeEvent data = new WeatherChangeEvent(97,28,1.013);
			view.SetData = data;
		}
	}
}

