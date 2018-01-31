namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ali5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Empty", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "Empty");
        }
    }
}
