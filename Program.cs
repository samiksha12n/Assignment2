using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parse()
            Console.WriteLine("Enter the value for Int16");
            var myInt16 =Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for Int32");
            var myInt32=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Int64");
            var myInt64 = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Value stored in myInt16 is=\t {0} and Data Type is: \t {1}",myInt16,myInt16.GetType());
            Console.WriteLine("Value stored in myInt32 is=\t {0} and Data Type is: \t {1}", myInt32, myInt32.GetType());
            Console.WriteLine("Value stored in myInt64 is=\t {0} and Data Type is: \t {1}", myInt64, myInt64.GetType());
            var myVar2 = int.Parse("(100)", System.Globalization.NumberStyles.AllowParentheses);
            Console.WriteLine("Value in myVar2 is=\t" +myVar2);

            Console.ReadKey();
        }
    }
}
