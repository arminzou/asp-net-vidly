namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0b303001-68e3-4823-8483-5bd2b6fa4fe8', N'guest@vidly.com', 0, N'AHJ5c5KMu6c4S8u6vyF/1Zp04BnEoFXMWx35irHgZFBLXuPACOo9thsJ7CZMqhGRsQ==', N'16037d4b-e889-4a2f-8504-341395146388', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1299730f-249d-4c2c-9bf9-098f5d3d9111', N'admin@vidly.com', 0, N'AGsKQTOltB5Y+X1quyKwiwxrP/ozwWrWtiTe+fShp4+YodxSVtIxAeij3hdJYQ+vZQ==', N'b9064d39-4032-4e55-a74a-3d0b76e91b80', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'248d4639-da63-49ad-ae88-5ac92e47611a', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1299730f-249d-4c2c-9bf9-098f5d3d9111', N'248d4639-da63-49ad-ae88-5ac92e47611a')


            ");
        }

        public override void Down()
        {
        }
    }
}
