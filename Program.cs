using System;
using System.Collections.Generic;

// Program to take a list of number inputs and output them as the largest possible number configuration
// I.e. 51, 4, 55, 10, 9, 59 should output 9595551419

namespace gnum
{
    class Program
    {
        static void Main(string[] args)
        {
// Input nums followed by empty list which will become output. 
            List<int> nums = new List<int>() { 51, 4, 55, 10, 9, 59 };
            List<int> anums = new List<int>();
            int c = 0;
            nums.Sort();
            nums.Reverse();

// After sort, list goes through every number 9 to 0 and tries to match the first digit to place in order from highest
// digit to lowest digit. If it registers it places into anums and removes from nums. c is a counter. 
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if(nums[j] > -1)
                    {
                        if(i == Reduce.Number(nums[j]))
                        {
                            anums.Add(nums[j]);
                            nums[j] = -1;
                            c++;
                        }
                    }
                }
            }
// Output everything in anums. 
            foreach (var item in anums)
            {
                Console.Write(item);
            }
        }
    }
}
