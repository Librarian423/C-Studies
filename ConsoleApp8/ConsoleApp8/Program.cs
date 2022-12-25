using System.Diagnostics.Metrics;
using System;
using System.Reflection;
using System.Linq;
using System.Collections;

namespace ConsoleApp6
{
	public class MyArray
	{
		public static void Reverse<T>(T[] array, int index, int length)
		{
			int destIndex = index + length;
			int startIndex = index;
			if (array == null)
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

			for (int i = 0; i < length / 2; i++)
			{
				T temp = array[startIndex + i];
				array[startIndex + i] = array[destIndex - i - 1];
				array[destIndex - i - 1] = temp;

			}
		}

		public static void Fill<T>(T[] array, T value, int startIndex, int count)
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

		public static void Copy(Array sourceArray, Array destinationArray, int length)
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
				length >= destinationArray.Length)
			{
				Console.WriteLine("ArgumentException");
				return;
			}

			for (int i = 0; i < length; i++)
			{

				destinationArray.SetValue(sourceArray.GetValue(i), i);
			}
		}

		public static void Resize<T>(ref T[]? array, int newSize)
		{
			if (newSize < 0)
			{
				Console.WriteLine("ArgumentOutOfRangeException");
				return;
			}

			T[] temp = new T[newSize];

			for (int i = 0; i < newSize; i++)
			{
				if (i >= array.Length)
				{
					continue;

				}
				else
				{
					temp.SetValue(array.GetValue(i), i);
				}

			}
			array = temp;
		}

		public static void Clear(Array array)
		{
			if (array == null)
			{
				Console.WriteLine("ArgumentNullException");
				return;
			}

			for (int i = 0; i < array.Length; i++)
			{
				array.SetValue(default, i);
			}
		}

		public static void Clear(Array array, int index, int length)
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
					array.SetValue(default, i);
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

		public static void Sort(Array array)
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
				IComparable temp = (IComparable)array.GetValue(i);
				
				for (j = i - 1; j >= 0; j--) 
				{
					if (array.GetValue(j) == default)
					{
						break;
					}
					else if (array.GetValue(j).ToString().CompareTo(temp) < 0) 
					{
						break;
					}
					array.SetValue(array.GetValue(j), j + 1);
				}
				array.SetValue(temp, j + 1);
			}
		}

		public static int IndexOf(Array array, object? value)
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

			for (int i = 0; i < array.Length; i++)
			{
				if (array.GetValue(i) == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int BinarySearch(Array array, object? value)
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
				if (array.GetValue(mid).ToString().CompareTo(value.ToString()) > 0) 
				{
					high = mid - 1;
				}
				else if (array.GetValue(mid).ToString().CompareTo(value.ToString()) < 0)
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


		
	}
	class MainApp
	{
		static void Main(string[] args)
		{
			string[] array = new string[5] { "1", "2", "3", "4", "5" };
			string[] array2 = new string[5] { "1", "2", "3", "4", "5" };
			int[] array3 = new int[5] { 1, 2, 3, 4, 5 };

			MyArray.Reverse(array, 0, 4);
			foreach (var item in array)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

			MyArray.Fill(array, "6", 1, 3);
			foreach (var item in array)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

			MyArray.Copy(array, array2, 2);
			foreach (var item in array2)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

			MyArray.Resize(ref array3, 3);
			foreach (var item in array3)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

			//int[,] array3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
			MyArray.Clear(array, 1, 3);
			foreach (var item in array)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();

			MyArray.Sort(array);
			foreach (var item in array)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();


			Console.WriteLine("{0}", MyArray.IndexOf(array, "4"));
			Console.WriteLine();
			Console.WriteLine("{0}", MyArray.BinarySearch(array3, 3));
			Console.WriteLine();
		}
	}
}

