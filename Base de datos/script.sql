
GO
CREATE TABLE [dbo].[usuarios](
	[codusu] [int] NOT NULL,
	[nomusu] [varchar](50) NULL,
	[pass] [varchar](50) NULL,
	[nivel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codusu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suplidor]    Script Date: 08/10/2015 14:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suplidor](
	[codsup] [int] NOT NULL,
	[nomsup] [varchar](50) NULL,
	[dirsup] [varchar](50) NULL,
	[telsup] [varchar](50) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codsup] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 08/10/2015 14:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[numfac] [int] NOT NULL,
	[fecfac] [datetime] NULL,
	[codcli] [int] NULL,
	[status] [bit] NULL,
	[monto] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[numfac] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalles]    Script Date: 08/10/2015 14:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles](
	[numfac] [int] NULL,
	[codart] [int] NULL,
	[cantven] [float] NULL,
	[preven] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamientos]    Script Date: 08/10/2015 14:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamientos](
	[coddep] [int] NOT NULL,
	[nomdep] [varchar](50) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[coddep] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 08/10/2015 14:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[codcli] [int] NOT NULL,
	[nomcli] [varchar](50) NULL,
	[telcli] [varchar](50) NULL,
	[dircli] [varchar](50) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codcli] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 08/10/2015 14:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Articulos](
	[codart] [int] NOT NULL,
	[nomart] [varchar](50) NULL,
	[canexi] [float] NULL,
	[coddep] [int] NULL,
	[codsup] [int] NULL,
	[preven] [float] NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codart] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Vista_factura]    Script Date: 08/10/2015 14:51:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Vista_factura] as 
select f.numfac,f.fecfac,f.monto,c.nomcli as cliente,a.nomart as articulo,df.cantven,df.preven
from Facturas f
left join Clientes c on c.codcli=f.codcli
left join detalles df on df.numfac=f.numfac
left join Articulos a on a.codart=df.codart
GO
/****** Object:  View [dbo].[Vista_articulo]    Script Date: 08/10/2015 14:51:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Vista_articulo] as
select a.codart,a.nomart,a.canexi,d.nomdep,s.nomsup,a.preven,a.status from articulos a
left join departamientos d on d.coddep=a.coddep left join suplidor s on s.codsup=a.codsup
GO
