using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSharpLearning
{
    public class Beginner
    {
        public Beginner()
        {

        }
        public void add()
        {
            Console.WriteLine("add number:");
            Console.WriteLine("enter first number:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of 2 numbers {a} and {b} is {(a + b)}");
            Console.WriteLine("Sum of 2 numbers {0} and {1} is {2}", a, b, (a + b));
        }
        public void substract()
        {
            Console.WriteLine("substract number:");
            Console.WriteLine("enter first number:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("substract of 2 number {0} and {1} is {2}", a, b, (a - b));
        }
        public void multiply()
        {
            Console.WriteLine("multiply number:");
            Console.WriteLine("enter first number:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("multiply of 2 number {0} and {1} is {2}", a, b, (a * b));
        }
        public void divide()
        {
            Console.WriteLine("divide number:");
            Console.WriteLine("enter first number:");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("division of 2 number {0} and {1} : quotient {2} and remiender {3}", a, b, (a / b), (a % b));
        }
    }
}
