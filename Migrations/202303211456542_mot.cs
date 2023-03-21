namespace PotholeDetectorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mot : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Potholes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        Location = c.String(),
                        Img = c.Binary(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Potholes");
        }
    }
}
