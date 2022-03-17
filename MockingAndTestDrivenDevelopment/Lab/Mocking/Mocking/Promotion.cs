using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking
{
    public class Promotion
    {
        private DateTime dateToday;

        public Promotion(DateTime today)
        {
            this.dateToday = today;
        }

        public Promotion()
            : this(DateTime.Now)
        {

        }

        public int CalculateDiscount(int price)
        {
            return price - price * Get() / 100;
        }

        public int Get()
        {
            if (dateToday.DayOfWeek == DayOfWeek.Monday)
            {
                return 20;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 10;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 40;
            }

            return 0;
        }
    }
}
