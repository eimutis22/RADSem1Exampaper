namespace Sem1Exampaper.Migrations.AttendMigrations
{
    using Sem1Exampaper.Models.AttendModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sem1Exampaper.Models.AttendModels.AttendDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\AttendMigrations";
        }

        protected override void Seed(Sem1Exampaper.Models.AttendModels.AttendDbContext c)
        {
            //SeedSubjects(c);
            //SeedStudents(c);
            //SeedStudentSubjects(c);
            //SeedLecturers(c);
            //SeedAttendances(c);
        }



        private void SeedAttendances(AttendDbContext c)
        {
            c.Attendances.AddOrUpdate(a => a.AttendanceID,
                new Attendance { StudentID = "S001", SubjectID = 1, Present = true, AttendanceDate = DateTime.Now},
                new Attendance { StudentID = "S001", SubjectID = 2, Present = false, AttendanceDate = DateTime.Now},
                new Attendance { StudentID = "S002", SubjectID = 1, Present = true, AttendanceDate = DateTime.Now},
                new Attendance { StudentID = "S002", SubjectID = 2, Present = true, AttendanceDate = DateTime.Now}
            );
        }

        private void SeedLecturers(AttendDbContext c)
        {
            c.Lecturers.AddOrUpdate( l => l.LecturerID,
                new Lecturer { LecturerName = "Patrick" },
                new Lecturer { LecturerName = "Jimmy" }
            );

            c.LecturerSubjects.AddOrUpdate(
                new LecturerSubject { LecturerID = 1, SubjectID = 1 },
                new LecturerSubject { LecturerID = 2, SubjectID = 2 }
            );
        }

        private void SeedStudentSubjects(AttendDbContext c)
        {
            c.StudentSubjects.AddOrUpdate(
                new StudentSubject { StudentID = "S001", SubjectID = 1 },
                new StudentSubject { StudentID = "S001", SubjectID = 2 },             
                new StudentSubject { StudentID = "S002", SubjectID = 1 },
                new StudentSubject { StudentID = "S002", SubjectID = 2 }
            );
        }

        private void SeedStudents(AttendDbContext c)
        {
            c.Students.AddOrUpdate(s => s.StudentID,
                new Student { StudentID = "S001", FirstName = "John", LastName = "Smith" },
                new Student { StudentID = "S002", FirstName = "Mary", LastName = "Bloggs" }
            );
        }

        private void SeedSubjects(AttendDbContext c)
        {
            c.Subjects.AddOrUpdate(
                p => p.SubjectID,
                new Subject { SubjectName = "Software Development" },
                new Subject { SubjectName = "Maths" },
                new Subject { SubjectName = "Databases" }
            );
        }
    }
}
