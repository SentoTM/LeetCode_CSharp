using System;

namespace LC_TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //Ejemplo 1. la solucion debería ser los índices 0 y 1.
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            
            try
            {
                int[] result = solution.TwoSum(nums, target);
                Console.WriteLine($"Indices que suman al objetivo: [{result[0]}, {result[1]}]");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            };

            //Ejemplo 2. la solucion debería ser los índices 1 y 2.
            int[] nums2 = { 3, 2, 4 };
            target = 6;

            try
            {
                int[] result = solution.TwoSum(nums2, target);
                Console.WriteLine($"Indices que suman al objetivo: [{result[0]}, {result[1]}]");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Ejemplo 3. la solucion debería ser los índices 0 y 1.
            int[] nums3 = { 3, 3 };
            target = 6;

            try
            {
                int[] result = solution.TwoSum(nums3, target);
                Console.WriteLine($"Indices que suman al objetivo: [{result[0]}, {result[1]}]");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Ejemplo 4. la solucion debería ser error.
            int[] nums4 = { 3, 3 };
            target = 7;

            try
            {
                int[] result = solution.TwoSum(nums3, target);
                Console.WriteLine($"Indices que suman al objetivo: [{result[0]}, {result[1]}]");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

    }
}




