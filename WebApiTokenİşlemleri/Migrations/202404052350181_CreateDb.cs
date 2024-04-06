namespace WebApiTokenİşlemleri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KitapAd = c.String(),
                        YazarAd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kitaps");
        }
    }
}
