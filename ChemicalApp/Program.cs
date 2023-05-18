//imports

using System;
using System.Collections.Generic;
using System.Threading;

namespace ChemicalApp
{
    class Program
    {

        

        //Global Variables
        static float finalEfficiency;
        static string bestChemical;
        static float bestEfficiency = 0;


        //Method and functions

        //recieve user input as an integer and check if integer meets a range criteria
        static int CheckInt(string question, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(question);
                int userInt = Convert.ToInt32(Console.ReadLine());

                if (userInt >= min && userInt <= max)
                {
                    return userInt;
                }

                Console.WriteLine($"Error: Enter a number between {min} and {max}");
            }
        }




        //OneChemical method(test a chemical and its efficeincy)
        static void OneChemical()
        {
            //chemicals
            List<string> chemicals = new List<string>() { "acid", "bleech", "chlorine", "coke", "alcohol","hydroPeroxide" };
            
           
            //Add the chemical
         

            //User chooses which one

            int choiceIndex = CheckInt("Please choose which chemical from 0-5 below:\n" +
                "0.acid\n" +
                "1.bleach\n" +
                "2.chlorine\n" +
                "3.coke\n" +
                "4.alcohol\n" +
                "5.hydroPeroxide\n", 0, 5);
            
            string choice = chemicals[choiceIndex];
           
            Console.WriteLine($"adding {choice}");

            //Efficiency
            for (int i = 0; i < 5; i++)
            {
                //random number generator
                Random randGen = new Random();

                //generate number of germs
                int firstgermCount = randGen.Next(1000, 10000);
                Console.WriteLine($"\nThere are {firstgermCount} germs");

                //add chosen chemical
                int germsKilled = randGen.Next(0, firstgermCount);
                Console.WriteLine($"Adding {choice}");
                
                
                //wait 5 seconds
                Console.WriteLine("\nWait for 5 seconds");
                Thread.Sleep(5000);

                //calculate efficiency
                float chemicalEfficiency = (float)(firstgermCount - germsKilled) / 5;
                Console.WriteLine($"Chemical Efficiency: {chemicalEfficiency}");
                finalEfficiency = (float)(+ chemicalEfficiency);
                Math.Round(finalEfficiency, 2);
                
               
                
                


            }
            //average/final efficiency
            finalEfficiency = (float)(finalEfficiency / 5);

            //determine best chemical
            if (finalEfficiency > bestEfficiency)
            {
                bestChemical = choice;
                bestEfficiency = finalEfficiency;
               
            }

            Console.WriteLine($"Average efficiency for {choice}: {finalEfficiency}");


        }





        //Main
        static void Main(string[] args)
        {
            int choiceIndex = CheckInt("WELCOME TO CHEMICAL APP\n" +
                "hOW MANY CHEMICAL DO YOU WANT TO TEST (maximum: 10):", 1, 10);

            for (int i = 0; i < choiceIndex; i++)
            {
                OneChemical();
            }
            Console.WriteLine($"The most efficient chemical was: {bestChemical} with and efficiency rating of: {bestEfficiency}");
          
           
        }
    }
}
