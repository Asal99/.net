using System;
using System.Runtime.CompilerServices;


namespace Ncit_lab_asal1

{
	class Circle
	{
		//private double radius = 7.87;
		
		public double Radius
		{
			get; set;
		}
	}
	internal class PropertyDemo
	{

		static void Main(string[] args)
		{
			Circle c1 = new Circle();
			c1.Radius = 10;
			Console.WriteLine("value of radius is = " + c1.Radius);
		}
	}
}

