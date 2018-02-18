namespace TPW_GM1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        type = c.Boolean(nullable: false),
                        method = c.Int(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        deletedDate = c.DateTime(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        lastModifiedDate = c.DateTime(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        createdBy = c.String(maxLength: 128),
                        modifiedBy = c.String(maxLength: 128),
                        userId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.createdBy)
                .ForeignKey("dbo.AspNetUsers", t => t.modifiedBy)
                .ForeignKey("dbo.AspNetUsers", t => t.userId)
                .Index(t => t.createdBy)
                .Index(t => t.modifiedBy)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IsDeleted = c.Boolean(nullable: false),
                        firstName = c.String(),
                        lastName = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Branchs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        branchName = c.String(),
                        branchLocation = c.String(),
                        branchOpenDate = c.DateTime(nullable: false),
                        branchLandLine = c.String(),
                        branchaOwner = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedDate = c.DateTime(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        lastModifiedDate = c.DateTime(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        branchManager = c.String(maxLength: 128),
                        createdBy = c.String(maxLength: 128),
                        modifiedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.branchManager)
                .ForeignKey("dbo.AspNetUsers", t => t.createdBy)
                .ForeignKey("dbo.AspNetUsers", t => t.modifiedBy)
                .Index(t => t.branchManager)
                .Index(t => t.createdBy)
                .Index(t => t.modifiedBy);
            
            CreateTable(
                "dbo.GymRates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        type = c.String(),
                        price = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedDate = c.DateTime(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        lastModifiedDate = c.DateTime(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        createdBy = c.String(maxLength: 128),
                        modifiedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.createdBy)
                .ForeignKey("dbo.AspNetUsers", t => t.modifiedBy)
                .Index(t => t.createdBy)
                .Index(t => t.modifiedBy);
            
            CreateTable(
                "dbo.MemberCatagories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        memberCatagory = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedDate = c.DateTime(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        lastModifiedDate = c.DateTime(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        createdBy = c.String(maxLength: 128),
                        modifiedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.createdBy)
                .ForeignKey("dbo.AspNetUsers", t => t.modifiedBy)
                .Index(t => t.createdBy)
                .Index(t => t.modifiedBy);
            
            CreateTable(
                "dbo.MemberOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        memberOptionType = c.Int(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        deletedDate = c.DateTime(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        lastModifiedDate = c.DateTime(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        createdBy = c.String(maxLength: 128),
                        modifiedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.createdBy)
                .ForeignKey("dbo.AspNetUsers", t => t.modifiedBy)
                .Index(t => t.createdBy)
                .Index(t => t.modifiedBy);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        paymentDate = c.DateTime(nullable: false),
                        discount = c.Single(nullable: false),
                        discountReason = c.String(),
                        finalPrice = c.Single(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        deletedDate = c.DateTime(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        lastModifiedDate = c.DateTime(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        createdBy = c.String(maxLength: 128),
                        gymRateId_ID = c.Int(),
                        modifiedBy = c.String(maxLength: 128),
                        UserId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.createdBy)
                .ForeignKey("dbo.GymRates", t => t.gymRateId_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.modifiedBy)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId_Id)
                .Index(t => t.createdBy)
                .Index(t => t.gymRateId_ID)
                .Index(t => t.modifiedBy)
                .Index(t => t.UserId_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Payments", "UserId_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Payments", "modifiedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Payments", "gymRateId_ID", "dbo.GymRates");
            DropForeignKey("dbo.Payments", "createdBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.MemberOptions", "modifiedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.MemberOptions", "createdBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.MemberCatagories", "modifiedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.MemberCatagories", "createdBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.GymRates", "modifiedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.GymRates", "createdBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Branches", "modifiedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Branches", "createdBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Branches", "branchManager_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Attendances", "userId_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Attendances", "modifiedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Attendances", "createdBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Payments", new[] { "UserId_Id" });
            DropIndex("dbo.Payments", new[] { "modifiedBy" });
            DropIndex("dbo.Payments", new[] { "gymRateId_ID" });
            DropIndex("dbo.Payments", new[] { "createdBy" });
            DropIndex("dbo.MemberOptions", new[] { "modifiedBy" });
            DropIndex("dbo.MemberOptions", new[] { "createdBy" });
            DropIndex("dbo.MemberCatagories", new[] { "modifiedBy" });
            DropIndex("dbo.MemberCatagories", new[] { "createdBy" });
            DropIndex("dbo.GymRates", new[] { "modifiedBy" });
            DropIndex("dbo.GymRates", new[] { "createdBy" });
            DropIndex("dbo.Branches", new[] { "modifiedBy" });
            DropIndex("dbo.Branches", new[] { "createdBy" });
            DropIndex("dbo.Branches", new[] { "branchManager_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Attendances", new[] { "userId_Id" });
            DropIndex("dbo.Attendances", new[] { "modifiedBy" });
            DropIndex("dbo.Attendances", new[] { "createdBy" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Payments");
            DropTable("dbo.MemberOptions");
            DropTable("dbo.MemberCatagories");
            DropTable("dbo.GymRates");
            DropTable("dbo.Branches");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Attendances");
        }
    }
}
