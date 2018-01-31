namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ali : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomNum = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Price = c.String(),
                        Checkin = c.DateTime(nullable: false),
                        Checkout = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserName = c.String(),
                        Name = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        PhoneNum = c.String(),
                        Address = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        EditeDate = c.DateTime(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ID", "dbo.Rooms");
            DropIndex("dbo.Users", new[] { "ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Rooms");
        }
    }
}
