namespace MovieDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInfo2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "CheckView");
            DropColumn("dbo.Films", "NumberOfStars");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "NumberOfStars", c => c.Int());
            AddColumn("dbo.Films", "CheckView", c => c.Boolean());
        }
    }
}
