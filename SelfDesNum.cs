using System;
namespace SelfDescribingApp
{
    public class SelfDescribing
    {
        public int count;
        public int flag;
        public int digit;
        public int numDigits;
        public void checkInput(int num)
        {
            string numberStr = num.ToString();
            numDigits = numberStr.Length - 1;
            flag = 1;
            for (int i = 0; i <= numDigits; i++){
            	count = 0;
            	for (int j = 0; j <= numDigits; j++){
            		digit = int.Parse(numberStr[j] + "");
            		if (digit == i){
            			count++;
            		}
            	}
            	int check = int.Parse(numberStr[i] + "");
            	if (count != check){
            		flag = 0;
            		Console.WriteLine("Not Self-Describing");
                    break;
            	}
            }
            if (flag == 1){
            	Console.WriteLine("Self-Describing");
            }
            
        }
    }
    
    public class Program 
    {
    	public static int testcases, number;
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter number of testcases:");
            testcases = int.Parse(Console.ReadLine());
            for(int k = 0; k < testcases; k++){
            	Console.WriteLine("Enter number:");
                number = int.Parse(Console.ReadLine());
                SelfDescribing TestCase = new SelfDescribing();
                TestCase.checkInput(number);
            }
        }
    }
}