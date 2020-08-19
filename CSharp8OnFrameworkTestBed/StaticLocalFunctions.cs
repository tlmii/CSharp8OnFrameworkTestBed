namespace CSharp8OnFrameworkTestBed
{
    public class StaticLocalFunctions
    {
        public static int M()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);

            static int Add(int left, int right) => left + right;
        }
    }
}
