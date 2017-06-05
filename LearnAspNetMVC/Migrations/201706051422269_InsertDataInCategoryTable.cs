namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataInCategoryTable : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            Sql("Delete from Categories where id in (1,2)");
        }
    }
}
