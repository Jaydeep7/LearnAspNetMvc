namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropAndAddIdColumnOfCategoryAndSetForeignKey1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "Category_Id");
            DropColumn("Categories", "Id");
            AddColumn("Categories", "Id", c => c.Int(nullable: false, identity: false));
            AddColumn("dbo.Items", "Category_Id", c=> c.Int (nullable:false));
            AddForeignKey("dbo.Items", "Category_Id", "dbo.Categories");
        }
        
        public override void Down()
        {

        }
    }
}
