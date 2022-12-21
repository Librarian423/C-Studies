namespace ConsoleApp3
{
	class Program
	{
		static double Square(double arg)
		{
			return arg*arg;
		}

		public static void Mean(
			double a, double b, double c, 
			double d, double e, ref double mean)
		{
			mean = (a + b + c + d + e) / 5; 
		}

		public static void Plus(int a, int b, out int c)
		{
			c = a + b;
		}

		public static void Plus(double a, double b, out double c)
		{
			c = a + b;
		}
		static void Main(string[] args)
		{
			//1번
			Console.Write("수를 입력하세요: ");
			string input = Console.ReadLine();
			double arg = Convert.ToDouble(input);

			Console.WriteLine("결과 : {0}",Square(arg));

			//2번
			double mean = 0;
			Mean(1, 2, 3, 4, 5, ref mean);
			Console.WriteLine("평균 : {0}",mean);

			//3번
			int a = 3;
			int b = 4;
			int resultA = 0;

			Plus(a,b, out resultA);

			Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

			double x = 2.4;
			double y = 3.1;
			double resultB = 0;

			Plus(x, y, out resultB);

			Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
		}
	}
}