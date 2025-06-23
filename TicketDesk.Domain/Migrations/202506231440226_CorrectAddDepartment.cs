namespace TicketDesk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectAddDepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Department", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Tickets", "Departmet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Departmet", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Tickets", "Department");
        }
    }
}
