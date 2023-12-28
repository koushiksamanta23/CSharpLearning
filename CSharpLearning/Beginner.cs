using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

        public void add(int a, int b)
        {
            Console.WriteLine("add number:");
            Console.WriteLine($"enter first number: {a}");
            Console.WriteLine($"Enter Second Number: {b}");

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

        public void substract(int a, int b)
        {
            Console.WriteLine("substract number:");
            Console.WriteLine($"enter first number: {a}");
            Console.WriteLine($"Enter Second Number: {b}");

            Console.WriteLine($"Sum of 2 numbers {a} and {b} is {(a - b)}");
            Console.WriteLine("Sum of 2 numbers {0} and {1} is {2}", a, b, (a - b));
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
        public void multiply(int a, int b)
        {
            Console.WriteLine("multiply number:");
            Console.WriteLine($"enter first number: {a}");
            Console.WriteLine($"Enter Second Number: {b}");

            Console.WriteLine($"multiplication of 2 numbers {a} and {b} is {(a * b)}");
            Console.WriteLine("multiplication of 2 numbers {0} and {1} is {2}", a, b, (a * b));
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
        public void divide(double a, double b)
        {
            Console.WriteLine("divide number:");
            Console.WriteLine($"enter first number: {a}");
            Console.WriteLine($"Enter Second Number: {b}");

            Console.WriteLine($"divide of 2 numbers {a} and {b} is {(a / b)}");
            Console.WriteLine("divide of 2 numbers {0} and {1} is {2}", a, b, (a / b));
        }

        public void runAll()
        {

            Console.WriteLine("Getting values for addition.\nEnter first No:");
            var add1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second No:");
            var add2 = int.Parse(Console.ReadLine());
            add(add1, add2);

            Console.WriteLine("Getting value for substract.\nEnter first no:");
            var sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no:");
            var sub2 = int.Parse(Console.ReadLine());
            substract(sub1, sub2);

            Console.WriteLine("Getting value for multiply.\nEnter first no:");
            var multi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no:");
            var multi2 = int.Parse(Console.ReadLine());
            multiply(multi1, multi2);

            Console.WriteLine("Getting value for divide.\nEnter first no:");
            var div1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            var div2 = int.Parse(Console.ReadLine());
            divide(div1, div2);

            Console.WriteLine("Getting value for operation all.\nEnter first no:");
            var all1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            var all2 = int.Parse(Console.ReadLine());
            runAll(all1, all2);

        }
        public void runAll(int no1, int no2)
        {
           Console.WriteLine("performing addition");
            add(no1,no2);
            Console.WriteLine("performing substract");
            substract(no1, no2);
            Console.WriteLine("performing multiply");
            multiply(no1, no2);
            Console.WriteLine("performing divide");
            divide(no1, no2);

        }
    }
}
