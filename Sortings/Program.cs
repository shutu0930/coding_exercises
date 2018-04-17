using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 0,3, 1, 6, 0, 8, 9 };
            //0,1,2,3,5,6,8,9
            //InsertionSort(arr);
            QuickSort(arr, 0, arr.Length-1);
            foreach (int ele in arr)
            {
                Console.WriteLine(ele);
            }
        }

        static void BubbleSort(int[] arr)
        {
            //int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length-i; j++)
                {
                    if (arr[j-1] > arr[j])
                    {
                        Swap(arr, j - 1, j);
                        //temp = arr[j-1];
                        //arr[j-1] = arr[j];
                        //arr[j] = temp;
                    }
                }
            }
        }
        static void SelectionSort(int[] arr)
        {
            int min;
            //int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                if (arr[i] > arr[min])
                {
                    Swap(arr, min, i);
                    //temp = arr[min];
                    //arr[min] = arr[i];
                    //arr[i] = temp;
                }
            }

        }
        static void InsertionSort(int[] arr)
        {
            //int temp;
            for (int i = 1; i < arr.Length; i++)
            {

                for (int j = i; j >0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j - 1, j);
                        //temp = arr[j];
                        //arr[j] = arr[j - 1];
                        //arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }


        static void QuickSort(int[] arr, int left, int right)
        {
            if (left > right)
                return;
            int pivotPos = Partition(arr, left, right);
            QuickSort(arr, left, pivotPos-1);
            QuickSort(arr, pivotPos+1, right);
        }
        
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (left < right)
            {
                while (pivot <= arr[right] && left<right)
                {
                    right--;
                }
                arr[left] = arr[right];

                while (pivot >= arr[left] && left < right)
                {
                    left++;
                }
               
                arr[right] = arr[left];
            }

            arr[left] = pivot;
            return left;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
