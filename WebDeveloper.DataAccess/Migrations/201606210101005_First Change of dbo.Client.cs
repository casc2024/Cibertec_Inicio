namespace WebDeveloper.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstChangeofdboClient : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Client", "Apellidos", "LastName"); //va hacer lo mismo que
            //up y down solo que no borra la data
            //AddColumn("dbo.Client", "LastName", c => c.String(nullable: false));
            //DropColumn("dbo.Client", "Apellidos");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Client", "LastName", "Apellidos");
            //AddColumn("dbo.Client", "Apellidos", c => c.String(nullable: false));
            //DropColumn("dbo.Client", "LastName");
        }
    }
}
