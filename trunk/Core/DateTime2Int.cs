﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWealth
{
    public static class DateTime2Int
    {
        private readonly static DateTime dt1970 = new DateTime(1970, 1, 1);

        public static DateTime DateTime(int i)
        {
            return dt1970 + new TimeSpan(TimeSpan.TicksPerSecond * i);
        }

        public static int Int(DateTime dt)
        {
            double result = ((TimeSpan)(dt - dt1970)).TotalSeconds;
            if (result <= 0)
                return 0;
            if (result >= int.MaxValue)
                return int.MaxValue;
            return (int)((TimeSpan)(dt - dt1970)).TotalSeconds;
        }

    }
}
