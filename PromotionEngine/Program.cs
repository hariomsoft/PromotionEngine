using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Channels;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Press q to quit");

            bool quitFlag = false;
            while (!quitFlag)
            {
                Console.WriteLine("Please enter SKU IDs.");
                // string userInput;
                string SKuInputs = Console.ReadLine();
                if (SKuInputs == "q")
                {
                    quitFlag = true;
                }
                else
                {
                    Promotion.GetPromotions(SKuInputs);
                    Console.ReadLine();
                }
            }
           
        }


       



    }
}
