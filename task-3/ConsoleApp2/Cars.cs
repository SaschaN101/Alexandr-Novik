using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class Cars
	{

		public string brend;
		public string type;
		public double price;

		public void Print()
		{
			Console.WriteLine("Купил новую машину");

			Console.WriteLine($"Марка: {brend}, тип кузова: {type}, стоимость: {price}");
		}


	}
	Cars bmv = new Cars;
	bmv.Print();
}