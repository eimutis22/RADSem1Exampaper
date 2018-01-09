using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sem1Exampaper.Models.AttendModels
{
    public class AttendDbContext : DbContext
    {
        public AttendDbContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<LecturerSubject> LecturerSubjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}