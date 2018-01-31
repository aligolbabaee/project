namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ali2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rooms", "Checkin");
            DropColumn("dbo.Rooms", "Checkout");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "Checkout", c => c.String());
            AddColumn("dbo.Rooms", "Checkin", c => c.String());
        }
    }
}
