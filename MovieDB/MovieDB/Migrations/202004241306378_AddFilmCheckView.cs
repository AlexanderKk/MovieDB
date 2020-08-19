namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmCheckView : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "CheckView", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "CheckView");
        }
    }
}
