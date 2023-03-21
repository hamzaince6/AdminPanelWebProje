namespace AdminPanelWebProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);

            CreateTable(
                    "dbo.Name",
                    c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);




            CreateTable(
                "dbo.Anasayfas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        profile = c.String(),
                        job = c.String(),
                        text = c.String(),
                        socialtext = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.socialicons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        icon = c.String(),
                        link = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.socialicons");
            DropTable("dbo.Anasayfas");
            DropTable("dbo.Admins");
        }
    }
}
