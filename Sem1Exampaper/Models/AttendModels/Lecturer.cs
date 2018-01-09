using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sem1Exampaper.Models.AttendModels
{
    [Table("Lecturer")]
    public class Lecturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LecturerID { get; set; }

        [Display(Name = "Lecturer Name")]
        public string LecturerName { get; set; }

        //public virtual LecturerSubject assocLecturerSubject { get; set; }
        public virtual ICollection<LecturerSubject> lecturerSubjects { get; set; }
    }
}