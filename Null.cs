using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null__Coalescing
{
     class Null
    {
        static int[] GetArray() 
        {
            int[] myArray = new int[0];

            return myArray;
        }
        static void Main(string[] args)
        {
            string str = null;

             str ??= string.Empty;
            Console.WriteLine("Count simbol in string " + str.Length);

            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine("Count simbol in array " + myArray.Length);
        }
    }
}
