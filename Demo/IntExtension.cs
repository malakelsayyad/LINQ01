﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class IntExtension
    {
        //1234
        //Extension method
        //public static int Reverse( this int Number)
        //{
        //    int ReversedNumber = 0,LastDigit;
        //    while ( Number>0)
        //    {
        //        LastDigit = Number % 10 ; //4
        //        ReversedNumber = ReversedNumber * 10 + LastDigit;
        //        Number /=10;
        //    }


        //    return ReversedNumber;
        //}
        //public static long Reverse(this long Number)
        //{
        //    long ReversedNumber = 0, LastDigit;
        //    while (Number > 0)
        //    {
        //        LastDigit = Number % 10; //4
        //        ReversedNumber = ReversedNumber * 10 + LastDigit;
        //        Number /= 10;
        //    }


        //    return ReversedNumber;
        //}
        // 4321
        // 12345
        // 12345 % 10 =5
        // 12345 / 10 = 1234
        // 1234 % 10=4
        // 1234 / 10 = 123
        // 123 % 10 = 3
        // 123 / 10 = 12
        // 12 % 10 = 2
        // 12 /10 = 1
        // 1 / 10 = 0 

    }
}
