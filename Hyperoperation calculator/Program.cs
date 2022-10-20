using System;

namespace Hyperoperation_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//starts the program idk
			//very pendantic comments yeah
			Console.WriteLine(HyperOperate(Convert.ToInt64(args[0]), Convert.ToInt16(args[1]), Convert.ToInt16(args[2])));
		}

		static long HyperOperate(long input, short order, short power)
		{
			//starts with the input
			long output = input;
			//ok this sets the order lower because reasons
			order = (short)(order - 2);
			//since this starts lower to higher, i start with exponentiation
			//in higher recursions it will do the previous operation to itself a bunch of times
			//i think this explains
			for(int i = 0; i < power; i++)
			{
				output = (long)Math.Pow(output, input);
				//yeah
			}
			//calls itself again and that's part of the hyperoperation bit
			//also tries not to infinitely run itself
				if (order > 3) {
					//sets output to the hyperoperation result of the lower options
					output = HyperOperate(output, (short)(order - 1), power);
				}
				//because reasons, i have to do another power
			output = (long)Math.Pow(output, input);
			return output;
		}
	}
}
