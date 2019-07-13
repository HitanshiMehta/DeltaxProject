USE [IMDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actor](
	[Actor_Id] [int] IDENTITY(1,1) NOT NULL,
	[Actor_Name] [varchar](50) NULL,
	[Actor_Photo] [varchar](200) NULL,
	[Actor_Sex] [varchar](10) NULL,
	[Actor_DOB] [date] NULL,
	[Actor_Bio] [varchar](1000) NULL,
	[Actor_Height] [varchar](10) NULL,
	[Actor_Birth_Name] [varchar](50) NULL,
	[Actor_Birth_State] [varchar](25) NULL,
 CONSTRAINT [PK_Actor] PRIMARY KEY CLUSTERED 
(
	[Actor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movie]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movie](
	[Movie_Id] [int] IDENTITY(1,1) NOT NULL,
	[Movie_Name] [varchar](50) NULL,
	[Movie_Release_Year] [varchar](4) NULL,
	[Movie_Plot] [varchar](200) NULL,
	[Movie_Poster] [varchar](100) NULL,
	[Movie_Rating] [float] NULL,
	[Producer_Id] [int] NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Movie_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Movie_Actor]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie_Actor](
	[Movie_Actor_Id] [int] IDENTITY(1,1) NOT NULL,
	[Movie_Id] [int] NULL,
	[Actor_Id] [int] NULL,
 CONSTRAINT [PK_Movie_Actor] PRIMARY KEY CLUSTERED 
(
	[Movie_Actor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producer]    Script Date: 7/14/2019 2:37:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producer](
	[Producer_Id] [int] IDENTITY(1,1) NOT NULL,
	[Producer_Name] [varchar](50) NULL,
	[Producer_Photo] [varchar](100) NULL,
	[Producer_Sex] [varchar](10) NULL,
	[Producer_DOB] [date] NULL,
	[Producer_Bio] [varchar](400) NULL,
 CONSTRAINT [PK_Producer] PRIMARY KEY CLUSTERED 
(
	[Producer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201907091622505_InitialCreate', N'DeltaxIMDB.Models.ApplicationDbContext', 0x1F8B0800000000000400DD5CDB6EE336107D2FD07F10F4D416A9954B77B10DEC2DB24ED206DD5CB0CE2EFAB6A025DA1156A254894A1D14FDB23EF493FA0B1D4AD48D175D6CC5768A051611393C331C0EC9E170E87FFFFE67FCD3CAF78C471CC56E4026E6D1E8D03430B103C725CB8999D0C5F76FCC9FDE7EFDD5F8C2F157C6A79CEE84D1414B124FCC074AC353CB8AED07ECA378E4BB7614C4C1828EECC0B7901358C787873F5A474716060813B00C63FC2121D4F571FA019FD380D838A409F2AE03077B312F879A598A6ADC201FC721B2F1C43CC71E45ABABEBF377A38CD834CE3C17812033EC2D4C031112504441CCD38F319ED12820CB590805C8BB7F0A31D02D9017632EFE6949DEB52787C7AC2756D93087B29398067E4FC0A313AE1A4B6CBE9682CD4275A0BC0B50327D62BD4E153831AF1C9C167D083C5080C8F074EA458C78625E172CCEE2F006D351DE7094415E4600F747107D1955110F8CCEED0E0A533A1E1DB27F07C634F16812E109C1098D907760DC2573CFB57FC54FF7C1174C262747F3C5C99B57AF9173F2FA077CF2AADA53E82BD0D50AA0E82E0A421C816C7851F4DF34AC7A3B4B6C5834ABB4C9B402B604B3C234AED1EA3D264BFA00F3E5F88D695CBA2BECE425DCB83E1217261134A251029F3789E7A1B9878B7AAB9127FBBF81EBF1ABD78370BD418FEE321D7A813F4C9C08E6D507ECA5B5F1831B66D3AB36DE9F39D96514F8ECBB6E5F59EDE759904436EB4CA025B947D112D3BA7463AB34DE4E26CDA08637EB1C75FF4D9B492A9BB7929475689D9990B3D8F66CC8E57D5EBE9D2DEE2C0C61F052D3621A69323869AF1A098D0F8C92A4349CA3AE8643A043FFE775F0C247AE37C042D8810BB8200B37F271D1CB7701981D22BD65BE43710CEB80F30B8A1F1A44873F07107D86ED2402F39C51E487CFCEEDEE2120F826F1E7CCEAB7C76BB0A1B9FF23B844360DA20BC25A6D8CF73EB0BF0409BD20CE39A2F823B57340F679EFFADD010611E7CCB6711C5F823163671A80879D035E117A72DC1B8EAD4FBB7644A61E727DB52722ACA49F73D2D21B5153481E89864CE5953489FA3E58BAA49BA839A95ED48CA255544ED6575406D64D524EA9173425689533A31ACCCF4B476878472F85DD7F4F6FB3CD5BB71654D438831512FF8C098E601973EE10A53822E50874593776E12CA4C3C7983EFBDE9472FA84BC6468566BCD867411187E36A4B0FB3F1B5231A1F8D1759857D2E1F89313037C277AF5C9AA7DCE09926D7B3AD4BAB96DE6DB590374D3E52C8E03DB4D678122F0C5C31675F9C18733DA6318596FC43808740C0CDD655B1E9440DF4CD1A86E091CF330C5C6999D0506A728B69123AB113AE4F4102CDF51158295F190BA70DF493CC1D271C41A2176088A61A6BA84CAD3C225B61B22AF554B42CB8E5B18EB7BC143AC39C721268C61AB26BA3057873F9800051F6150DA3434B62A16D76C881AAF5537E66D2E6C39EE5254622B36D9E23B6BEC92FB6FCF6298CD1ADB827136ABA48B00DA50DE2E0C949F55BA1A807870D93703154E4C1A03E52ED5560CB4AEB11D18685D252FCE40B3236AD7F117CEABFB669EF583F2F6B7F54675EDC0366BFAD833D3CC7C4F6843A1058E64F33C9FB34ABCA28AC319C8C9CF67317775451361E0334CEB219BD2DF55FAA156338868444D80A5A1B580F24B4009489A503D84CB63798DD2712FA2076C1E776B84E56BBF005BB10119BB7A195A21D45F998AC6D9E9F451F4ACB006C9C83B1D162A380A831017AF7AC73B284517979515D3C517EEE30D573AC607A341412D9EAB4649796706D7526E9AED5A5239647D5CB28DB424B84F1A2DE59D195C4BDC46DB95A4700A7AB8051BA9A8BE850F34D9F24847B1DB1475632B4B91E205634B934B35BE4661E8926525B78A9718B32CB16AFAFDAC7FCA919F615876ACC83C2AA42D38D120424B2CD4026B90F4D28D627A8E289A2316E7993ABE44A6DC5B35CB7FCEB2BA7DCA8398EF033935FB3B6B215FDDD7B65AD917E11097D0419F393469145D31FCEAE6064B75431E8A1481FB69E0253ED1FB57FAD6D9F55DB57D5622238C2D417EC97F92942579B975CD771A17794E0C334685F7B2FE38E92174DACE7DCFAABE75FEA81E250F4F55517421AB9D8D9BCE8DE93356A283D87FA85A119E6756F1AC942A002FEA8951496C90C02A75DD51EBB92755CC7A4D774421C1A40A2954F590B29A465213B25AB1169E46A36A8AEE1CE4C4912ABA5CDB1D59914252855654AF81AD9059ACEB8EAAC832A9022BAABB63972927E21ABAC7FB96F6D8B2EEC6951D6C37DBB93418CFB3200EB3F155EEEFAB4095E29E58FC865E02E3E57B694CDAD3DDBAC69485333633260D867EDDA95D7CD7979DC6DB7A3D66ED36BBB6B437DDE6EBF1FA99ECB31A8674B613490AEEC5194F38CB8DF9B9AAFDF18C74D0CA484C2357236CEB4F31C5FE88118C66BF7B53CFC56C11CF09AE11711738A6590687797C78742C3CC0D99FC730561C3B9EE25CAA7B11531FB32D2463914714D90F2892532336783052824A51E72BE2E0D5C4FC336D759A0630D85F69F18171157F24EEEF0954DC470936FE92533D8749A06F3E61EDE97387EE5ABDFAED73D6F4C0B88D60C69C1A87822ED719E1FA23885ED2644D379066EDA7112F7742D55E1E28518509B1FE4383B94B077964904BF98D8F56DFF6154DF990602344C56381A1F00651A1EE31C03A58DA87000E7CD2F42140BFCEAA1F06AC239AF651804BFA83894F02BA2F4379CB1D6E358A23D13696A454CFAD29D51BE557EE7A6F9232AF379AE87276750FB80D32A8D7B08C17967C3CD8EEA8C82D1E0C7B97A6FDEC09C5FB92435C6677EC3675789BD9C20D7742FFAB24E13D486B53A4E9EC3E1578DBB6A60BE3EE793E65BF84DF3D33369EBCB5FBB4DE6D1B9B2ECCBBE7C6D62B7977CF6C6D57FBE78E2DADF316BAF3545C39AB48731DA38A05B7A5DA66817338E1CF033082CCA3CC5E48AA73BB9AF2525B1896247AA6FAA43291B1347124BE124533DB7E7DE51B7E6367394D335B4D2A66136FBEFE37F2E634CDBC35098EBB481256A618AA12B75BD6B1A60CA89794145CEB494B0E7A9BCFDA78B7FE92728007514A6DF668EE885F4ECAEF202A1972EAF448F195AF7B61EFACFCA222ECDFB1BB2C21D8EF2B126CD776CD82E68A2C827CF31624CA498408CD35A6C8812DF52CA2EE02D914AA598C397DE29DC6EDD84DC71C3B57E436A16142A1CBD89F7BB5801773029AF8A779CC7599C7B761FA6B25437401C474596CFE96BC4B5CCF29E4BE54C4843410CCBBE0115D3696944576974F05D24D403A0271F5154ED13DF6430FC0E25B32438F781DD9C0FCDEE325B29FCA08A00EA47D20EA6A1F9FBB6819213FE618657BF8041B76FCD5DBFF0048DD45D358540000, N'6.1.3-40302')
SET IDENTITY_INSERT [dbo].[Actor] ON 

INSERT [dbo].[Actor] ([Actor_Id], [Actor_Name], [Actor_Photo], [Actor_Sex], [Actor_DOB], [Actor_Bio], [Actor_Height], [Actor_Birth_Name], [Actor_Birth_State]) VALUES (1, N'Shahid Kapoor', N'shahid.jpg', N'Male', CAST(0x0C090B00 AS Date), N'Shahid''s rise to stardom reads like a bollywood script: from a struggler to a winner. With his hard work, perseverance and sincerity, he has written his own destiny.

Shahid is a mine of unabashed talent and spark, beneath his calm and innocent veneer. Shahid Kapoor is young and vibrant, with a magnetic charm and easy going candour that sets him apart from the rest. His debut performance as the young and carefree boy-next-door in "Ishk Vishk" was not only applauded but also awarded the Filmfare Best Male Debut.', N'5'' 6''''', N'Sahid Kappor', N'Delhi')
INSERT [dbo].[Actor] ([Actor_Id], [Actor_Name], [Actor_Photo], [Actor_Sex], [Actor_DOB], [Actor_Bio], [Actor_Height], [Actor_Birth_Name], [Actor_Birth_State]) VALUES (2, N'Hrithik Roshan', N'hrithik.jpg', N'Male', CAST(0xF8FE0A00 AS Date), N'Hrithik Roshan is an Indian actor, born on 10th January 1974, well known globally for his versatile roles, unmatchable dancing skills and attractive looks.After having appeared in films as a child actor in the 1980s, Roshan made his film debut in a leading role in Kaho Naa... Pyaar Hai (2000) for which he earned Filmfare Awards for Best Actor and Best Male Debut. It was not just a new actor on the block, but a star was born. He became a romantic hero, an action hero and revolutionized the Hindi film industry in significant ways. Never before had any debutant become an overnight sensation of this kind.', N'5'' 8''''', N'Hrithik Rakesh Nagrath', N'Maharastraa.')
INSERT [dbo].[Actor] ([Actor_Id], [Actor_Name], [Actor_Photo], [Actor_Sex], [Actor_DOB], [Actor_Bio], [Actor_Height], [Actor_Birth_Name], [Actor_Birth_State]) VALUES (3, N'Saif Ali Khan', N'saif.jpg', N'Male', CAST(0x1DFA0A00 AS Date), N'Saif is the son of Bollywood actress, Sharmila Tagore, and Indian cricketer, Mansoor Ali Khan.

Both his grandfather, Iftikhar Ali Khan Pataudi, and father were professional cricketers. His mother, Sharmila Tagore, an actress within her own rights. He has two sisters, Bollywood actress Soha Ali Khan, and fashion designer Saba Ali Khan.

Saif studied in Himachal Pradesh''s Lawrence School Sanawar, and then went on to continue his studies in Lockers Park School and Winchester College - both located in the United Kingdom.', N'5'' 6''''', N'Sajid Ali Khan', N'Delhi')
INSERT [dbo].[Actor] ([Actor_Id], [Actor_Name], [Actor_Photo], [Actor_Sex], [Actor_DOB], [Actor_Bio], [Actor_Height], [Actor_Birth_Name], [Actor_Birth_State]) VALUES (4, N'Aamir Khan', N'aamir.jpg', N'Male', CAST(0x60F20A00 AS Date), N'Aamir is no doubt one of the most dedicated actors in this world. With his recent success in India and China markets combined he has got the title of Worlds Biggest Superstar. He went through rapid transformations in his body structure for his films to bring out the reality factor in his characters. This is also one of the reasons why his films and he is loved all over the world. His most visible changes include the movies like Ghajini, 3 idiots, Talaash, Dhoom 3, PK and Dangal. With his recent successful movies like Dangal, Pk , Talaash and TV serial Satyamev jayate, his image has become more of a serious actor. However, the truth is that he is a fabulous actor when it comes to comedy too. He has played some really funny iconic characters in some cult comedy movies like Andaaz Apna Apna, Ishq, Mela, Dil chahta hai and many more. He has also done a lot of TVC where his character was funny like Coca cola, Tata sky and Snapdeal.
', N'5'' 5''''', N'Aamir khan', N'Maharastra')
INSERT [dbo].[Actor] ([Actor_Id], [Actor_Name], [Actor_Photo], [Actor_Sex], [Actor_DOB], [Actor_Bio], [Actor_Height], [Actor_Birth_Name], [Actor_Birth_State]) VALUES (5, N'Aishwarya Rai', N'Aishwarya.jpg', N'Female', CAST(0x06E60A00 AS Date), N'Rai made her acting debut in 1997 with Mani Ratnam''s Tamil film Iruvar, a semi-biographical political drama, featuring Mohanlal, Prakash Raj, Tabu and Revathi. The film was a critical success and among other awards, won the Best Film award at the Belgrade International Film Festival. Rai featured as Pushpavalli and Kalpana – dual roles; the latter was a fictionalised portrayal of politician and former actress Jayalalithaa.', N'5'' 5"', N'Aishwarya Krishnaraj Rai', N'Karnataka')
INSERT [dbo].[Actor] ([Actor_Id], [Actor_Name], [Actor_Photo], [Actor_Sex], [Actor_DOB], [Actor_Bio], [Actor_Height], [Actor_Birth_Name], [Actor_Birth_State]) VALUES (6, N'Preity Zinta', N'Preity.jpg', N'Female', CAST(0x27010B00 AS Date), N'Preity Zinta shot to fame as the refreshing, cool, wet model in the Liril commercial. She also modeled for Perk and her dimpled smile won the hearts of millions. Preity never thought she would be an actress. Kapoor saw her in the Liril commercial and liked her so much that he instantly decided that the next film he would announce would have her in the lead.', N'5'' 2"', N'Preity Zinta', N'Simla')
SET IDENTITY_INSERT [dbo].[Actor] OFF
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'09f10959-2d3b-4af3-8808-4634ebf15144', N'hitanshimehta18@gmail.com', 0, N'AGM9x7i3X4Px3K2UGjPqtsYehX1p+j5w83cFxMrsg5QU0L5EVVMZ5tzbu0l/wGTdcw==', N'18ddb5fc-1513-4293-b89c-ad8740d6499c', NULL, 0, 0, NULL, 1, 0, N'hitanshimehta18@gmail.com')
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([Movie_Id], [Movie_Name], [Movie_Release_Year], [Movie_Plot], [Movie_Poster], [Movie_Rating], [Producer_Id]) VALUES (6, N'Lagaan', N'2001', N'The people of a small village in Victorian India stake their future on a game of cricket against their ruthless British rulers. ', N'lagaan.jpg', 9.4, 1)
INSERT [dbo].[Movie] ([Movie_Id], [Movie_Name], [Movie_Release_Year], [Movie_Plot], [Movie_Poster], [Movie_Rating], [Producer_Id]) VALUES (7, N'Student of the Year ', N'2017', N'A student must face off against bullies and overcome hurdles, both academic and romantic, to win his college''s coveted Student of the Year trophy. ', N'student.jpg', 6.5, 9)
INSERT [dbo].[Movie] ([Movie_Id], [Movie_Name], [Movie_Release_Year], [Movie_Plot], [Movie_Poster], [Movie_Rating], [Producer_Id]) VALUES (8, N'Chori Chori Chupke Chupke ', N'2001', N'A prostitute agrees to get impregnated and then give the baby to a couple (Raj and Priya) in exchange for a million rupees. Everything changes when she develops feelings for the baby and Raj. ', N'chori.jpg', 7.5, 6)
INSERT [dbo].[Movie] ([Movie_Id], [Movie_Name], [Movie_Release_Year], [Movie_Plot], [Movie_Poster], [Movie_Rating], [Producer_Id]) VALUES (9, N'De De Pyaar De ', N'2019', N'A 50-year-old single father faces disapproval from his family and his ex-wife when he falls in love with a 26-year-old woman. ', N'de.jpg', 7.1, 4)
SET IDENTITY_INSERT [dbo].[Movie] OFF
SET IDENTITY_INSERT [dbo].[Movie_Actor] ON 

INSERT [dbo].[Movie_Actor] ([Movie_Actor_Id], [Movie_Id], [Actor_Id]) VALUES (6, 6, 2)
INSERT [dbo].[Movie_Actor] ([Movie_Actor_Id], [Movie_Id], [Actor_Id]) VALUES (7, 6, 3)
INSERT [dbo].[Movie_Actor] ([Movie_Actor_Id], [Movie_Id], [Actor_Id]) VALUES (8, 8, 6)
INSERT [dbo].[Movie_Actor] ([Movie_Actor_Id], [Movie_Id], [Actor_Id]) VALUES (11, 7, 4)
INSERT [dbo].[Movie_Actor] ([Movie_Actor_Id], [Movie_Id], [Actor_Id]) VALUES (12, 8, 2)
INSERT [dbo].[Movie_Actor] ([Movie_Actor_Id], [Movie_Id], [Actor_Id]) VALUES (14, 9, 6)
INSERT [dbo].[Movie_Actor] ([Movie_Actor_Id], [Movie_Id], [Actor_Id]) VALUES (15, 7, 4)
SET IDENTITY_INSERT [dbo].[Movie_Actor] OFF
SET IDENTITY_INSERT [dbo].[Producer] ON 

INSERT [dbo].[Producer] ([Producer_Id], [Producer_Name], [Producer_Photo], [Producer_Sex], [Producer_DOB], [Producer_Bio]) VALUES (1, N'Ashutosh Gowariker', N'aasutosh.jpg', N'Male', CAST(0xD7F00A00 AS Date), N'His passion for cinema immediately draws your attention, making you realize that Ashutosh Gowariker would not have been anywhere except behind the camera, however tempting the choice. An actor who took to film direction after almost a decade in front of the camera, Ashutosh has acted in Hindi films, Marathi films, television serials')
INSERT [dbo].[Producer] ([Producer_Id], [Producer_Name], [Producer_Photo], [Producer_Sex], [Producer_DOB], [Producer_Bio]) VALUES (4, N'Yash Chopra', N'yash.jpg', N'Male', CAST(0x11010B00 AS Date), N'Chopra was born on 27 September 1932 in Lahore, British India, into a Punjabi Hindu family in British India (now Pakistan). His father was an accountant in the PWD division of the British Punjab administration. He was the youngest of eight children, the oldest of whom was almost 30 years his senior. The eminent film-maker BR Chopra is one of his brothers. ')
INSERT [dbo].[Producer] ([Producer_Id], [Producer_Name], [Producer_Photo], [Producer_Sex], [Producer_DOB], [Producer_Bio]) VALUES (6, N'Ekta Kapoor', N'Ekta.jpg', N'Female', CAST(0xEAE90A00 AS Date), N'Kapoor started her career aged 15, interning with ad and feature filmmaker Kailash Surendranath, until after obtaining financing from her father, she decided to become a producer. She ventured into Bollywood movie production in 2001 beginning with Kyo Kii... Main Jhuth Nahin Bolta, Kucch To Hai and Krishna Cottage based on supernatural themes followed in 2003 and 2004.')
INSERT [dbo].[Producer] ([Producer_Id], [Producer_Name], [Producer_Photo], [Producer_Sex], [Producer_DOB], [Producer_Bio]) VALUES (9, N'Priyanka Chopra', N'Priyanka.jpg', N'Female', CAST(0x33D90A00 AS Date), N'Priyanka Chopra was born on 18 July 1982 in Jamshedpur, Bihar (present-day Jharkhand), to Ashok and Madhu Chopra, both physicians in the Indian Army. Her father was a Punjabi Hindu from Ambala. Her mother, from Jharkhand, is the eldest daughter of Madhu Jyotsna Akhouri, a former member of Bihar Legislative Assembly, and Dr. Manohar Kishan Akhouri, a former Congress veteran.')
SET IDENTITY_INSERT [dbo].[Producer] OFF
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Movie_Actor]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Actor_Actor] FOREIGN KEY([Actor_Id])
REFERENCES [dbo].[Actor] ([Actor_Id])
GO
ALTER TABLE [dbo].[Movie_Actor] CHECK CONSTRAINT [FK_Movie_Actor_Actor]
GO
ALTER TABLE [dbo].[Movie_Actor]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Actor_Table_Movie] FOREIGN KEY([Movie_Id])
REFERENCES [dbo].[Movie] ([Movie_Id])
GO
ALTER TABLE [dbo].[Movie_Actor] CHECK CONSTRAINT [FK_Movie_Actor_Table_Movie]
GO
