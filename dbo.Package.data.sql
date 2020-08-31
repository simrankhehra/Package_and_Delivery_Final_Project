SET IDENTITY_INSERT [dbo].[Package] ON
INSERT INTO [dbo].[Package] ([Id], [CourierId], [SenderId], [Description], [DeliveryAddress], [Submitted], [PackageStatus]) VALUES (1, 1, 1, N'Important Documents ', N'230 Queen Street , Auckland 1010', N'0001-01-01 00:00:00', 0)
INSERT INTO [dbo].[Package] ([Id], [CourierId], [SenderId], [Description], [DeliveryAddress], [Submitted], [PackageStatus]) VALUES (2, 2, 2, N'Gift ', N'345 Victoria Street Auckland ', N'0001-01-01 00:00:00', 2)
SET IDENTITY_INSERT [dbo].[Package] OFF
