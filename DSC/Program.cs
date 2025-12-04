using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSC
{
    internal class Program
    {
        #region Value type parameters
        // VALUE
        //public static void Swap(int n1 , int n2 ) // work in method stack frame 
        //{
        //    int index = n1;  // index =5 ,n1= 2 ,n2= 5
        //    n1= n2;
        //    n2 = index;
        //}
        #endregion
        #region Value type parameters
        // Ref
        //public static void Swap(ref int n1 ,  ref int n2 ) // work in method stack frame 
        //{
        //    int index = n1;  // index =5 
        //    n1= n2;
        //    n2 = index;
        //}
        #endregion
        #region reference type parameters
        // value
        //public static int sum(int[] num) // has asame address in heap 
        //{
        //    num[0] = 30;
        //    int sum = 0;
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        sum += num[i];
        //    }
        //    return sum;
        //}
        #endregion
        #region reference type parameters
        //ref
        //public static int sum(int[] num) // has a diffrent address in heap 
        //{
        //    num = [10,20,30,40];
        //    int sum = 0;
        //    for (int i = 0; i < num.Length; i++) // i =4 , sum =100
        //    {
        //        sum += num[i];
        //    }
        //    return sum;
        //}
        #endregion
        #region q1
        //public static double Sum(double n1, double n2)
        //    { return n1 + n2; }
        #endregion
        #region q2
        //public static void Print(int n)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        Console.Write(i+" ");
        //    }
        //}
        #endregion
        #region q3
        //public static void Swap(ref int x, ref int y)
        //{
        //    int T = x;
        //    x = y;
        //    y = T;
        //}
        #endregion
        #region q4
        //public static int[] MinMax(int[] arr)
        //{
        //  int  max = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        if (arr[i] > max)
        //            max = arr[i];
        //    }
        //    int min = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //            min = arr[i];
        //    }
        //    return [max, min];

        //}

        #endregion
        #region q5
        //public static string IsPrime(int n)
        //{
        //    if(n<=1)
        //        return "Not prime";

        //    for (int i = 2; i * i <= n; i++)
        //    {
        //        if (n % i == 0 )
        //            return "Not prime";
        //    }

        //    return "Prime";
        //}
        #endregion
        #region q6
                    public static void factorial(long n)
        {
            long  fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"factorial : {fact}");

        //}
        #endregion
        #region q7
        //public static void SumDigit(int n)
        //{
        //    int sum = 0;
        //    while (n > 0)
        //    {
        //        int r = n % 10;
        //        sum += r;
        //        n /= 10;
        //    }
        //    Console.WriteLine(sum);

        //}
        #endregion
        #region q8
        //        public static string Palindrome(string n)
        //        {
        //            while (n.StartsWith("0"))
        //                n = n.Substring(1);
        //            while (n.EndsWith("0"))
        //                n = n.Substring(0, n.Length - 1);
        //            for (int i = 0; i < n.Length; i++)
        //            {
        //                if (n[i] != n[n.Length - 1 - i])
        //                    return "NO";
        //            }

        //            return "YES";
        //}
        #endregion
        #region q9
        //public static void ShiftZeros(int[] A, int N)
        //{
        //    int j = 0;
        //    for (int i = 0; i < N; i++)
        //    {
        //        if (A[i] != 0)
        //        {
        //            A[j] = A[i];
        //            j++;
        //        }
        //    }
        //    while (j < N)
        //    {
        //        A[j] = 0;
        //        j++;
        //    }
        //}
        #endregion
        #region q10
        //public static void Swaprow(int n, int x, int y, int[,] arr)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        int temp = arr[x, i];
        //        arr[x, i] = arr[y, i];
        //        arr[y, i] = temp;
        //    }
        //}
        //public static void Swapcolumn(int n, int x, int y, int[,] arr)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        int temp = arr[i, x];
        //        arr[i, x] = arr[i, y];
        //        arr[i, y] = temp;
        //    }
        //}
        #endregion
        #region q11
        //public static string HarryPotter(string n)
        //{
        //    char index = n[n.Length - 1];
        //    if (index == '0')
        //        return "AvadaKedavra";
        //    else
        //        return "ExpectoPatronum";

        //}

        #endregion
        static void Main(string[] args)
            {
            #region  Value type parameters
            //value
            //int a = 5;
            //int b = 2;
            //Swap(a, b);
            //Console.WriteLine(a); // 5
            //Console.WriteLine(b); // 2
            #endregion
            #region Value type parameters
            // ref
            //int a = 5;
            //int b = 2;
            //Swap( ref a,ref  b);
            //Console.WriteLine(a); // 2
            //Console.WriteLine(b); // 5
            #endregion
            #region reference type parameters
            // value
            //int[] num = { 1, 2, 3 };
            //int index = sum(num);
            //Console.WriteLine(num[0]); // 30
            //Console.WriteLine(index); // 35
            #endregion
            #region reference type parameters
            // ref 
            //int[] num = { 1, 2, 3 };
            //int index = sum(num);
            //Console.WriteLine(num[0]); // 1
            //Console.WriteLine(index); // 100
            #endregion
            #region q1 => main
            // double x = 3;
            // double y = 2;
            //double result= Sum(x,y);
            // Console.WriteLine(result);
            #endregion
            #region q2 => main
            //int n=int.Parse(Console.ReadLine());
            //Print(n);
            #endregion
            #region q3 => main
            //int x = 5;
            //int y = 3;
            //Swap(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #region q4 => main
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for(int i=0;i<size;i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine
            //}
            //int[] n = MinMax(arr);
            //Console.WriteLine("Max: " + n[0]);
            //Console.WriteLine("Min: " + n[1]);
            #endregion
            #region q5 => main
            //int n = int.Parse(Console.ReadLine());
            //string answer = IsPrime(n);
            //Console.WriteLine(answer);
            //#endregion
            #region q6 => main
            //int n = int.Parse(Console.ReadLine());
            //factorial(n);
            #endregion
            #region q7 => main
            //SumDigit(251);
            #endregion
            #region q8 => main
            //string n= Console.ReadLine();
            //string x = Palindrome(n);
            //Console.WriteLine(x);


            #endregion
            #region q9 => main
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //    arr[i] = int.Parse(Console.ReadLine());
            //ShiftZeros(arr, n);
            //for (int i = 0; i < n; i++)
            //    Console.Write(arr[i] + " ");

            #endregion
            #region q10 => main
            //int n = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    string[] row = Console.ReadLine().Split();
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr[i, j] = int.Parse(row[j]);
            //    }
            //}
            //Swaprow(n, x, y, arr);
            //Swapcolumn(n, x, y, arr);
            //Console.WriteLine( );
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region q11 => main
            //string N = Console.ReadLine();
            //string answer = HarryPotter(N);
            //Console.WriteLine(answer);

            #endregion

        }

    }
}
