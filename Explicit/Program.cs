using Explicit;
using System;

int dayNumber = 12;


ExplicityDay newDay = new ExplicityDay(dayNumber);

//int day = (int)newDay; // will be set day as int
ExplicityDay asDay = (ExplicityDay)dayNumber; // will be set day as string

Console.WriteLine(newDay.DayOfWeek);
 