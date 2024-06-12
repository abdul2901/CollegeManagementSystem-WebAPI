using System.ComponentModel.DataAnnotations;

namespace college1.Models
{
    public class Course
    {
        public string courseName {  get; set; }
        [Key]
        public string courseCode { get; set; }
        public string description { get; set; }
        public string credits { get; set; }
        public string department { get; set; }
    }
}
