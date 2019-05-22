using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class TimeTable
    {
        public TimeTable()
        {
        }

        [Key]
        public Guid TimeTableID { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime FlightTime { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}:\d{2}$")]
        public string MondayTimeTable { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}:\d{2}$")]
        public string TuesdayTimeTable { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}:\d{2}$")]
        public string WednesdayTimeTable { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}:\d{2}$")]
        public string ThursdayTimeTable { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}:\d{2}$")]
        public string FridayTimeTable { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}:\d{2}$")]
        public string SaturdayTimeTable { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}:\d{2}$")]
        public string SundayTimeTable { get; set; }
    }
}
