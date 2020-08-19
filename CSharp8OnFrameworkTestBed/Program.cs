using System;
using System.Threading.Tasks;

namespace CSharp8OnFrameworkTestBed
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Point p = new Point() { X = 3, Y = 4 };
            Console.WriteLine(p);

            PatternMatching.RGBColor rgbColor = PatternMatching.FromRainbow(PatternMatching.Rainbow.Green);

            decimal salesTax = PatternMatching.ComputeSalesTax(new PatternMatching.Address() { State = "WA" }, 10);

            string rps = PatternMatching.RockPaperScissors("rock", "paper");

            PatternMatching.Quadrant quadrant = PatternMatching.GetQuadrant(new PatternMatching.Point(1, 1));

            UsingDeclarations.DoSomething();

            StaticLocalFunctions.M();

            DisposableRefStructHelper.Go();

            // This line doesn't give any compile-time errors, but would throw at runtime
            // because the code is expecting the first parameter to never be null
            //Console.WriteLine(NullableReferenceTypes.ReturnAString(null, null));
            Console.WriteLine(NullableReferenceTypes.ReturnAString(new NullableReferenceTypes(), null));

            // AsynchronousStreams can't be used in .NET Framework because
            // IAsyncEnumerable<T> doesn't exist
            //await foreach (var number in AsynchronousStreams.GenerateSequence())
            //{
            //    Console.WriteLine(number);
            //}

            // IAsyncDisposable does not exist in .NET Framework, so this won't compile
            //var exampleAsyncDisposable = new ExampleAsyncDisposable();
            //await using (exampleAsyncDisposable.ConfigureAwait(false))
            //{
            // Interact with the exampleAsyncDisposable instance.
            //}


            // Won't do anything because .NET Framework doesn't 
            // have System.Index or System.Range
            IndicesAndRanges.Go();

            NullCoalescingAssignment.Go();

            UnmanagedConstructedTypes.Go();

            StackAllocInNestdExpressions.Go();

            InterpolatedStrings.Go();

            Console.ReadKey();
        }
    }
}
