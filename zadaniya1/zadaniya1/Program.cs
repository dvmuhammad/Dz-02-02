using System;

namespace zadaniya1
{
	class Calc
	{
		public int x=10;
		public int y = 25;


		public void GetInfo()
		{
			int z = x + y;
			Console.WriteLine($"{x}-{y}-{z}");

		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			Calc calc = new Calc();

			calc.GetInfo();
			Console.ReadKey();
		}
	}
}
