using System;

namespace ArrayT
{
   public  class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
       public class PushZero
        {

            // Function which pushes all zeros 

            // to end of an array.

            public static void pushToEnd(int[] arr, int n)

            {

              int count = 0;
                for (int i = 0; i < n; i++)

                    if (arr[i] != 0)

                     
                        arr[count++] = arr[i];
             
                while (count < n)

                    arr[count++] = 0;

            }
            public static void Main()

            {
                Console.WriteLine("Entert the number of elements of array");
                int num = Convert.ToInt32(Console.ReadLine());
                //int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
                int[] arr=new int[num];
                Console.WriteLine("Enter the elements");
                for (int i = 0; i < num;i++)
                {
                   arr[i]= Convert.ToInt32(Console.ReadLine());
                }
                int n = arr.Length;

                pushToEnd(arr, n);

                Console.WriteLine("Array after pushing all zeros to the back: ");

                for (int i = 0; i < n; i++)

                    Console.Write(arr[i] + " ");

            }
        }
    }
}
