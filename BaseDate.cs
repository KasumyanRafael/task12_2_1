using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12_2_1
{
    class BaseDate
    {
        protected int day;
        protected int month;
        protected int year;

        public BaseDate(int year,int month,int day)
        {
            this.year = year;
            this.day = day;
            this.month = month;
        }

        public virtual string GetFormat()
        {
            //return $"год:{year}, месяц: {month}, день: {day}";
            return String.Format("год:{0}, месяц: {1}, день: {2}",year,month,day);
        }
    }

    class AmericanDate:BaseDate
    {
        public AmericanDate(int year, int month, int day) : base(year, month, day)
        { }
        public override string GetFormat()
        {
            return $"{month}.{day}.{year}";
        }
    }
}
