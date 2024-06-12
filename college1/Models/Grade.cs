using System.ComponentModel.DataAnnotations;

namespace college1.Models
{
    public class Grade
    {
        [Key]
       public string id {  get; set; }         
    public string student {  get; set; }
        public string coursecode { get; set; }
        public string  gradevalue { get; set; }
    }
}
