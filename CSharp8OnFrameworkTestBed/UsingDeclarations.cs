using System;
using System.IO;

namespace CSharp8OnFrameworkTestBed
{
    public class UsingDeclarations
    {
        public static void DoSomething()
        {
            using MemoryStream memoryStream = new MemoryStream();
        }

        public class DisposableNothing : IDisposable
        {
            public DisposableNothing()
            {
                Console.WriteLine("DisposableNothing Created");
            }
            public void Dispose()
            {
                Console.WriteLine("DisposableNothing Disposed.");
            }
        }
    }
}
