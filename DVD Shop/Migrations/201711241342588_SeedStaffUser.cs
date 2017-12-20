namespace DVD_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStaffUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'b24ce9d5-8a9d-46b8-80f1-df43e733fca0', N'staff@dvdshop.com', 0, N'AN+Pm3Przc6loWg+wVuy0gEccXGaGeITl7n8xARVRVDVXHq1ZlyV/48hScNvQk1OGw==', N'23fd4e3d-d489-4495-abe3-db3e5e759764', NULL, 0, 0, NULL, 1, 0, N'staff@dvdshop.com', N'123456', N'123456')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2f2c81ff-e584-4f83-842d-ee185db4bebb', N'CanManageCustomers')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b24ce9d5-8a9d-46b8-80f1-df43e733fca0', N'2f2c81ff-e584-4f83-842d-ee185db4bebb')
");
        }
        
        public override void Down()
        {
        }
    }
}
