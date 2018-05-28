namespace EFMain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveComment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MyEntity", "Comment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyEntity", "Comment", c => c.String());
        }
    }
}
