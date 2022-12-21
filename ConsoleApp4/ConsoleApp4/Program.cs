using System;

namespace Questions
{
	//7-1번
	//클래스는 형식이며 각 클래스 별로 하나만 존재한다. 데이터 항목과 메소드를 정의해야 한다.
	//객체는 메모리에 적재된 실체이며 무한대로 생성 가능하다. 선언된 데이터 항목에 실제 데이터를 저장하며 메소드를 실행한다.

	//7-2번 
	//B d = new A();가 자식 클라스가 부모 클라스를 참조한다.

	//7-3번 
	//this는 클래스의 현재 인스턴스를 가리키며 확장 메서드의 첫 번째 매개 변수에 대한 한정자로 사용됩니다.
	//base는 파생 클래스 내에서 기본 클래스의 맵버에 엑세스하는데 사용됩니다.

	//7-4번
	//(2)번(깊은 복사)
	//(3)번(값 형식)

	//7-6번
	//다형성은 동일한 메소드를 여러 형태로 나타내는 것이다.
	//오버라이딩(overriding)은 부모 클래스에서 상속 받은 메소드를 자식 클래스에서 제정의하는 것이다.

	//8-1번
	//인터페이스는 클래스가 어떤 메소드를 가질지 경정해 준다
	//인터페이스는 메소드 구현을 가지지 못하고 상속한 실체 클래스는 메소드를 모두 구현해야 함

	//8-2번
	//추상 클래스는 메소드 구현을 가질 수 있다.

	//7-5번
	struct ACSetting
	{
		
		public double currentInCelsius; //현재 온도
		public double target;   //희망 온도

		public readonly double GetFahrenheit()
		{
			//target = currentInCelsius * 1.8 + 32;
			return currentInCelsius * 1.8 + 32;
		}
	}

	//9-1번
	class NameCard
	{
		private int age;
		private string name;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}

	class MainApp
    {
		//7-7번
		public static double GetDiscountRate(object client)
		{
			double rate = 0; 
			switch (client)
			{
				case ("학생", int age) when age < 18:
					rate= 0.2;
					break;
				case ("학생", _):
					rate= 0.1;
					break;
				case ("일반", int age) when age < 18:
					rate= 0.1;
					break;
				case ("일반", _):
					rate= 0;
					break;
			}
			return rate;
		}
		static void Main(string[] args)
        {
			//7-5번
			ACSetting acs;
			acs.currentInCelsius = 25;
			acs.target = 25;

			Console.WriteLine($"{acs.GetFahrenheit()}");
			Console.WriteLine($"{acs.target}");
			//
			//7-7번
			double ret = GetDiscountRate(("일반", 10));
			Console.WriteLine(ret);


			//9-1번
			NameCard myCard = new NameCard();
			myCard.Age = 24;
			myCard.Name = "상현";

			Console.WriteLine("나이 : {0}",myCard.Age);
			Console.WriteLine("이름 : {0}", myCard.Name);

			//9-2번
			var nameCard = new { Name = "박상현", Age = 17 };
			Console.WriteLine("이름:{0}, 나이:{1}", nameCard.Name, nameCard.Age);

			var complex = new { Real = 3, Imaginary = -12 };
			Console.WriteLine("Real:{0}, Imaginary:{1}", complex.Real, complex.Imaginary);
		}
	}
}
