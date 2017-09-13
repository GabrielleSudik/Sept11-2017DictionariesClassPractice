using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept11_2017DictionariesClassPractice
{
    class Program
    { 
        //DICTIONARIES
        //data collection of key/value pairs
        //the key is always unique (think of a real dictionary) -- each key is only one
        //the value is not always unique (think of different words that mean the same thing)
        //another analogy: coat check ticket stubs are all different
        //but there might be 10 identical coats in the closet

        //dictionaries are supposedly very cool, but you won't use them much.

        //you might see K and V referenced -- key and value

        //also called hash tables or key-value tables
    
        static void Main(string[] args)
        {
            //the syntax:

            Dictionary<int, string> coatCheck = new Dictionary<int, string>() //a lot like List.
                                                                               //first item in <> is key, second item is value

            //to add items:
            {
                { 23, "trench"}, {35, "poncho" }, {47, "mink stole" }, {19, "trench" }, {59, "bolero" },
                {11, "bomber" }, {16, "bolero" }, { 1, "letterman" }
            }; //note semicolon is here, after the creation of the list.
                //you just broke it into multiple lines is all

            //to print all items:

            foreach (KeyValuePair<int, string> ticket in coatCheck)
            {
                Console.WriteLine(ticket);
            }

            //other stuff:

            Console.WriteLine($"There are {coatCheck.Count} total key-value pairs.");

            foreach (KeyValuePair<int, string> ticket in coatCheck)
            {
                Console.WriteLine(ticket.Key);
            }

            foreach (KeyValuePair<int, string> ticket in coatCheck)
            {
                Console.WriteLine(ticket.Value);
            }

            //some class exercises:

            Console.WriteLine(coatCheck.ContainsValue("bolero")); //ContainsValue is a bool. This will print true.
            Console.WriteLine(coatCheck.ContainsValue("sports")); //This will print false.
            Console.WriteLine();

            coatCheck.Remove(23);

            foreach (KeyValuePair<int, string> ticket in coatCheck)
            {
                Console.WriteLine(ticket);
            }

            Console.WriteLine();

            coatCheck.Add(40, "jean jacket");

            foreach (KeyValuePair<int, string> ticket in coatCheck)
            {
                Console.WriteLine(ticket);
            }

            Console.WriteLine();

            coatCheck.Add(60, "raincoat");

            foreach (KeyValuePair<int, string> ticket in coatCheck)
            {
                Console.WriteLine(ticket);
            }

            Console.WriteLine();

            coatCheck.Remove(47);
            coatCheck.Add(48, "fox fur");
            coatCheck.Add(99, "fugly");

            foreach (KeyValuePair<int, string> ticket in coatCheck)
            {
                Console.WriteLine(ticket);
            }

            //you discovered something interesting...
            //if you remove then add, the added item goes where the removed one was.
            //otherwise, they get stuck on the end.

            Console.WriteLine();

            Dictionary<string, int> zoo = new Dictionary<string, int>()
            {
                {"tiger", 4 }, { "lion", 5 }, {"elephant", 3 }, {"snake", 100 }, {"bat", 500 }, {"owl", 9 }, {"manatee", 8 },
                {"rhino" , 25 }, {"seal", 16 }, {"prairie dog" , 100}
            };

            Console.WriteLine($"There are initially {zoo.Count} types of animals in the zoo.");

            zoo.Remove("elephant");

            Console.WriteLine($"After moving the elephants, there are {zoo.Count} types of animals.");
            Console.WriteLine();

            Console.WriteLine("What animal would you like to see?");
            string wantedAnimal = Console.ReadLine();

            //bool containsAnimal = true;

            if(zoo.ContainsKey(wantedAnimal))
                {
                Console.WriteLine($"Follow me to see the {wantedAnimal}.");
            }

            else
            {
                Console.WriteLine("Would you like the zoo to acquire that animal? (yes/no)");
                string yesNo = Console.ReadLine();

                if (yesNo == "yes")
                {
                    zoo.Add(wantedAnimal, 40);
                }

                else
                {
                    Console.WriteLine("OK, they are better off in the wild anyway.");
                }
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, int> animal in zoo)
            {
                Console.WriteLine(animal);
            }

            

            Console.ReadLine();
        }
    }
}
