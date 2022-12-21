using System;

namespace StringQuestions
{
    class MainApp
    {
        public static void Main()
        {
            Console.WriteLine("문자열을 입력하세요.");
            string input = Console.ReadLine();
            string[] lines = { input };
           
            Console.WriteLine("1.{0}", lines[0].Reverse());
        }
    }
}
