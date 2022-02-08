using System;
using Day = System.DayOfWeek;
namespace DayWeekColl;
class DayOfWeekCollection 
{
    Day[] days={
        Day.Sunday,
        Day.Monday,
        Day.Tuesday,
        Day.Wednesday,
        Day.Thursday,
        Day.Friday,
        Day.Saturday
    };
    public int this[Day day] => FindDayIndex(day);
    private int FindDayIndex(Day day) {
        for (int j = 0; j < days.Length; j++) {
            if (days[j] == day) {
                return j;
            }
        }
        throw new ArgumentOutOfRangeException(nameof(day), $"Day {day} is not supported.\nDay input must be a defined System.DayOfWeek value.");
    }
}