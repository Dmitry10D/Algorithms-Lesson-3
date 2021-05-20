using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;

namespace Algoreithms_Lesson_3
{   
    class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        

        public class PointClass
        {
            [ParamsSource(nameof(valueGenerator))]
            public int X;
            [ParamsSource(nameof(valueGenerator))]
            public int Y;

            public IEnumerable<int> valueGenerator()
            {
                int[] data = new int[1000];
                Random rnd = new Random();
                for (var i = 0; i <= data.Length; i++)
                {
                    data[i] = rnd.Next();
                }
                return data;
            }

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
            [ParamsSource(nameof(valueGenerator_))]
            public int X;
            [ParamsSource(nameof(valueGenerator_))]
            public int Y;

            public IEnumerable<int> valueGenerator_()
            {
                int[] data = new int[1000];
                Random rnd = new Random();
                for (var i = 0; i <= data.Length; i++)
                {
                    data[i] = rnd.Next();
                }
                return data;
            }

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
    }
}
