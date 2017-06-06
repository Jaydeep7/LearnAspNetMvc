namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagePathColumnToItemTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ImagePath", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items","ImagePath");
        }
    }
}
