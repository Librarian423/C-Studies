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

        }

        public static void Resize(ref int[] array, int newSize)
        {
        }

        public static void Clear(int[] array)
        {

        }

        public static void Clear(int[] array, int index, int length)
        {

        }

        public static void Sort(int[] array)
        {
        }

        public static int IndexOf(int[] array, int value)
        {
            return 0;
        }

        public static int BinarySearch(int[] array, int value)
        {
            return 0;
        }


        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            Reverse(array, 0, 4);
            foreach (var item in array)
            {
                Console.WriteLine("{0}", item);
            }
            Fill(array, 1, 1, 3);
			foreach (var item in array)
			{
                Console.WriteLine("{0}", item);
			}
           
        }
    }
    
}