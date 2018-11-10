using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class CalcDate
    {
        private static int[] daysInLeapYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static int[] daysInCommonYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static int CalcWeek(int year,int month,int day)
        {
            int c = year / 10 / 10;
            int y = year % 100;
            int m = month;
            if(month==1||month==2)
            {
                y--;
                m += 12;
            }
            int d = day;
            /*
             * 公式中的符号含义如下，w：星期；c：世纪-1；y：年（两位数）；
             * m：月（m大于等于3，小于等于14，即在蔡勒公式中，某年的1、2月
             * 要看作上一年的13、14月来计算，比如2003年1月1日要看作2002年
             * 的13月1日来计算）；d：日；[ ]代表取整，即只要整数部分。
             * (C是世纪数减一，y是年份后两位，M是月份，d是日数。1月和2月要
             * 按上一年的13月和 14月来算，这时C和y均按上一年取值。) 
             */
             return ((y+y/4+c/4-2*c + 26*(m + 1) / 10 + d - 1)%7);
        }
    }
}
