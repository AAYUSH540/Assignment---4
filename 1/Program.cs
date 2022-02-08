using System;
class TimePeriod {
    private double _seconds;
    public double Hours {
        get {
            return _seconds / 3600;
        }
        set {
            if (value < 0 || value > 24) throw new ArgumentOutOfRangeException($"{nameof(value)} MUST BE BETWEEN 0 & 24.");
            _seconds = value * 3600;
        }
    }
}
class Program {
    static void Main() {
        Console.WriteLine("PROPERTIES WITH BACKING FIELDS");
        TimePeriod t = new TimePeriod();
        t.Hours = 24;
        Console.WriteLine($"TIME IN HOURS : {t.Hours}");
    }
}