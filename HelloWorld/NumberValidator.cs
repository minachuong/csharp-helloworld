using System;

namespace HelloWorld
{
	public class NumberValidator
	{
		public static string Validity;
		public static void isValid(int num)
		{
			if (num >= 1 && num <= 10)
			{
				NumberValidator.Validity = "\nValid";
			}
			else 
			{
				NumberValidator.Validity = "\nInvalid";
			}
			Console.WriteLine(NumberValidator.Validity);	
		}
	}
}
