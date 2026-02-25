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
        Hour = hour;
    }

    public OPP(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public OPP(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public OPP(int hour, int minute, int second, int millisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
    }
    public int Hour 
    {
        get => _hour;
        set => _hour = ValidHours(value);

    }

    public int Millisecond 
    {
        get => _millisecond;
        set => _millisecond = ValidMilliseconds(value);
    }

    public int Minute
    { 
        get => _minute;
        set => _minute = ValidMinute(value);
    }

    public int Second
    { 
        get => _second;
        set => _second = ValidSecond(value);
    }


    public override string ToString()
    {
        return $"{Hour:D2}:{Minute:D2}:{Second:D2}:{Millisecond:D}";
    }

    private int ValidHours(int hour)
    {

        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException(nameof(hour), "Error: Las horas deben estar entre 0 y 23.");
        }
        return hour - 12;
    }

    private int ValidMilliseconds(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new ArgumentOutOfRangeException(nameof(millisecond), "Error: Los milisegundos deben estar entre 0 y 999.");
        }
        return millisecond;
    }

    private int ValidMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        { 
            throw new ArgumentOutOfRangeException(nameof(minute), "Error: Los minutos deben estar entre 0 y 59.");
        }
        return minute;
    }

    private int ValidSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(second), "Error: Los segundos deben estar entre 0 y 59.");
        }
        return second;
    }

}
