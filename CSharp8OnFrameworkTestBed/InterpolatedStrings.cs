using System;

namespace CSharp8OnFrameworkTestBed
{
    public class InterpolatedStrings
    {
        public static void Go()
        {
            string dollarFirst = $@"
{true}
";
            string atFirst = $@"
{true}
";

            Console.WriteLine(dollarFirst);
            Console.WriteLine(atFirst);
        }
    }
}
