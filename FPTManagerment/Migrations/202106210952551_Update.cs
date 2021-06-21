namespace FPTManagerment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "Category_Id", newName: "CategoryId");
            RenameIndex(table: "dbo.Courses", name: "IX_Category_Id", newName: "IX_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_CategoryId", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Courses", name: "CategoryId", newName: "Category_Id");
        }
    }
}
