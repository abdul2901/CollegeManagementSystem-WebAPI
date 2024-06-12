using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace college1.Models
{
    public class student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studId { get; set; }
        public string Coursecode {  get; set; }

        public string faculty    { get; set; }

        public string starttime { get; set; }
        public string endtime { get; set; }
    }
}

