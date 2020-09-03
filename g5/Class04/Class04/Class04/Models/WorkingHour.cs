using System;

namespace Class04.Models
{
    public class WorkingHour
    {

        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public WorkingHour()
        {
            
        }

        public WorkingHour(DateTime startAt, DateTime endAt)
        {
            StartAt = startAt;
            EndAt = endAt;
        }
    }
}
