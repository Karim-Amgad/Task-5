using System;
using System.Linq;
using System.Threading;

namespace Task_5
#nullable enable
{
    internal class Program
    {
        #region Problem-2 Function
        //public static void TestDegensiveCode()
        //{
        //    int X, Y, Z;
        //    do
        //        Console.WriteLine("enter first number :");
        //    while (!int.TryParse(Console.ReadLine(), out X) && X > 0);
        //    do
        //        Console.WriteLine("enter second number :");
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y > 1);
        //    Z = X / Y;

        //    int[] arr = { 1, 2, 3, 4 };
        //    if (arr?.Length > 108)
        //        arr[108] = 78;
        //}
        #endregion

        #region Problem-9 Function
        //public static void SumAndMultiply(int n1, int n2, out int sum, out int Mul)
        //{
        //sum = n1 + n2;
        //Mul = n1 * n2;
        //}
        #endregion

        #region Problem-10 Function
        //public static void Print(string S1, int n1 = 5)
        //{
        //    for (int i = 0; i < n1; i++)
        //        Console.WriteLine(S1);
        //}
        #endregion

        #region Problem-13 Function
        //public static void SumArray(out int sum, params int[] numbers)
        //{
        //    sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            #region Problem-1
            //// input the 2 values and parse into int and make sure they can be parsed
            //int N1, N2;
            //do { Console.WriteLine("Please Enter Valid first Number"); }
            //while (!int.TryParse(Console.ReadLine(), out N1));

            //do { Console.WriteLine("Please Enter Valid Second Number"); }
            //while (!int.TryParse(Console.ReadLine(), out N2));

            //// begin devision and use try and catch
            //try
            //{
            //    int Div = (N1 / N2); //// if it can be done it will continue, if not catch will get it
            //    Console.WriteLine($"The result is {Div}");
            //}
            //catch (DivideByZeroException ex)
            //{ Console.WriteLine(ex.Message); }
            //finally { Console.WriteLine("Operation complete"); }
            //Console.WriteLine("The code can run either there is exception or not");
            #endregion

            #region Question-1
            // it's purpose to allow the code to continue running even if exception shows.
            // and as we know the exception stops running the whole block so it allows the code to continue running after exception appears 
            #endregion

            #region Question-2
            // int.Parse() = it will parse the value and if it can't be parsed, it will throw an exception.
            //int.TryParse() = it will try to parse the value and if it can't be parsed, it will return 0 and a bool with value false and vise versa.

            // int.TryParse() is better as it provides a safer way to cast values without throwing an exception, which allows the program to handle any
            //                invalid dat casting without exceptions
            #endregion

            #region Problem-3
            //// declare nullable & use ??
            //int? n1 = null; // Nullable<int> n1;
            //int n2 = n1 ?? default;


            //// HasValue (it's like bool which has value of true or false)
            //// Value (It's like int which returns value of the variable)
            //if (n1.HasValue)
            //    Console.WriteLine($"Number has value is {n1.Value}");
            //else Console.WriteLine("Number has no value");
            #endregion

            #region Question-3
            //// it returns InvalidOperationException 

            //int? d = null;
            //int y = d.Value;
            //Console.WriteLine(y);
            #endregion

            #region Problem-4

            //int[] arr = new int[4];

            //try
            //{
            //    arr[55] = 44;
            //    Console.WriteLine($"Then number is {arr[55]}");
            //}
            //catch ( IndexOutOfRangeException ex )
            //{ 
            //Console.WriteLine( ex.Message );
            //}

            #endregion

            #region Question-4
            // to avoid IndexOutOfRangeException and ensure the right functionality of program
            // also memory safety from accessing different part of memory which can lead to data corruption
            #endregion

            #region Problem-5
            //To enter values of array
            //int SumCol = 0;
            //int SumRow = 0;
            //int[,] arr = new int[3,3];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"For row {i + 1}");
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter value For column {j + 1}");
            //        bool flag = int.TryParse(Console.ReadLine(), out arr[i,j]);
            //    }
            //}

            //// to get sum of row 
            //Console.WriteLine("Enter the row number you want to get the sum of its elements");
            //bool dd = int.TryParse(Console.ReadLine(),out int n);
            //for (int j = 0;j < arr.GetLength(1); j++)
            //{
            //    SumRow += arr[n-1,j];
            //}
            //Console.WriteLine($"The sum is {SumRow}");

            //// to get sum of col
            //Console.WriteLine("Enter the column number you want to get the sum of its elements");
            //bool d = int.TryParse(Console.ReadLine(), out int h);
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    SumCol += arr[i,h-1];
            //}
            //Console.WriteLine($"The sum is {SumCol}");
            #endregion

            #region Question-5
            // as shown in previous example
            // arr.GetLength(x) returns the length of array dimension which has index of value x
            // for example:
            //int[,] arr = new int[3,5] ;
            //Console.WriteLine(arr.GetLength(0)); //3
            //Console.WriteLine(arr.GetLength(1)); //5
            #endregion

            #region Problem-6
            //// declare Jagged array
            //int[][] Jag = new int[3][];
            //// get number of elements in each row and put values in it
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter number of values for row {i + 1}");
            //    int.TryParse(Console.ReadLine(), out int J);
            //    Jag[i] = new int[J];
            //    for (int k =0 ; k < J ; k++)
            //    { 
            //        Console.WriteLine($"Enter Values for element {k+ 1} in row {i + 1}");
            //        int.TryParse(Console.ReadLine(), out Jag[i][k]);
            //    }
            //}
            //// print numbers
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Jag[i].Length ; j++)
            //    {
            //        Console.Write($"{Jag[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Question-6
            // rectangle array: It's an array of elements stored as a single block and takes space equal to no of elements*size of element.
            // jagged array : It's an array of arrays or an array of references of arrays where each row has a different size and stored
            //                away from other rows not as a single block.The whole size depend on number of rows and size of each row. 
            #endregion

            #region Problem-7
            //String? name = null;
            //Console.WriteLine("Please enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine($"The name is "+name!);
            #endregion

            #region Question-7
            // It's an enhancement in compiler like a warning 
            // it makes us avoid NullReferenceException by reminding us that this ref is holding null now
            #endregion

            #region Problem-8
            //int i = 1;
            //object obj = i;
            //Console.WriteLine(obj);

            //object obj1 = 'm';
            //int j = (int)obj1;
            //Console.WriteLine(j);

            //// we here have invalid cast exception and with check it becomes
            //try
            //{
            //    object obj2 = true;
            //    int k = (int)obj2;
            //    Console.WriteLine(k);
            //}
            //catch (Exception EX)
            //{ Console.WriteLine(EX.Message); }  
            #endregion

            #region Question-8
            // Boxing: it's assigning a value type into ref type.It causes memory overhead as it creates a new object and copies the value type int it 
            //         which increases the memory taken for it and performance is reduced as now it will deal with object in heap instead of int in stack
            //         which will slows the performance, but it can be done safely.
            // UnBoxing: it's assigning a ref type into value type. It also copies the value but from heap into stack which causes memory overhead.  
            //           It checks the type before doing casting so it takes more time than unboxing.if it contains an incompatible format type, it
            //           will throw an exception while doing so it is unsafe to do. 
            #endregion

            #region Problem-9 
            //Console.WriteLine("Please enter thw first number");
            //int.TryParse(Console.ReadLine(), out int x1);
            //Console.WriteLine("Please enter thw second number");
            //int.TryParse(Console.ReadLine(), out int x2);
            //SumAndMultiply(x1,x2,out int sum, out int Mul);
            //Console.WriteLine($"The sum is {sum} and the multiplicaation is {Mul}"); 
            #endregion

            #region Question-9
            // because in the methods, it is responsible to assign the value to the variable
            // and the compiler requires that these parameters must be assigned before returning the value to them to ensure type compatability
            #endregion

            #region Problem-10
            //Print(S1:"Depi",n1: 6);
            #endregion

            #region Question-10
            // because if they were in the middle, the compiler won't know if this value is for the optional parameter or the required parameter.
            #endregion

            #region Problem-11
            //int?[] array = { 1, 2, 3 } ;
            //int? num1 = array?.Length ;
            //Console.WriteLine(num1);
            //Console.WriteLine(array[0]);
            #endregion

            #region Question-11
            // it provides a safe way to access the properties of nullable objects and prohibites throwing the exception and return null 
            #endregion

            #region Problem-12
            //Console.WriteLine("Please enter day of week");
            //String s1 = Console.ReadLine();
            //switch (s1)
            //{
            //    case ("Monday"):
            //    Console.WriteLine(1);
            //    break;

            //    case ("Tuesday"):
            //    Console.WriteLine(2);
            //    break;

            //    case ("Wednesday"):
            //    Console.WriteLine(3);
            //    break;

            //    case ("Thursday"):
            //    Console.WriteLine(4);
            //    break;

            //    case ("Friday"):
            //    Console.WriteLine(5);
            //    break;

            //    case ("Satueday"):
            //    Console.WriteLine(6);
            //    break;

            //    case ("Sunday"):
            //    Console.WriteLine(7);    
            //    break;

            //    default:
            //    Console.WriteLine("Enter a valid day");
            //    break;
            //}
            #endregion

            #region Question-12
            // it's prefered when there are big number of possible values for the variable asit becomes more readable
            // when returning a value as it does it in 1 step
            #endregion

            #region Problem-13
            //SumArray(out int sum ,1, 2, 4, 5);
            //Console.WriteLine(sum);
            //int[] ARRAY = { 1, 2, 3, 5 };
            //SumArray(out int sum2 , ARRAY);
            //Console.WriteLine(sum2);
            #endregion

            #region Question-13
            // the method only accepts 1 params
            // it must be the last parameter
            // it works with only same type of array
            // can't do casting within even implicit
            #endregion
            //-------------------------------------------------------------------------------------
            // Part 2
            #region Program-1
            //int num;
            //bool flag;
            //do {
            //    Console.WriteLine("Please enter a positive int");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag || num <= 0);
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region Program-2
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Please enter a positive int");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag || num <= 0);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{num * i},");
            //}
            #endregion

            #region Program-3
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Please enter a positive even int");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag || num <= 0 || num%2 == 1);

            //for (int i = 2; i <= num; i += 2)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region Program-4
            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int num2);
            //if (num1 == 0 && num2 == 0)
            //{
            //    Console.WriteLine("Please enter valid values");
            //}
            //// using for loop
            //int res1=1;
            //for (int i = 1; i <= num2; i++)
            //{
            //    res1 *=num1;
            //}
            //// another solution 
            //double res = Math.Pow(num1, num2);
            //Console.WriteLine($"The result is {res1}");
            #endregion

            #region Program-5
            //Console.WriteLine("Please enter the word to be reversed");
            //String S1 = Console.ReadLine(); //input of string
            //char[] array = S1.ToCharArray(); //made a char array and transform the string to char array
            //Array.Reverse(array); // reverse the array
            //Console.WriteLine(array); // print the reversed array
            #endregion

            #region Program-6
            //int num;
            //Console.WriteLine("Please enter the number to be reversed");
            //String S1 = Console.ReadLine();
            //char[] array = S1.ToCharArray();
            //Array.Reverse(array);
            //Console.WriteLine(array);
            #endregion

            #region Program-7
            //int size;
            //// get size of array and declare array
            //Console.WriteLine("Please input the number of elements"); 
            //int.TryParse(Console.ReadLine(), out size);
            //int[] array = new int[size];
            ////get elements of array
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Enter the element number {i + 1}");
            //    int.TryParse(Console.ReadLine(), out array[i]);
            //}
            //int BiggestDistance = -1;
            //int Distance = 0;
            //// search for biggest distance
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        // Check if two elements are the same
            //        if (array[i] == array[j])
            //        {
            //            // Calculate the distance between them
            //            Distance = j - i - 1;
            //            // check if the distance is bigger than the BiggestDistance or not
            //            if (Distance > BiggestDistance)
            //            {
            //                BiggestDistance = Distance;
            //            }
            //        }
            //    }
            //}
            #endregion

            #region Program-8
            string S1 = "English is great";  
            string S2 = string.Join(" ", S1.Split(' ').Reverse()); // here splits the string by spaces then reverses it then adds space in 
                                                                                       // between each word 
            Console.WriteLine(S2);  // Output the reversed sentence
            #endregion
        }
    }   
}    