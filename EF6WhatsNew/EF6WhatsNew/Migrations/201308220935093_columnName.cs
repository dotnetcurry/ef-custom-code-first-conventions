namespace EF6WhatsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Posts", name: "PkPostId", newName: "PK_POST_ID");
            AlterColumn("dbo.Posts", "TITLE", c => c.String(maxLength: 200));
            AlterColumn("dbo.Posts", "CONTENT", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Content", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String(maxLength: 200));
            RenameColumn(table: "dbo.Posts", name: "PK_POST_ID", newName: "PkPostId");
        }
    }
}
