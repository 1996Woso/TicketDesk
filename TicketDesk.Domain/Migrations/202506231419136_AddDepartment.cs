namespace TicketDesk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Departmet", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Departmet");
        }
    }
}
