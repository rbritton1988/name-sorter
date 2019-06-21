using System;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("Missing Argument: the path to a file containing names is required.");
            }

            string filePath = args[0];

            NameSorter nameSorter = new NameSorter(filePath);
            
            nameSorter.SortByLastName();

 
            
            Console.WriteLine("Hello World!");
        }
    }
}
