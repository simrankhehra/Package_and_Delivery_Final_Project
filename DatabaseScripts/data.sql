INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'10b4619f-4b99-4da9-9e44-00cf15a8a50c', N'admin', N'admin', N'106f2877-8b35-4849-96fa-5f279c5d0f03')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8197f278-945a-4704-aeb2-739599478592', N'sender', N'sender', N'28bac3d1-b0d5-493a-abf3-d30254efd403')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1be6ea39-7bfa-497f-900b-2f98d6ce06cc', N'frank@package.com', N'FRANK@PACKAGE.COM', N'frank@package.com', N'FRANK@PACKAGE.COM', 1, N'AQAAAAEAACcQAAAAEEnFy2KrdWIOPdyG5xEat4lWh3Re7xWHjj1cca2uj5+jlY2jgqmPrvH1IK4spnDklw==', N'Q7B7LACASTLOW7I6LBSI7ACIVCVESLFT', N'9fb3d093-361c-4a35-a104-9214ec3519bb', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'63c54074-eebb-4af8-b975-3d50837c7e61', N'greg@package.com', N'GREG@PACKAGE.COM', N'greg@package.com', N'GREG@PACKAGE.COM', 1, N'AQAAAAEAACcQAAAAELYOhIQCvgDtQSJndSm2MSeQBs8MNx8wQBNTsm5lotTP1xiYoC6X7piBlnjKZa853Q==', N'LBEMXK3XXFJ6GQHLMHL34I6VYY4LUZAK', N'fc560833-282e-46e3-9052-90507667d26e', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'75d6c88d-a633-4a96-a0cd-a3e423a3bbe6', N'admin@package.com', N'ADMIN@PACKAGE.COM', N'admin@package.com', N'ADMIN@PACKAGE.COM', 1, N'AQAAAAEAACcQAAAAEMIAvBmxmOBhPPlRmEoDEUzQiyE0VpPjn4zA5hyy+ybZH/ApyCcgS+j+zAls/IFElw==', N'J5RE3TWAY7NWVJ6VLBMO3YIEJCNDRAM4', N'046a9be8-ca88-443d-86bc-bedbda55eaa2', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'75d6c88d-a633-4a96-a0cd-a3e423a3bbe6', N'10b4619f-4b99-4da9-9e44-00cf15a8a50c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1be6ea39-7bfa-497f-900b-2f98d6ce06cc', N'8197f278-945a-4704-aeb2-739599478592')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'63c54074-eebb-4af8-b975-3d50837c7e61', N'8197f278-945a-4704-aeb2-739599478592')
SET IDENTITY_INSERT [dbo].[Courier] ON
INSERT INTO [dbo].[Courier] ([Id], [Name], [LogoUrl]) VALUES (1, N'DHL', N'dhl-logo.jpg')
INSERT INTO [dbo].[Courier] ([Id], [Name], [LogoUrl]) VALUES (2, N'UPS', N'ups-logo.jpg')
SET IDENTITY_INSERT [dbo].[Courier] OFF
SET IDENTITY_INSERT [dbo].[Sender] ON
INSERT INTO [dbo].[Sender] ([Id], [SenderName], [PhoneNumber], [Email]) VALUES (1, N'Greg Wilkinson', N'0213334567', N'greg@package.com')
INSERT INTO [dbo].[Sender] ([Id], [SenderName], [PhoneNumber], [Email]) VALUES (2, N'Frank Simon', N'0213458999', N'frank@package.com')
SET IDENTITY_INSERT [dbo].[Sender] OFF
SET IDENTITY_INSERT [dbo].[Package] ON
INSERT INTO [dbo].[Package] ([Id], [CourierId], [SenderId], [Description], [DeliveryAddress], [Submitted], [PackageStatus]) VALUES (1, 1, 1, N'Important Documents ', N'230 Queen Street , Auckland 1010', N'2020-08-27 00:00:00', 0)
INSERT INTO [dbo].[Package] ([Id], [CourierId], [SenderId], [Description], [DeliveryAddress], [Submitted], [PackageStatus]) VALUES (2, 2, 2, N'Gift ', N'345 Victoria Street Auckland ', N'2020-08-25 00:00:00', 2)
SET IDENTITY_INSERT [dbo].[Package] OFF
