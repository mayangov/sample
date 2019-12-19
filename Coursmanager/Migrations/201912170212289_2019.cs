namespace Coursmanager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2019 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActionLink",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10, fixedLength: true),
                        Controller = c.String(maxLength: 10, fixedLength: true),
                        Action = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseManagement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassId = c.Int(),
                        TeacherId = c.Int(),
                        CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sidebar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10, fixedLength: true),
                        Controller = c.String(maxLength: 32, fixedLength: true),
                        Action = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10, fixedLength: true),
                        ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10, fixedLength: true),
                        TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Account = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Teacher");
            DropTable("dbo.Student");
            DropTable("dbo.Sidebar");
            DropTable("dbo.CourseManagement");
            DropTable("dbo.Course");
            DropTable("dbo.Classes");
            DropTable("dbo.ActionLink");
        }
    }
}
