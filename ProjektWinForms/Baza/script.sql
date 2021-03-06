USE [Projekt]
GO
/****** Object:  Table [dbo].[OśrodekNarciarski]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OśrodekNarciarski](
	[ID_ośrodka] [int] IDENTITY(1,1) NOT NULL,
	[ID_trasy] [int] NOT NULL,
	[ID_użytkownika] [int] NOT NULL,
	[NazwaOśrodka] [nvarchar](30) NULL,
	[Telefon] [char](14) NULL,
	[Fax] [char](20) NULL,
	[Email] [char](20) NULL,
	[NIP] [char](9) NULL,
	[Miejscowość] [varchar](35) NULL,
	[Ulica] [char](35) NULL,
	[NrBudynku] [char](5) NULL,
	[KodPocztowy] [varchar](15) NULL,
	[Kraj] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ośrodka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrasaNarciarska]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrasaNarciarska](
	[ID_trasy] [int] IDENTITY(1,1) NOT NULL,
	[ID_właściwościtrasy] [int] NOT NULL,
	[NazwaTrasy] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_trasy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Użytkownik]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Użytkownik](
	[ID_użytkownika] [int] IDENTITY(1,1) NOT NULL,
	[Email] [char](20) NULL,
	[Telefon] [char](14) NULL,
	[Imię] [char](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_użytkownika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WłaściwościTrasy]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WłaściwościTrasy](
	[ID_właściwościtrasy] [int] IDENTITY(1,1) NOT NULL,
	[Kolor] [char](20) NULL,
	[DługośćTrasy] [char](20) NULL,
	[SztuczneNaśnieżanie] [char](20) NULL,
	[Nachylenie] [char](20) NULL,
	[OświetlenieTrasy] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_właściwościtrasy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OśrodekNarciarski]  WITH CHECK ADD FOREIGN KEY([ID_trasy])
REFERENCES [dbo].[TrasaNarciarska] ([ID_trasy])
GO
ALTER TABLE [dbo].[OśrodekNarciarski]  WITH CHECK ADD FOREIGN KEY([ID_użytkownika])
REFERENCES [dbo].[Użytkownik] ([ID_użytkownika])
GO
ALTER TABLE [dbo].[TrasaNarciarska]  WITH CHECK ADD FOREIGN KEY([ID_właściwościtrasy])
REFERENCES [dbo].[WłaściwościTrasy] ([ID_właściwościtrasy])
GO
/****** Object:  StoredProcedure [dbo].[spDodajOśrodekNarciarski]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spDodajOśrodekNarciarski] 
	@ID_trasy INT,
	@ID_użytkownika INT,
	@NazwaOśrodka NVARCHAR(30),
	@Telefon CHAR(14),
	@Fax CHAR(20),
	@Email CHAR(20),
	@NIP CHAR(9),
	@Miejscowość VARCHAR(35),
	@Ulica CHAR(35),
	@NrBudynku CHAR(5),
	@KodPocztowy VARCHAR(15),
	@Kraj CHAR(10)
AS
BEGIN
INSERT INTO OśrodekNarciarski
values(@ID_trasy,@ID_użytkownika,@NazwaOśrodka,@Telefon,@Fax,@Email,@NIP,@Miejscowość,@Ulica,@NrBudynku,@KodPocztowy,@Kraj)
END
GO
/****** Object:  StoredProcedure [dbo].[spDodajTrasęNarciarską]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spDodajTrasęNarciarską] 
@ID_właściwościtrasy INT,
@NazwaTrasy NVARCHAR(20)
AS
BEGIN
INSERT INTO TrasaNarciarska
values(@ID_właściwościtrasy,@NazwaTrasy)
END
GO
/****** Object:  StoredProcedure [dbo].[spDodajUżytkownika]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spDodajUżytkownika]
@Email CHAR(20),
@Telefon CHAR(14),
@Imię CHAR(30)
AS
BEGIN
INSERT INTO Użytkownik
values(@Email,@Telefon,@Imię)
END
GO
/****** Object:  StoredProcedure [dbo].[spDodajWłaściwościTrasy]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spDodajWłaściwościTrasy]
@Kolor CHAR(20),
@DługośćTrasy CHAR(20),
@SztuczneNaśnieżanie CHAR(20),
@Nachylenie CHAR(20),
@OświetlenieTrasy CHAR(20)
AS
BEGIN
INSERT INTO WłaściwościTrasy
values(@Kolor,@DługośćTrasy,@SztuczneNaśnieżanie,
@Nachylenie,@OświetlenieTrasy)
END
GO
/****** Object:  StoredProcedure [dbo].[spUsuńOśrodekNarciarski]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spUsuńOśrodekNarciarski]
@ID_ośrodka INT
AS
BEGIN
DELETE FROM OśrodekNarciarski
WHERE ID_ośrodka=@ID_ośrodka
END
GO
/****** Object:  StoredProcedure [dbo].[spUsuńTrasęNarciarską]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spUsuńTrasęNarciarską]
@ID_trasy INT
AS
BEGIN
DELETE FROM TrasaNarciarska
WHERE ID_trasy=@ID_trasy
END
GO
/****** Object:  StoredProcedure [dbo].[spUsuńUżytkownika]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spUsuńUżytkownika]
@ID_użytkownika INT
AS
BEGIN
DELETE FROM Użytkownik
WHERE ID_użytkownika = @ID_użytkownika
END
GO
/****** Object:  StoredProcedure [dbo].[spUsuńWłaściwościTrasy]    Script Date: 26.07.2020 21:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spUsuńWłaściwościTrasy]
@ID_właściwościtrasy INT
AS
BEGIN
DELETE FROM WłaściwościTrasy
WHERE ID_właściwościtrasy=@ID_właściwościtrasy
END
GO
