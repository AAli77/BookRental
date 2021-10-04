namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublisherFromBookModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Publisher", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Publisher", c => c.Int(nullable: false));
        }
    }
}
