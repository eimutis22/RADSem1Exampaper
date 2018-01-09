using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sem1Exampaper.Models.AttendModels
{
    [Table("StudentSubject")]
    public class StudentSubject
    {
        [Key, Column(Order = 1)]
        [Display(Name = "Student ID")]
        public string StudentID { get; set; }

        [Key, Column(Order = 2)]
        [Display(Name = "Subject ID")]
        public int SubjectID { get; set; }

        public virtual Student assocStudent { get; set; }
        public virtual Subject assocSubject { get; set; }
    }
}