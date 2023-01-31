using System;
namespace EffectiveResistanceApp
{
    class ResistanceEquation
    {
    	public double inverseResistance = 0;
    	public double effectiveResistance;
    	public void resistanceSum (double r){
    		inverseResistance += 1/r;
    	}
    	public void display(){
    		effectiveResistance = 1/inverseResistance;
    		Console.WriteLine("The effective resistance is {0}", effectiveResistance);
    	}
    }
    
    class Program 
    {
    	public static int number_of_resistors;
    	public static double resistance;
        public static void Main(String[] args) 
        {
        	
        	Console.WriteLine("Enter the number of resistors");
        	number_of_resistors = int.Parse(Console.ReadLine());
        	ResistanceEquation Case = new ResistanceEquation();
        	for (int i = 0; i < number_of_resistors; i++){
        		Console.WriteLine("Enter Resistance {0}",i+1);
        		resistance = Double.Parse(Console.ReadLine());
        		Case.resistanceSum(resistance);
        	}
        	Case.display();
        }
    }
}