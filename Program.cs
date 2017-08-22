using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for a name and then phone number, and repeats until there are no more names. 
            //When the user enters a blank name, the program should continue to part 2.
            var MyDictionary = new Dictionary<string, int>();
            var name = "Name";
            while (name != string.Empty)
            {
                Console.WriteLine("Enter Name ");
                name = Console.ReadLine();
                if (name != string.Empty)
                {
                    Console.WriteLine($" Pelase, enter the phone number for {name}:");
                    var phoneNumber = int.Parse(Console.ReadLine());
                    MyDictionary.Add(name, phoneNumber);
                }
            }

            // The program now will ask whose phone number to look up. The user will be prompted to enter a name. 
            //The user will enter a name, and the program will print out that student's number. 
            //If the user enters a blank name, the program exits. If the user doesn't type a name that exists in the database,
            // the program should provide a few suggestions for names.
            //Part 2
            var lookUp = "lookingUp";
            while (lookUp != string.Empty)
                Console.WriteLine("Enter the name you are looking up: ");
            lookUp = Console.ReadLine();
            foreach (var item in MyDictionary)
            {
                if (lookUp == String.Empty)
                {
                    break;  //exits the scope 
                }
                if (item.Key == lookUp)
                {
                    Console.WriteLine(item.Value);
                }
                //if (Array.conta)// not sure thos to get suggestions 
                {

                }

            }

        }

    }
}