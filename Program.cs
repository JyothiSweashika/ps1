using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string intString = "123456";
            int intValue;
            if (int.TryParse(intString, out intValue))
            {
                Console.WriteLine("TryParse successful. Converted Integer value:"+intValue);
            }
            else
            {
                Console.WriteLine("TryParse failed. Invalid Input String");
            }

            string str2 = "123456789123456";
            try
            {
                double num2 = Convert.ToDouble(str2);
                Console.WriteLine("Convert successfully converted the string to a double: " + num2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed to convert the string to a double.");
            }
           


            string str3 = "99.99";
            try
            {
                decimal num3 = decimal.Parse(str3);
                Console.WriteLine("Parse successfully converted the string to a decimal: " + num3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed to convert the string to a decimal.");
            }

            Console.ReadKey();

        }
    }
}
