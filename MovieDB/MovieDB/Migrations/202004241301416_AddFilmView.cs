namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmView : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "view", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "view");
        }
    }
}
