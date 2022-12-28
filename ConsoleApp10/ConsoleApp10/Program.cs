using System;
using System.Linq;

//namespace Ex15_1
//{
//    class Car
//    {
//        public int Cost { get; set; }
//        public int MaxSpeed { get; set; }
//    }

//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // ...
//            Car[] cars =
//            {
//                new Car(){Cost= 56, MaxSpeed= 120},
//                new Car(){Cost= 70, MaxSpeed= 150},
//                new Car(){Cost= 45, MaxSpeed= 180},
//                new Car(){Cost= 32, MaxSpeed= 200},
//                new Car(){Cost= 82, MaxSpeed= 280}
//            };

//            var selected = from car in cars
//                           where car.Cost >= 50 && car.MaxSpeed >= 150
//                           select new {car.Cost, car.MaxSpeed};
//            /* Cost가 50 이상, MaxSpeed는 150 이상인 레코드를 조회하는 LINQ */
//            foreach (var c in selected)
//                Console.WriteLine($"Cost : {c.Cost}, MaxSpeed : {c.MaxSpeed}");
//        }
//    }
//}

namespace Ex15_2
{
	class MainApp
	{
		class Car
		{
			public int Cost { get; set; }
			public int MaxSpeed { get; set; }
		}

		static void Main(string[] args)
		{
			Car[] cars =
			{
				new Car(){Cost= 56, MaxSpeed= 120},
				new Car(){Cost= 70, MaxSpeed= 150},
				new Car(){Cost= 45, MaxSpeed= 180},
				new Car(){Cost= 32, MaxSpeed= 200},
				new Car(){Cost= 82, MaxSpeed= 280}
			};

			// ...
			var selected = cars.Where(c => c.Cost < 60).OrderBy(c => c.Cost);
			var selected2 = from car in cars
							where car.Cost < 60
							orderby car.Cost
							select new { car.Cost, car.MaxSpeed };

			foreach (var c in selected2)
			{
				Console.WriteLine($"Cost : {c.Cost}, MaxSpeed : {c.MaxSpeed}");
			}
		}
	}
}
