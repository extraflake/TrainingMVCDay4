﻿namespace TrainingMSHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingvalidationmodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
    }
}
