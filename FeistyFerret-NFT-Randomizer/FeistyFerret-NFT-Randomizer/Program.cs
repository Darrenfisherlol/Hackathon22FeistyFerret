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
        // universal list of combinations of NFTs Sequence References
        static List<string> listcombinations = new List<string>();

        // main method 
        static void Main(String[] args)
        {
            // gets amount of combinations
            // 3 combinations of 3 = 64 possibilities
            // gets all combinations
            getCombinationsArray();

            // nft merger??
            createNFTs();


            Console.ReadKey();
        }

        // returns the number of slots we want in an
        static void getCombinationsArray()
        {
            // all combinations
            int[] head = { 0, 1, 2 };
            int[] body = { 0, 1, 2 };
            int[] legs = { 0, 1, 2 };

            // each index contains a combination 

            for (int x = 0; x <= head.Length; x++)
            {
                for (int y = 0; y <= body.Length; y++)
                {
                    for (int z = 0; z <= legs.Length; z++)
                    {
                        listcombinations.Add(x.ToString() + y.ToString() + z.ToString());
                    }
                }
            }
        }

        static void createNFTs()
        {




        }



    }
    

        // in classs
}
    

