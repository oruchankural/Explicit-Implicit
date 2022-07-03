using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit
{
    public struct ExplicityDay
    {
        public  int Day;

        public ExplicityDay(int day)
        {
            if (day > 6)
                day = 6;

            Day = day;
            DayOfWeek = (DayOfWeek)day;
        }

        public DayOfWeek DayOfWeek { get;}

        public bool IsWeekDay => Day >= 1 && Day <= 5;

        public bool IsWeekendDay => Day == 0 || Day == 6;

        //public static implicit operator int(ExplicityDay day) => day.Day;

        //public static implicit operator ExplicityDay(int day) => new ExplicityDay(day);


        public static explicit operator int(ExplicityDay day) => day.Day; // if there is a conscious transformation

        public static explicit operator ExplicityDay(int day) => new ExplicityDay(day); // if there is a conscious transformation

    }
}
