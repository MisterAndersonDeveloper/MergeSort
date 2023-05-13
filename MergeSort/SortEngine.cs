namespace MergeSort
{
    internal static class SortEngine
    {
        public static void MergeSort(int[] unsortedArray, int start, int end)
        {
            if (start < end)
            {
                int middle = start + (end - start) / 2;

                MergeSort(unsortedArray, start, middle);
                MergeSort(unsortedArray, middle + 1, end);

                Merge(unsortedArray, start, middle, end);
            }
        }

        private static void Merge(int[] unsortedArray, int start, int middle, int end)
        {
            int n1 = middle - start + 1;
            int n2 = end - middle;

            int[] first = CopySubArray(unsortedArray, start, n1);
            int[] second = CopySubArray(unsortedArray, middle + 1, n2);

            int i = 0, j = 0, k = start;

            while (i < n1 && j < n2)
            {
                if (first[i] < second[j])
                {
                    unsortedArray[k] = first[i];
                    i++;
                }
                else
                {
                    unsortedArray[k] = second[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                unsortedArray[k] = first[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                unsortedArray[k] = second[j];
                j++;
                k++;
            }


            #region Advanced approach
            //while (i < n1 && j < n2)
            //    unsortedArray[k++] = first[i] < second[j] ? first[i++] : second[j++];

            //while (i < n1)
            //    unsortedArray[k++] = first[i++];

            //while (j < n2)
            //    unsortedArray[k++] = second[j++];
            #endregion
        }

        private static int[] CopySubArray(int[] originalArray, int startIndex, int subLength)
        {
            int[] subArray = new int[subLength];

            for (int i = 0; i < subLength; i++)
                subArray[i] = originalArray[startIndex + i];

            return subArray;
        }
    }
}
