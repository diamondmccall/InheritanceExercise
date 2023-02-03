using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class







            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBirds = new Birds();
            myBirds.WingColor = "Yellow";
            myBirds.BeakLength = 2.5;
            myBirds.WillMigrate = true;
            myBirds.CanFly = true;

            var myReptile = new Reptile();
            myReptile.IsScaly = true;
            myReptile.CanGrowTail = true;
            myReptile.Habitat = "swamp";
            myReptile.IsColdBlooded = true;

            var myAnimals = new Animals[] { myBirds, myReptile };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"{animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");
    
            }

            

           



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
