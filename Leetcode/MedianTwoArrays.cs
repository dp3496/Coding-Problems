using System;

namespace Leetcode
{
    public class MediaTwoArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] wholeArr = new int[nums1.Length + nums2.Length];

            int pivot = 0;
            int index = 0;
            while (true)
            {
                if (nums2.Length <= pivot && nums1.Length <= index)
                {
                    break;
                }
                if (nums2.Length <= pivot)
                {
                    wholeArr[(index + pivot)] = nums1[index];
                    index++;
                    continue;
                }
                if (nums1.Length <= index)
                {
                    wholeArr[(index + pivot)] = nums2[pivot];
                    pivot++;
                    continue;
                }
                if (nums1[index] <= nums2[pivot])
                {
                    wholeArr[(pivot + index)] = nums1[index];
                    index++;
                }
                else
                {
                    wholeArr[(pivot + index)] = nums2[pivot];
                    pivot++;
                }
            }

            int middle = wholeArr.Length / 2;

            if (wholeArr.Length % 2 == 0)
            {
                var first = (double)wholeArr[middle - 1];
                var second = (double)wholeArr[middle];
                return (first + second) / 2;
            }

            return wholeArr[(int)middle];
        }
    }
}