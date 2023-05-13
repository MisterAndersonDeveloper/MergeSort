// See https://aka.ms/new-console-template for more information
using MergeSort;

int[] inputArray = new int[] { 12, 11, 13, 5, 6, 7, 0 };
SortEngine.MergeSort(inputArray, 0, inputArray.Length - 1);

for (int i = 0; i < inputArray.Length; i++)
{
    Console.Write($"{inputArray[i]} ");
}
