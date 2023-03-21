namespace AdminPanelWebProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Anasayfas", "Name", c => c.String());
            AddColumn("dbo.Anasayfas", "deneme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Anasayfas", "deneme");
            DropColumn("dbo.Anasayfas", "Name");
        }
    }
}
