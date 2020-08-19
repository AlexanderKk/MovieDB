namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfo1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Rating", c => c.Int(nullable: false));
        }
    }
}
