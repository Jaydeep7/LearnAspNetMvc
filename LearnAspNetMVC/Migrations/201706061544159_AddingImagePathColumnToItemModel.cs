namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingImagePathColumnToItemModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "ImagePath");
            AddColumn("dbo.Items", "ImagePath", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "ImagePath");
        }
    }
}
