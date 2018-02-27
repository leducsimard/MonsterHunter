namespace monsterhunterAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sharpnesses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        RedSharpness = c.Int(nullable: false),
                        orangeSharpness = c.Int(nullable: false),
                        YellowSharpness = c.Int(nullable: false),
                        GreenSharpness = c.Int(nullable: false),
                        BlueSharpness = c.Int(nullable: false),
                        WhiteSharpness = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Weapons", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sharpnesses", "Id", "dbo.Weapons");
            DropIndex("dbo.Sharpnesses", new[] { "Id" });
            DropTable("dbo.Sharpnesses");
        }
    }
}
