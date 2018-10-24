using System;

namespace TestDemoLib
{
    public static class Triangle
    {
        public static double GetArea(double a, double h)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(a),
                    "Length of triangle base side must be greater then zero.");
            }

            if (h <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(h),
                    "Length of triangle height must be greater then zero.");
            }

            return a * h / 2;
        }

        public static double GetPerimeter(double a, double b, double c) => 0;
    }
}
