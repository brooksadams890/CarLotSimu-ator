﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //dot notation
            var car1 = new Car();
            car1.Year = 2005;
            car1.Make = "Mazda";
            car1.Model = "CX-5";
            car1.EngineNoise = "Zoom zoom";
            car1.HonkNoise = "beeeep!";
            car1.IsDriveable = true;

            //object initializer syntax
            var car2 = new Car() { Year = 1990, Make = "Ford", Model = "Focus", EngineNoise = "shake shake die", HonkNoise = "unintimidating beep", IsDriveable = false };

            //Custom Constructor
            var car3 = new Car(2001, "Jeep", "Wrangler Unlimited", "Vroom!", "Loud Honk", true);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
