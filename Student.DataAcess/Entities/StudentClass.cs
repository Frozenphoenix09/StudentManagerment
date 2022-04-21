using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student.DataAcess.Entities
{
    public class StudentClass
    {
        [Key]
        public int StudentClassId { get; set; }
        public int StudentId  { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
