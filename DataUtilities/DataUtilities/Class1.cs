namespace DataUtilities
{
    public class Convertor
    {
        public static float BytesToKb(long? bytes)
        {
            return (float)bytes / 1000;
        }
    }
}
