namespace Hackerrank.Sorting
{
    public static class MergeSort
    {
        public static void Sort(int[] items)
        {
            Sort(items, 0, items.Length - 1);
        }

        private static void Sort(int[] items, int start, int end)
        {
            if(start >= end)
            {
                return;
            }

            var middle = (start + end) / 2;

            Sort(items, start, middle);
            Sort(items, middle + 1, end);
            Merge(items, start, middle + 1, end);
        }

        private static void Merge(int[] items, int start, int middle, int end)
        {
            var left = start;
            var right = middle;

            while (left <= (middle - 1) && right <= end)
            {
                if(items[left] > items[right])
                {
                    var tempI = items[right];
                    items[right] = items[left];
                    items[left] = tempI;

                    left++;
                    right++;
                }
                else if(items[left] < items[right])
                {
                    left++;
                }
                else
                {
                    left++;
                    right++;
                }
            }
        }
    }
}