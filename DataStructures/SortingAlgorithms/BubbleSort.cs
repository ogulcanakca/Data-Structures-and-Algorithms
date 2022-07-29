﻿using DataStructures.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SortingAlgorithms
{
    public class BubbleSort
    {
        
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j].CompareTo(array[j + 1])>0)
                    {
                        Sorting.Swap<T>(array,j,j+1);
                    }
                }
            }
        }
        public static void Sort<T>(T[] array, SortDirection sortDirection = SortDirection.Ascending) where T : IComparable
        {
            var comparer = new CustomComparer<T>(sortDirection, Comparer<T>.Default);
            

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j+1]) >= 0)
                    {
                        continue;
                    }
                    Sorting.Swap<T>(array, j, j+1);
                }
            }
        }
    }
}
