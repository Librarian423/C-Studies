using System;
using System.Collections;

namespace Question
{
    class MainApp
    {
        //1번
        //(1)번 int 배열에 string 값을 할당
        //

        //2번
        private static void MatrixMul(int[,] a, int[,] b)
		{
            int[,] array = new int[2, 2];
            int temp = 0;
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
                    temp = 0;
					for (int k = 0; k < 2; k++)
					{
                        temp += a[i, k] * b[k, j];
                        
					}
                    array[i, j] = temp;
                }
			}
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        //3번
        //5 4 3 2 1

        //4번
        //1 2 3 4 5 

        //5번
        private static void HTable()
		{
            Hashtable ht = new Hashtable();
            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["회사"]);
            Console.WriteLine("URL : {0}", ht["URL"]);
        }
        static void Main(string[] args)
        {
            //2번
            int[,] matrixA =new int[2,2] { { 3, 2 }, { 1, 4 } };
            int[,] matrixB = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            MatrixMul(matrixA, matrixB);
            Console.WriteLine();
            HTable();
        }
    }
}
