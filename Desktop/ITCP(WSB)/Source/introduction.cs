using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_01
            Console.WriteLine("Hello World!!!");
            #endregion

            #region Task_02
            int a = 5;
            int b = 10;
            int result = a * b;
            Console.WriteLine(result);
            #endregion

            #region Task_03
            //fixing errors of code that given bellow
            //int x = 5
            //y = 0;
            //int x = Console.ReadLine();
            //Console.WriteLine(x / y);
            int x = 5;
            int y = 0;
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine(x/x);
            #endregion

            #region Task_04
            double pln = 100.00;
            double usd = 0.26;
            double result1 = pln * usd;
            Console.WriteLine(result1);

            #endregion

            #region Task_05
            Console.WriteLine("How much you want to convert?:(PLN) ");
            double pln2 = double.Parse(Console.ReadLine());
            double usd2 = 0.26;
            double result2 = pln2 * usd2;
            Console.WriteLine(result2);

            #endregion

            #region Task_06/07/08-10(debugging)
            //Output of formula
            Console.WriteLine("y = ax2 + bx + c");

            //getting variable "x" and declaring it to "x2"
            Console.Write("Please enter x: ");
            int x2 = int.Parse(Console.ReadLine());
            //getting variable "a" and declaring it to "a1"
            Console.Write("Please enter a: ");
            int a1 = int.Parse(Console.ReadLine());
            //getting variable "b" and declaring it to "b1"
            Console.Write("Please enter b: ");
            int b1 = int.Parse(Console.ReadLine());
            //getting variable "c" 
            Console.Write("Please enter c: ");
            int c = int.Parse(Console.ReadLine());
            //make a solution and declaring it as a result3
            int result3 = a1 * (x2 * x2) + b1 * x2 + c;
            //Result outputiing
            Console.WriteLine("result: Y="+result3);
            #endregion

            #region Task_11
            //float
            float[] values = { Single.MinValue, -1.38e10f, -1023.299f, -12.98f,
                  0f, 9.113e-16f, 103.919f, 17834.191f, Single.MaxValue };
            int res;

            foreach (float value in values)
            {
                try
                {
                    res = Convert.ToInt32(value);
                    Console.WriteLine("Converted the {0} value {1} to the {2} value {3}.",
                                      value.GetType().Name, value, res.GetType().Name, res);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} is outside the range of the Int32 type.", value);
                }
            }
            #endregion

            #region Task_12
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            #endregion

            #region Task_13
            
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");

            Console.WriteLine("=======================");

            #endregion

            #region Task_14/15

            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");

            Console.WriteLine("=======================");

            string field1 = "O";
            string field2 = "X";
            string field3 = "O";
            string field4 = "X";
            string field5 = "O";
            string field6 = "X";
            string field7 = "O";
            string field8 = "X";
            string field9 = "O";

            Console.WriteLine(" "+field1+" | "+field2+" | "+field3+"  ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" "+field4+" | "+field5+" | "+field6+"  ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" "+field7+" | "+field8+" | "+field9+"  ");
           

            #endregion
        }
    }
}
