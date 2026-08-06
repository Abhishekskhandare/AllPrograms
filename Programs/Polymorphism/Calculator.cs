using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms.Programs.Polymorphism
{
	internal class Calculator
	{
        public Calculator()
        {
			TestMethodOverloading();
			TestMethodOverriding();
		}
        //Method Overloading → Compile-Time Polymorphism
        public void TestMethodOverloading()
		{
			Console.WriteLine("Method Overloading → Compile-Time Polymorphism");

			int result1 = Add(5, 10);
			Console.WriteLine(result1);
			int result2 = Add(5, 10, 22);
			Console.WriteLine(result2);
			double result3 = Add(5.12d, 10.32d);
			Console.WriteLine(result3);
		}

		//Method Overriding → Runtime Polymorphism
		public void TestMethodOverriding()
		{
			Console.WriteLine("Method Overriding → Runtime Polymorphism");

			AdditionCalculator calc = new AdditionCalculator();
			int result = calc.Addition(5, 10);
			Console.WriteLine(result);
			int SubstractionResult = calc.Substraction(5, 10);
			Console.WriteLine(SubstractionResult);

		}


		#region private methods

		private int Add(int a, int b)
		{
			return a + b;
		}

		private int Add(int a, int b, int c)
		{
			return a + b + c;
		}

		private double Add(double a, double b)
		{
			return a + b;
		}

		#endregion

	}



	internal class BaseCalculator
	{
		public virtual int Addition(int a, int b)
		{
			Console.WriteLine("Base Calculator");
			return a + b;
		}
		public virtual int Substraction(int a, int b)
		{
			Console.WriteLine("Base Calculator");
			return a - b;
		}
	}

	class AdditionCalculator : BaseCalculator
	{
		public override int Addition(int a, int b)
		{
			return a + b;
		}
	}

}
