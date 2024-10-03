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
            Console.WriteLine($"my string values are {aString} and {bString}");//useful string builder
            Console.WriteLine("my string values are {0} and {1}",aString,bString);
            //• character → character code
            char myChar = 'A';
            Console.WriteLine(Convert.ToInt32(myChar));
            myChar = '0';
            Console.WriteLine(Convert.ToInt32(myChar));

            //• character code → character
            int numChar = 97;
            Console.WriteLine(Convert.ToChar(numChar));
            numChar = 42;
            Console.WriteLine(Convert.ToChar(numChar));
            numChar = 32;
            Console.WriteLine(Convert.ToChar(numChar));
            numChar = 55;
            Console.WriteLine(Convert.ToChar(numChar));
            //• string conversion operations.
            //  string to integer
            int numInput;
            Console.Write("Enter a number: ");
            numInput =Convert.ToInt32( Console.ReadLine());

            //• string to float
            double doubleInput;
            Console.Write("Enter a number: ");
            doubleInput = Convert.ToDouble(Console.ReadLine());

            //• integer to string
            //• float to string
            Console.WriteLine(numInput.ToString());
            Console.WriteLine(doubleInput.ToString());
            //• date / time to string
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("ddd"));
            Console.WriteLine(d.ToString("Y"));

            //• string to date / time.
            string stringDate = "01/01/2001";
            d = Convert.ToDateTime(stringDate);
            Console.WriteLine(d.ToString("dddd"));
            d = d.AddDays(100);
            Console.WriteLine(d.ToString("dddd"));
        }
    }
}
