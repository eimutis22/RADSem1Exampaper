using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sem1Exampaper.Models.AttendModels
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectID { get; set; }

        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        public virtual ICollection<StudentSubject> studentSubjects { get; set; }
        public virtual ICollection<LecturerSubject> lecturerSubjects { get; set; }
    }
}