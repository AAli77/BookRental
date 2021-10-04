namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeActualStartDatetoActualEndDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookRents", "ActualEndDate", c => c.DateTime());
            DropColumn("dbo.BookRents", "ActualStartDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookRents", "ActualStartDate", c => c.DateTime());
            DropColumn("dbo.BookRents", "ActualEndDate");
        }
    }
}
