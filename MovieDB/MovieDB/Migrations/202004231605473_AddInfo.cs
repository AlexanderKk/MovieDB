namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Duration", c => c.Int(nullable: false));
            DropColumn("dbo.Films", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Time", c => c.DateTime());
            DropColumn("dbo.Films", "Duration");
        }
    }
}
