using System;

namespace MultiplicationTable
{
	class Program
	{
		static void Main(string[]args)
		{
			for(int j = 0; j <= 10; j++)
			{
				for(int i = 1; i <= 10; i++)
				{
					Console.WriteLine($"{i}*{j} = {i * j}\t");
				}
				Console.WriteLine();

			}
            Console.ReadKey();
        }
	}
}