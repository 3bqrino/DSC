using System;
using System.Runtime.InteropServices;
using System.Text;
using static System.Console;
namespace Task
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region q1
            /* double pi = 3.141592653;
               WriteLine("Enter A Radius : ");
               double r = double.Parse(ReadLine());
               Console.WriteLine();
               double area = r * r * pi;
               WriteLine($"Area: {area.ToString("f3")}");
               ReadKey();*/
            #endregion

            #region q2
            /* Write("Enter First number :");
             int a = int.Parse(ReadLine());
             Write("Enter First number :");
             char c = char.Parse(ReadLine());
             Write("Enter First number :");
             int b = int.Parse(ReadLine());          
             Write($"{a} + {b} = {a+b}");
             Write($"{a} * {b} = {a*b}");
             Write($"{a} - {b} = {a-b}"); */
            #endregion

            #region q3
            /* int a, b;
             Write("Enter first number :");
             a = int.Parse(ReadLine());
             Write("Enter second number :");
             b = int.Parse(ReadLine());
             if (a % b == 0)
             {
                 WriteLine("Multiples");
             }
             else
                 WriteLine("Not Multiple");*/
            #endregion

            #region q4
            /* Write("Enter first number :");
            int a = int.Parse(ReadLine());
             Write("Enter second number :");
            int b = int.Parse(ReadLine());
             Write("Enter third number :");
            int c = int.Parse(ReadLine());
             if (a >= b && a >= c && c >= b)
                 Write($"{a} {b}");
             else if (a >= b && a >= c && b >= c)
                 Write($"{a} {c}");
             else if (b >= a && a >= c && b >= c)
                 Write($"{b} {c}");
             else if (b >= a && c >= a && b >= c)
                 Write($"{b} {a}");
             else if (c >= b && a >= b && c >= a)
                 Write($"{c} {b}");
             else if (c >= b && b >= a && c >= a)
                 Write($"{c} {a}");
             else
                 WriteLine("equel");*/
            #endregion

            #region q5
            /*char n=char.Parse(Console.ReadLine());
            if (n >= 48 && n <= 64)
            {
                WriteLine("Is Digit");   
            }
            else if (n >= 65 && n <= 96)
            {
                WriteLine("Alpha");
                WriteLine("Is Capital");
            }
            else if (n >= 97 && n <= 125)
            {
                WriteLine("Alpha");
                WriteLine("Is small");
            }*/
            #endregion

            #region q6
            /*int a=int.Parse(ReadLine());
            char c=char.Parse(ReadLine());
            int b=int.Parse(ReadLine());
            char h=char.Parse(ReadLine());
            int result=int.Parse(ReadLine());
              int i=0;
              switch(c)
              {
                  case '+':

                      i = a + b;
                      break;
                  case '-':
                      i = a - b;
                      break;
                  case '*':
                      i = a * b;
                      break;
                  case '/':
                      i = a / b;
                      break;
              }
              if(i == result)
              {
                  WriteLine("Yes");
              }
              else
                  WriteLine("No");*/
            #endregion

            #region q7

            /* int a, b, c, d, f;
             a=int.Parse(ReadLine());
             b=int.Parse(ReadLine());
             c=int.Parse(ReadLine());
             d=int.Parse(ReadLine());
             a = a % 100; 
             b = b % 100; 
             c = c % 100;
             d = d % 100;
             f = (a * b * c * d) % 100;
             if (f < 10)
                 WriteLine($"{0}{f}");
             else
                 WriteLine($"{f}");*/
            #endregion

            #region q8
            /* int a = int.Parse(ReadLine());
             int b = int.Parse(ReadLine());
            int c = int.Parse(ReadLine());
            int d = int.Parse(ReadLine());
             double result1 = 1, result2 = 1;
             for (int i = 0; i < b; i++)
             {
                 result1 *= a;
             }
             for (int i = 0; i < d; i++)
             {
                 result2 *= c;
             }
             if (result1 > result2)
                 WriteLine("Yes");
             else if (result1 < result2)
                 WriteLine("No");
             else WriteLine("Equal");*/
            #endregion

            #region q9
            /*int a = int.Parse(ReadLine());
             Console.WriteLine(a);*/
            #endregion

            #region q10
            /*string n = ReadLine();
            Convert.ToInt32(n);
            WriteLine(n);*/
            #endregion

            #region q11
            /* string n = "abdelrhman";
             Console.WriteLine(n.Substring( 0,3));//abd*/
            #endregion

            #region q12
            /* string n=ReadLine();
             string m=ReadLine();
             string z = n + m;
             WriteLine(z);*/
            #endregion

            #region q13
            /* int principal = int.Parse(Console.ReadLine());
             int rate = int.Parse(Console.ReadLine());
             int time = int.Parse(Console.ReadLine());
             int Interest = 0;
             Interest = (principal * rate * time) / 100;
             Console.WriteLine($"Interest = {Interest}");*/
            #endregion

            #region q14
            /* int n = int.Parse(ReadLine());
             if(n<10)
                 WriteLine("Just Cold");
             if(n>30)
                 WriteLine("Just Hot");
             else
                 WriteLine("Just Good");*/
            #endregion

            #region q15
            /*int n = int.Parse(ReadLine());
            if (n % 3 == 0&& n % 3 == 4)
                WriteLine("Yes");
            else
                WriteLine("No");*/
            #endregion

            #region q16
            /* int n =int.Parse(ReadLine());
              if (n % 2 == 0)
                  WriteLine("even");
              else
                  WriteLine("odd");*/
            #endregion

            #region q17
            /*char c =char.Parse(Console.ReadLine());
             if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                 Console.WriteLine("vowel");
             else if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                 Console.WriteLine("vowel");
             else
                 Console.WriteLine("Consonant");*/
            #endregion
        }
    }
}