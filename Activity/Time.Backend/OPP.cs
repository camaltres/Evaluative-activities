namespace Time.Backend;

public class OPP
{

    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;



    public OPP()
    {
        _hour = 23;
        _minute = 59;
        _second = 59;
        _millisecond = 999;
    }

    public OPP(int hour)
    {
        _hour = hour;
    }

    public OPP(int hour, int minute)
    {
        _hour = hour;
        _minute = minute;
    }

    public OPP(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
    }

    public OPP(int hour, int minute, int second, int millisecond)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
    }
    public int Hour 
    {
        get => _hour;
        set => _hour = value;

    }

    public int Millisecond 
    {
        get => _millisecond;
        set => _millisecond = value;
    }

    public int Minute
    { 
        get => _minute;
        set => _minute = value;
    }

    public int Second
    { 
        get => _second;
        set => _second = value;
    }
















}
