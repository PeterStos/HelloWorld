using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int answer = 0;

            Console.WriteLine("Enter a number:");
            string sNum = Console.ReadLine();

            Console.WriteLine("Enter another number:");
            string sNum2 = Console.ReadLine();

            Int32.TryParse(sNum, out num1);
            Int32.TryParse(sNum2, out num2);

            answer = num1 + num2;

            Console.WriteLine("the answer is: " + answer);

            Console.ReadLine();
        }

        static void WriteLine(string value){ 
        
        }
    }
}
