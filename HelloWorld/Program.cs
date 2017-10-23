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
			//Console.WriteLine(result);

			//var numbers = new int[3];
			//numbers[1] = 1;
			//Console.WriteLine(numbers[0]);
			//Console.WriteLine(numbers[1]);
			//Console.WriteLine(numbers[2]);
			//int[] numbers = new int[3] { 1, 2, 3 };

			var strings = new string[3];
			Console.WriteLine("1");
			Console.WriteLine(strings[0]);
			Console.WriteLine("");
			Console.WriteLine("A");
			Console.WriteLine(strings[1]);
			Console.WriteLine(strings[2]);

			//string name = string.Format("{0} {1}", firstName, lastName);
			var numbers = new int[3] { 1, 2, 3 };
			string list = string.Join(", ", numbers);
			Console.WriteLine(list);
			Console.WriteLine(list[0]);

			var someAnimal = Animal.Cat;
			Console.WriteLine(someAnimal);
			Console.WriteLine((int)someAnimal);
			var animalId = 1;
			Console.WriteLine((Animal)animalId);
			// converting string to enum
			var longNeck = "Giraffe";
			var tallAnimal = (Animal)Enum.Parse(typeof(Animal), longNeck);

			NumberValidator someNumber = new NumberValidator();
			Console.WriteLine("Please provide a number within the range of 1 - 10: ");
			int input = Int32.Parse(Console.ReadLine());
			NumberValidator.isValid(input);
		}
	}
}
