using System.ComponentModel.DataAnnotations;

namespace college1.Models
{
    public class ClassSchedule
    {
        [Key] 
        public int id { get; set; }
        public string  course { get; set; }
        public string faculty { get; set; }
        public string dayOfWeek { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string classroom { get; set; }
    }
}
