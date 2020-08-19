﻿using System;

namespace CSharp8OnFrameworkTestBed
{
    public class UnmanagedConstructedTypes
    {
        public struct Coords<T>
        {
            public T X;
            public T Y;
        }

        public static void Go()
        {
            Span<Coords<int>> coordinates = stackalloc[]
            {
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 0, Y = 3 },
                new Coords<int> { X = 4, Y = 0 }
            };
        }
    }
}
