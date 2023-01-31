using System;

namespace FabonacciApp
{
	class Fabonacci
	{
		public int num1, num2, nextNum;
		public string fabonacciSeries;
		public void generate(int term)
		{
			fabonacciSeries = "";
			num1 = 1;
			num2 = 1;
			fabonacciSeries += num1.ToString() + ", ";
			fabonacciSeries += num2.ToString()+ ", ";
			for (int i = 2; i < term; i++){
				nextNum = num1 + num2;
				fabonacciSeries += nextNum.ToString() + ", ";
				num1 = num2;
				num2 = nextNum;
			}
			
			Console.WriteLine("The series is: {0}",fabonacciSeries);
		}
		
	}

    class Program 
    {
    	public static int number_of_terms;
        static void Main(string[] args) 
        {
           Console.WriteLine("Enter the number of terms:");
           number_of_terms = int.Parse(Console.ReadLine());
           Fabonacci Series = new Fabonacci();
           Series.generate(number_of_terms);
        }
    }
}