internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dob = new DateTime(1974, 7, 10, 7, 10, 24);
        Console.WriteLine("Day:{0}", dob.Day);
        Console.WriteLine("Month:{0}", dob.Month);
        Console.WriteLine("Year:{0}", dob.Year);
        Console.WriteLine("Hour:{0}", dob.Hour);
        Console.WriteLine("Minute:{0}", dob.Minute);
        Console.WriteLine("Second:{0}", dob.Second);
        Console.WriteLine("Millisecond:{0}", dob.Millisecond);
        Console.WriteLine("Day of Week:{0}", dob.DayOfWeek);
        Console.WriteLine("Day of Year: {0}", dob.DayOfYear);
        Console.WriteLine("Time of Day:{0}", dob.TimeOfDay);
        Console.WriteLine("Tick:{0}", dob.Ticks);
        Console.WriteLine("Kind:{0}", dob.Kind);

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);
        Console.WriteLine(DateTime.Now.TimeOfDay);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());
        Console.WriteLine(DateTime.Now.ToLocalTime());
        Console.WriteLine(DateTime.Now.ToUniversalTime());
        Console.WriteLine(DateTime.Now.ToOADate());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddMonths(4));

        //Datetime format
        Console.WriteLine(DateTime.Now.ToString("dd"));//11
        Console.WriteLine(DateTime.Now.ToString("ddd"));//Cum
        Console.WriteLine(DateTime.Now.ToString("dddd"));//Cuma

        Console.WriteLine(DateTime.Now.ToString("MM"));//11
        Console.WriteLine(DateTime.Now.ToString("MMM"));//Kas
        Console.WriteLine(DateTime.Now.ToString("MMMM"));//Kasım

        Console.WriteLine(DateTime.Now.ToString("yy"));//22
        Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022

        //Math Kütüphanesi
        Console.WriteLine(Math.Abs(-21));
        Console.WriteLine(Math.Sqrt(4));
        Console.WriteLine(Math.Sin(180));
        Console.WriteLine(Math.Tan(90));
        Console.WriteLine(Math.Ceiling(23.3));//24
        Console.WriteLine(Math.Round(23.7));//24
        Console.WriteLine(Math.Floor(23.7));//23

        Console.WriteLine(Math.Min(6,3));
        Console.WriteLine(Math.Max(6,3));

        Console.WriteLine(Math.Sqrt(16));//karekök
        Console.WriteLine(Math.Pow(3,4));//3^4
        Console.WriteLine(Math.Log(9));//9'un e tabanındaki log. karşılığı
        Console.WriteLine(Math.Exp(3));//e üzeri 3'ü verir
        Console.WriteLine(Math.Log10(10));//log10(10)
        


    }
}