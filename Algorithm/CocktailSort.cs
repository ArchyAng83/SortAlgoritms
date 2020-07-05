﻿using System;


namespace Algorithm
{
    public class CocktailSort<T> : AlgorithmBase<T> where T: IComparable
    {
        protected override void MakeSort()
        {      
            int left = 0;
            int right = Items.Count - 1; 

            while (left < right)
            {
                var sc = SwapCount;

                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                        ComprisonCount++;
                    }
                }
                right--;

                if (sc == SwapCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                        ComprisonCount++;
                    }
                }
                left++;

                if (sc == SwapCount)
                {
                    break;
                }
            }
        }
    }
}
