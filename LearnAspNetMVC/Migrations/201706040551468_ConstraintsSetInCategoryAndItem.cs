namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConstraintsSetInCategoryAndItem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Name", c => c.String(maxLength: 200));
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
        }
    }
}
