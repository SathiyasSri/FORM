namespace FORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        _Name = c.String(maxLength: 30, unicode: false),
                        _FatherName = c.String(maxLength: 30, unicode: false),
                        _MotherName = c.String(maxLength: 30, unicode: false),
                        _Gender = c.String(maxLength:10,unicode: false),
                        _dob = c.String(maxLength: 10, unicode: false),
                        _Email = c.String(maxLength: 50, unicode: false),
                        _Department = c.String(maxLength: 30, unicode: false),
                        _MobileNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t._id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
