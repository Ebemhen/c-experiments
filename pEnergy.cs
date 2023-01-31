using System;

namespace PotentialEnergyApp
{
	class PotentialEnergy
	{
		public double potentialEnergy;
		public double length;
		public void pEnergy(double l)
		{
			const double k = 15E-1F;
			length = l;
			potentialEnergy = (0.5) * (k) * (Math.Pow(l, 2));
			Console.WriteLine("The potential energy is {0}", potentialEnergy);
		}
	}

    class Program 
    {
    	public static double lengthInput;
        static void Main(string[] args) 
        {
        	Console.WriteLine("Enter the value of length");
        	lengthInput = Double.Parse(Console.ReadLine());
        	PotentialEnergy PE = new PotentialEnergy();
        	PE.pEnergy(lengthInput);
        }
    }
}