using System;

//namespace RectArea
//{
//    class MainApp
//    {
//        public static void Main()
//        {
//            Console.WriteLine("사각형의 너비를 입력하세요.");
//            string width = Console.ReadLine();

//            Console.WriteLine("사각형의 높이를 입력하세요.");
//            string height = Console.ReadLine();


//            Console.WriteLine($"넓이 {Convert.ToInt32(width) * Convert.ToInt32(height)}"); 
//        }
//    }
//}

//2번
//int a = 7.3(float 형)
//float b = 3.14(double 형)
//double c = a * b(형식 오류)
//char d = "abc"(문자열)
//string e = '한'(char 형)
//

//3번 
//값 형식은 스택(Stack) 공간에 데이터를 할당
//참조 형식은 힙(Heap) 공간에 데이터를 할당

//4번
//박싱은 값 형식을 Object의 형태인 참조 형식으로 변환 하는것
//언박싱은 Object형식에서 값 형식으로 변환 하는것

//5번 
//int
//string

namespace StringQuestions
{
    class MainApp
    {
        public static void Main()
        {
            Console.WriteLine("문자열을 입력하세요.");
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            string[] arr = input.Split(
                new string[] { " " }, StringSplitOptions.None);

            char[] countStr = input.ToCharArray();
            int countAlp = 0;
            int countSP = 0;
            int countNum = 0;
            foreach (char c in countStr)
            {
                if (c >= '0' && c <= '9')
                {
                    countNum++;
                }
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    countAlp++;
                }
                else
                {
                    countSP++;

                }
            }



            int count = 0;
            char[] words = input.ToCharArray();
            char word = '0';

            for (int i = 0; i < words.Count(); i++) 
			{
                int ct = 0;
				for (int j  = 0; j < words.Count(); j++)
				{
                    if (words[i] == words[j]) 
					{
                        ct++;
					}

                }
				if (count < ct)
				{
                    //word.
                    count = ct;
                    word = words[i];

                }
            }
           
           

            Console.WriteLine("1. 뒤집어서 출력: {0}", new string(chars));
            Console.WriteLine("2. 단어의 수: {0}", arr.Count());
            Console.WriteLine("3. 알파벳: {0}  특수문자: {1}   숫자: {2}",countAlp,countSP,countNum);
            Console.WriteLine("4. 문자: {0}  횟수: {1}", word, count);
            Console.Write("5. 대소문자: ");
           
            foreach (var item in input)
            {
                if (char.IsLower(item))
                {
                    Console.Write("{0}", char.ToUpper(item));
                }
                else
                {
                    Console.Write("{0}", char.ToLower(item));
                    
                }
            }
            Console.WriteLine("");

            Console.WriteLine("문자열을 입력하세요.");
            string input1 = Console.ReadLine();
            Console.WriteLine("문자열을 입력하세요.");
            string input2 = Console.ReadLine();

            string[] arr2 = input1.Split(
                new string[] { " " }, StringSplitOptions.None);

            int count1 = 0;
			foreach (var item in arr2)
			{
				if (item == input2)
				{
                    count1++;
				}
			}
            Console.WriteLine("6. 횟수: {0}", count1);
        }
    }
}
