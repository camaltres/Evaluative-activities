using Time.Backend;

try
{
    var t1 = new OPP();
    var t2 = new OPP(14);
    var t3 = new OPP(9, 34);
    var t4 = new OPP(19, 45, 56);
    var t5 = new OPP(25, 3, 45, 678);

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

