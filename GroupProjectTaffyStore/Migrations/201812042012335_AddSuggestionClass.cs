namespace GroupProjectTaffyStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuggestionClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suggestions",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
            DropTable("dbo.Suggestions");
        }
    }
}
