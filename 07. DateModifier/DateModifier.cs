using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        private string startDate;
        private string endDate;

        public DateModifier(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int CalculateDatesDifference(string startDate, string endDate)
        {
            TimeSpan timespan = DateTime.Parse(startDate) - DateTime.Parse(endDate);

            return Math.Abs(timespan.Days);
        }
    }
}