SET IDENTITY_INSERT [dbo].[Sender] ON
INSERT INTO [dbo].[Sender] ([Id], [SenderName], [PhoneNumber], [Email]) VALUES (1, N'Greg Wilkinson', N'0213334567', N'greg@package.com')
INSERT INTO [dbo].[Sender] ([Id], [SenderName], [PhoneNumber], [Email]) VALUES (2, N'Frank Simon', N'0213458999', N'frank@package.com')
SET IDENTITY_INSERT [dbo].[Sender] OFF
