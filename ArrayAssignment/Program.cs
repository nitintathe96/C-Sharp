using System;
using System.Linq;
using System.Collections;

namespace ArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* integer array declaration & Initialization*/
            int[] evenNums = new int[5] { 4, 2, 6, 3, 9};
            
            /* Accessing Array Elements using for Loop */
            // read values of array elements
            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            //increase the value of each element by 5
            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 5;

            Console.WriteLine("After increasing  values");
            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            /* Array Declaration using var */
            var cities = new string[] { "Mumbai", "Pune", "Nagpur" };
            foreach (var city in cities)
                Console.WriteLine(city);

            int[] nums = new int[5] { 10, 15, 16, 8, 6 };
            //int[] emptyArray = new int[6];

            //Array.Copy(nums, emptyArray, nums.Length);
            //Console.Write("after coping  array elements: ");
            // Displaying second array  
            //Console.WriteLine(emptyArray);

            Console.WriteLine("length of first array: " + nums.Length);  // Displaying length of array  
            Console.WriteLine("\nIndex position of 15 is " + Array.IndexOf(nums, 15)); // Finding index of an array element
                                                                                       // 
            /* The Array class implements the IEnumerable interface, so you can LINQ extension methods such as Max(), Min(), Sum(), reverse(), etc. */

            Console.WriteLine(nums.Max()); // returns max Value
            Console.WriteLine(nums.Min()); // returns min Value
            Console.WriteLine(nums.Sum()); // returns sum of array element
            Console.WriteLine(nums.Average()); // returns average of sequence of value.


            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Incube");
            list.Add(4567);
            list.Add(3.14);
            list.Add('I');
            Console.WriteLine("\n Print ArrayList elements:");
            foreach (var arr in list)
            {
                Console.WriteLine(arr);
            }
    
            Console.WriteLine("Printing index Of some value in Arraylist");
            Console.WriteLine(list.IndexOf("Incube"));

            Console.WriteLine("Inserting element in arralist");
            list.Insert(3, "vedant");
            list.Insert(2, "aditya");
            Console.WriteLine("After Inserting  values arraylist");
            foreach (var arr in list)
            {
                Console.WriteLine(arr);
            }

            Console.WriteLine("Removing the value like I");
            list.Remove('I');
            foreach (var arr in list)
            {
                Console.WriteLine(arr);
            }

            list.RemoveAt(2);
            Console.WriteLine("After Removing at specified index  values");
            foreach (var arr in list)
            {
                Console.WriteLine(arr);
            }

            // it return boolean value.
            Console.WriteLine(list.Contains(2));
            
            // reversing array                                     
            list.Reverse();
            Console.Write("Reversed ArrayList elements: ");
            foreach (var arr in list)
            {
                Console.WriteLine(arr + " ");
            }

        }
    }
}
