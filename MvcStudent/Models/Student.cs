using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStudent.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Display(Name = "Student Address")]
        public string StudentAddress { get; set; }
        [Display(Name = "Student City")]
        public string StudentCity { get; set; }
        [Display(Name = "Student Zip")]
        public string StudentZip { get; set; }
        [Display(Name = "StudentState")]
        public string StudentState { get; set; }
    }
}
