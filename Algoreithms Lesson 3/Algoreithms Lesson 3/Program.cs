using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algoreithms_Lesson_3
{
    public class PointClass
    {
        public int X;
        public int Y;

        [Benchmark]
        public static float PointDistanceFloat(PointClass point1, PointClass point2)
        {
            float x = point1.X - point2.X;
            float y = point1.Y - point2.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
    }
    public struct PointStruct
    {
        public int X;
        public int Y;

        [Benchmark]
        public static float PointDistanceFloat(PointStruct point1, PointStruct point2)
        {
            float x = point1.X - point2.X;
            float y = point1.Y - point2.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        [Benchmark]
        public static double PointDistanceDouble(PointStruct point1, PointStruct point2)
        {
            double x = point1.X - point2.X;
            double y = point1.Y - point2.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        [Benchmark]
        public static float PointDistanceShort(PointStruct point1, PointStruct point2)
        {
            float x = point1.X - point2.X;
            float y = point1.Y - point2.Y;
            return (x * x) + (y * y);
        }
    }

    public class Tester
    {
        
    }
       
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
