using System;

namespace MyATMApp
{
    public class ATMApp
    {
        static void Main(string[] args)
        {

            //clear the console
            Console.Clear();
            //set console title color
            Console.ForegroundColor = ConsoleColor.White;
            //add title to the console
            Console.Title = "\n\n----------Welcome To My ATM App----------\n\n";
            //prompt the user to insert their atm card
            Console.WriteLine("Please insert your ATM card.\n");
            Console.WriteLine("Note: Actual ATM machine will accept and validate the physical ATM card, read the card number and validate it.");
            
                Console.WriteLine("\n\nPress Enter to continue...\n");
            Console.ReadLine();
        }
    }
}