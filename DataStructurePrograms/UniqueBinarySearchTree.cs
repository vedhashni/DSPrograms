﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class UniqueBinarySearchTree
    {
        public static double numberOfBinarySearchTree(int n)
        {

            int[] uniqueBST = new int[n + 1];
            uniqueBST[0] = 1;
            uniqueBST[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    uniqueBST[i] = uniqueBST[i] + (uniqueBST[i - j] *
                                     uniqueBST[j - 1]);
                }
            }
            double powerVal = Math.Pow(10, 8);
            return Math.Abs(uniqueBST[n] % powerVal);
        }
    }
}
