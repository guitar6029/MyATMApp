using System;
using MyATMApp.UI;

namespace MyATMApp.App
{
    public class ATMApp
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validator.Convert<long>("your card number");
            
            Console.WriteLine($"Your card number is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}