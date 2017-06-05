namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.Categories ( Name ) values ( 'Shoes')");
            Sql("insert into dbo.Categories ( Name ) values ( 'Watches')");
        }
        
        public override void Down()
        {
            Sql("Delete From dbo.Categories Where Id in (1,2)");
        }
    }
}
