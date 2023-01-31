using System;

namespace CarsApp
{
    class Cars
    {
    	public string engineNature, speed, shape;
    	public void carModel(string carShape){
    		shape = carShape;
    		if(shape == "Vboot"){
    			speed = "20 horsepower";
    			engineNature = "V4 Engine";
    		}
    		else if (shape == "Tortoise"){
    			speed = "40 horsepower";
    			engineNature = "Flat Engine";
    		}
    		else if (shape == "Sports car"){
    			speed = "90 horsepower";
    			engineNature = "V6 Engine";
    		}
            else if (shape == "Hatchback"){
    			speed = "80 horsepower";
    			engineNature = "Hybrid Engine";
    		}
    		else if (shape == "Convertible"){
    			speed = "70 horsepower";
    			engineNature = "Electric Engine";
    		}
    	}
    	public void display(){
    		Console.WriteLine(@"The {0} shaped car has a speed of {1} and {2}", shape, speed, engineNature);
    		Console.WriteLine("\n");
    	}
    }

    class Program 
    {
        public static void Main(string[] args) 
        {
        	Cars Vboot = new Cars();
        	Vboot.carModel("Vboot");
        	Vboot.display();
        	
        	Cars Tortoise = new Cars();
        	Tortoise.carModel("Tortoise");
        	Tortoise.display();
        	
        	Cars SportsCar = new Cars();
        	SportsCar.carModel("Sports car");
        	SportsCar.display();
        	
        	Cars Hatchback = new Cars();
        	Hatchback.carModel("Hatchback");
        	Hatchback.display();
        	
        	Cars Convertible = new Cars();
        	Convertible.carModel("Convertible");
        	Convertible.display();
        }
        
    }
}