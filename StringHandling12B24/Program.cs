using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StringHandling12B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString = "String handling";
            string bString = "operations";
            // length
            Console.WriteLine(aString.Length);
            //• position
            Console.WriteLine(aString[0]);
            Console.WriteLine(aString[aString.Length - 1]);
            //Console.WriteLine((aString[aString.Length])); Outside bounds of the array

            //• substring
            Console.WriteLine(aString.Substring(0,3));//start at index 0 length of 3
            Console.WriteLine(aString.Substring(5)); //start at index 5 to the end

            //• concatenation
            Console.WriteLine(aString + " "+bString);
            Console.WriteLine($"my string values are {aString} and {bString}");
            Console.WriteLine("my string values are {0} and {1}",aString,bString);
            //• character → character code
            //• character code → character
            //• string conversion operations.
            //  string to integer
            //• string to float
            //• integer to string
            //• float to string
            //• date / time to string
            //• string to date / time.
        }
    }
}
