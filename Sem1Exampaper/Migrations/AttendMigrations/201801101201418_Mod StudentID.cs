namespace Sem1Exampaper.Migrations.AttendMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModStudentID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendance", "StudentID", "dbo.Student");
            DropForeignKey("dbo.StudentSubject", "StudentID", "dbo.Student");
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "StudentID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Student", "StudentID");
            AddForeignKey("dbo.Attendance", "StudentID", "dbo.Student", "StudentID");
            AddForeignKey("dbo.StudentSubject", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSubject", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Attendance", "StudentID", "dbo.Student");
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "StudentID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Student", "StudentID");
            AddForeignKey("dbo.StudentSubject", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.Attendance", "StudentID", "dbo.Student", "StudentID");
        }
    }
}
