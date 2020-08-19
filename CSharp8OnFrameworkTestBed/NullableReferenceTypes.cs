#nullable enable
namespace CSharp8OnFrameworkTestBed
{

    public class NullableReferenceTypes
    {
        public static string ReturnAString(NullableReferenceTypes nrt1, NullableReferenceTypes? nrt2)
        {
            if (nrt2 is null)
            {
                // CS8603  Possible null reference return
                //return null;
            }

            return nrt1.ToString();

        }
    }
}
#nullable disable
