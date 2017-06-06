namespace LearnAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReInsertingDataToItemTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.Items ( Name, Description, Price, Stock, Category_Id, ImagePath )" +
                "values ('Shoes For Man','Latest Shoes for Man', 100, 5, 1, '~/Images/Shoes1.jpeg') ");

            Sql("insert into dbo.Items ( Name, Description, Price, Stock, Category_Id, ImagePath )" +
                "values ('Shoes For Man','Latest Shoes for Man', 200, 10, 1, '~/Images/Shoes2.jpeg') ");

            Sql("insert into dbo.Items ( Name, Description, Price, Stock, Category_Id, ImagePath )" +
                "values ('Shoes For Man','Latest Shoes for Man', 300, 15, 1, '~/Images/Shoes3.jpeg') ");

            Sql("insert into dbo.Items ( Name, Description, Price, Stock, Category_Id, ImagePath )" +
                "values ('Watches For Man','Latest Watches for Man', 1000, 50, 2, '~/Images/Watches1.jpeg') ");

            Sql("insert into dbo.Items ( Name, Description, Price, Stock, Category_Id, ImagePath )" +
                "values ('Watches For Man','Latest Watches for Man', 2000, 100, 2, '~/Images/Watches2.jpeg') ");

            Sql("insert into dbo.Items ( Name, Description, Price, Stock, Category_Id, ImagePath )" +
                "values ('Watches For Man','Latest Watches for Man', 3003, 150, 2, '~/Images/Watches3.jpeg') ");
        }

        public override void Down()
        {
            Sql("Truncate table dbo.Items");
        }
    }
}
