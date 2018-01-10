namespace Sem1Exampaper.Migrations.AttendMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        AttendanceID = c.Int(nullable: false, identity: true),
                        AttendanceDate = c.DateTime(nullable: false, storeType: "date"),
                        SubjectID = c.Int(nullable: false),
                        StudentID = c.String(maxLength: 128),
                        Present = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceID)
                .ForeignKey("dbo.Student", t => t.StudentID)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.StudentSubject",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        SubjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.SubjectID })
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectID);
            
            CreateTable(
                "dbo.LecturerSubject",
                c => new
                    {
                        SubjectID = c.Int(nullable: false),
                        LecturerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SubjectID, t.LecturerID })
                .ForeignKey("dbo.Lecturer", t => t.LecturerID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID)
                .Index(t => t.LecturerID);
            
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        LecturerID = c.Int(nullable: false, identity: true),
                        LecturerName = c.String(),
                    })
                .PrimaryKey(t => t.LecturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendance", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.StudentSubject", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.LecturerSubject", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.LecturerSubject", "LecturerID", "dbo.Lecturer");
            DropForeignKey("dbo.StudentSubject", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Attendance", "StudentID", "dbo.Student");
            DropIndex("dbo.LecturerSubject", new[] { "LecturerID" });
            DropIndex("dbo.LecturerSubject", new[] { "SubjectID" });
            DropIndex("dbo.StudentSubject", new[] { "SubjectID" });
            DropIndex("dbo.StudentSubject", new[] { "StudentID" });
            DropIndex("dbo.Attendance", new[] { "StudentID" });
            DropIndex("dbo.Attendance", new[] { "SubjectID" });
            DropTable("dbo.Lecturer");
            DropTable("dbo.LecturerSubject");
            DropTable("dbo.Subject");
            DropTable("dbo.StudentSubject");
            DropTable("dbo.Student");
            DropTable("dbo.Attendance");
        }
    }
}
