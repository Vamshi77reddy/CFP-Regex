using System;
using System.Collections.Generic;
using System.Text;

namespace RegexImpl
{
    internal class User
    {
        public void UserInput() { 
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();


        Console.Write("Enter a phone number : ");

        string phoneNumber = Console.ReadLine();

        bool isNameValid = RegexI.ValidateName(name);

        bool isPhoneValid = RegexI.ValidatePhoneNumber(phoneNumber);

        Console.WriteLine("Name validation result:");

        if (isNameValid)
        {
            Console.WriteLine("Name is valid.");
        }
        else
        {
            Console.WriteLine("Name is invalid.");
        }


           if (isPhoneValid)
         {
              Console.WriteLine("Phone number is valid.");
           }
           else
           {
              Console.WriteLine("Phone number is invalid.");

            }
    }
    }
}
