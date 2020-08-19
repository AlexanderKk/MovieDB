namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInfo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Image", c => c.Binary());
        }
    }
}
