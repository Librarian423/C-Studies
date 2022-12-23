using System;

//namespace Ex13_1
//{
//    delegate int MyDelegate(int a, int b);

//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            MyDelegate Callback;
//            Callback = delegate (int a, int b)
//            {
//                return a + b;
//            };
//            Console.WriteLine(Callback(3, 4));
//            Callback = delegate (int a, int b)
//            {
//                return a - b;
//            };
//            Console.WriteLine(Callback(7, 5));
//        }
//    }
//}

namespace Ex13_2
{
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;

        public void BuySomething(int CustomerNo)
		{
            if (CustomerNo == 30) 
			{
                CustomerEvent(CustomerNo);
			}
		}
    }

	class MainApp
	{
        //static void EventWon(int number)
        //{
        //    Console.WriteLine("축하합니다! {0}번째 고객 이벤트에 당첨되셨습니다.", number);
        //}

        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(
                delegate(int a) 
            { 
                Console.WriteLine("축하합니다! {0}번째 고객 이벤트에 당첨되셨습니다.", a); 
            }
            );

			for (int i = 0; i < 100; i+=10)
			{
                market.BuySomething(i);
			}
        }
    }
}
