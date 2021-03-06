namespace Polaris4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEszkoztable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eszkozs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GBSzam = c.Int(nullable: false),
                        GyariSzam = c.String(maxLength: 50),
                        EszkozSzam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Eszkozs");
        }
    }
}
