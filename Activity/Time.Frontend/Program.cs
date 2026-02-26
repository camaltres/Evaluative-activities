using Time.Backend;

try
{
    var t1 = new OPP();
    var t2 = new OPP(1);
    var t3 = new OPP(21, 34);
    var t4 = new OPP(9, 34, 00);
    var t5 = new OPP(0, 0, 0, 000);

    var times = new List<OPP> { t1, t2, t3, t4, t5 };

    foreach (OPP time in times)
    {
        Console.WriteLine($"\tMilliseconds: {time.ToMilliseconds(),15:N0}");
    }
    
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}

