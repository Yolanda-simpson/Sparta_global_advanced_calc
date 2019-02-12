using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string optionnum;


            Console.WriteLine("What would you like to calculate? Maths or Shapes?");
            optionnum = Console.ReadLine();

            if (optionnum == "1")

            {
                int num1 = 0;
                int num2 = 0;
                float answer = 0.0f;
                string numoperator = "";

                Console.WriteLine("Enter the operator +,-,/,* or %");
                numoperator = Console.ReadLine();

                Console.Write("Please enter the first number: ");
                num1 = Int32.Parse(Console.ReadLine());

                Console.Write("Please enter the second number: ");
                num2 = Int32.Parse(Console.ReadLine());

                switch (numoperator)
                { 
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                case "%":
                    answer = num1 % num2;
                    break;
                    default:
                        Console.WriteLine("this calc doesnt understand");
                        break;

                }
                Console.WriteLine(num1 + " " + numoperator + " " + num2 + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                string shapeChoice;
                Console.WriteLine(" choose a shape, square triangle, rectangle ");
                shapeChoice = Console.ReadLine();

                if(shapeChoice == "triangle")
                    {
                    Console.WriteLine("enter base");
                    double base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("enter height");
                    double height1 = double.Parse(Console.ReadLine());

                    double areat = (base1 * height1 * 0.5);
                    Console.WriteLine(areat);
                    Console.Read();
                }
                else if (shapeChoice == "square")
                {
                    Console.WriteLine("enter base");
                    double base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("enter height");
                    double height1 = double.Parse(Console.ReadLine());

                    double areas = (base1 * height1 );
                    Console.WriteLine(areas);
                    Console.Read();
                }
                else if (shapeChoice == "rectangle")
                {
                    Console.WriteLine("enter base");
                    double base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("enter height");
                    double height1 = double.Parse(Console.ReadLine());

                    double arear = (base1 * height1);
                    Console.WriteLine(arear);
                    Console.Read();
                }
                else
                    Console.WriteLine("input not valid");
                
            }

            }
        }
    }
        
