namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ali4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "ID", "dbo.Rooms");
            DropForeignKey("dbo.Reserves", "User_ID", "dbo.Users");
            DropIndex("dbo.Users", new[] { "ID" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "ID");
            AddForeignKey("dbo.Reserves", "User_ID", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserves", "User_ID", "dbo.Users");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Users", "ID");
            CreateIndex("dbo.Users", "ID");
            AddForeignKey("dbo.Reserves", "User_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.Users", "ID", "dbo.Rooms", "ID");
        }
    }
}
