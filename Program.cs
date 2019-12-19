using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7___Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string search;
            //Setting up list as per tutorial
            List<string> names = new List<string>() {"Arthur Dent", "Marvin"};
            names.Add("Trillian");
            names.Add("Ford Prefect");

            //Q1 - Print list
            Console.WriteLine("All names in List:");
            foreach (string name in names)
                Console.WriteLine(name);

            //Q2 - Uppercase the list
            for (int i = 0; i < names.Count; i++)
                names[i] = names[i].ToUpper();
            Console.WriteLine("");
            Console.WriteLine("");

            //Q3 - Sort the list
            names.Sort();

            //Q4 - Print the new list
            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine("");
            Console.WriteLine("");

            //Q5 - Add 3 uppercase names to list using a loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter a name:");
                names.Add(Console.ReadLine().ToUpper());
            }
            Console.WriteLine("");
            Console.WriteLine("");

            //Q6 - Sort the list
            names.Sort();

            //Q7 - Print the list and its size
            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine($"There are {names.Count} names in the list.");
            Console.WriteLine("");

            //Q8 - Remove or add name from the list
            Console.WriteLine("Type in a name to remove:");
            search = Console.ReadLine().ToUpper();
            if (names.Remove(search))
                Console.WriteLine($"{search} removed");
            else
            {
                names.Add(search);
                Console.WriteLine($"{search} added");
            }
            Console.WriteLine("");

            //Q9 - Print the list
            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine("");
             
            //Q10 - Clears the list
            names.Clear();
        }
    }
}
