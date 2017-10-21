using System;
using HelloWorld.Math;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			var john = new Person();
			john.FirstName = "Foos";
			john.LastName = "Fez";
			john.Introduce();

			Calculator calculator = new Calculator();
			var result = calculator.Add(3, 4);
			Console.WriteLine(result);
		}
	}
}
