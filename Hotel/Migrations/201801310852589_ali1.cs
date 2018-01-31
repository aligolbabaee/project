namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ali1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "Checkin", c => c.String());
            AlterColumn("dbo.Rooms", "Checkout", c => c.String());
            AlterColumn("dbo.Users", "RegisterDate", c => c.String());
            AlterColumn("dbo.Users", "EditeDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "EditeDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "RegisterDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rooms", "Checkout", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rooms", "Checkin", c => c.DateTime(nullable: false));
        }
    }
}
