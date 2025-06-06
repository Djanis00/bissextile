namespace bissextile
{
    public class Program
    {
        public static void Main()
        {
           
        }
    }
}


namespace bissextile
{
    public static class DateUtils
    {
        public static bool IsBissextile(int annee)
        {
            return annee % 400 == 0;
        }
    }
}
