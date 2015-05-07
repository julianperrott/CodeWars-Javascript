﻿/* http://www.codewars.com/kata/55252a50de8b4bac00000805

Write a function to multiply a number (x) by a given number (y) a certain number of times (n). The results are to be returned in an array.

eg. multiplyBy(2, 4, 6);
The output is: [8, 32, 128, 512, 2048, 8192]
NB: all arguments (x,y and n) will always be integers. Times (n) will always be a positive integer.
*/

namespace CSharp.Codewars
{
    using System.Linq;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public partial class MultiplyByCs
    {
        public static List<int> MultiplyBy(int x, int y, int n)
        {
            return Enumerable.Repeat(y, n - 1)
                .Aggregate(new List<int> { x * y }, (acc, mult) => 
                {
                    return acc.Concat(new List<int> { acc.Last() * mult }).ToList(); 
                });
        }
    }
}