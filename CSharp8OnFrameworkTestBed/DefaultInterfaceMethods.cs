namespace CSharp8OnFrameworkTestBed
{
    // Default interface methods
    // DOES NOT WORK - Compile-time error
    public interface ISomethingWithDefaults
    {
        void NonDefaultMethod();

        // Compile-time error:
        // CS8701 Target runtime doesn't support default interface implementation.

        //void DefaultMethod()
        //{
        //    Console.WriteLine("Default implementation");
        //}
    }
}
