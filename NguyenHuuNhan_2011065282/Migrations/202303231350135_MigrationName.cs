namespace NguyenHuuNhan_2011065282.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "Lecturer_Id", newName: "LecturerId");
            RenameIndex(table: "dbo.Courses", name: "IX_Lecturer_Id", newName: "IX_LecturerId");
            AddColumn("dbo.Courses", "Place", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Courses", "Pleace");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Pleace", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Courses", "Place");
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerId", newName: "IX_Lecturer_Id");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "Lecturer_Id");
        }
    }
}
