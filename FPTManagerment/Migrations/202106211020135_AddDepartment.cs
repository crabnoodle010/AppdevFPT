namespace FPTManagerment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TraineeIfs", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.TraineeIfs", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.TraineeIfs", "DepartmentId");
            AddForeignKey("dbo.TraineeIfs", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TraineeIfs", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.TraineeIfs", new[] { "DepartmentId" });
            DropColumn("dbo.TraineeIfs", "DepartmentId");
            DropColumn("dbo.TraineeIfs", "Age");
            DropTable("dbo.Departments");
        }
    }
}
