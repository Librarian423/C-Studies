using System.Diagnostics.Metrics;
using System;
using System.Reflection;
using System.Linq;

namespace ConsoleApp6
{
    public class MyArray
    {
        public static void Reverse(int[] array, int index, int length)
        {
            int destIndex = index + length;
            int startIndex = index;
            if (array == null  )
			{
                Console.WriteLine("ArgumentNullException");
                return;
            }
            if (destIndex > array.Length ||
                startIndex >= array.Length ||
                startIndex < 0 ||
                length < 0 ||
                length >= array.Length) 
			{
                Console.WriteLine("ArgumentOutOfRangeException");
                return;
            }
            if (array.Rank > 1) 
			{
                Console.WriteLine("RankException");
                return;
            }
            
			for (int i = 0; i < length/2; i++)
			{
                int temp = array[startIndex + i];
                array[startIndex + i] = array[destIndex - i-1];
                array[destIndex - i - 1] = temp;

            }
        }

        public static void Fill(int[] array, int value, int startIndex, int count)
        {
            int destIndex = startIndex + count;
            //int index = startIndex;
            if (array == null)
            {
                Console.WriteLine("ArgumentNullException");
                return;
            }
            if (destIndex > array.Length ||
                startIndex >= array.Length ||
                startIndex < 0 ||
                count < 0 ||
                count >= array.Length)
            {
                Console.WriteLine("ArgumentOutOfRangeException");
                return;
            }
            if (array.Rank > 1)
            {
                Console.WriteLine("RankException");
                return;
            }

            for (int i = startIndex; i < destIndex; i++)
            {
                array[i] = value;
            }
        }

        public static void Copy(int[] sourceArray, int[] destinationArray, int length)
        {
            if (sourceArray == null || destinationArray == null) 
			{
				Console.WriteLine("ArgumentNullException");
                return;
            }
			if (sourceArray.Rank != destinationArray.Rank)
			{
				Console.WriteLine("RankException");
				return;
			}
			if (sourceArray.GetType() != destinationArray.GetType())
			{
				Console.WriteLine("ArrayTypeMismatchException");
				return;
			}
            if (length < 0) 
			{
				Console.WriteLine("ArgumentOutOfRangeException");
				return;
			}
			if (length >= sourceArray.Length ||
				length >= destinationArray.Length )
			{
				Console.WriteLine("ArgumentException");
				return;
			}
			for (int i = 0; i < length; i++)
			{
				destinationArray[i] = sourceArray[i];
			}
		}

        public static void Resize(ref int[] array, int newSize)
        {
			if (newSize < 0)
			{
				Console.WriteLine("ArgumentOutOfRangeException");
				return;
			}

            
            int length =  newSize;
            int[] temp = new int[length];

			for (int i = 0; i < length; i++)
            {
                if (i >= array.Length)
                {
                    continue;

				}
                else
                {
					temp[i] = array[i];
				}
                
            }
            array = temp;
		}

        public static void Clear(int[] array)
        {
            if (array == null) 
			{
				Console.WriteLine("ArgumentNullException");
				return;
			}

            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                array[i] = 0;
            }
		}

        public static void Clear(int[] array, int index, int length)
        {
			if (array == null)
			{
				Console.WriteLine("ArgumentNullException");
				return;
			}
            if (index < 0 ||
				length < 0 ||
				index >= array.Length || 
                index + length >= array.Length) 
			{
				Console.WriteLine("ArgumentOutOfRangeException");
				return;
			}

            int destIndex = index + length;
            if (array.Rank == 1)
            {
				for (int i = index; i < destIndex; i++)
				{
					array[i] = 0;
				}
			}
			//if (array.Rank >= 2)
			//{
			//	for (int i = index; i < destIndex; i++)
			//	{
			//		array[i] = 0;
			//	}
			//}
		}

        public static void Sort(int[] array)
        {
			if (array == null)
			{
				Console.WriteLine("ArgumentNullException");
				return;
			}
            if (array.Rank > 1) 
			{
				Console.WriteLine("RankException");
				return;
			}

            int length = array.Length;
            int i, j;
            for (i = 1; i < length; i++) 
            {
                int temp = array[i];
                for (j = i - 1; j >= 0 && array[j] > temp; j--) 
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = temp;
            }
		}

        public static int IndexOf(int[] array, int value)
        {
			if (array == null)
			{
				Console.WriteLine("ArgumentNullException");
                return -1;
			}
			if (array.Rank > 1)
			{
				Console.WriteLine("RankException");
				return -1;
			}

            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (array[i] == value) 
                {
                    return i;
                }
            }
			return -1;
        }

        public static int BinarySearch(int[] array, int value)
        {
			if (array == null)
			{
				Console.WriteLine("ArgumentNullException");
				return -1;
			}
			if (array.Rank > 1)
			{
				Console.WriteLine("RankException");
				return -1;
			}

			int low = 0;
			int high = array.Length - 1;
			int mid;
			while (low <= high) 
			{
				mid = (low + high) / 2;
				if (value < array[mid])
				{
					high = mid - 1;
				}
				else if (value > array[mid]) 
				{
					low = mid + 1;
				}
				else
				{
					return mid;
				}
			}
			return -1;
		}


        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
			int[] array2 = new int[5] { 1, 2, 3, 4, 5 };

			Reverse(array, 0, 4);
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Fill(array, 1, 1, 3);
			foreach (var item in array)
			{
                Console.Write("{0} ", item);
			}
			Console.WriteLine();

            Copy(array, array2, 2);
			foreach (var item in array2)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

			Resize(ref array2, 3);
			foreach (var item in array2)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

            int[,] array3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Clear(array, 1, 3);
			foreach (var item in array)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

			Sort(array);
			foreach (var item in array)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();


            Console.WriteLine("{0}", IndexOf(array, 1));
			Console.WriteLine();
			Console.WriteLine("{0}", BinarySearch(array, 0));
			Console.WriteLine();
		}
    }
    
}