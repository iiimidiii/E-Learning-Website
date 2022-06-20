using System;
using System.Collections.Generic;

namespace Eleaning_Web.Models
{
    public partial class TestSchedule
    {
        public int TestScheduleId { get; set; }
        public DateTime? DayExam { get; set; }
        public DateTime? Time { get; set; }
    }
}
