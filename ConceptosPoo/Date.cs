namespace ConceptosPoo
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("Invalid month");
        }

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int year, int month, int day)
        {
            if(day == 29 && month == 2 && IsLeapYear(year))
            {
                return day;
            }

            int[] DaysPerMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= DaysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Invalid day");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        public override string ToString()
        {
            return $"La fecha es: {_year} / {_month} / {_day} ";
        }
    }
}
