using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesExample
{
    public class ActionExample
    {
        public void Show()
        {
            Console.WriteLine("Action");

            Action<string, string> actionDelegate = DisplayConnectedStrings;
            actionDelegate += CheckIfStringsAreTheSame;

            actionDelegate("Santa", "Claus");
        }
        private void DisplayConnectedStrings(string firstString, string secondString)
        {
            Console.WriteLine($"{firstString} {secondString}");
        }

        private void CheckIfStringsAreTheSame(string firstString, string secondString)
        {
            Console.WriteLine(firstString == secondString ? "Given strings are the same" : "Strings are not the same");
        }
    }
}
