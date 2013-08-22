namespace EF6WhatsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpperCaseColumnNames : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Posts", name: "PK_POST_ID", newName: "POST_PK_POST_ID");
            RenameColumn(table: "dbo.Posts", name: "TITLE", newName: "POST_TITLE");
            RenameColumn(table: "dbo.Posts", name: "CONTENT", newName: "POST_CONTENT");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Posts", name: "POST_CONTENT", newName: "CONTENT");
            RenameColumn(table: "dbo.Posts", name: "POST_TITLE", newName: "TITLE");
            RenameColumn(table: "dbo.Posts", name: "POST_PK_POST_ID", newName: "PK_POST_ID");
        }
    }
}
