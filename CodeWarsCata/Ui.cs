using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCata
{
    public class Ui
    {
        public string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}