namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "Status");
        }
    }
}
