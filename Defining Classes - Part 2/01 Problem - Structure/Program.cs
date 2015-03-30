﻿/*Problem 1. Structure

Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.
 */

/*Problem 2. Static read-only field

Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
Add a static property to return the point O.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D test = new Point3D() { X = 5, Y = 6, Z = 2 };
            // Console.WriteLine(test.ToString()); // Pr1
            // Console.WriteLine(Point3D.O.ToString());     // Pr2 > def O
            Point3D p2 = new Point3D() { X = -7, Y = 11, Z = -13 };
            Calculations.Print(test, p2);

        }
    }
}