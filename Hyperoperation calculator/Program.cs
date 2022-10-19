using System;

namespace Hyperoperation_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine(HyperOperate(3, 5, 3));
		}

		static long HyperOperate(long input, short order, short power)
		{
			long output = input;
			order = (short)(order - 2);
			for(int i = 0; i < power; i++)
			{
				output = (long)Math.Pow(output, input);
			}
			
				if (order > 3) {
					HyperOperate(output, (short)(order - 1), power);
				}
			output = (long)Math.Pow(output, input);

			return output;
		}
	}
}
