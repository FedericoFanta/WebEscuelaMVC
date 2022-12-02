namespace WebEscuelaMVCc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aulas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aulas");
        }
    }
}
