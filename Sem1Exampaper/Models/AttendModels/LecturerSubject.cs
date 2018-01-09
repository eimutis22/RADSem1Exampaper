using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sem1Exampaper.Models.AttendModels
{
    [Table("LecturerSubject")]
    public class LecturerSubject
    {
        [Key, Column(Order = 1)]
        [Display(Name = "SubjectID")]
        [ForeignKey("assocSubject")]
        public int SubjectID { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("assocLecturer")]
        [Display(Name = "LecturerID")]
        public int LecturerID { get; set; }

        public virtual Subject assocSubject { get; set; }
        public virtual Lecturer assocLecturer { get; set; }
    }
}