using System.Runtime.CompilerServices;

namespace DateModifier
{
    public class DateModifier
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public DateModifier(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public double GetDateDifference() => (this.endDate - this.startDate).TotalDays;


    }
}