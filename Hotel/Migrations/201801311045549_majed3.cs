namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class majed3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reserves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Checkin = c.String(),
                        Checkout = c.String(),
                        Room_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.Room_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Room_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserves", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Reserves", "Room_ID", "dbo.Rooms");
            DropIndex("dbo.Reserves", new[] { "User_ID" });
            DropIndex("dbo.Reserves", new[] { "Room_ID" });
            DropTable("dbo.Reserves");
        }
    }
}
