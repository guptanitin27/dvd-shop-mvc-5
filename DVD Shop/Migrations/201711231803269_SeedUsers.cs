namespace DVD_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'13a980e7-dbd5-4394-b63e-7cd418a4a36c', N'guest@dvdshop.com', 0, N'AAd4ws5i9BRt7gdUPW1Bivz5h/N+XLjAW9YAz8dgIY9AuGjMbPM3YYEkL+hHFuykwQ==', N'5e352388-4706-40b9-9228-d4b7b27a647c', NULL, 0, 0, NULL, 1, 0, N'guest@dvdshop.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e4438806-5dba-4e39-8316-95c683360d46', N'admin@dvdshop.com', 0, N'ADR5gZDLKzdpR+kv//UowM5E1Z1MpVsE8ybqUAjhSE77sdxqCPTrQfezzAVptfYMrg==', N'b9c9a5d7-6746-4e33-a2a3-d2de624354e4', NULL, 0, 0, NULL, 1, 0, N'admin@dvdshop.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c3ebb7bf-640b-4d77-8ee6-fc638711f959', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e4438806-5dba-4e39-8316-95c683360d46', N'c3ebb7bf-640b-4d77-8ee6-fc638711f959')

");
        }
        
        public override void Down()
        {
        }
    }
}
