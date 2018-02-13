namespace UtilitiesCalculator.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        BillType = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Readings",
                c => new
                    {
                        ReadingId = c.Int(nullable: false, identity: true),
                        ReadingName = c.String(),
                        ReadingValue = c.String(),
                        BillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReadingId)
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .Index(t => t.BillId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Readings", "BillId", "dbo.Bills");
            DropIndex("dbo.Readings", new[] { "BillId" });
            DropTable("dbo.Readings");
            DropTable("dbo.Bills");
        }
    }
}
