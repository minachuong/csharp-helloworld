using System;

namespace HelloWorld
{
	public class Person
	{
		public string Name;

		public static string Status = "I am human";
		public void Introduce() 
		{
			Console.WriteLine("Hi, my name is " + Name);
		}

		public static void Main() 
		{
			Person mina = new Person();
			var minaC = new Person();
			mina.Name = "Mina";
			mina.Introduce();
			Console.WriteLine(Person.Status);

		}
	}
}
