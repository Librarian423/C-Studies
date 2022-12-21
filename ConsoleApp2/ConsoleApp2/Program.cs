using System;

namespace ForFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //1번
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            //2번
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            //3번
            int num = 0;
            while (num < 5) 
			{
                int num2 = 0;
                while (num2 <= num) 
				{
                    Console.Write("*");
                    num2++;
                }
                Console.WriteLine("");
                num++;
            }
            Console.WriteLine("");
            num = 5;
            do
			{
                int num2 = 0;
                while (num2 < num)
				{
                    Console.Write("*");
                    num2++;
                }
                Console.WriteLine("");
                num--;
            } while (num >= 0);

            //4번
            Console.Write("반복 횟수를 입력하세요: ");
            string input = Console.ReadLine();
            if (Convert.ToInt32(input) <= 0) 
			{
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                return;
            }
			else
			{
                int count = Convert.ToInt32(input);
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

    }

	
}