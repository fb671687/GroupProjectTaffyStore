namespace GroupProjectTaffyStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaffyClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Taffies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Flavor = c.String(),
                        Size = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Taffies");
        }
    }
}
