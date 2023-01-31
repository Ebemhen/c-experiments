using System;

namespace FactorialApp
{
	class Factorial
	{
		public int getFactorial(int number)
		{
			int result;
			if(number<=1){
				return 1;
			}
			else{
				result = number * getFactorial(number-1);
				return result;
			}
		}
	}

    class Program 
    {
    	public static int n, r, nCombR;
        static void Main(string[] args) 
        {
           Console.WriteLine("Enter the value of n");
           n = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the value of r");
           r = int.Parse(Console.ReadLine());
           Factorial Combination = new Factorial();
           nCombR = Combination.getFactorial(n)/(Combination.getFactorial(n-r) * Combination.getFactorial(r));
           Console.WriteLine("The value of {0} Combination {1} is {2} ",n,r,nCombR);
        }
    }
}