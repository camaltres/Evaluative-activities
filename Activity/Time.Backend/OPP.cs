using System.Numerics;

namespace Time.Backend;

public class OPP
{
    //Atributes
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;


    //Constructors
    public OPP()
    {
        _hour = 0;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
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
    //Properties
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

    //Methods
    public override string ToString()
    {
        int format;
        format = Hour;
        string change = "AM";
        if (format <= 23 && format >= 12)
        {
            format = Hour % 12;
            change = "PM";
        }
        return $"{format:D2}:{Minute:D2}:{Second:D2}:{Millisecond:D3}"+" "+change;
    }

 
    private int ValidHours(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException(nameof(hour), $"La hora: {hour}, debe estar entre 0 y 23.");
        }
        return hour;
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

    public int ToMilliseconds()
    {
        int addition;
        addition = Hour * 3600000 + Minute * 60000 + Second * 1000 + Millisecond;
        return addition;
    }

    public int ToSeconds()
    {
        int addition;
        addition = Hour * 3600 + Minute * 60 + Second;
        return addition;

    }

    public int ToMinutes()
    {
        int addition;
        addition = Hour * 60 + Minute;
        return addition;
    }

    public bool IsOtherDay(OPP day)
    {
        this.ToMilliseconds();
        day.ToMilliseconds();

        int time1 = 86400000;
        if (this.ToMilliseconds() + day.ToMilliseconds() >= time1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int Add(OPP time)
    {
        
    }

}
