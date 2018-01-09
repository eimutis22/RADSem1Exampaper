using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sem1Exampaper.Models.AttendModels
{
    [Table("Attendance")]
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceID { get; set; }

        [Column(TypeName = "date")]
        public DateTime AttendanceDate { get; set; }

        [Display(Name = "Subject ID")]
        public int SubjectID { get; set; }

        [Display(Name = "StudentID")]
        public string StudentID { get; set; }

        [Display(Name = "Present")]
        public bool Present { get; set; }

        public virtual Student assocStudent { get; set; }
        public virtual Subject assocSubject { get; set; }
    }
}