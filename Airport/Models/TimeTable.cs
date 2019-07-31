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
        public string FlightTime { get; set; }

        [DataType(DataType.Time)]
        public string MondayTimeTable { get; set; }

        [DataType(DataType.Time)]
        public string TuesdayTimeTable { get; set; } 

        [DataType(DataType.Time)]
        public string WednesdayTimeTable { get; set; }

        [DataType(DataType.Time)]
        public string ThursdayTimeTable { get; set; }

        [DataType(DataType.Time)]
        public string FridayTimeTable { get; set; }

        [DataType(DataType.Time)]
        public string SaturdayTimeTable { get; set; }

        [DataType(DataType.Time)]
        public string SundayTimeTable { get; set; }
    }
}
