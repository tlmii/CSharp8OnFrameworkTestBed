namespace CSharp8OnFrameworkTestBed
{
    public ref struct DisposableRefStruct
    {
        public void Dispose()
        {

        }
    }

    public static class DisposableRefStructHelper
    {
        public static void Go()
        {
            using (DisposableRefStruct disposableRefStruct = new DisposableRefStruct())
            {

            }
        }
    }
}
