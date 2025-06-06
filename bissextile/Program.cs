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
           
            if (annee % 400 == 0) return true;
            if (annee % 100 == 0) return false;

            return false; 
            
        }

    }
}

