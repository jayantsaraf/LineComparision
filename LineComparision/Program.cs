﻿using System;

namespace LineComparision
{
    class Program
    {
        public static int CompareTo(double length1, double length2)
        {
            double line1Length = length1;
            double line2Length = length2;

            //Checking for equality and other comparisions
            if (line1Length == line2Length)
                Console.WriteLine("Both lines have equal length");
            else if (line1Length > line2Length)
                Console.WriteLine("First line is longer than the second one");
            else
                Console.WriteLine("First line is sorter than the second one");
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program!");

            ////variables
            int[] line1Point1 = new int[2];
            int[] line1Point2 = new int[2];
            int[] line2Point1 = new int[2];
            int[] line2Point2 = new int[2];



            ////Function to find length
            static double FindLength(int[] l1, int[] l2)
            {
                double length;
                length = Math.Sqrt(Math.Pow((l2[0] - l1[0]), 2) + Math.Pow((l2[1] - l1[1]), 2));
                return length;
            }

            ////Taking input for 1st line          
            static void InputLine(ref int[] point1, ref int[] point2)
            {
                Console.WriteLine("Enter X-Coordinate of 1st point");
                point1[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y-Coordinate of 1st point");
                point1[1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter X-Coordinate of 2nd point");
                point2[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y-Coordinate of 2nd point");
                point2[1] = Int32.Parse(Console.ReadLine());

                return;
            }

            ////Taking points of line1 and printing length of line 1
            InputLine(ref line1Point1, ref line1Point2);
            double line1Length;
            line1Length = FindLength(line1Point1, line1Point2);
            Console.WriteLine("Length of first line is " + line1Length);

            ////Taking points of line1 and printing length of line 2
            InputLine(ref line1Point1, ref line1Point2);
            double line2Length;
            line2Length = FindLength(line1Point1, line1Point2);
            Console.WriteLine("Length of first line is " + line2Length);

            CompareTo(line1Length, line2Length);


        }
    }
}
