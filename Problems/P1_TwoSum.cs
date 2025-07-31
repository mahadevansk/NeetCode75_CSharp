using System;

namespace Problems
{
    public static class P1_TwoSum
    {
        // Brute Force Suedo Code

        // for i from 0 to nums.length - 1:
        // for j from i + 1 to nums.length - 1:
        // if nums[i] + nums[j] == target:
        // return [i, j]


        public static void Run()
        {
            Console.WriteLine("Running Problem 1 ");
            int[] nums = { 1, 2, 5, 8, 9, 12, 6, 65 }; // int [] nums = new int[] {1,2,3,4};
            int target = 69;
            int[] resIndex = GetTwoSum(nums, target);

            Console.WriteLine($"Index of the Elements {0,1}", resIndex[0], resIndex[1]);
       
        }



        public static int[] GetTwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };

                }
            }


            return new int[] { -1, -1 }; // not found. To Do Handle later. 

        }

    }
}