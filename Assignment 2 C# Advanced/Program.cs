using System;

namespace Assignment_2_C__Advanced
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 89, 99 };
            Func<int, int> half = n => n / 2;   //I dont think it can be done using predicate as predicate returns bool
            var halfed = nums.Select(half);
            foreach(var number in halfed)
            {
                Console.WriteLine(number);
            }
           
        }
    }
}
