﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 2;
            int int2 = 10;

            float float1 = 10.23f;
            float float2 = 3.4f;

            double double1 = 11.0;
            double double2 = 5.234;

            char char1 = 'x';
            char char2 = '$';
               
            uint num1 = 4294967295;
            uint num2 = 1;
            uint result = num1 + num2;

            Console.WriteLine(int1 + "+" + int2 + "=" + (int1 + int2));
            Console.WriteLine(int1 + "-" + int2 + "=" + (int1 - int2));
            Console.WriteLine(float1 + "+" + float2 + "=" + (float1 + float2));
            Console.WriteLine(double1 + "+" + double2 + "=" + (double1 + double2));
            Console.WriteLine(char1 + "+" + char2 + "=" + (double1 + double1));
            Console.WriteLine(result);
        }
    }
}