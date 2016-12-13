using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Sample_Code_Test
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] returnIndices = new int[2];
            int previousIndex = 0;
            List<int> secondaryNums = nums.ToList();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];
                int? currentTarget = null;

                secondaryNums.RemoveAt(i);

                for (int j = 0; j < secondaryNums.Count; j++)
                {
                    int secondaryReturnIndexValue = secondaryNums[j];

                    currentTarget = currentNumber + secondaryReturnIndexValue;

                    if (currentTarget == target)
                    {
                        returnIndices[0] = i;
                        returnIndices[1] = j + 1;

                        break;
                    }
                }

                secondaryNums = nums.ToList();

                if (currentTarget == target)
                {
                    break;
                }
            }

            return returnIndices;
        }
    }
}