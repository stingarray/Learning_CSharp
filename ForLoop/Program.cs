using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[5];

            myArray[0] = "Tiger";
            Console.WriteLine(myArray[0]);

            myArray[1] = "Burmese Python";
            Console.WriteLine(myArray[1]);

            myArray[2] = "Bear";
            Console.WriteLine(myArray[2]);

            myArray[3] = "Flamingo";
            Console.WriteLine(myArray[3]);

            myArray[4] = "Ostrich";
            Console.WriteLine(myArray[4]);

            for(int i = 0; i < myArray.Length; i++)

            {
                Console.WriteLine("myArray index " + i + "= " + myArray[i]);
               
            }

            Console.ReadLine();
        }
    }
}
