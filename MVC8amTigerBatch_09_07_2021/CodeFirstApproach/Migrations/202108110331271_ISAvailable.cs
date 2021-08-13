namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ISAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LibraryModels", "isAvailabel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LibraryModels", "isAvailabel");
        }
    }
}
