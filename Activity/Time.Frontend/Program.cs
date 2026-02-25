using Time.Backend;

try
{
    var t1 = new OPP();
    var t2 = new OPP(1);
    var t3 = new OPP(21, 34);
    var t4 = new OPP(22, 45, 56);
    var t5 = new OPP(0, 3, 45, 678);

    Console.WriteLine(t1);
    Console.WriteLine(t2);
    Console.WriteLine(t3);
    Console.WriteLine(t4);
    Console.WriteLine(t5);

}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}

