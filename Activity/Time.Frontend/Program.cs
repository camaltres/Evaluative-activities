using Time.Backend;

try
{
    var t1 = new OPP();
    var t2 = new OPP(14);
    var t3 = new OPP(9, 34);
    var t4 = new OPP(19, 45, 56);
    var t5 = new OPP(23, 3, 45, 678);

    var times = new List<OPP> { t1, t2, t3, t4, t5 };

    foreach (OPP time in times)
    {
        Console.WriteLine($"Time: {time}");
        Console.WriteLine($"\tMilliseconds: {time.ToMilliseconds(),15:N0}");
        Console.WriteLine($"\tSeconds     : {time.ToSeconds(),15:N0}");
        Console.WriteLine($"\tMinutes     : {time.ToMinutes(),15:N0}");
        Console.WriteLine($"\tIs Other day: {time.IsOtherDay(t1)}");
        Console.WriteLine($"\tIs Other day: {time.IsOtherDay(t4)}");
        
    }

    var t6 = new OPP(45, -7, 90, -87);

}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}


