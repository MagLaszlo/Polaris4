namespace Polaris4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSzEtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SzEs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SzENev = c.String(nullable: false, maxLength: 100),
                        SzEKod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SzEs");
        }
    }
}
