using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAcess.Entities
{
    public  class Student
    {
        [Key]
        public int  StudentId { get; set; }
        public string  Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
