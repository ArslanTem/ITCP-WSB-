using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic #02
            #region exc1
            //exc1
            /*
            int num1 =int.Parse(Console.ReadLine());
            int result = num1 % 2;

            if (result == 0){
                Console.WriteLine("the number " + num1 + " is even");
            }
            else
            {
              Console.WriteLine("the number " + num1 + " is odd");
            }
            */
            #endregion

            #region exc2
            //exc2
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = (a + b) / (a * b);
            Console.WriteLine(result);
            */
            #endregion

            #region exc3
            //exc3
            /*
            Console.WriteLine("Please write 1st number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write 2nd number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write 3th number: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c && b > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else if (a < b && a < c && b < c)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
            else if (b > a && b > c && c > a)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
            else if (b > a && b > c && a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);

            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
            */
            #endregion

            #region exc4/5
            //exc4/5
            /*
            Console.WriteLine("Please Enter first number: ");
              int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the operation: ");
            string sign = Console.ReadLine();
            Console.WriteLine("Please enter second number: ");
              int b = int.Parse(Console.ReadLine());
            if (sign == "+")
            {
                Console.WriteLine("result "+(a + b));
            }
            else if (sign == "-")
            {
                Console.WriteLine("result "+(a - b));
            }
            else if (sign == "*")
            {
                Console.WriteLine("result:"+(a * b));
            }else if (sign == "/")
            {
                Console.WriteLine("result"+(a / b));
            }
            */
            #endregion

            #region exc6
            //exc6
            /*
            int result = 1;
            int i = int.Parse(Console.ReadLine());
            for ( i=i; i <= 10; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
            */
            #endregion

            #region exc7
            //exc7
            /*
            string w="";
            Console.WriteLine("Please,Write width: ");
            int width = int.Parse(Console.ReadLine());
            for(int i = 0; i < width; i++)
            {
              w +="*";
            }
            //Console.WriteLine(w);
            Console.WriteLine("Please,write the height: ");
            int height = int.Parse(Console.ReadLine());
            for (int x = 0; x < height; x++)
            {
                Console.WriteLine(w);
            }
            */
            #endregion

            #region exc8
            //exc8
            /*
            int height = int.Parse(Console.ReadLine());
            string p = "*";
            string leftSide = "   ";
            string rightSide = "   ";

            for (int i = 0;i<height;i++)
            {

                p=leftSide+"*";
                
                

            }
            */
            #endregion

            #region exc9
            //9
            /*
            int num = int.Parse(Console.ReadLine());
            if (num > 1 && num % num == 0&&(num%2)>0)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

             */
            #endregion


            #region tic tac toe

            string field1 = ""; //(Console.ReadLine());
            string field2 = ""; //(Console.ReadLine());
            string field3 = ""; //(Console.ReadLine());
            string field4 = ""; //(Console.ReadLine());
            string field5 = ""; //(Console.ReadLine());
            string field6 = ""; //(Console.ReadLine());
            string field7 = ""; //(Console.ReadLine());
            string field8 = ""; //(Console.ReadLine());
            string field9 = ""; //(Console.ReadLine());


            Console.WriteLine("  1  |  2  |  3  ");
            Console.WriteLine("- - -+- - -+- - -");
            Console.WriteLine("  4  |  5  |  6  ");
            Console.WriteLine("- - -+- - -+- - -");
            Console.WriteLine("  7  |  8  |  9  ");




            string player = "X";
            int move;
            int i;

            for (i = 1; i < 10; i++)
            {
                Console.WriteLine(player + "'s turn");
                move = int.Parse(Console.ReadLine());

                if (move>9 || move<1)
                {
                    Console.WriteLine("Illegal move,try again");
                    i--;
                    continue;

                }

              switch (move)
                {
                    case 1:
                        field1 = player;
                        break;
                    case 2:
                        field2 = player;
                        break;
                    case 3:
                        field3 = player;
                        break;
                    case 4:
                        field4 = player;
                        break;
                    case 5:
                        field5= player;
                        break;
                    case 6:
                        field6 = player;
                        break;
                    case 7:
                        field7 = player;
                        break;
                    case 8:
                        field8 = player;
                        break;
                    case 9:
                        field9 = player;
                        break;
                }
                
                Console.WriteLine(" " + field1 + " | " + field2 + " | " + field3);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" " + field4 + " | " + field5 + " | " + field6);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" " + field7 + " | " + field8 + " | " + field9);

                player = player == "X" ? "O" : "X";

                if (field1 == field2 && field1 == field3)
                {
                    Console.WriteLine("GAME OVER");
                    break;
                  
                }
                
                
            }

            #endregion
        }



        }
            
    }



    
