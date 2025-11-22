using System;
using System.Collections.Generic;
using static System.Console;
namespace DSC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //WriteLine("Enter a number");
            //int n = int.Parse(ReadLine());
            //int i = 1;
            //while (i <= 12)
            //{
            //    WriteLine($"{n} x {i} = {n * i}");
            //    i++;
            //}
            //ReadKey();
            #endregion
            #region q2
            //WriteLine("Enter a number");
            //int n = int.Parse(ReadLine());
            //int sum = 0;
            //if(n>0)
            //{ for (int i = 1; i <= n; i++)
            //    {
            //        sum += i;
            //    }
            //    WriteLine($"The sum is {sum}");
            //    ReadKey();
            //}
            //else
            //{
            //    WriteLine("Please enter a positive number");
            //  ReadKey();
            //}
            #endregion
            #region q3
            //WriteLine("Enter the number of elements:");
            //int n = int.Parse(ReadLine());
            //if (n > 0)
            //{
            //    List<int> numbers = new List<int>();
            //    int ECount = 0;
            //    int OCount = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        Write($"Enter number {i + 1}:");
            //        int num = int.Parse(ReadLine());
            //        numbers.Add(num);
            //    }
            //    foreach (int number in numbers)
            //    {
            //        if (number % 2 == 0)
            //            ECount++;
            //        else
            //            OCount++;
            //    }
            //    WriteLine($"Even numbers count: {ECount}");
            //    WriteLine($"Odd numbers count: {OCount}");
            //ReadKey();
            //}
            //else
            //{
            //    WriteLine("Please enter a positive number");
            //ReadKey();
            //}
            #endregion
            #region q4
            //Console.WriteLine("Please enter 10 numbers (or 999 to stop early):");
            //int sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"number {i + 1}: ");
            //    int n = int.Parse(Console.ReadLine());
            //    if (n == 999)
            //        break;
            //    if (n < 0) 
            //        continue;
            //    sum += n;
            //}
            //Console.WriteLine($"Sum of valid numbers: {sum}");
            //ReadKey();
            #endregion
            #region bouns
            //WriteLine("Enter the target :");
            //int t = int.Parse(ReadLine());
            //int[] nums=new int[4];
            //for(int i=0;i<nums.Length;i++)
            //{
            //    WriteLine($"Enter number {i+1}:");
            //    nums[i]=int.Parse(ReadLine());
            //}
            //for(int i=0;i<nums.Length;i++)
            //{
            //    if ((nums[i] + nums[i + 1]) == t)
            //        WriteLine($"[{i},{i+1}]");
            //    else if ((nums[i] + nums[i + 2]) == t)
            //        WriteLine($"[{i},{i+2}]");
            //    else if ((nums[i] + nums[i + 3]) == t)
            //        WriteLine($"[{i},{i+3}]");
            //    else if ((nums[i + 1] + nums[i + 2]) == t)
            //        WriteLine($"[{i+1},{i+2}]");
            //    else if ((nums[i + 1] + nums[i + 3]) == t)
            //        WriteLine($"[{i+1},{i+3}]");
            //    else if ((nums[i + 2] + nums[i + 3]) == t)
            //        WriteLine($"[{i+2},{i+3}]");
            //    ReadKey();
            //}
            #endregion
        }
    }
}
