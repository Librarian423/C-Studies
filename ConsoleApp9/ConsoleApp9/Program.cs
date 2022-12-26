using System;

//문제 1번
//70

namespace Ex14_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array)
            {
                Action action = () => Console.WriteLine(a * a);
                action.Invoke();
            }

        }
    }
}