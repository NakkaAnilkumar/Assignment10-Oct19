using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Oct19
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Admin\\source\\repos\\Assignment9-Oct19\\Assignment9-Oct19\\personData.txt";

            // Task 1: Create a text file and store person data
            Console.WriteLine("Enter person data (name,address,city,country):");
            string input = Console.ReadLine();
            File.WriteAllText(filePath, input);

            // Task 2: Read the data from the file
            string fileData = File.ReadAllText(filePath);
            Console.WriteLine("Data from the file: ");
            Console.WriteLine(fileData);

            // Task 3: Append one more record to it
            Console.WriteLine("Enter another person data to append:");
            string newData = Console.ReadLine();
            File.AppendAllText(filePath, Environment.NewLine + newData);

            // Task 4: Read the data again after appending
            fileData = File.ReadAllText(filePath);
            Console.WriteLine("Data from the file after appending: ");
            Console.WriteLine(fileData);
            Console.ReadLine();
        }
    }
}
