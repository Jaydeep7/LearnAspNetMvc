namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsSelectedColumnToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "isSelected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "isSelected");
        }
    }
}
