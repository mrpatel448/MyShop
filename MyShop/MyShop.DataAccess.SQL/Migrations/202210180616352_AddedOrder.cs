namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Surname", c => c.String());
            DropColumn("dbo.Orders", "Surnamee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Surnamee", c => c.String());
            DropColumn("dbo.Orders", "Surname");
        }
    }
}
