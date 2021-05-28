namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDesignation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "Designation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "Designation");
        }
    }
}
//6.1.3
//Enable Migrations
//add-migration
//update-database