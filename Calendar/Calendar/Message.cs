using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Message
    {
        public static string[] someThings={"睡觉","运动","乔迁"};
        public string GoodThing { set; get; }
        public string BadThing { set; get; }

        public Message()
        {
            Random random = new Random();
            int t = random.Next(0, someThings.Length);
            GoodThing =someThings[t];
            t = random.Next(0, someThings.Length);
            BadThing = someThings[t];
        }
    }
}
