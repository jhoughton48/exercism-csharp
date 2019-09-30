using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // declare output variable
        bool isLeapYear;

        // declare and set booleans to indicate whether the year divides by 4, 100 and 400
        bool divBy4 = year % 4 == 0 ? true : false;
        bool divBy100 = year % 100 == 0 ? true : false;
        bool divBy400 = year % 400 == 0 ? true : false;

        // set isLeapYear boolean subject to logic
        isLeapYear = ((divBy4 && divBy400) || (divBy4 && !divBy100 && !divBy400)) ? true : false;

        return isLeapYear;
    }
}