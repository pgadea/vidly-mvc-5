namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'360b5873-5ec7-4564-9c46-b86d72130ac4', N'guest@vidly.com', 0, N'ACqlmDEy7NizDt3G7dvZVGmng5O7UQgYDW1Acd9mWdWlVoLCJOqzEgThjzx6Mhgnbw==', N'cf5e801a-abed-4664-a365-1933bbafdb30', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd7fd433c-bd3a-49f5-ab46-50ad31ade851', N'admin@test.com', 0, N'AOiHfezwE06BfWBgb6gLI4I9AxQ8MJUBCbo3kfI/zeZ7jR12Hv11AkASSzh7rBTqpQ==', N'28aa241a-2beb-44e6-b37c-65b5b3abf566', NULL, 0, 0, NULL, 1, 0, N'admin@test.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'421d9cb8-79fa-4730-a37c-8f6c8f1010f9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd7fd433c-bd3a-49f5-ab46-50ad31ade851', N'421d9cb8-79fa-4730-a37c-8f6c8f1010f9')

");
        }
        
        public override void Down()
        {
        }
    }
}
