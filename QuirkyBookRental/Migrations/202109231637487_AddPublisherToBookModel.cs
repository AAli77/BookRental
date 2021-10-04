namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublisherToBookModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Publisher", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Publisher");
        }
    }
}
