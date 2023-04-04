//imports

using System;
using System.Collections.Generic;

namespace ChemicalApp
{
    class Program
    {
        private static int choiceNumber;

        //Global Variables
        







        //OneChemical method(test a chemical and its efficeincy)
        static void OneChemical()
        {
            //chemicals
            List<string> chemicals = new List<string>() { "acid", "bleech", "chlorine", "coke", "alcohol","hydroPeroxide" };
            
           
            //Add the chemical
            Console.WriteLine("Please choose which chemical from 0-5 below:\n" +
                "0.acid\n" +
                "1.bleach\n" +
                "2.chlorine\n" +
                "3.coke\n" +
                "4.alcohol\n" +
                "5.hydroPeroxide\n");
           
            //User chooses which one
            string userChoice = Console.ReadLine();
            int choiceIndex;
            choiceIndex = Convert.ToInt32(userChoice);
            
            string choice = chemicals[choiceIndex];
           
            Console.WriteLine($"adding {choice}");

            //Efficiency
            for (int i = 0; i < 5; i++)
            {
                //random number generator
                Random randGen = new Random();

                //generate number of germs
                int germCount = randGen.Next(1000, 10000);






            }











































































        }









        //Main
        static void Main(string[] args)
        {
            OneChemical();
        }
    }
}
