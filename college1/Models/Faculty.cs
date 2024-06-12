using System.ComponentModel.DataAnnotations;

namespace college1.Models
{
    public class Faculty
    {
        [Key]
       public int  id {  get; set; }
  public string  firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public long phoneNumber { get; set; }
        public string department { get; set; }
        public string coursesTaught { get; set; }
        public string courseCode { get; set; }
    }
}
