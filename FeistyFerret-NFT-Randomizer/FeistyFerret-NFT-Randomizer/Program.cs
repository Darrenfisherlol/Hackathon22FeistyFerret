/*
 * Hackathon OU 22
 * Darren Fisher
 * NFT randomizer and creator
 */




using System;
using System.Collections.Generic;

// "used to organize your code, and it is a container for classes and other namespaces" w3schools
namespace randomNFT
{

    // container for data and methods
    class Program
    {

        // main method 
        static void Main(String[] args)
        {

            // gets amount of combinations
            int numCombinations = getNumCombinations();

            // gets all combinations
            // = getCombinationsArray(numCombinations);

            // check each combination
            //foreach (var x in )
            //{
            //    Console.WriteLine(x);

            //}



            Console.ReadKey();
        }

        static int getNumCombinations()
        {

            // Stack overflow: Ahmad Khalil & Peter Mortensen
            // get the factorial 

            // we have 3 in each of the 3 categories,
            int factorioWanted = 3;
            int factorial = factorioWanted;
         
            for (int i = factorial - 1; i > 0; i--)
            {
                factorial *= i;
            }
            
            // make sure that number has the proper factorial
            Console.WriteLine("Number of different combinations: " + factorial + "\n");

            return factorial;
        }

        static void getCombinationsArray(int num)
        {
            // all combinations
            int[] head = { 0, 1, 2 };
            int[] body = { 0, 1, 2 };
            int[] legs = { 0, 1, 2 };

            // each index contains a combination 
            int[] combinations = new int[num];

            






        }




    }
}