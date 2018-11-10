using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int LunarDay { get; set; }

        public Message DateMessage{ get; private set;}

        public Date()
        {
            Year = 0;
            Month = 0;
            Day = 0;
            LunarDay = 0;
            DateMessage = new Message();
        }

        private void CalculateLunarDay()                //计算出农历
        {
            LunarDay = 0;
        }


    }
}
