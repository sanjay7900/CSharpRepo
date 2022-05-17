using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRepo
{
    internal class Program
    {
        public Program()
        {

        }
        ~Program()
        {

        }
        static void Main(string[] args)
        {

            Console.WriteLine("hello i m demo");

            int num1 = 10;
            int num2 = 10;
            int num3 = num1 + num2;
            Console.WriteLine(num3);

            PerformOOPs obj = new PerformOOPs();
            Console.WriteLine(obj.sum(12, 39));
            Console.WriteLine(obj.sum(23.9, 39.3));
            //Program b=new Program();
            obj.JustOverRide();

            Console.ReadKey();
        }
    }




}
