namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblRecipes",
                c => new
                    {
                        RecipeID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        WriteID = c.Int(nullable: false),
                        Writer_WriterID = c.Int(),
                    })
                .PrimaryKey(t => t.RecipeID)
                .ForeignKey("dbo.tblWriters", t => t.Writer_WriterID)
                .Index(t => t.Writer_WriterID);
            
            CreateTable(
                "dbo.tblWriters",
                c => new
                    {
                        WriterID = c.Int(nullable: false, identity: true),
                        WriterName = c.String(),
                    })
                .PrimaryKey(t => t.WriterID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblRecipes", "Writer_WriterID", "dbo.tblWriters");
            DropIndex("dbo.tblRecipes", new[] { "Writer_WriterID" });
            DropTable("dbo.tblWriters");
            DropTable("dbo.tblRecipes");
        }
    }
}
