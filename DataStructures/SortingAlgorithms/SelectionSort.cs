using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Shared;

namespace DataStructures.SortingAlgorithms
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int minimumindex = i;
                T minValue = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue)<0)
                    {
                        //büyükse 1 küçükse -1 eşitse 0
                        minimumindex = j;
                        minValue = array[minimumindex];
                    }
                }
                Sorting.Swap(array,i,minimumindex);
            }
        }

        public static void Sort<T>(T[] array,SortDirection sortDirection = SortDirection.Ascending) where T : IComparable
        {
            var comparer = new CustomComparer<T>(sortDirection, Comparer<T>.Default);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[j], array[i])>=0)
                    {
                        continue;
                    }
                    Sorting.Swap<T>(array, i, j);
                }
                
            }
        }
    }
}
