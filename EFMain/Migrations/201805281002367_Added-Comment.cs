namespace EFMain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyEntity", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyEntity", "Comment");
        }
    }
}
