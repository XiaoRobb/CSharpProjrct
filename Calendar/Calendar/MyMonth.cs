using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class MyMonth
    {
        private static readonly int[] daysInLeapYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] daysInCommonYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int Year { get; set; }         //年份
        public int Month { get; set; }        //月份
        public int Days { get; set; }         //次月包含的天数

        public MyMonth(int year,int month)
        {
            Year = year;
            Month = month;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Days = daysInLeapYear[month - 1];
            else
                Days = daysInCommonYear[month - 1];
        }
    }
}
