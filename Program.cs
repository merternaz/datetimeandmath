namespace methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("mm"));
            Console.WriteLine(DateTime.Now.ToString("m"));
            Console.WriteLine(DateTime.Now.ToString("y"));
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("******Math**********");

            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Sin(30));

            Console.WriteLine(Math.Max(10,5));
            Console.WriteLine(Math.Min(10,5));

            Console.WriteLine(Math.Round(11.3));
            Console.WriteLine(Math.Floor(11.3));
            Console.WriteLine(Math.Ceiling(11.3));
            Console.WriteLine(Math.Round(11.6));

            Console.WriteLine(Math.Pow(10,3));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Log(3,5));
        }
    }
}