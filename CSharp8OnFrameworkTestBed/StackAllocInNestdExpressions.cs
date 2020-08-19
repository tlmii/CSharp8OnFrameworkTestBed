using System;

namespace CSharp8OnFrameworkTestBed
{
    public class StackAllocInNestdExpressions
    {
        public static void Go()
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var ind = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });
            Console.WriteLine(ind);  // output: 1
        }
    }
}
