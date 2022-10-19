using System;

namespace Hyperoperation_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(HyperOperate(Convert.ToInt64(args[0]), Convert.ToInt16(args[1]), Convert.ToInt16(args[2])));
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
