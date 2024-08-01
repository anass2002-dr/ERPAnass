SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_C_RubriquesTotalExo](
@codeExo nvarchar(200)='',
@valueExo float=0,
@salaireBase float=0,
@HeuresTravail float=0
)
returns float
as
begin
	declare @TotalExo float=0,@SMIG float=2970.05
	
	if(@codeExo='Nat_Indem_Exo1')
		begin
			if(@valueExo>5000)
			begin
				select @TotalExo=5000
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end	
	if(@codeExo='Nat_Indem_Exo2')
		begin
			if(@valueExo>5000)
			begin
				select @TotalExo=5000
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end	
	if(@codeExo='Nat_Indem_Exo3')
		begin
			if(@valueExo>5000)
			begin
				select @TotalExo=5000
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end	
	if(@codeExo='Nat_Indem_Exo4')
		begin
			if(@valueExo>3)
			begin
				select @TotalExo=3
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo5')
		begin
			if(@valueExo>500)
			begin
				select @TotalExo=500
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo6')
		begin
			if(@valueExo>750)
			begin
				select @TotalExo=750
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo7')
		begin
			select @TotalExo=@valueExo	
		end
	if(@codeExo='Nat_Indem_Exo8')
		begin
			if(@valueExo>1500)
			begin
				select @TotalExo=1500
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo9')
		begin
			if(@valueExo>190)
			begin
				select @TotalExo=190
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo10')
		begin
			if(@valueExo>(@salaireBase*0.1))
			begin
				select @TotalExo=(@salaireBase*0.1)
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo11')
		begin
			if(@valueExo>100)
			begin
				select @TotalExo=100
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo12')
		begin
			if(@valueExo>210)
			begin
				select @TotalExo=210
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo13')
		begin
			if(@valueExo>150)
			begin
				select @TotalExo=150
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo14')
		begin
			if(@valueExo>(2*(@SMIG/191)))
			begin
				select @TotalExo=(2*(@SMIG/191))
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo15')
		begin
			if(@valueExo>20 and @valueExo>(@salaireBase*0.2))
			begin
				select @TotalExo=20
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end	
	if(@codeExo='Nat_Indem_Exo16')
		begin
			if(@valueExo>(@salaireBase*0.6))
			begin
				select @TotalExo=(@salaireBase*0.6)
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo17')
		begin
			if(@valueExo>2525252525)
			begin
				select @TotalExo=(@valueExo)
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo18')
		begin
			select @TotalExo=@valueExo				
		end
	if(@codeExo='Nat_Indem_Exo19')
		begin
			if(@valueExo>2500)
			begin
				select @TotalExo=2500
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo20')
		begin
			if(@valueExo>2525252522)
			begin
				select @TotalExo=(@valueExo)
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo21')
		begin
			if(@valueExo>(2*@SMIG))
			begin
				select @TotalExo=(2*@SMIG)
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo22')
		begin
			if(@valueExo>10)
			begin
				select @TotalExo=10
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo23')
		begin
			if(@valueExo>2525252)
			begin
				select @TotalExo=(@valueExo)
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end
	if(@codeExo='Nat_Indem_Exo24')
		begin
			if(@valueExo>25252525252)
			begin
				select @TotalExo=(@valueExo)
			end 
			else
			begin 
				select @TotalExo=@valueExo				
			end
		end	
	if(@codeExo='Nat_Indem_Exo25')
		begin
			select @TotalExo=@valueExo				
		end
	return	@TotalExo
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_Users](
	[idUser] [nvarchar](450) NOT NULL,
	[nomUser] [nvarchar](200) NULL,
	[emailUser] [nvarchar](200) NULL,
	[userName] [nvarchar](200) NULL,
	[passwordUser] [nvarchar](max) NULL,
	[adresseUser] [nvarchar](200) NULL,
	[teleUser] [nvarchar](200) NULL,
	[userPhoto] [nvarchar](max) NULL,
	[tokenLogin] [nvarchar](max) NULL,
	[lastLoginDate] [datetime] NULL,
	[outLoginDate] [datetime] NULL,
	[typeAdmin] [bit] NULL,
	[createDate] [datetime] NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_Pays](
	[idPays] [int] IDENTITY(1,1) NOT NULL,
	[nomPays] [nvarchar](50) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPays] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_Ville](
	[idVille] [int] IDENTITY(1,1) NOT NULL,
	[nomVille] [nvarchar](50) NULL,
	[idGroup] [int] NULL,
	[idPays] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [t_Client](
	[idClient] [int] IDENTITY(1,1) NOT NULL,
	[codeClient] [nvarchar](50) NULL,
	[nomClient] [nvarchar](200) NULL,
	[adresseClient] [nvarchar](200) NULL,
	[postalClient] [nvarchar](50) NULL,
	[iceClient] [nvarchar](50) NULL,
	[cnssClient] [nvarchar](50) NULL,
	[nifClient] [nvarchar](50) NULL,
	[patenteClient] [nvarchar](50) NULL,
	[siegeClient] [nvarchar](50) NULL,
	[banqueClient] [nvarchar](50) NULL,
	[ribClient] [nvarchar](50) NULL,
	[soldAutoriseClient] [money] NULL,
	[frmJuridiqueClient] [nvarchar](50) NULL,
	[emailClient] [nvarchar](250) NULL,
	[teleClient] [nvarchar](250) NULL,
	[fixClient] [nvarchar](250) NULL,
	[typeClient] [nvarchar](250) NULL,
	[contratClient] [bit] NULL,
	[vendeurClient] [bit] NULL,
	[distributeur] [bit] NULL,
	[createdate] [datetime] NULL,
	[idVille] [int] NULL,
	[idPays] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[cinClient] [nvarchar](50) NULL,
	[potentielClt] [nvarchar](500) NULL,
	[categorieClt] [nvarchar](500) NULL,
	[origineContact] [nvarchar](500) NULL,
	[siteweb] [nvarchar](max) NULL,
	[propriete] [nvarchar](max) NULL,
	[incoterms] [nvarchar](max) NULL,
	[autorizacion] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [t_tableClient]
as 
select c.*,v.nomVille,p.nomPays,u.nomUser from t_Client c 
left join b_Ville v on v.idVille=c.idVille
left join b_Pays p on p.idPays=c.idPays
inner join s_Users u on u.idUser=c.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [t_ClientSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from t_tableClient where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_E_Employe](
	[idEmploye] [int] IDENTITY(1,1) NOT NULL,
	[nomEmployee] [nvarchar](500) NULL,
	[prenomEmployee] [nvarchar](500) NULL,
	[matricule] [nvarchar](500) NULL,
	[titre] [nvarchar](max) NULL,
	[cinEmployee] [nvarchar](20) NULL,
	[nationalite] [nvarchar](max) NULL,
	[dateNaissance] [datetime] NULL,
	[sitFamiliale] [nvarchar](500) NULL,
	[nbEnfants] [int] NULL,
	[lieuNaissance] [nvarchar](150) NULL,
	[abattement] [int] NULL,
	[email] [nvarchar](200) NULL,
	[adresse] [nvarchar](500) NULL,
	[observation] [nvarchar](max) NULL,
	[createDate] [datetime] NULL,
	[idGroup] [int] NOT NULL,
	[idUser] [nvarchar](450) NOT NULL,
	[idNiveau] [int] NULL,
	[idCategorie] [int] NULL,
	[idDepartement] [int] NULL,
	[idFonction] [int] NULL,
	[dateEntree] [datetime] NULL,
	[dateSortie] [datetime] NULL,
	[checkSortie] [bit] NULL,
	[typePaie] [nvarchar](200) NULL,
	[typeSalarie] [nvarchar](200) NULL,
	[salaireBase] [money] NULL,
	[numCarte] [nvarchar](50) NULL,
	[checkPointage] [bit] NULL,
	[salaireFix] [bit] NULL,
	[banque] [nvarchar](200) NULL,
	[numCompte] [nvarchar](200) NULL,
	[recharge] [nvarchar](200) NULL,
	[traiteAssurVie] [nvarchar](200) NULL,
	[dateAssurVie] [datetime] NULL,
	[plafondAssurVie] [float] NULL,
	[traiteAssurRetraite] [nvarchar](200) NULL,
	[dateAssurRetraite] [datetime] NULL,
	[plafondAssurRetraite] [float] NULL,
	[photo] [nvarchar](max) NULL,
	[idVille] [int] NULL,
	[idModRglm] [int] NULL,
	[genre] [nvarchar](200) NULL,
	[empCadre] [nvarchar](200) NULL,
	[idUserDevice] [int] NULL,
	[idPlanning] [int] NULL,
	[telephone] [nvarchar](30) NULL,
	[busStation] [nvarchar](250) NULL,
	[numDeclareEmp] [nvarchar](200) NULL,
	[PrixKgs] [float] NULL,
	[PrixHeurSup] [float] NULL,
	[PrixParHeur] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmploye] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [paie_I_Categorie](
	[idCategorie] [int] IDENTITY(1,1) NOT NULL,
	[nomCategorie] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategorie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [paie_I_Departement](
	[idDepartement] [int] IDENTITY(1,1) NOT NULL,
	[nomDepartement] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDepartement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [paie_I_Fonction](
	[idFonction] [int] IDENTITY(1,1) NOT NULL,
	[nomFonction] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFonction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [paie_I_Niveau](
	[idNiveau] [int] IDENTITY(1,1) NOT NULL,
	[nomNiveau] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idNiveau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_ModRglm](
	[idModRglm] [int] IDENTITY(1,1) NOT NULL,
	[nomModRglm] [nvarchar](100) NULL,
	[categModRglm] [nvarchar](100) NULL,
	[timbre] [money] NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idModRglm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Z_UserDevice](
	[idUserDevice] [int] IDENTITY(1,1) NOT NULL,
	[enrolNumber] [int] NULL,
	[name] [nvarchar](500) NULL,
	[passwordU] [nvarchar](100) NULL,
	[idDevice] [int] NULL,
	[createDate] [datetime] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUserDevice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [Paie_E_tableEmploye]
  as 
  select e.*,n.nomNiveau,c.nomCategorie,d.nomDepartement,f.nomFonction,u.enrolNumber,m.nomModRglm from Paie_E_Employe e
  left join paie_I_Niveau n on n.idNiveau=e.idNiveau
  left join paie_I_Categorie c on c.idCategorie=e.idCategorie
  left join paie_I_Departement d on d.idDepartement=e.idDepartement
  left join paie_I_Fonction f on f.idFonction=e.idFonction
  left join Paie_Z_UserDevice u on u.idUserDevice=e.idUserDevice
  left join b_ModRglm m on m.idModRglm=e.idModRglm
  left join s_Users us on e.idUser=us.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [Paie_E_EmployeSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_E_tableEmploye where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel_B_BookingPayment](
	[idBookingPayment] [int] IDENTITY(1,1) NOT NULL,
	[idBookingEntete] [int] NULL,
	[comment] [nvarchar](max) NULL,
	[idModRglm] [int] NULL,
	[montant] [money] NULL,
	[createDate] [datetime] NULL,
	[datePayment] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBookingPayment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [hotel_tableBookingsPayment]
as
SELECT p.*,m.nomModRglm FROM Hotel_B_BookingPayment p 
inner join b_ModRglm m on m.idModRglm=p.idModRglm
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_S_RoomType](
	[idRoomType] [int] IDENTITY(1,1) NOT NULL,
	[nameRoomType] [nvarchar](500) NULL,
	[descRoomType] [nvarchar](max) NULL,
	[nbGuests] [int] NULL,
	[maxNbGuests] [int] NULL,
	[priceModel] [int] NULL,
	[prixLouer_HT] [money] NULL,
	[idTaxeLouer] [int] NULL,
	[prixVente_TTC] [money] NULL,
	[sortOrder] [int] NULL,
	[objectType] [nvarchar](250) NULL,
	[photoRoomType] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRoomType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_S_Units](
	[idUnit] [int] IDENTITY(1,1) NOT NULL,
	[unitName] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idRoomType] [int] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_Taxe](
	[idTaxe] [int] IDENTITY(1,1) NOT NULL,
	[nomTaxe] [nvarchar](100) NULL,
	[typeTaxe] [nvarchar](100) NULL,
	[cauxTaxe] [int] NULL,
	[createdate] [datetime] NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTaxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [hotel_tableRoomsEntete]
as 
select r.*,u.idUnit,u.unitName,t.cauxTaxe from hotel_S_RoomType r 
inner join hotel_S_Units u on r.idRoomType=u.idRoomType
left join b_Taxe t on t.idTaxe=r.idTaxeLouer
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_Pos](
	[idPos] [int] IDENTITY(1,1) NOT NULL,
	[tokenPos] [nvarchar](max) NULL,
	[namePos] [nvarchar](200) NULL,
	[titrePos] [nvarchar](200) NULL,
	[souTitrePos] [nvarchar](500) NULL,
	[msgPos] [nvarchar](200) NULL,
	[checkEmail] [bit] NULL,
	[emailSend] [nvarchar](200) NULL,
	[checkOpenSession] [bit] NULL,
	[idTreso] [int] NULL,
	[idDepot] [int] NULL,
	[clientDivers] [int] NULL,
	[idDossier] [int] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_Depot](
	[idDepot] [int] IDENTITY(1,1) NOT NULL,
	[nomDepot] [nvarchar](100) NULL,
	[adressDepot] [nvarchar](200) NULL,
	[prcpDepot] [bit] NULL,
	[idVille] [int] NULL,
	[idPays] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[createDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDepot] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_Tresorerie](
	[idTreso] [int] IDENTITY(1,1) NOT NULL,
	[nameTreso] [nvarchar](100) NULL,
	[soldAutoriseTreso] [money] NULL,
	[cherfTreso] [money] NULL,
	[defaultTreso] [bit] NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[adresseTreso] [nvarchar](100) NULL,
	[ribTreso] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [p_tablePos]
  as 
	select p.*,t.nameTreso,d.nomDepot,c.nomClient from p_Pos p  
	inner join b_Tresorerie t on p.idTreso=t.idTreso
	inner join b_Depot d on p.idDepot=d.idDepot
	inner join t_Client c on p.clientDivers=c.idClient
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel_B_BookingLigne](
	[idBookingLigne] [int] IDENTITY(1,1) NOT NULL,
	[idBookingEntete] [int] NULL,
	[idRoomType] [int] NULL,
	[idUnit] [int] NULL,
	[guests] [int] NULL,
	[prixTTC] [money] NULL,
	[prixHT] [money] NULL,
	[createDate] [datetime] NULL,
	[priceModel] [bit] NULL,
	[TTPrix_TTC] [money] NULL,
	[TTPrix_HT] [money] NULL,
	[lgnTVA] [int] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idBookingLigne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [hotel_tableBookingLigne]
as 
select l.*, r.nameRoomType, u.unitName from Hotel_B_BookingLigne l
inner join hotel_S_RoomType r on r.idRoomType=l.idRoomType
inner join hotel_S_Units u on u.idUnit=l.idUnit
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [hotel_B_BookingLigneSelect](
@idBookingEntete int=null
)
returns table
as
	return	
	select * from hotel_tableBookingLigne where idBookingEntete=@idBookingEntete
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_Caissier](
	[idCaissier] [int] IDENTITY(1,1) NOT NULL,
	[nameCaissier] [nvarchar](200) NULL,
	[passCaissier] [nvarchar](100) NULL,
	[adminCaissier] [bit] NULL,
	[avoirCheck] [bit] NULL,
	[prixCheck] [bit] NULL,
	[remCheck] [bit] NULL,
	[fermerCheck] [bit] NULL,
	[archiveChecke] [bit] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[anulatinTicket] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCaissier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_Ticket](
	[idTicket] [int] IDENTITY(1,1) NOT NULL,
	[numTicket] [int] NULL,
	[total] [money] NULL,
	[dateCreation] [datetime] NULL,
	[idCaissier] [int] NULL,
	[isCancel] [bit] NULL,
	[dateCancel] [datetime] NULL,
	[isClosed] [bit] NULL,
	[idSession] [int] NULL,
	[idClient] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [p_tableTicket]
as
select e.*,cl.nomClient,c.nameCaissier from p_Ticket e
inner join P_Caissier c on c.idCaissier=e.idCaissier
left join t_Client cl on cl.idClient=e.idClient
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_Ticket_ligne](
	[idLigne] [int] IDENTITY(1,1) NOT NULL,
	[idTicket] [int] NULL,
	[dateCreation] [datetime] NULL,
	[idproduct] [int] NULL,
	[price] [money] NULL,
	[umvente] [varchar](20) NULL,
	[qte] [int] NULL,
	[rem] [float] NULL,
	[total] [money] NULL,
	[checkVenduGrand] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLigne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [a_Article](
	[idArticle] [int] IDENTITY(1,1) NOT NULL,
	[refArticle] [nvarchar](500) NULL,
	[codeBareArticle] [nvarchar](500) NULL,
	[nomArticle] [nvarchar](500) NULL,
	[descArticle] [nvarchar](500) NULL,
	[favorisArticle] [bit] NULL,
	[photoArticle] [nvarchar](500) NULL,
	[achatArticle] [bit] NULL,
	[venteArticle] [bit] NULL,
	[locationArticle] [bit] NULL,
	[typeArticle] [nvarchar](500) NULL,
	[prixAchat_HT] [money] NULL,
	[prixAchat_HT_1] [money] NULL,
	[prixAchat_TTC] [money] NULL,
	[prixAchat_TTC_1] [money] NULL,
	[prixVente_HT] [money] NULL,
	[prixVente_HT_1] [money] NULL,
	[prixVente_TTC] [money] NULL,
	[prixVente_TTC_1] [money] NULL,
	[prixlocation_HT] [money] NULL,
	[prixlocation_TTC] [money] NULL,
	[classmentArticle] [nvarchar](250) NULL,
	[stkMinArticle] [float] NULL,
	[wooArticle] [bit] NULL,
	[idWooProducts] [int] NULL,
	[metaWooArticle] [nvarchar](max) NULL,
	[metaArticle] [nvarchar](max) NULL,
	[pourCentArticle] [float] NULL,
	[createDate] [datetime] NULL,
	[idFamille] [int] NULL,
	[idTaxeAchat] [int] NULL,
	[idTaxeVente] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[qteBox] [float] NULL,
	[checkDureDevie] [bit] NULL,
	[stateDureDevie] [nvarchar](100) NULL,
	[dureDevie] [int] NULL,
	[prixVente_HT_2] [money] NULL,
	[prixVente_TTC_2] [money] NULL,
	[checkBateau] [bit] NULL,
	[mesureArticle] [nvarchar](50) NULL,
	[idUnite] [int] NULL,
	[checkMaintenance] [bit] NULL,
	[codePdFini] [int] NULL,
	[PdFini] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idArticle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [p_tableTicketLigne]
as
select tl.*,a.nomArticle from p_Ticket_ligne tl
inner join a_Article a on a.idArticle=tl.idproduct
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [fish_NomScientifique](
	[idNomScientifique] [bigint] IDENTITY(1,1) NOT NULL,
	[NomScientifique] [nvarchar](max) NULL,
	[idGroup] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNomScientifique] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [fish_TypeFamaille](
	[idTypeFamaille] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeFamaille] [nvarchar](max) NULL,
	[idGroup] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTypeFamaille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [a_Famille](
	[idFamille] [int] IDENTITY(1,1) NOT NULL,
	[nomFamille] [nvarchar](250) NULL,
	[desFamille] [nvarchar](500) NULL,
	[photoFamille] [nvarchar](max) NULL,
	[wooFamille] [bit] NULL,
	[parentId] [int] NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idWooCategories] [int] NULL,
	[idTypeFamaille] [bigint] NULL,
	[idNomScientifique] [bigint] NULL,
	[CDE_FAO] [nvarchar](max) NULL,
	[idPays] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFamille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [a_FamilleSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select a.*,t.TypeFamaille as nomTypeFamille,fn.NomScientifique,bp.nomPays from a_Famille a inner join fish_TypeFamaille t on a.idTypeFamaille=t.idTypeFamaille
	inner join fish_NomScientifique fn on a.idNomScientifique=fn.idNomScientifique
	left join b_Pays bp on a.idPays=bp.idPays
	where ((@SelectALL=1 and  a.idUser=@idUser) or (@SelectALL=0 and a.idGroup=@idGroup))



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Calcul_Avance](
	[idAvance] [int] IDENTITY(1,1) NOT NULL,
	[idEmploye] [int] NULL,
	[dateAvance] [datetime] NULL,
	[createDate] [datetime] NULL,
	[montant] [money] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[cloturer] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idAvance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [Paie_Calcul_tableAvance]
  as 
  select a.*,e.matricule,(e.nomEmployee+' '+e.prenomEmployee) as nomEmploye from Paie_Calcul_Avance a
  inner join Paie_E_Employe e on e.idEmploye=a.idEmploye
  inner join s_Users u on e.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_Propriete](
	[idPropriete] [int] IDENTITY(1,1) NOT NULL,
	[nomPropriete] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPropriete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [b_ProprieteSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from b_Propriete where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Calcul_Conges](
	[idCng] [int] IDENTITY(1,1) NOT NULL,
	[idEmploye] [int] NULL,
	[periodeDebut] [datetime] NULL,
	[periodeFin] [datetime] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idDossier] [int] NULL,
	[nbJours] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCng] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [Paie_Calcul_tableConges]
  as 
  select c.*,(e.nomEmployee+' '+e.prenomEmployee) as nomEmployee from Paie_Calcul_Conges c
  inner join Paie_E_Employe e on e.idEmploye=c.idEmploye
  inner join s_Users u on e.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Calcul_Entete](
	[idEntete] [int] IDENTITY(1,1) NOT NULL,
	[idEmploye] [int] NULL,
	[idGrpEnt] [int] NULL,
	[salaireBase] [money] NULL,
	[totalBrut] [money] NULL,
	[createDate] [datetime] NULL,
	[joursTravail] [float] NULL,
	[hS0] [float] NULL,
	[hS25] [float] NULL,
	[hS50] [float] NULL,
	[hS100] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEntete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [Paie_Calcul_tableEntete]
  as 
  select c.*,(e.nomEmployee+' '+e.prenomEmployee) as nomEmployee, e.matricule
  from Paie_Calcul_Entete c
  inner join Paie_E_Employe e on c.idEmploye=e.idEmploye
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [e_Emails](
	[idEmail] [int] IDENTITY(1,1) NOT NULL,
	[to] [nvarchar](max) NULL,
	[subject] [nvarchar](max) NULL,
	[message] [nvarchar](max) NULL,
	[uid] [nvarchar](200) NULL,
	[folder] [nvarchar](300) NULL,
	[createDate] [datetime] NULL,
	[dateEmail] [datetime] NULL,
	[attachements] [nvarchar](max) NULL,
	[seen] [bit] NULL,
	[fromName] [nvarchar](max) NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [e_EmailsSelect](
@dateD datetime, 
@dateE datetime,
@folder nvarchar(300)='Sent',
@idGroup int=null
)
returns table
as
	return	select * from e_Emails where idGroup=@idGroup
			and cast(createDate as date) between cast(@dateD as date) and cast(@dateE as date) and folder=@folder
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Z_LogData](
	[idLogData] [int] IDENTITY(1,1) NOT NULL,
	[idUserDevice] [int] NULL,
	[dateTimeRecord] [datetime] NULL,
	[uniqueId] [nvarchar](100) NULL,
	[createDate] [datetime] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[timeRecord] [time](7) NULL,
	[idEmploye] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLogData] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Z_Planning](
	[idPlanning] [int] IDENTITY(1,1) NOT NULL,
	[nomPlanning] [nvarchar](500) NULL,
	[heureDepartDe] [time](7) NULL,
	[heureDepartA] [time](7) NULL,
	[heurePauseDe] [time](7) NULL,
	[heurePauseA] [time](7) NULL,
	[heureSortie] [time](7) NULL,
	[checkPause] [bit] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPlanning] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Z_ZKTDevices](
	[idDevice] [int] IDENTITY(1,1) NOT NULL,
	[nameDevice] [nvarchar](500) NULL,
	[ipDevice] [nvarchar](200) NULL,
	[portDevice] [int] NULL,
	[machingNumber] [int] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDevice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [Paie_Z_tablePointage]
  as 
   select (e.nomEmployee+' '+e.prenomEmployee) as nomEmploye,
   CASE WHEN l2.timeRecord IS NULL  THEN l2.timeRecord
       ELSE l2.timeRecord
       end as timeRecord,
   CASE WHEN l2.dateTimeRecord IS NULL  THEN l2.dateTimeRecord
       ELSE l2.dateTimeRecord
       end as dateTimeRecord,z.nameDevice,p.nomPlanning,
  CASE WHEN l2.timeRecord between p.heureDepartDe and p.heureDepartA THEN 'Entrée'
	   WHEN l2.timeRecord between p.heurePauseDe and p.heurePauseA THEN 'Pause'
       WHEN l2.timeRecord = heureSortie THEN 'Sortie'
       ELSE 'Hors HP'
       end as descriptionPlanning,u.enrolNumber,l2.idLogData,e.*
  from Paie_E_Employe e
  left join Paie_Z_Planning p on e.idPlanning= p.idPlanning
  --left join Paie_Z_LogData l on e.idUserDevice=l.idUserDevice
  left join Paie_Z_LogData l2 on e.idEmploye=l2.idEmploye
  left join Paie_Z_UserDevice u on e.idUserDevice=u.idUserDevice
  left join Paie_Z_ZKTDevices z on u.idDevice=z.idDevice
  left join s_Users us on e.idUser=us.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [e_TypeDoc](
	[codeType] [varchar](20) NOT NULL,
	[idDossier] [int] NOT NULL,
	[numFacture] [int] NULL,
	[nomFacture] [nvarchar](250) NULL,
	[descType] [nvarchar](100) NULL,
	[valStock] [int] NULL,
	[valCmup] [int] NULL,
	[valFifo] [int] NULL,
	[valLifo] [int] NULL,
	[valCaisse] [int] NULL,
	[codeCl_FR] [int] NULL,
	[calculMarge] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codeType] ASC,
	[idDossier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [e_EntetGetValCmupStock](
@idDossier int=null,
@codeType varchar(20)
)
returns table
as
	return	select * from e_TypeDoc where codeType=@codeType and idDossier=@idDossier
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [Paie_Z_tableUserDevice]
  as 
  select u.*,z.nameDevice
  from Paie_Z_UserDevice u
  inner join Paie_Z_ZKTDevices z on u.idDevice=z.idDevice
  inner join s_Users us on u.idUser=us.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [e_EntetLastNum](
	@idDossier int,
	@codeType varchar(20))
	returns table
	as
		return	select numFacture+1 as numFacture from e_TypeDoc where idDossier=@idDossier and codeType=@codeType
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [r_Reglement](
	[idReglement] [int] IDENTITY(1,1) NOT NULL,
	[numReglement] [int] NULL,
	[dateReglement] [datetime] NULL,
	[banque] [nvarchar](100) NULL,
	[numCheque] [nvarchar](100) NULL,
	[dateEcheanche] [datetime] NULL,
	[nom] [nvarchar](100) NULL,
	[info] [nvarchar](200) NULL,
	[etatReg] [nvarchar](100) NULL,
	[idModRglm] [int] NULL,
	[idTreso] [int] NULL,
	[idClient] [int] NULL,
	[idFournisseur] [int] NULL,
	[codeType] [varchar](20) NULL,
	[idUser] [nvarchar](450) NULL,
	[idDossier] [int] NULL,
	[idEntet] [int] NULL,
	[idGroup] [int] NULL,
	[montant] [money] NULL,
	[createDate] [datetime] NULL,
	[idEntetFish] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idReglement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [t_Fournisseur](
	[idFournisseur] [int] IDENTITY(1,1) NOT NULL,
	[codeFournisseur] [nvarchar](50) NULL,
	[nomFournisseur] [nvarchar](200) NULL,
	[adresseFournisseur] [nvarchar](200) NULL,
	[postalFournisseur] [nvarchar](50) NULL,
	[iceFournisseur] [nvarchar](50) NULL,
	[cnssFournisseur] [nvarchar](50) NULL,
	[nifFournisseur] [nvarchar](50) NULL,
	[patenteFournisseur] [nvarchar](50) NULL,
	[siegeFournisseur] [nvarchar](50) NULL,
	[banqueFournisseur] [nvarchar](50) NULL,
	[ribFournisseur] [nvarchar](50) NULL,
	[soldAutoriseFournisseur] [money] NULL,
	[frmJuridiqueFournisseur] [nvarchar](50) NULL,
	[emailFournisseur] [nvarchar](250) NULL,
	[teleFournisseur] [nvarchar](250) NULL,
	[fixFournisseur] [nvarchar](250) NULL,
	[typeFournisseur] [nvarchar](250) NULL,
	[contratFournisseur] [bit] NULL,
	[fournisseur] [bit] NULL,
	[sous_traitance] [bit] NULL,
	[createdate] [datetime] NULL,
	[idVille] [int] NULL,
	[idPays] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[cinFournisseur] [nvarchar](50) NULL,
	[potentielFR] [nvarchar](500) NULL,
	[categorieFR] [nvarchar](500) NULL,
	[origineContactFR] [nvarchar](500) NULL,
	[sitewebFr] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idFournisseur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [r_tableReglement]
  as 
  select r.*,m.nomModRglm,t.nameTreso,u.nomUser,c.codeClient,c.nomClient,f.codeFournisseur,f.nomFournisseur from r_Reglement r
  left join b_ModRglm m on r.idModRglm=m.idModRglm
  left join b_Tresorerie t on r.idTreso=t.idTreso
  inner join s_Users u on r.idUser=u.idUser
  left join t_Client c on c.idClient=r.idClient
  left join t_Fournisseur f on f.idFournisseur=r.idFournisseur
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tr_TresorerieEntet](
	[idTresoEntet] [int] IDENTITY(1,1) NOT NULL,
	[numTresoEntet] [int] NULL,
	[dateTresoEntet] [datetime] NULL,
	[dateEcheanche] [datetime] NULL,
	[banque] [nvarchar](150) NULL,
	[numCheque] [nvarchar](150) NULL,
	[etatDoc] [nvarchar](50) NULL,
	[montant] [money] NULL,
	[descTresoEntet] [nvarchar](300) NULL,
	[codeType] [varchar](20) NULL,
	[idModRglm] [int] NULL,
	[idTreso] [int] NULL,
	[idTreso_2] [int] NULL,
	[idService] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idDossier] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTresoEntet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_Service](
	[idService] [int] IDENTITY(1,1) NOT NULL,
	[nomService] [nvarchar](200) NULL,
	[descService] [nvarchar](300) NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idService] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [tr_tableTresorerieEntet]
  as
  select tr.*,m.nomModRglm,t.nameTreso,t2.nameTreso as nameTreso_2,s.nomService,u.nomUser from tr_TresorerieEntet tr
  left join b_ModRglm m on  tr.idModRglm=m.idModRglm
  left join b_Tresorerie t on tr.idTreso=t.idTreso
  left join b_Tresorerie t2 on tr.idTreso_2=t2.idTreso
  left join b_Service s on tr.idService=s.idService
  inner join s_Users u on tr.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [e_Entet](
	[idEntet] [int] IDENTITY(1,1) NOT NULL,
	[numFactur] [int] NULL,
	[refFactur] [nvarchar](50) NULL,
	[dateEntet] [datetime] NULL,
	[dateEcheanche] [datetime] NULL,
	[nom] [nvarchar](150) NULL,
	[info] [nvarchar](150) NULL,
	[valider] [bit] NULL,
	[clotur] [bit] NULL,
	[TT_ttc] [money] NULL,
	[TT_ht] [money] NULL,
	[TT_tva] [money] NULL,
	[TT_remis] [money] NULL,
	[TT_MargeCmup] [money] NULL,
	[TT_MargePxAcha] [money] NULL,
	[TT_TauxMargeCmup] [money] NULL,
	[TT_TauxMargePxAcha] [money] NULL,
	[timbre] [bit] NULL,
	[TT_net] [money] NULL,
	[avance] [money] NULL,
	[etatDoc] [nvarchar](50) NULL,
	[numCheq] [nvarchar](50) NULL,
	[remiseGlobal] [money] NULL,
	[teypGlobal] [bit] NULL,
	[tva] [bit] NULL,
	[ttc] [bit] NULL,
	[obs] [nvarchar](100) NULL,
	[checkExpiration] [bit] NULL,
	[meta] [nvarchar](max) NULL,
	[createDate] [datetime] NULL,
	[idModRglm] [int] NULL,
	[idDepot] [int] NULL,
	[idDepot_2] [int] NULL,
	[idClient] [int] NULL,
	[idFournisseur] [int] NULL,
	[codeType] [varchar](20) NULL,
	[idDossier] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idVendeur] [int] NULL,
	[terms] [nvarchar](max) NULL,
	[metaImpression] [nvarchar](max) NULL,
	[proprieteClient] [nvarchar](max) NULL,
	[typeLigne] [nvarchar](500) NULL,
	[dateValidation] [datetime] NULL,
	[checkCopierVers] [bit] NULL,
	[idFamille] [int] NULL,
	[idDestinataire] [int] NULL,
	[nomDestinataire] [nvarchar](max) NULL,
	[truck] [nvarchar](max) NULL,
	[tauxPlastique] [float] NULL,
	[SumNetWeight] [float] NULL,
	[SumUnitePrice] [float] NULL,
	[changeDH] [float] NULL,
	[certificatEuro] [nvarchar](max) NULL,
	[LotePF] [nvarchar](max) NULL,
	[MtPremier] [nvarchar](max) NULL,
	[NumeroTaux] [int] NULL,
	[lote] [nvarchar](max) NULL,
	[TauxGalce] [float] NULL,
	[InternationalCheck] [bit] NULL,
	[PesoBruto] [float] NULL,
	[MateriaPrima] [float] NULL,
	[PesoNetoEscurido] [float] NULL,
	[PesoNeto] [float] NULL,
	[idEntetS] [int] NULL,
	[expeditoP_plt] [nvarchar](max) NULL,
	[fechaP_plt] [date] NULL,
	[factureP_plt] [nvarchar](max) NULL,
	[quantiteP_plt] [float] NULL,
	[expeditoLP_plt] [nvarchar](max) NULL,
	[fechaLP_plt] [date] NULL,
	[factureLP_plt] [nvarchar](max) NULL,
	[quantiteLP_plt] [float] NULL,
	[DETLP_plt] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEntet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [et_ActiviteClients]
(
@dateCompStart datetime=null,
@dateCompEnd datetime =null,
@dateStart datetime=null,
@dateEnd datetime =null,
@idGroup int
)
returns table
as return
	select
	c.idClient,
    c.codeClient,
    c.nomClient,
    sum(case when e.dateEntet between @dateCompStart and @dateCompEnd then e.TT_ht else 0 end) as chiffreAffCompare,
    (sum(case when e.dateEntet between @dateCompStart and @dateCompEnd then e.TT_ht else 0 end) * 100) / 
        (select sum(e.TT_ht) from t_Client c
        inner join e_Entet e on e.idClient = c.idClient
        where e.dateEntet between @dateCompStart and @dateCompEnd 
        and e.codeType = 'BLFC'
        and e.valider = 1) as tauxCompare,
    sum(case when e.dateEntet between @dateStart and @dateEnd then e.TT_ht else 0 end) as chiffreAff,
    (sum(case when e.dateEntet between @dateStart and @dateEnd then e.TT_ht else 0 end) * 100) / 
        (select sum(e.TT_ht) from t_Client c
        inner join e_Entet e on e.idClient = c.idClient
        where e.dateEntet between @dateStart and @dateEnd 
        and e.codeType = 'BLFC'
        and e.valider = 1) as taux
		from t_Client c
		inner join e_Entet e on e.idClient = c.idClient
		where ((e.dateEntet between @dateCompStart and @dateCompEnd) or (e.dateEntet between @dateStart and @dateEnd))
		and e.codeType = 'BLFC'
		and e.valider = 1 and e.idGroup=@idGroup
		group by c.codeClient, c.nomClient, c.idClient
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [e_EntetLign](
	[idLign] [int] IDENTITY(1,1) NOT NULL,
	[idEntet] [int] NULL,
	[idArticle] [int] NULL,
	[refArticle] [nvarchar](500) NULL,
	[descLign] [nvarchar](max) NULL,
	[qteLign] [float] NULL,
	[prixTTC] [money] NULL,
	[prixHT] [money] NULL,
	[lgnTTC] [money] NULL,
	[lgnHT] [money] NULL,
	[lgnRemise] [money] NULL,
	[lgnTVA] [money] NULL,
	[lgnCmup] [money] NULL,
	[lgnMargeCmup] [money] NULL,
	[lgnMargePxAcha] [money] NULL,
	[lgnTauxMargeCmup] [money] NULL,
	[lgnTauxMargePxAcha] [money] NULL,
	[valStock] [int] NULL,
	[valCmup] [int] NULL,
	[dateExpiration] [datetime] NULL,
	[meta] [nvarchar](max) NULL,
	[lgnUnite] [nvarchar](100) NULL,
	[lgnUrgence] [nvarchar](100) NULL,
	[idSupDepot] [int] NULL,
	[idSupDepot_2] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[createDate] [datetime] NULL,
	[lgnValeurCmup] [money] NULL,
	[lgnValeurPxAcha] [money] NULL,
	[lgnPxAcha] [money] NULL,
	[lastQte] [float] NULL,
	[dateLigne] [nvarchar](100) NULL,
	[sortOrder] [int] NULL,
	[PackageEmvase] [float] NULL,
	[GrossWeight] [float] NULL,
	[drainedNetWeight] [float] NULL,
	[NetWeight] [float] NULL,
	[frozenDate] [nvarchar](max) NULL,
	[lote] [nvarchar](max) NULL,
	[DuaLigne] [nvarchar](max) NULL,
	[LotePfLigne] [nvarchar](max) NULL,
	[PesoNetoLigne] [float] NULL,
	[DateCongelationLigne] [date] NULL,
	[codePdFini] [nvarchar](max) NULL,
	[qtebyDua] [float] NULL,
	[SinAgua] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLign] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [et_RentabiliteClients]
(
@dateStart datetime=null,
@dateEnd datetime =null,
@idGroup int
)
returns table
as return
	select c.idClient ,c.codeClient, c.nomClient, count(distinct e.idEntet) as 'Nb Documents',
    sum(l.lgnHT*l.valStock*-1) as 'CA HT NET',
    sum(l.lgnMargeCmup*l.valStock*-1) as 'Marge',
    ((sum(l.lgnMargeCmup*l.valStock*-1))/(sum(l.lgnHT*l.valStock*-1)))*100 as 'MargeSurCA'
	from e_Entet e 
	inner join e_EntetLign l on e.idEntet=l.idEntet
	inner join a_Article a on l.idArticle=a.idArticle
	inner join t_Client c on c.idClient=e.idClient
	inner join e_TypeDoc t on e.codeType=t.codeType
	where t.calculMarge=1 
		and e.dateEntet between @dateStart and @dateEnd
		and l.qteLign<>0 
		and l.lgnValeurCmup<>0
		and e.idGroup=@idGroup
	group by c.codeClient, c.nomClient,c.idClient
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [fish_entet](
	[idEntet] [int] IDENTITY(1,1) NOT NULL,
	[numFactur] [int] NULL,
	[refFacture] [nvarchar](max) NULL,
	[idFournisseur] [int] NULL,
	[dateEntet] [date] NULL,
	[idPays] [int] NULL,
	[ETAT] [nvarchar](max) NULL,
	[idFamille] [int] NULL,
	[stockEntree] [float] NULL,
	[stockTaxable] [float] NULL,
	[totalAchat] [float] NULL,
	[PM] [float] NULL,
	[totalCharges] [float] NULL,
	[comission] [float] NULL,
	[idDossier] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idClient] [int] NULL,
	[codeType] [nvarchar](max) NULL,
	[idPort] [int] NULL,
	[kgRec] [float] NULL,
	[valider] [bit] NULL,
	[etatDoc] [nvarchar](50) NULL,
	[clotur] [bit] NULL,
	[barco] [nvarchar](max) NULL,
	[TotalCais] [float] NULL,
	[TotalPN] [float] NULL,
	[Lote] [nvarchar](max) NULL,
	[DUA] [nvarchar](max) NULL,
	[dateCongele] [date] NULL,
	[idEntetS] [int] NULL,
	[numBon_plt] [nvarchar](max) NULL,
	[quantite_plt] [float] NULL,
	[facturNum_plt] [nvarchar](max) NULL,
	[dua_plt] [nvarchar](max) NULL,
	[date_plt] [date] NULL,
	[numBonL_plt] [nvarchar](max) NULL,
	[quantiteL_plt] [float] NULL,
	[dateL_plt] [date] NULL,
	[facturNumL_plt] [nvarchar](max) NULL,
	[duaL_plt] [nvarchar](max) NULL,
	[LoteL_plt] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEntet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [fish_port](
	[idPort] [int] IDENTITY(1,1) NOT NULL,
	[nomPort] [nvarchar](max) NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPort] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE VIEW [v_fish_EntetSelect] AS
select fe.*,tf.nomFournisseur,ff.nomFamille,fp.nomPort,su.nomUser
	from fish_entet as fe left join a_Famille as ff on fe.idFamille=ff.idFamille
	left join fish_Port as fp on fe.idPort=fp.idPort
	left join t_Fournisseur as tf on fe.idFournisseur=tf.idFournisseur
	left join s_Users as su on fe.idUser=su.idUser

	--select * from fish_entet



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [f_Fabrication](
	[idFabrication] [int] IDENTITY(1,1) NOT NULL,
	[idArticle] [int] NULL,
	[reference] [nvarchar](200) NULL,
	[info] [nvarchar](250) NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[createDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFabrication] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [f_tableFabrication]
  as 
	select f.*,a.nomArticle,a.codeBareArticle,a.refArticle,u.nomUser from f_Fabrication f
	inner join a_Article a on f.idArticle=a.idArticle
	inner join s_Users u on f.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [f_FabricationSelect](
			@idUser nvarchar(450),
			@SelectDoc bit=null,
			@idGroup int=null
			)
			returns table
			as
				return	select * from f_tableFabrication where ((@SelectDoc=1 and  idUser=@idUser) or (@SelectDoc=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_P_POINTAGE](
	[idPointage] [int] IDENTITY(1,1) NOT NULL,
	[createdDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[mois] [nvarchar](max) NULL,
	[descrPointage] [nvarchar](max) NULL,
	[numPointage] [int] NULL,
	[idDossier] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPointage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_P_POINTAGE_LIGNE](
	[idPointageLigne] [int] IDENTITY(1,1) NOT NULL,
	[idEmploye] [int] NULL,
	[HeureEntree] [time](7) NULL,
	[HeureSortire] [time](7) NULL,
	[kgs] [float] NULL,
	[idPointage] [int] NULL,
	[heureSupp] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPointageLigne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [Paie_P_tablePointageLigne]
  as 
  --SELECT TOP (1000) [idPointageLigne]
  --    ,[idEmploye]
  --    ,[HeureEntree]
  --    ,[HeureSortire]
  --    ,[kgs]
  --FROM [ITTONE_ERP_V1].[dbo].[Paie_P_POINTAGE_LIGNE]
   select pl.*,pe.nomEmployee,pe.matricule,pe.prenomEmployee,p.createdDate,pe.typePaie from Paie_P_POINTAGE_LIGNE pl 
   inner join Paie_P_POINTAGE p on pl.idPointage=p.idPointage
   inner join Paie_E_Employe pe on pl.idEmploye=pe.idEmploye

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [et_StatistiquesClientsparFam]
(
@dateStart datetime=null,
@dateEnd datetime =null,
@idGroup int
)
returns table
as return	
	select
	  e.codeType,
	  e.idClient,
	  f.nomFamille as famille,
	  a.refArticle as reference,
	  a.nomArticle as designation,
	  sum(eL.lgnHT) as CA_NET_HT,
	  sum(eL.lgnRemise) as remiseHT,
	  sum(eL.lgnHT) - sum(a.prixAchat_HT * eL.qteLign) as MargeHT,
	  ((sum(eL.lgnHT) - sum(a.prixAchat_HT * eL.qteLign)) / (sum(eL.lgnHT)))*100 as MargeHTSurCA,
	  sum(eL.lgnTTC) as CA_NET_TTC,
	  sum(eL.lgnRemise) as remiseTTC,
	  sum(eL.lgnTTC) - sum(a.prixAchat_TTC * eL.qteLign) as MargeTTC,
	  ((sum(eL.lgnTTC) - sum(a.prixAchat_TTC * eL.qteLign)) / (sum(eL.lgnTTC)))*100 as MargeTTCSurCA
	from
	  e_Entet e
	  inner join e_EntetLign eL on eL.idEntet = e.idEntet
	  inner join e_TypeDoc t on t.codeType = e.codeType
	  inner join a_Article a on a.idArticle = eL.idArticle
	  inner join a_Famille f on f.idFamille = a.idFamille
	where
	  e.dateEntet between @dateStart and @dateEnd and e.idGroup=@idGroup 
	  
	group by
	  f.nomFamille,
	  a.refArticle,
	  a.nomArticle,
	  e.idClient,
	  e.codeType
	having 
	sum(eL.prixHT)<>0 and sum(eL.lgnHT)<>0 and sum(eL.lgnTTC)<>0 and sum(eL.prixTTC)<>0
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [d_Departement](
	[idDepartement] [int] IDENTITY(1,1) NOT NULL,
	[nomDepartement] [nvarchar](200) NULL,
	[descDepartement] [nvarchar](200) NULL,
	[idGroup] [int] NOT NULL,
	[idUser] [nvarchar](450) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDepartement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [d_tableDepartement]
  as 
  select d.*,u.nomUser from d_Departement d 
  left join s_Users u on u.idUser=d.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [d_DepartementSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from d_tableDepartement where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [e_Art_Depot](
	[idArticle] [int] NULL,
	[idDepot] [int] NULL,
	[idSupDepot] [int] NULL,
	[qteDepot] [float] NULL,
	[cmup] [money] NULL,
	[lastPrix] [money] NULL,
	[firstPrix] [money] NULL,
	[idDossier] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [f_FabricationLign](
	[idLignFab] [int] IDENTITY(1,1) NOT NULL,
	[idFabrication] [int] NULL,
	[idLignArticle] [int] NULL,
	[qteFabrication] [float] NULL,
	[qteLignFabrication] [float] NULL,
	[createDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLignFab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [f_listArticleStock](
@idFabrication int,
@idDepot int,
@idDossier int,
@QtOrdre float
)
returns table
as
	return	select a.refArticle,e.qteDepot,(fl.qteLignFabrication*@QtOrdre) as 'qte',e.qteDepot-(fl.qteLignFabrication *@QtOrdre) as 'qteInstock',
			a.nomArticle from f_FabricationLign fl 
			inner join e_Art_Depot e on fl.idLignArticle=e.idArticle
			inner join a_Article a on a.idArticle=fl.idLignArticle
			   where fl.idFabrication=@idFabrication and e.idDepot =@idDepot and e.idDossier=@idDossier
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [a_Bateau](
	[idBateau] [int] IDENTITY(1,1) NOT NULL,
	[idArticle] [int] NULL,
	[idClient] [int] NULL,
	[dimensionX] [float] NULL,
	[dimensionY] [float] NULL,
	[prixM] [money] NULL,
	[checkCollaboration] [bit] NULL,
	[dateDebut] [datetime] NULL,
	[dateFin] [datetime] NULL,
	[valider] [bit] NULL,
	[clotur] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBateau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [a_tableBateau] 
  as
  select b.*,a.photoArticle,a.nomArticle,a.refArticle,a.prixVente_HT,a.prixVente_TTC,u.nomUser,a.idUser,a.idGroup
  from a_Bateau b 
  inner join a_Article a on a.idArticle=b.idArticle
  inner join s_Users u on a.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [a_BateauSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from a_tableBateau where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_B_BookingEntete](
	[idBookingEntete] [int] IDENTITY(1,1) NOT NULL,
	[bookingInDate] [datetime] NULL,
	[bookingOutDate] [datetime] NULL,
	[tt_NbGuest] [int] NULL,
	[createDate] [datetime] NULL,
	[idClient] [int] NULL,
	[checkIn] [bit] NULL,
	[checkInDate] [datetime] NULL,
	[checkOut] [bit] NULL,
	[checkOutDate] [datetime] NULL,
	[message] [nvarchar](max) NULL,
	[comment] [nvarchar](max) NULL,
	[cancel] [bit] NULL,
	[cancelDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idDossier] [int] NULL,
	[numBooking] [int] NULL,
	[nbNights] [int] NULL,
	[infoClients] [nvarchar](max) NULL,
	[totalEnteteHT] [money] NULL,
	[totalEnteteTTC] [money] NULL,
	[totalEnteteUnPaye] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBookingEntete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [hotel_B_BookingEnteteLastNum](
	@idDossier int)
	returns table
	as
		return	select top 1 ISNULL(numBooking,0)as numBooking from hotel_B_BookingEntete e where idDossier=@idDossier order by numBooking desc
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE view [e_tableEntet]
as
 select e.*,d.nomDepot,d2.nomDepot as nomDepot_2,af.nomFamille,m.nomModRglm,c.nomClient,f.nomFournisseur,u.nomUser,c.iceClient,f.iceFournisseur,
 c.codeClient,f.codeFournisseur,v.nomClient as 'NomVendeur' ,ds.adresseClient as  adresseDestinataire ,bv.nomVille as villeDestinataire,c.incoterms
 ,bvc.nomVille as villeClient,bp.nomPays as paysDestinataire,bpc.nomPays as paysClient,c.adresseClient
 from	e_Entet	e
 left join b_Depot d on e.idDepot=d.idDepot
 left join b_Depot d2 on e.idDepot_2=d2.idDepot
 left join b_ModRglm m on e.idModRglm=m.idModRglm
 left join t_Client c on e.idClient=c.idClient
 left join t_Client v on v.idClient=e.idVendeur 
 left join t_Client ds on e.idDestinataire=ds.idClient 
 left join t_Fournisseur f on e.idFournisseur=f.idFournisseur
 left join fish_entet fe on e.refFactur=fe.refFacture
 left join a_Famille af on af.idFamille=e.idFamille
 left join s_Users u on e.idUser=u.idUser
 left join b_Ville bvc on c.idVille=bvc.idVille
 left join b_Ville bv on ds.idVille=bv.idVille
left join b_Pays bpc on c.idPays=bpc.idPays
 left join b_Pays bp on ds.idPays=bp.idPays

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [et_MouvementsClients]
(
@dateStart datetime=null,
@dateEnd datetime =null,
@idGroup int
)
returns table
as return
		select e.idClient,(case when e.codeType='BCC' then ('BC0'+CAST(e.numFactur AS nvarchar)) else ('BL0'+CAST(e.numFactur AS nvarchar)) end)
		as numFact, a.nomArticle, e.dateEntet,  l.qteLign, l.prixHT, d.descType, d.valCaisse, l.lgnCmup as CMUP,l.lgnMargeCmup as Marge,e.codeType
		from e_tableEntet e
		inner join e_TypeDoc d ON e.codeType = d.codeType
		inner join e_EntetLign l on l.idEntet=e.idEntet
		inner join a_Article a on a.idArticle=l.idArticle
		where e.dateEntet between @dateStart and @dateEnd and e.idGroup=@idGroup
		group by e.idClient,e.numFactur, a.nomArticle, e.dateEntet, l.qteLign, l.prixHT, d.descType, d.valCaisse,e.codeType, l.lgnCmup ,
		l.lgnMargeCmup,e.codeType
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_S_Categorie](
	[idCategorie] [int] IDENTITY(1,1) NOT NULL,
	[categName] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategorie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [hotel_S_CategorieSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from hotel_S_Categorie where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [fish_entetLign](
	[idLign] [int] IDENTITY(1,1) NOT NULL,
	[idEntet] [int] NULL,
	[idFamille] [int] NULL,
	[descLign] [nvarchar](max) NULL,
	[calibre] [nvarchar](max) NULL,
	[quantite] [float] NULL,
	[prix] [float] NULL,
	[prixTotal] [float] NULL,
	[CodePLT] [nvarchar](max) NULL,
	[PN] [float] NULL,
	[cais] [float] NULL,
	[caisINVT] [float] NULL,
	[PNINVT] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLign] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE view [e_fishtableEntetLign]
as 
select fe.*,f.nomFamille from fish_entetLign fe 
left join a_Famille f on fe.idFamille=f.idFamille

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [e_FishEntetLignSelect](
@idEntet int=null
)
returns table
as
	return	
	select * from e_fishtableEntetLign where idEntet=@idEntet 
	--WITH CTE AS (
	--	SELECT *
	--	FROM e_tableEntetLign
	--	WHERE idEntet = @idEntet
	--)
	--SELECT *
	--FROM CTE
	--ORDER BY dateLigne ASC;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_S_Extras](
	[idExtras] [int] IDENTITY(1,1) NOT NULL,
	[extrasName] [nvarchar](500) NULL,
	[descExtras] [nvarchar](max) NULL,
	[prix_HT] [money] NULL,
	[idTaxeExtras] [int] NULL,
	[prix_TTC] [money] NULL,
	[sortExtras] [int] NULL,
	[qteMax] [nvarchar](500) NULL,
	[photoExtras] [nvarchar](max) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idExtras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [hotel_S_ExtrasSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from hotel_S_Extras where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [hotel_S_RoomTypeSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from hotel_S_RoomType where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Maint_S_Member](
	[idMember] [int] IDENTITY(1,1) NOT NULL,
	[idEmploye] [int] NULL,
	[idFournisseur] [int] NULL,
	[idTeam] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Maint_S_Team](
	[idTeam] [int] IDENTITY(1,1) NOT NULL,
	[nomTeam] [nvarchar](500) NULL,
	[typeTeam] [nvarchar](500) NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTeam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [Maint_tableTeam]
as
select t.*,
	ISNULL(STUFF((SELECT ' , '+  CASE t.typeTeam 
       WHEN 'interieur' THEN e.nomEmployee+' '+e.prenomEmployee
       WHEN 'exterieur' THEN f.nomFournisseur
       ELSE null
	END from Maint_S_Member m 
	left join t_Fournisseur f on f.idFournisseur=m.idFournisseur
	left join Paie_E_Employe e on e.idEmploye=m.idEmploye
    FOR XML PATH ('')),1,2,''),'') AS nom
	 from Maint_S_Team t
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Maint_A_Equipements](
	[idEquipement] [int] IDENTITY(1,1) NOT NULL,
	[modeleEquipement] [nvarchar](max) NULL,
	[numeroSerie] [nvarchar](250) NULL,
	[coutEquipement] [money] NULL,
	[dateGarantie] [datetime] NULL,
	[dateEffet] [datetime] NULL,
	[idLign] [int] NULL,
	[idArticle] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEquipement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Maint_A_EquipementsSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Maint_A_Equipements where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Maint_S_TeamSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Maint_tableTeam where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_Famille](
	[idPos] [int] NULL,
	[idFamille] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [p_FamilleSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null,
@idPos int
)
returns table
as
	return	select f.*, (select COUNT(*) from p_Famille p  where p.idPos=@idPos and p.idFamille=f.idFamille ) as selected from a_Famille f  
	where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [p_PosSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from p_Pos where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_C_Cotisations](
	[idCotisation] [int] IDENTITY(1,1) NOT NULL,
	[codeCotis] [int] NULL,
	[libelleCotis] [nvarchar](500) NULL,
	[partSalariel] [float] NULL,
	[prestationSoc] [float] NULL,
	[allFamilial] [float] NULL,
	[formationProf] [float] NULL,
	[plafond] [float] NULL,
	[cotisationPatr] [float] NULL,
	[tauxPenalite] [float] NULL,
	[tauxMajoration1] [float] NULL,
	[tauxMajorationAutres] [float] NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idEmploye] [int] NULL,
	[typeCoti] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCotisation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_C_CotisationsSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_C_Cotisations where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))  and typeCoti='Standard'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_C_Rubriques](
	[idRubrique] [int] IDENTITY(1,1) NOT NULL,
	[codeRubrique] [int] NULL,
	[libelleRubrique] [nvarchar](500) NULL,
	[codeExo] [nvarchar](max) NULL,
	[imposable] [bit] NULL,
	[positive] [bit] NULL,
	[valeur] [float] NULL,
	[taux] [float] NULL,
	[tauxPenalite] [float] NULL,
	[tauxMajoration1] [float] NULL,
	[tauxMajorationAutres] [float] NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRubrique] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_C_RubriquessSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_C_Rubriques where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_C_Variables](
	[idVariable] [int] IDENTITY(1,1) NOT NULL,
	[codeVar] [nvarchar](100) NULL,
	[libelleVar] [nvarchar](500) NULL,
	[valeurVar] [money] NULL,
	[propreSal] [bit] NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVariable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_C_VariablesSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_C_Variables where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Calcul_GrpEntete](
	[idGrpEnt] [int] IDENTITY(1,1) NOT NULL,
	[numPaie] [int] NULL,
	[datePaie] [datetime] NULL,
	[valider] [bit] NULL,
	[cloturer] [bit] NULL,
	[mois] [int] NULL,
	[periodeD] [datetime] NULL,
	[periodeF] [datetime] NULL,
	[idDossier] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[createDate] [datetime] NULL,
	[descPaie] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idGrpEnt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [Paie_Calcul_GrpEnteteLastNum](
	@idDossier int,
	@idGroup int)
	returns table
	as
		return	select top 1 numPaie as numPaie from Paie_Calcul_GrpEntete where idDossier=@idDossier and idGroup=@idGroup order by numPaie desc
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [paie_I_CategorieSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from paie_I_Categorie where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_E_Contrat](
	[idContrat] [int] IDENTITY(1,1) NOT NULL,
	[numContrat] [nvarchar](200) NULL,
	[dateContrat] [datetime] NULL,
	[idProfil] [int] NULL,
	[periodeD] [datetime] NULL,
	[periodeF] [datetime] NULL,
	[observationC] [nvarchar](max) NULL,
	[idEmploye] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idContrat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [paie_I_ProfilContrat](
	[idProfil] [int] IDENTITY(1,1) NOT NULL,
	[nomProfil] [nvarchar](500) NULL,
	[partSalariel] [bit] NULL,
	[allFamiliel] [bit] NULL,
	[formationProf] [bit] NULL,
	[cotisationPatr] [bit] NULL,
	[iR] [bit] NULL,
	[plafondIR] [float] NULL,
	[typeProfil] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [Paie_E_tableContrat]
  as 
  select c.*,(e.nomEmployee+' '+e.prenomEmployee) as nomEmployee,p.nomProfil from Paie_E_Contrat c
  inner join Paie_E_Employe e on e.idEmploye=c.idEmploye
  inner join paie_I_ProfilContrat p on p.idProfil=c.idProfil
  inner join s_Users u on e.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [paie_I_DepartementSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from paie_I_Departement where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_E_ContratSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_E_tableContrat where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [paie_I_FonctionSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from paie_I_Fonction where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [paie_I_NiveauSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from paie_I_Niveau where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [paie_I_ProfilContratSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from paie_I_ProfilContrat where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [paie_I_TauxFraisProf](
	[idTaux] [int] IDENTITY(1,1) NOT NULL,
	[codeTaux] [nvarchar](500) NULL,
	[libelleTaux] [nvarchar](500) NULL,
	[taux] [float] NULL,
	[plafond] [float] NULL,
	[refTaux] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTaux] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [paie_I_TauxFraisProfSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from paie_I_TauxFraisProf where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_Z_PlanningSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_Z_Planning where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_Z_UserDeviceSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_Z_UserDevice where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Calcul_bulletin_ligne](
	[IdBulletinLigne] [int] IDENTITY(1,1) NOT NULL,
	[IdBulletin] [int] NULL,
	[idEmploye] [int] NULL,
	[SalaireBase] [float] NULL,
	[totalPrixSupp] [float] NULL,
	[nbHeurSup] [int] NULL,
	[totalKgs] [float] NULL,
	[totalPrixKgs] [float] NULL,
	[salaireTotal] [float] NULL,
	[nbJours] [int] NULL,
	[nbconge] [int] NULL,
	[nombreHeurs] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBulletinLigne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [Paie_Calcul_bulletin_ligne_select]
as

	select pl.*,pe.nomEmployee,pe.prenomEmployee,pe.salaireBase as salaireEmp,pe.typePaie,pe.PrixKgs,pe.PrixHeurSup,pe.PrixParHeur from Paie_Calcul_bulletin_ligne pl inner join Paie_E_Employe pe on pl.idEmploye=pe.idEmploye
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_Z_ZKTDevicesSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_Z_ZKTDevices where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_EmailsSettings](
	[idESettings] [int] IDENTITY(1,1) NOT NULL,
	[urlServer] [nvarchar](500) NULL,
	[urlAttach] [nvarchar](500) NULL,
	[hostSm] [nvarchar](200) NULL,
	[usernameSm] [nvarchar](500) NULL,
	[passwordSm] [nvarchar](50) NULL,
	[portSm] [int] NULL,
	[fromNameSm] [nvarchar](500) NULL,
	[checkSMTP] [bit] NULL,
	[hostIm] [nvarchar](200) NULL,
	[usernameIm] [nvarchar](500) NULL,
	[passwordIm] [nvarchar](50) NULL,
	[portIm] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[createDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idESettings] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [s_EmailsSettingsSelect](
@idGroup int=null
)
returns table
as
	return	select * from s_EmailsSettings where idGroup=@idGroup
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Calcul_LigneRubrique](
	[idLigne] [int] IDENTITY(1,1) NOT NULL,
	[idEntete] [int] NULL,
	[idRubrique] [int] NULL,
	[idCotisation] [int] NULL,
	[idPret] [int] NULL,
	[codeRubrique] [int] NULL,
	[libelleRubrique] [nvarchar](500) NULL,
	[base] [money] NULL,
	[taux] [float] NULL,
	[gains] [money] NULL,
	[retenues] [money] NULL,
	[createDate] [datetime] NULL,
	[position] [int] NULL,
	[valeur] [int] NULL,
	[typeRubrique] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLigne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_E_Conges](
	[idConge] [int] IDENTITY(1,1) NOT NULL,
	[idEmploye] [int] NULL,
	[annee] [int] NULL,
	[numberMonths] [int] NULL,
	[jConsommes] [float] NULL,
	[jCongeN_1] [float] NULL,
	[jCongeN] [float] NULL,
	[jRestes] [float] NULL,
	[idDossier] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idConge] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_Calcul_ImpressionBulletin](
@idEntete int=null
)
returns table
as
	return 	SELECT c.*, em.idEmploye,em.matricule,(em.nomEmployee+' '+em.prenomEmployee) AS nomEmploye,em.nbEnfants,em.nomFonction,em.nomDepartement,em.nomCategorie,em.adresse,em.dateNaissance,
	em.dateEntree,em.sitFamiliale,em.cinEmployee,em.nomModRglm,g.periodeD,g.periodeF,g.datePaie,g.numPaie,cg.jConsommes,cg.jCongeN_1,
	cg.jCongeN,cg.jRestes
	FROM Paie_Calcul_LigneRubrique c
	INNER JOIN Paie_Calcul_Entete e ON e.idEntete=c.idEntete
	inner join Paie_Calcul_GrpEntete g on g.idGrpEnt = e.idGrpEnt
	INNER JOIN Paie_E_tableEmploye em ON em.idEmploye=e.idEmploye 
	inner join Paie_E_Conges cg on cg.idEmploye=e.idEmploye
	WHERE c.idEntete=@idEntete AND c.typeRubrique='Calcul' AND (c.base <> 0 or c.taux <> 0 or c.gains <> 0 or c.retenues <> 0)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_GroupUsers](
	[idGroup] [int] IDENTITY(1,1) NOT NULL,
	[descGroup] [nvarchar](50) NULL,
	[createDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_Settings](
	[idSettings] [int] IDENTITY(1,1) NOT NULL,
	[currencyFormat] [nvarchar](max) NULL,
	[qteFormat] [nvarchar](max) NULL,
	[tvaCheck] [bit] NULL,
	[ttcCheck] [bit] NULL,
	[subDepot] [bit] NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idSettings] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [s_UserSettings](
	@idUser nvarchar(450)
	)
	returns table
	as
		return	select u.nomUser,u.typeAdmin,u.userName,s.* from s_Users u
		inner join s_GroupUsers g on g.idGroup=u.idGroup
		inner join s_Settings s on s.idGroup=g.idGroup
		where idUser=@idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_Calcul_bulletin](
	[IdBulletin] [int] IDENTITY(1,1) NOT NULL,
	[numBulletin] [int] NULL,
	[createdDate] [datetime] NULL,
	[periodeD] [datetime] NULL,
	[periodeF] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idDossier] [int] NULL,
	[valider] [bit] NULL,
	[descPaie] [nvarchar](max) NULL,
	[cloturer] [bit] NULL,
	[mois] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBulletin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [Paie_Calcul_BulletinLastNum](
	@idDossier int,
	@idGroup int)
	returns table
	as
		return	select top 1 numBulletin as numBulletin from Paie_Calcul_bulletin where idDossier=@idDossier and idGroup=@idGroup order by numBulletin desc
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [sc_calendar](
	[idCalendar] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](500) NULL,
	[checked] [bit] NULL,
	[color] [varchar](100) NULL,
	[bgColor] [varchar](100) NULL,
	[borderColor] [varchar](100) NULL,
	[dragBgColor] [varchar](100) NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCalendar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [sc_calendarSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from sc_calendar where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [u_UniteMesure](
	[idUnite] [int] IDENTITY(1,1) NOT NULL,
	[descUnite] [nvarchar](100) NULL,
	[idGroup] [int] NULL,
	[prcpUnite] [bit] NULL,
	[idUser] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUnite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [a_tableArticle]
  as 
  select a.*,f.nomFamille,u.nomUser,ISNULL(ta.cauxTaxe,0) as cauxTaxeAchat,ISNULL(tv.cauxTaxe,0) as cauxTaxeVente,un.descUnite as mesureArticle2 from a_Article a 
  left join a_Famille f on a.idFamille=f.idFamille
  left join b_Taxe ta on ta.idTaxe=a.idTaxeAchat
  left join b_Taxe tv on tv.idTaxe=a.idTaxeVente
  left join s_Users u on a.idUser=u.idUser
  left join u_UniteMesure un on a.idUnite=un.idUnite
	where a.checkBateau=0
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [a_ArticleSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@SelectArticles bit=null,
@idGroup int=null
)
returns table
as
	return	select * from a_tableArticle  where ((@SelectALL=1 and  idUser=@idUser) or (@SelectArticles=1 and idUser=@idUser)
	 or (@SelectALL=0 and @SelectArticles=0 and idGroup=@idGroup) )
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [sc_schedule](
	[idSchedule] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](max) NULL,
	[body] [nvarchar](max) NULL,
	[isAllday] [bit] NULL,
	[start] [datetime] NULL,
	[endd] [datetime] NULL,
	[isPrivate] [bit] NULL,
	[nomTier] [nvarchar](500) NULL,
	[idCalendar] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[heureStart] [time](7) NULL,
	[heureEndd] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSchedule] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [sc_scheduleSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null,
@idCalendar int,
@renderStart datetime,
@renderEnd datetime
)
returns table
as
	return	select s.*,c.name,c.color,c.bgColor,c.borderColor,c.dragBgColor from sc_schedule s
			inner join sc_calendar c on c.idCalendar=s.idCalendar
	where ((@SelectALL=1 and  s.idUser=@idUser) or (@SelectALL=0 and s.idGroup=@idGroup)) and s.idCalendar=@idCalendar
	and start between @renderStart and @renderEnd
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_DepotSup](
	[idSupDepot] [int] IDENTITY(1,1) NOT NULL,
	[nomSupDepot] [nvarchar](100) NULL,
	[prcpSupDepot] [bit] NULL,
	[infoSupDepot] [nvarchar](300) NULL,
	[idDepot] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[createDate] [datetime] NULL,
	[typeSupDepot] [nvarchar](100) NULL,
	[couloirX] [nvarchar](100) NULL,
	[rayonY] [nvarchar](100) NULL,
	[hauteur] [nvarchar](100) NULL,
	[codeBare] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSupDepot] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [b_tableDepotSup]
  as 
   select s.*,d.nomDepot from b_DepotSup s inner join b_Depot d on d.idDepot=s.idDepot
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [b_DepotSupSelect](
	@idUser nvarchar(450),
	@SelectALL bit=null,
	@idGroup int=null
	)
	returns table
	as
		return	select * from b_tableDepotSup  where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_E_Prets](
	[idPret] [int] IDENTITY(1,1) NOT NULL,
	[reliquant] [money] NULL,
	[montantTotal] [money] NULL,
	[nbEcheance] [int] NULL,
	[montantEcheance] [money] NULL,
	[montantDernierEcheance] [money] NULL,
	[dateEcheanceD] [datetime] NULL,
	[dateEcheanceF] [datetime] NULL,
	[codeRubrique] [nvarchar](50) NULL,
	[observation] [nvarchar](max) NULL,
	[idEmploye] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPret] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [Paie_E_tablePrets]
  as 
  select p.*,(e.nomEmployee+' '+e.prenomEmployee) as nomEmployee from Paie_E_Prets p
  inner join Paie_E_Employe e on e.idEmploye=p.idEmploye
  inner join s_Users u on e.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [b_SoldTresorerie](
	[idTreso] [int] NOT NULL,
	[idDossier] [int] NOT NULL,
	[soldTresorerie] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTreso] ASC,
	[idDossier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [tr_SoldCaisse](
@idDossier int=null
)
returns table
as
	return	select (select ISNULL(SUM(montant),0) from tr_TresorerieEntet tr where tr.codeType='DPS' and idDossier=@idDossier and tr.idTreso=st.idTreso)
 +(select ISNULL(SUM(montant),0) from r_Reglement r inner join e_TypeDoc t on t.codeType=r.codeType where t.valCaisse=-1 and r.idDossier=@idDossier and r.idTreso=st.idTreso) as 'DPS',
 (select ISNULL(SUM(montant),0) from tr_TresorerieEntet tr where tr.codeType='RCT' and idDossier=@idDossier and tr.idTreso=st.idTreso) + 
 (select ISNULL(SUM(montant),0) from r_Reglement r inner join e_TypeDoc t on t.codeType=r.codeType where t.valCaisse=1 and r.idDossier=@idDossier and r.idTreso=st.idTreso) as 'RCT',
 soldTresorerie ,bt.nameTreso
  from b_SoldTresorerie st inner join b_Tresorerie bt on st.idTreso=bt.idTreso where idDossier=@idDossier
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_E_PretsSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_E_tablePrets where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create view [a_tablefamille]
  as 
select a.*,t.TypeFamaille as nomTypeFamille,fn.NomScientifique,bp.nomPays from a_Famille a inner join fish_TypeFamaille t on a.idTypeFamaille=t.idTypeFamaille
	inner join fish_NomScientifique fn on a.idNomScientifique=fn.idNomScientifique
	left join b_Pays bp on a.idPays=bp.idPays
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [Paie_E_tableConges]
  as 
  select c.*,(e.nomEmployee+' '+e.prenomEmployee) as nomEmployee from Paie_E_Conges c
  inner join Paie_E_Employe e on e.idEmploye=c.idEmploye
  inner join s_Users u on e.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [a_tableGestionQte] 
  as
  select a.idArticle,a.nomArticle,a.refArticle,a.qteBox,
  a.codeBareArticle,a.idFamille,
  f.parentId,ad.idDepot,isnull(ad.cmup,0) as cmup,
  isnull(ad.firstPrix,0) as firstPrix,ad.idDossier,isnull(ad.lastPrix,0) as lastPrix,
  isnull(ad.qteDepot,0) as qteDepot,ad.idSupDepot,d.nomDepot,ds.nomSupDepot,f.nomFamille,a.idUser
   from a_Article a
  left join a_Famille f on f.idFamille=a.idFamille
  left join e_Art_Depot ad on ad.idArticle=a.idArticle
  left join b_Depot d on d.idDepot=ad.idDepot
  left join b_DepotSup ds on ds.idSupDepot=ad.idSupDepot
	where a.typeArticle in ('Standard','Fabrication','Nomenclature')
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Paie_E_CongesSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Paie_E_tableConges where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE view [e_tableEntetLignByMonth]
as 
select el.idEntet,a.codePdFini,el.qteLign,ee.dateEntet from e_EntetLign el 
inner join e_Entet ee on el.idEntet=ee.idEntet 
inner join a_Article a on el.idArticle=a.idArticle where codeType='BPI'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [e_tableEtatInventaire]
as 
select e.*,a.qteDepot from e_EntetLign e 
inner join e_Art_Depot a on e.idArticle=a.idArticle
inner join e_Entet et on e.idEntet=et.idEntet
where et.idDepot=a.idDepot and a.idDossier=et.idDossier
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [f_tableFabricationLign]
  as 
	select f.*,a.nomArticle,a.refArticle from f_FabricationLign f
	inner join a_Article a on a.idArticle=f.idLignArticle
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE view [e_tableEntetLign]
as 
select e.*,a.typeArticle,a.qteBox,d.nomSupDepot,f.nomFamille,a.nomArticle,a.idFamille from e_EntetLign e 
left join a_Article a on e.idArticle=a.idArticle
left join b_DepotSup d on d.idSupDepot=e.idSupDepot
left join a_Famille f on a.idFamille=f.idFamille
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE FUNCTION [e_EntetLignSelect](
@idEntet int=null
)
returns table
as
	return	
	select * from e_tableEntetLign where idEntet=@idEntet 
	--WITH CTE AS (
	--	SELECT *
	--	FROM e_tableEntetLign
	--	WHERE idEntet = @idEntet
	--)
	--SELECT *
	--FROM CTE
	--ORDER BY dateLigne ASC;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [f_OrdreLine](
	[idOrdreLine] [int] IDENTITY(1,1) NOT NULL,
	[qteOrdreLine] [float] NULL,
	[cmup] [money] NULL,
	[ttHT] [money] NULL,
	[typeOrdre] [nvarchar](10) NULL,
	[valStock] [int] NULL,
	[idLignArticle] [int] NULL,
	[idOrdre] [int] NULL,
	[idDepot] [int] NULL,
	[idSupDepot] [int] NULL,
	[idDossier] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idOrdreLine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [f_tableOrderLine]
as
select SUM(qteOrdreLine*valStock) as qteOrderLine,cmup,a.nomArticle,a.refArticle,f.idOrdre from f_OrdreLine f 
inner join a_Article a on a.idArticle=f.idLignArticle
group by cmup,nomArticle,refArticle,idOrdre
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [f_Ordre](
	[idOrdre] [int] IDENTITY(1,1) NOT NULL,
	[numOrdre] [int] NULL,
	[qteOrdre] [float] NULL,
	[ttHT] [money] NULL,
	[datePlanification] [datetime] NULL,
	[dateEndPlanification] [datetime] NULL,
	[positionOrdre] [int] NULL,
	[progressType] [nvarchar](100) NULL,
	[idDepot] [int] NULL,
	[idSupDepot] [int] NULL,
	[idFabrication] [int] NULL,
	[idArticle] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idDossier] [int] NULL,
	[createDate] [datetime] NULL,
	[valider] [bit] NULL,
	[numberPerson] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idOrdre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [f_tableOrdre] as
  select o.*,f.reference,f.info,a.nomArticle,u.nomUser from f_Ordre o 
  inner join f_Fabrication f on o.idFabrication=f.idFabrication
  inner join a_Article a on o.idArticle=a.idArticle
  inner join s_Users u on o.idUser=u.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Maint_R_Request](
	[idRequest] [int] IDENTITY(1,1) NOT NULL,
	[numRequest] [int] NULL,
	[nomRequest] [nvarchar](max) NULL,
	[etatRequest] [nvarchar](250) NULL,
	[typeMaint] [nvarchar](250) NULL,
	[descMaint] [nvarchar](max) NULL,
	[lieuMaint] [nvarchar](250) NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
	[idDossier] [int] NULL,
	[idTeam] [int] NULL,
	[idEquipement] [int] NULL,
	[progressType] [nvarchar](100) NULL,
	[positionOrdre] [int] NULL,
	[dateRequest] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRequest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [Maint_R_tableRequest]
as 
	select r.*,(a.nomArticle + ' ( N° Série : ' + e.numeroSerie + ' ) ') as nomEquipement,t.nomTeam from Maint_R_Request r
	inner join Maint_A_Equipements e on e.idEquipement=r.idEquipement
	inner join a_Article a on a.idArticle=e.idArticle
	inner join Maint_S_Team t on t.idTeam=r.idTeam
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Maint_R_RequestSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from Maint_R_tableRequest where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [fish_charge](
	[idCharge] [int] IDENTITY(1,1) NOT NULL,
	[idEntet] [int] NULL,
	[idService] [int] NULL,
	[cout] [float] NULL,
	[idGroup] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCharge] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [fish_chargeSelect]
as
  select fc.idCharge,fc.idEntet,fc.cout,bs.nomService,bs.descService from fish_charge as fc left join b_Service as bs on fc.idService=bs.idService
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [fish_famille](
	[idFamille] [int] IDENTITY(1,1) NOT NULL,
	[CDE_FAO] [nvarchar](max) NULL,
	[marchandises] [nvarchar](max) NULL,
	[idNomScientifique] [bigint] NULL,
	[idTypeFamaille] [bigint] NULL,
	[idPays] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NOT NULL,
 CONSTRAINT [PK__fish_famille] PRIMARY KEY CLUSTERED 
(
	[idFamille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [fish_familleSelect]
AS
SELECT f.*,t.TypeFamaille,p.nomPays,nm.NomScientifique
FROM fish_famille as f 
inner join fish_NomScientifique as nm on f.idNomScientifique=nm.idNomScientifique
inner join fish_TypeFamaille as t on f.idTypeFamaille=t.idTypeFamaille
inner join b_Pays as p on f.idPays=p.idPays
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [t_tableFournisseur]
as 
select f.*,v.nomVille,p.nomPays,u.nomUser from t_Fournisseur f 
left join b_Ville v on v.idVille=f.idVille
left join b_Pays p on p.idPays=f.idPays
inner join s_Users u on u.idUser=f.idUser
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [hotel_tableBookingsEntete]
as
 select b.*,c.nomClient from hotel_B_BookingEntete b
 inner join t_Client c on b.idClient=c.idClient
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [t_FournisseurSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null
)
returns table
as
	return	select * from t_tableFournisseur where ((@SelectALL=1 and  idUser=@idUser) 
	or (@SelectALL=0 and idGroup=@idGroup))
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [hotel_tableBookingsEnteteCalendar]
as
 select b.*,c.nomClient,l.TTPrix_HT,l.TTPrix_TTC,l.idRoomType,l.idUnit from hotel_B_BookingEntete b
 inner join t_Client c on b.idClient=c.idClient
 inner join Hotel_B_BookingLigne l on b.idBookingEntete=l.idBookingEntete
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel_B_BookingExtras](
	[idBookingExtra] [int] IDENTITY(1,1) NOT NULL,
	[idBookingEntete] [int] NULL,
	[idExtras] [int] NULL,
	[description] [nvarchar](max) NULL,
	[qte] [int] NULL,
	[prixExtra] [money] NULL,
	[createDate] [datetime] NULL,
	[totalExtras] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBookingExtra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [hotel_tableBookingsExtras]
as
 select b.*,e.extrasName,e.prix_HT,e.prix_TTC from Hotel_B_BookingExtras b
 inner join hotel_S_Extras e on b.idExtras=e.idExtras
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [a_ArticleInFille](
	[idFille] [int] NULL,
	[idArticle] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [e_FilleInEmails](
	[idEmail] [int] NOT NULL,
	[idFille] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmail] ASC,
	[idFille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [e_FilleInEntet](
	[idFille] [int] NULL,
	[idEntet] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel_B_BookingInvites](
	[idBookingInvite] [int] IDENTITY(1,1) NOT NULL,
	[nomInvite] [nvarchar](500) NULL,
	[prenomInvite] [nvarchar](500) NULL,
	[cinInvite] [nvarchar](20) NULL,
	[ageInvite] [int] NULL,
	[sexeInvite] [nvarchar](50) NULL,
	[nationalite] [nvarchar](250) NULL,
	[idBookingEntete] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBookingInvite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_B_FilleInBookingEntete](
	[idFille] [int] NULL,
	[idBookingEntete] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_S_Equipements](
	[idRoomType] [int] NULL,
	[valeurEquip] [nvarchar](500) NULL,
	[textEquip] [nvarchar](max) NULL,
	[createDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [hotel_S_RoomCategorie](
	[idRoomType] [int] NOT NULL,
	[idCategorie] [int] NOT NULL,
 CONSTRAINT [PK_hotel_S_RoomCategorie] PRIMARY KEY CLUSTERED 
(
	[idRoomType] ASC,
	[idCategorie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_ModRglm](
	[idModRglm] [int] NULL,
	[idPos] [int] NULL,
	[defaults] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_Session](
	[idSession] [int] IDENTITY(1,1) NOT NULL,
	[idPos] [int] NULL,
	[dateOpen] [datetime] NULL,
	[caissierOpen] [int] NULL,
	[soldeOpen] [money] NULL,
	[dateClose] [datetime] NULL,
	[caissierClose] [int] NULL,
	[soldeClose] [money] NULL,
	[closed] [bit] NULL,
	[totalCaissier] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idSession] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [p_Ticket_Reg](
	[idPaiment] [int] IDENTITY(1,1) NOT NULL,
	[idTicket] [int] NULL,
	[idModRglm] [int] NULL,
	[mantant] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPaiment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_C_RubriquesExo](
	[idExo] [int] IDENTITY(1,1) NOT NULL,
	[codeExo] [nvarchar](200) NULL,
	[libelleExo] [nvarchar](500) NULL,
	[createDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idExo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Paie_E_FilleInContrat](
	[idContrat] [int] NOT NULL,
	[idFille] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idContrat] ASC,
	[idFille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [r_ReglementInFille](
	[idFille] [int] NULL,
	[idReglement] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_Dossier](
	[idDossier] [int] IDENTITY(1,1) NOT NULL,
	[Nom_dossier] [nvarchar](100) NULL,
	[Activite] [varchar](100) NULL,
	[Adresse] [varchar](100) NULL,
	[Complement] [varchar](100) NULL,
	[Cp] [varchar](100) NULL,
	[Region] [nvarchar](100) NULL,
	[Ville] [nvarchar](100) NULL,
	[Pays] [nvarchar](100) NULL,
	[Fix] [varchar](100) NULL,
	[Sitee] [varchar](100) NULL,
	[Tele] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Cnss] [varchar](100) NULL,
	[Patente] [varchar](100) NULL,
	[Iff] [varchar](100) NULL,
	[Rc] [varchar](100) NULL,
	[Ice] [varchar](100) NULL,
	[Date_creation] [datetime] NULL,
	[Entet_dossier] [nvarchar](500) NULL,
	[Pied_dossier] [nvarchar](500) NULL,
	[Style_dossier] [varchar](200) NULL,
	[Logo] [varchar](500) NULL,
	[domainName] [nvarchar](500) NULL,
	[wooClientKey] [nvarchar](max) NULL,
	[wooClientSecret] [nvarchar](max) NULL,
	[dateExeStart] [datetime] NULL,
	[dateExeEnd] [datetime] NULL,
	[createDate] [datetime] NULL,
	[Objectif] [nvarchar](max) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDossier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_Fille](
	[idFille] [int] IDENTITY(1,1) NOT NULL,
	[nameFile] [nvarchar](max) NULL,
	[pathFile] [nvarchar](max) NULL,
	[typeFile] [nvarchar](max) NULL,
	[sizeFile] [nvarchar](max) NULL,
	[createDate] [datetime] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_LiaisonUsers](
	[idUser] [nvarchar](450) NULL,
	[idDepot] [int] NULL,
	[idTreso] [int] NULL,
	[idVille] [int] NULL,
	[idPays] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_Menu](
	[idMenu] [int] IDENTITY(1,1) NOT NULL,
	[codeMenu] [nvarchar](100) NULL,
	[nomMenu] [nvarchar](200) NULL,
	[photoMenu] [nvarchar](200) NULL,
	[dataModel] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_MenuInstall](
	[idMenu] [int] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_MenuSub](
	[idSubMenu] [int] IDENTITY(1,1) NOT NULL,
	[nomSubMenu] [nvarchar](200) NULL,
	[codeMenu] [nvarchar](100) NULL,
	[namePrincipale] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSubMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_MenuSubInstall](
	[idSubMenu] [int] NULL,
	[idGroup] [int] NULL,
	[idUser] [nvarchar](450) NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_Roles](
	[idRole] [int] IDENTITY(1,1) NOT NULL,
	[nameRole] [nvarchar](max) NULL,
	[insertRole] [bit] NULL,
	[updateRole] [bit] NULL,
	[deleteRole] [bit] NULL,
	[selectByUser] [bit] NULL,
	[selectALL] [bit] NULL,
	[selectDoc] [bit] NULL,
	[createDate] [datetime] NULL,
	[idGroup] [int] NULL,
	[imprimerRole] [bit] NULL,
	[valider] [bit] NULL,
	[selectArticles] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_UserDossier](
	[idUser] [nvarchar](450) NOT NULL,
	[idDossier] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUser] ASC,
	[idDossier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [s_UserRoles](
	[idRole] [int] NOT NULL,
	[idUser] [nvarchar](450) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRole] ASC,
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [sb_CreationBarCode](
	[idCreation] [int] IDENTITY(1,1) NOT NULL,
	[dimensionW] [float] NULL,
	[dimensionH] [float] NULL,
	[vBarWidth] [float] NULL,
	[vBarHeight] [float] NULL,
	[meta] [nvarchar](max) NULL,
	[codeType] [nvarchar](250) NULL,
	[createDate] [datetime] NULL,
	[idDossier] [int] NULL,
	[idUser] [nvarchar](450) NULL,
	[idGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCreation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [t_ClientCredit](
	[idClient] [int] NULL,
	[idDossier] [int] NULL,
	[credit] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [t_FournisseurCredit](
	[idFournisseur] [int] NULL,
	[idDossier] [int] NULL,
	[credit] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [t_salarie](
	[idSalarie] [int] IDENTITY(1,1) NOT NULL,
	[nomSalarie] [varchar](max) NULL,
	[prenomSalarie] [varchar](max) NULL,
	[age] [int] NULL,
	[post] [varchar](max) NULL,
	[salaire] [float] NULL,
	[DateEntree] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idSalarie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [a_Article]  WITH CHECK ADD FOREIGN KEY([idFamille])
REFERENCES [a_Famille] ([idFamille])
GO
ALTER TABLE [a_Article]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [a_Article]  WITH CHECK ADD FOREIGN KEY([idTaxeAchat])
REFERENCES [b_Taxe] ([idTaxe])
GO
ALTER TABLE [a_Article]  WITH CHECK ADD FOREIGN KEY([idTaxeVente])
REFERENCES [b_Taxe] ([idTaxe])
GO
ALTER TABLE [a_Article]  WITH CHECK ADD FOREIGN KEY([idUnite])
REFERENCES [u_UniteMesure] ([idUnite])
GO
ALTER TABLE [a_Article]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [a_ArticleInFille]  WITH CHECK ADD FOREIGN KEY([idArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [a_ArticleInFille]  WITH CHECK ADD FOREIGN KEY([idFille])
REFERENCES [s_Fille] ([idFille])
GO
ALTER TABLE [a_Bateau]  WITH CHECK ADD FOREIGN KEY([idArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [a_Bateau]  WITH CHECK ADD FOREIGN KEY([idClient])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [a_Famille]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [a_Famille]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [a_Famille]  WITH CHECK ADD  CONSTRAINT [FK_a_Famille_fish_TypeFamaille] FOREIGN KEY([idTypeFamaille])
REFERENCES [fish_TypeFamaille] ([idTypeFamaille])
GO
ALTER TABLE [a_Famille] CHECK CONSTRAINT [FK_a_Famille_fish_TypeFamaille]
GO
ALTER TABLE [a_Famille]  WITH CHECK ADD  CONSTRAINT [FK_a_Famillefish_b_Pays] FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [a_Famille] CHECK CONSTRAINT [FK_a_Famillefish_b_Pays]
GO
ALTER TABLE [a_Famille]  WITH CHECK ADD  CONSTRAINT [FK_a_Famillefish_NomScientifique] FOREIGN KEY([idNomScientifique])
REFERENCES [fish_NomScientifique] ([idNomScientifique])
GO
ALTER TABLE [a_Famille] CHECK CONSTRAINT [FK_a_Famillefish_NomScientifique]
GO
ALTER TABLE [b_Depot]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_Depot]  WITH CHECK ADD FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [b_Depot]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [b_Depot]  WITH CHECK ADD FOREIGN KEY([idVille])
REFERENCES [b_Ville] ([idVille])
GO
ALTER TABLE [b_DepotSup]  WITH CHECK ADD FOREIGN KEY([idDepot])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [b_DepotSup]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_DepotSup]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [b_ModRglm]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_ModRglm]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [b_Pays]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_Propriete]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_Propriete]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [b_Service]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_Service]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [b_SoldTresorerie]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [b_SoldTresorerie]  WITH CHECK ADD FOREIGN KEY([idTreso])
REFERENCES [b_Tresorerie] ([idTreso])
GO
ALTER TABLE [b_Taxe]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_Tresorerie]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_Tresorerie]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [b_Ville]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [b_Ville]  WITH CHECK ADD  CONSTRAINT [fk_b_ville_b_pays] FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [b_Ville] CHECK CONSTRAINT [fk_b_ville_b_pays]
GO
ALTER TABLE [d_Departement]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [d_Departement]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [e_Art_Depot]  WITH CHECK ADD FOREIGN KEY([idDepot])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [e_Art_Depot]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [e_Art_Depot]  WITH CHECK ADD FOREIGN KEY([idSupDepot])
REFERENCES [b_DepotSup] ([idSupDepot])
GO
ALTER TABLE [e_Emails]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [e_Emails]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idClient])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idDepot])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idDepot_2])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idFournisseur])
REFERENCES [t_Fournisseur] ([idFournisseur])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idModRglm])
REFERENCES [b_ModRglm] ([idModRglm])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [e_Entet]  WITH CHECK ADD  CONSTRAINT [FK_e_entet_a_famille] FOREIGN KEY([idFamille])
REFERENCES [a_Famille] ([idFamille])
GO
ALTER TABLE [e_Entet] CHECK CONSTRAINT [FK_e_entet_a_famille]
GO
ALTER TABLE [e_EntetLign]  WITH CHECK ADD FOREIGN KEY([idArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [e_EntetLign]  WITH CHECK ADD FOREIGN KEY([idEntet])
REFERENCES [e_Entet] ([idEntet])
GO
ALTER TABLE [e_EntetLign]  WITH CHECK ADD FOREIGN KEY([idSupDepot_2])
REFERENCES [b_DepotSup] ([idSupDepot])
GO
ALTER TABLE [e_EntetLign]  WITH CHECK ADD FOREIGN KEY([idSupDepot])
REFERENCES [b_DepotSup] ([idSupDepot])
GO
ALTER TABLE [e_EntetLign]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [e_FilleInEmails]  WITH CHECK ADD FOREIGN KEY([idEmail])
REFERENCES [e_Emails] ([idEmail])
GO
ALTER TABLE [e_FilleInEmails]  WITH CHECK ADD FOREIGN KEY([idFille])
REFERENCES [s_Fille] ([idFille])
GO
ALTER TABLE [e_FilleInEntet]  WITH CHECK ADD FOREIGN KEY([idEntet])
REFERENCES [e_Entet] ([idEntet])
GO
ALTER TABLE [e_FilleInEntet]  WITH CHECK ADD FOREIGN KEY([idFille])
REFERENCES [s_Fille] ([idFille])
GO
ALTER TABLE [e_TypeDoc]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [f_Fabrication]  WITH CHECK ADD FOREIGN KEY([idArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [f_Fabrication]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [f_Fabrication]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [f_FabricationLign]  WITH CHECK ADD FOREIGN KEY([idFabrication])
REFERENCES [f_Fabrication] ([idFabrication])
GO
ALTER TABLE [f_FabricationLign]  WITH CHECK ADD FOREIGN KEY([idLignArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [f_Ordre]  WITH CHECK ADD FOREIGN KEY([idArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [f_Ordre]  WITH CHECK ADD FOREIGN KEY([idDepot])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [f_Ordre]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [f_Ordre]  WITH CHECK ADD FOREIGN KEY([idFabrication])
REFERENCES [f_Fabrication] ([idFabrication])
GO
ALTER TABLE [f_Ordre]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [f_Ordre]  WITH CHECK ADD FOREIGN KEY([idSupDepot])
REFERENCES [b_DepotSup] ([idSupDepot])
GO
ALTER TABLE [f_Ordre]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [f_OrdreLine]  WITH CHECK ADD FOREIGN KEY([idDepot])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [f_OrdreLine]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [f_OrdreLine]  WITH CHECK ADD FOREIGN KEY([idLignArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [f_OrdreLine]  WITH CHECK ADD FOREIGN KEY([idOrdre])
REFERENCES [f_Ordre] ([idOrdre])
GO
ALTER TABLE [f_OrdreLine]  WITH CHECK ADD FOREIGN KEY([idSupDepot])
REFERENCES [b_DepotSup] ([idSupDepot])
GO
ALTER TABLE [fish_charge]  WITH CHECK ADD  CONSTRAINT [FK_fish_charge_b_Service] FOREIGN KEY([idService])
REFERENCES [b_Service] ([idService])
GO
ALTER TABLE [fish_charge] CHECK CONSTRAINT [FK_fish_charge_b_Service]
GO
ALTER TABLE [fish_charge]  WITH CHECK ADD  CONSTRAINT [FK_fish_charge_s_GroupUsers] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [fish_charge] CHECK CONSTRAINT [FK_fish_charge_s_GroupUsers]
GO
ALTER TABLE [fish_entet]  WITH CHECK ADD  CONSTRAINT [FK_fish_entet_a_Famille] FOREIGN KEY([idFamille])
REFERENCES [a_Famille] ([idFamille])
GO
ALTER TABLE [fish_entet] CHECK CONSTRAINT [FK_fish_entet_a_Famille]
GO
ALTER TABLE [fish_entet]  WITH CHECK ADD  CONSTRAINT [fk_fish_entet_b_Pays] FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [fish_entet] CHECK CONSTRAINT [fk_fish_entet_b_Pays]
GO
ALTER TABLE [fish_entet]  WITH CHECK ADD  CONSTRAINT [fk_fish_entet_fish_port] FOREIGN KEY([idPort])
REFERENCES [fish_port] ([idPort])
GO
ALTER TABLE [fish_entet] CHECK CONSTRAINT [fk_fish_entet_fish_port]
GO
ALTER TABLE [fish_entet]  WITH CHECK ADD  CONSTRAINT [fk_fish_entet_s_dossier] FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [fish_entet] CHECK CONSTRAINT [fk_fish_entet_s_dossier]
GO
ALTER TABLE [fish_entet]  WITH CHECK ADD  CONSTRAINT [FK_fish_entet_s_GroupUsers] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [fish_entet] CHECK CONSTRAINT [FK_fish_entet_s_GroupUsers]
GO
ALTER TABLE [fish_entet]  WITH CHECK ADD  CONSTRAINT [FK_fish_entet_s_User] FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [fish_entet] CHECK CONSTRAINT [FK_fish_entet_s_User]
GO
ALTER TABLE [fish_entet]  WITH CHECK ADD  CONSTRAINT [FK_fish_entet_t_Client] FOREIGN KEY([idClient])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [fish_entet] CHECK CONSTRAINT [FK_fish_entet_t_Client]
GO
ALTER TABLE [fish_entetLign]  WITH CHECK ADD  CONSTRAINT [FK_fish_entetLign_a_famille] FOREIGN KEY([idFamille])
REFERENCES [a_Famille] ([idFamille])
GO
ALTER TABLE [fish_entetLign] CHECK CONSTRAINT [FK_fish_entetLign_a_famille]
GO
ALTER TABLE [fish_entetLign]  WITH CHECK ADD  CONSTRAINT [FK_fish_entetLign_fish_entet] FOREIGN KEY([idEntet])
REFERENCES [fish_entet] ([idEntet])
GO
ALTER TABLE [fish_entetLign] CHECK CONSTRAINT [FK_fish_entetLign_fish_entet]
GO
ALTER TABLE [fish_famille]  WITH CHECK ADD  CONSTRAINT [FK_fish_famille_b_pays] FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [fish_famille] CHECK CONSTRAINT [FK_fish_famille_b_pays]
GO
ALTER TABLE [fish_famille]  WITH CHECK ADD  CONSTRAINT [FK_fish_famille_fish_NomScientifique] FOREIGN KEY([idNomScientifique])
REFERENCES [fish_NomScientifique] ([idNomScientifique])
GO
ALTER TABLE [fish_famille] CHECK CONSTRAINT [FK_fish_famille_fish_NomScientifique]
GO
ALTER TABLE [fish_famille]  WITH CHECK ADD  CONSTRAINT [FK_fish_famille_fish_TypeFamaille] FOREIGN KEY([idTypeFamaille])
REFERENCES [fish_TypeFamaille] ([idTypeFamaille])
GO
ALTER TABLE [fish_famille] CHECK CONSTRAINT [FK_fish_famille_fish_TypeFamaille]
GO
ALTER TABLE [fish_famille]  WITH CHECK ADD  CONSTRAINT [FK_fish_famille_s_GroupUsers] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [fish_famille] CHECK CONSTRAINT [FK_fish_famille_s_GroupUsers]
GO
ALTER TABLE [fish_famille]  WITH CHECK ADD  CONSTRAINT [FK_fish_famille_s_Users] FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [fish_famille] CHECK CONSTRAINT [FK_fish_famille_s_Users]
GO
ALTER TABLE [fish_NomScientifique]  WITH CHECK ADD  CONSTRAINT [FK_fish_NomScientifique_s_GroupUsers] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [fish_NomScientifique] CHECK CONSTRAINT [FK_fish_NomScientifique_s_GroupUsers]
GO
ALTER TABLE [fish_port]  WITH CHECK ADD  CONSTRAINT [fk_fish_port_s_GroupUsers] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [fish_port] CHECK CONSTRAINT [fk_fish_port_s_GroupUsers]
GO
ALTER TABLE [fish_port]  WITH CHECK ADD  CONSTRAINT [fk_fish_port_s_user] FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [fish_port] CHECK CONSTRAINT [fk_fish_port_s_user]
GO
ALTER TABLE [fish_TypeFamaille]  WITH CHECK ADD  CONSTRAINT [FK_fish_TypeFamaille_s_GroupUsers] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [fish_TypeFamaille] CHECK CONSTRAINT [FK_fish_TypeFamaille_s_GroupUsers]
GO
ALTER TABLE [hotel_B_BookingEntete]  WITH CHECK ADD FOREIGN KEY([idClient])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [hotel_B_BookingEntete]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [hotel_B_BookingEntete]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [hotel_B_BookingEntete]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Hotel_B_BookingExtras]  WITH CHECK ADD FOREIGN KEY([idBookingEntete])
REFERENCES [hotel_B_BookingEntete] ([idBookingEntete])
GO
ALTER TABLE [Hotel_B_BookingExtras]  WITH CHECK ADD FOREIGN KEY([idExtras])
REFERENCES [hotel_S_Extras] ([idExtras])
GO
ALTER TABLE [Hotel_B_BookingInvites]  WITH CHECK ADD FOREIGN KEY([idBookingEntete])
REFERENCES [hotel_B_BookingEntete] ([idBookingEntete])
GO
ALTER TABLE [Hotel_B_BookingLigne]  WITH CHECK ADD FOREIGN KEY([idBookingEntete])
REFERENCES [hotel_B_BookingEntete] ([idBookingEntete])
GO
ALTER TABLE [Hotel_B_BookingLigne]  WITH CHECK ADD FOREIGN KEY([idRoomType])
REFERENCES [hotel_S_RoomType] ([idRoomType])
GO
ALTER TABLE [Hotel_B_BookingLigne]  WITH CHECK ADD FOREIGN KEY([idUnit])
REFERENCES [hotel_S_Units] ([idUnit])
GO
ALTER TABLE [Hotel_B_BookingLigne]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Hotel_B_BookingPayment]  WITH CHECK ADD FOREIGN KEY([idBookingEntete])
REFERENCES [hotel_B_BookingEntete] ([idBookingEntete])
GO
ALTER TABLE [Hotel_B_BookingPayment]  WITH CHECK ADD FOREIGN KEY([idModRglm])
REFERENCES [b_ModRglm] ([idModRglm])
GO
ALTER TABLE [hotel_B_FilleInBookingEntete]  WITH CHECK ADD FOREIGN KEY([idBookingEntete])
REFERENCES [hotel_B_BookingEntete] ([idBookingEntete])
GO
ALTER TABLE [hotel_B_FilleInBookingEntete]  WITH CHECK ADD FOREIGN KEY([idFille])
REFERENCES [s_Fille] ([idFille])
GO
ALTER TABLE [hotel_S_Categorie]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [hotel_S_Categorie]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [hotel_S_Equipements]  WITH CHECK ADD FOREIGN KEY([idRoomType])
REFERENCES [hotel_S_RoomType] ([idRoomType])
GO
ALTER TABLE [hotel_S_Extras]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [hotel_S_Extras]  WITH CHECK ADD FOREIGN KEY([idTaxeExtras])
REFERENCES [b_Taxe] ([idTaxe])
GO
ALTER TABLE [hotel_S_Extras]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [hotel_S_RoomType]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [hotel_S_RoomType]  WITH CHECK ADD FOREIGN KEY([idTaxeLouer])
REFERENCES [b_Taxe] ([idTaxe])
GO
ALTER TABLE [hotel_S_RoomType]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [hotel_S_Units]  WITH CHECK ADD FOREIGN KEY([idRoomType])
REFERENCES [hotel_S_RoomType] ([idRoomType])
GO
ALTER TABLE [hotel_S_Units]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Maint_A_Equipements]  WITH CHECK ADD FOREIGN KEY([idArticle])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [Maint_A_Equipements]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Maint_A_Equipements]  WITH CHECK ADD FOREIGN KEY([idLign])
REFERENCES [e_EntetLign] ([idLign])
GO
ALTER TABLE [Maint_A_Equipements]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Maint_R_Request]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [Maint_R_Request]  WITH CHECK ADD FOREIGN KEY([idEquipement])
REFERENCES [Maint_A_Equipements] ([idEquipement])
GO
ALTER TABLE [Maint_R_Request]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Maint_R_Request]  WITH CHECK ADD FOREIGN KEY([idTeam])
REFERENCES [Maint_S_Team] ([idTeam])
GO
ALTER TABLE [Maint_R_Request]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Maint_S_Member]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Maint_S_Member]  WITH CHECK ADD FOREIGN KEY([idFournisseur])
REFERENCES [t_Fournisseur] ([idFournisseur])
GO
ALTER TABLE [Maint_S_Member]  WITH CHECK ADD FOREIGN KEY([idTeam])
REFERENCES [Maint_S_Team] ([idTeam])
GO
ALTER TABLE [Maint_S_Team]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Maint_S_Team]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [p_Caissier]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [p_Caissier]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [p_Famille]  WITH CHECK ADD FOREIGN KEY([idFamille])
REFERENCES [a_Famille] ([idFamille])
GO
ALTER TABLE [p_Famille]  WITH CHECK ADD FOREIGN KEY([idPos])
REFERENCES [p_Pos] ([idPos])
GO
ALTER TABLE [p_ModRglm]  WITH CHECK ADD FOREIGN KEY([idModRglm])
REFERENCES [b_ModRglm] ([idModRglm])
GO
ALTER TABLE [p_ModRglm]  WITH CHECK ADD FOREIGN KEY([idPos])
REFERENCES [p_Pos] ([idPos])
GO
ALTER TABLE [p_Pos]  WITH CHECK ADD FOREIGN KEY([clientDivers])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [p_Pos]  WITH CHECK ADD FOREIGN KEY([idDepot])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [p_Pos]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [p_Pos]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [p_Pos]  WITH CHECK ADD FOREIGN KEY([idTreso])
REFERENCES [b_Tresorerie] ([idTreso])
GO
ALTER TABLE [p_Pos]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [p_Session]  WITH CHECK ADD FOREIGN KEY([caissierOpen])
REFERENCES [p_Caissier] ([idCaissier])
GO
ALTER TABLE [p_Session]  WITH CHECK ADD FOREIGN KEY([caissierClose])
REFERENCES [p_Caissier] ([idCaissier])
GO
ALTER TABLE [p_Session]  WITH CHECK ADD FOREIGN KEY([idPos])
REFERENCES [p_Pos] ([idPos])
GO
ALTER TABLE [p_Ticket]  WITH CHECK ADD FOREIGN KEY([idCaissier])
REFERENCES [p_Caissier] ([idCaissier])
GO
ALTER TABLE [p_Ticket]  WITH CHECK ADD FOREIGN KEY([idClient])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [p_Ticket]  WITH CHECK ADD FOREIGN KEY([idSession])
REFERENCES [p_Session] ([idSession])
GO
ALTER TABLE [p_Ticket_ligne]  WITH CHECK ADD FOREIGN KEY([idproduct])
REFERENCES [a_Article] ([idArticle])
GO
ALTER TABLE [p_Ticket_ligne]  WITH CHECK ADD FOREIGN KEY([idTicket])
REFERENCES [p_Ticket] ([idTicket])
GO
ALTER TABLE [p_Ticket_Reg]  WITH CHECK ADD FOREIGN KEY([idModRglm])
REFERENCES [b_ModRglm] ([idModRglm])
GO
ALTER TABLE [p_Ticket_Reg]  WITH CHECK ADD FOREIGN KEY([idTicket])
REFERENCES [p_Ticket] ([idTicket])
GO
ALTER TABLE [Paie_C_Cotisations]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_C_Cotisations]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_C_Cotisations]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_C_Rubriques]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_C_Rubriques]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_C_Variables]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_C_Variables]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Calcul_Avance]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_Calcul_Avance]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Calcul_Avance]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Calcul_bulletin]  WITH CHECK ADD  CONSTRAINT [fk_Paie_Calcul_bulletin_dossier] FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [Paie_Calcul_bulletin] CHECK CONSTRAINT [fk_Paie_Calcul_bulletin_dossier]
GO
ALTER TABLE [Paie_Calcul_bulletin]  WITH CHECK ADD  CONSTRAINT [fk_Paie_Calcul_bulletin_groupUser] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Calcul_bulletin] CHECK CONSTRAINT [fk_Paie_Calcul_bulletin_groupUser]
GO
ALTER TABLE [Paie_Calcul_bulletin]  WITH CHECK ADD  CONSTRAINT [fk_Paie_Calcul_bulletin_user] FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Calcul_bulletin] CHECK CONSTRAINT [fk_Paie_Calcul_bulletin_user]
GO
ALTER TABLE [Paie_Calcul_bulletin_ligne]  WITH CHECK ADD  CONSTRAINT [fk_Paie_Calcul_bulletin_ligne_bulletin] FOREIGN KEY([IdBulletin])
REFERENCES [Paie_Calcul_bulletin] ([IdBulletin])
GO
ALTER TABLE [Paie_Calcul_bulletin_ligne] CHECK CONSTRAINT [fk_Paie_Calcul_bulletin_ligne_bulletin]
GO
ALTER TABLE [Paie_Calcul_bulletin_ligne]  WITH CHECK ADD  CONSTRAINT [fk_Paie_Calcul_bulletin_ligne_Employee] FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_Calcul_bulletin_ligne] CHECK CONSTRAINT [fk_Paie_Calcul_bulletin_ligne_Employee]
GO
ALTER TABLE [Paie_Calcul_Conges]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [Paie_Calcul_Conges]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_Calcul_Conges]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Calcul_Conges]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Calcul_Entete]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_Calcul_Entete]  WITH CHECK ADD FOREIGN KEY([idGrpEnt])
REFERENCES [Paie_Calcul_GrpEntete] ([idGrpEnt])
GO
ALTER TABLE [Paie_Calcul_GrpEntete]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [Paie_Calcul_GrpEntete]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Calcul_GrpEntete]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Calcul_LigneRubrique]  WITH CHECK ADD FOREIGN KEY([idEntete])
REFERENCES [Paie_Calcul_Entete] ([idEntete])
GO
ALTER TABLE [Paie_E_Conges]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [Paie_E_Conges]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_E_Conges]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_E_Conges]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_E_Contrat]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_E_Contrat]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_E_Contrat]  WITH CHECK ADD FOREIGN KEY([idProfil])
REFERENCES [paie_I_ProfilContrat] ([idProfil])
GO
ALTER TABLE [Paie_E_Contrat]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idCategorie])
REFERENCES [paie_I_Categorie] ([idCategorie])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idDepartement])
REFERENCES [paie_I_Departement] ([idDepartement])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idFonction])
REFERENCES [paie_I_Fonction] ([idFonction])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idModRglm])
REFERENCES [b_ModRglm] ([idModRglm])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idNiveau])
REFERENCES [paie_I_Niveau] ([idNiveau])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idPlanning])
REFERENCES [Paie_Z_Planning] ([idPlanning])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idUserDevice])
REFERENCES [Paie_Z_UserDevice] ([idUserDevice])
GO
ALTER TABLE [Paie_E_Employe]  WITH CHECK ADD FOREIGN KEY([idVille])
REFERENCES [b_Ville] ([idVille])
GO
ALTER TABLE [Paie_E_FilleInContrat]  WITH CHECK ADD FOREIGN KEY([idContrat])
REFERENCES [Paie_E_Contrat] ([idContrat])
GO
ALTER TABLE [Paie_E_FilleInContrat]  WITH CHECK ADD FOREIGN KEY([idFille])
REFERENCES [s_Fille] ([idFille])
GO
ALTER TABLE [Paie_E_Prets]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_E_Prets]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_E_Prets]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [paie_I_Categorie]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [paie_I_Categorie]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [paie_I_Departement]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [paie_I_Departement]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [paie_I_Fonction]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [paie_I_Fonction]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [paie_I_Niveau]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [paie_I_Niveau]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [paie_I_ProfilContrat]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [paie_I_ProfilContrat]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [paie_I_TauxFraisProf]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [paie_I_TauxFraisProf]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_P_POINTAGE]  WITH CHECK ADD  CONSTRAINT [fk_Paie_P_POINTAGE_idGroup] FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_P_POINTAGE] CHECK CONSTRAINT [fk_Paie_P_POINTAGE_idGroup]
GO
ALTER TABLE [Paie_P_POINTAGE]  WITH CHECK ADD  CONSTRAINT [fk_Paie_P_POINTAGE_idUser] FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_P_POINTAGE] CHECK CONSTRAINT [fk_Paie_P_POINTAGE_idUser]
GO
ALTER TABLE [Paie_P_POINTAGE]  WITH CHECK ADD  CONSTRAINT [fk_pointage_dossier] FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [Paie_P_POINTAGE] CHECK CONSTRAINT [fk_pointage_dossier]
GO
ALTER TABLE [Paie_P_POINTAGE_LIGNE]  WITH CHECK ADD  CONSTRAINT [fk_Paie_P_POINTAGE_LIGNE_idEmploye] FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_P_POINTAGE_LIGNE] CHECK CONSTRAINT [fk_Paie_P_POINTAGE_LIGNE_idEmploye]
GO
ALTER TABLE [Paie_P_POINTAGE_LIGNE]  WITH CHECK ADD  CONSTRAINT [fk_Paie_P_POINTAGE_LIGNE_idPointage] FOREIGN KEY([idPointage])
REFERENCES [Paie_P_POINTAGE] ([idPointage])
GO
ALTER TABLE [Paie_P_POINTAGE_LIGNE] CHECK CONSTRAINT [fk_Paie_P_POINTAGE_LIGNE_idPointage]
GO
ALTER TABLE [Paie_Z_LogData]  WITH CHECK ADD FOREIGN KEY([idEmploye])
REFERENCES [Paie_E_Employe] ([idEmploye])
GO
ALTER TABLE [Paie_Z_LogData]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Z_LogData]  WITH CHECK ADD FOREIGN KEY([idUserDevice])
REFERENCES [Paie_Z_UserDevice] ([idUserDevice])
GO
ALTER TABLE [Paie_Z_LogData]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Z_Planning]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Z_Planning]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Z_UserDevice]  WITH CHECK ADD FOREIGN KEY([idDevice])
REFERENCES [Paie_Z_ZKTDevices] ([idDevice])
GO
ALTER TABLE [Paie_Z_UserDevice]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Z_UserDevice]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [Paie_Z_ZKTDevices]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [Paie_Z_ZKTDevices]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idClient])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idEntet])
REFERENCES [e_Entet] ([idEntet])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idFournisseur])
REFERENCES [t_Fournisseur] ([idFournisseur])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idModRglm])
REFERENCES [b_ModRglm] ([idModRglm])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idTreso])
REFERENCES [b_Tresorerie] ([idTreso])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [r_Reglement]  WITH CHECK ADD  CONSTRAINT [fk_reglement_fish_entet] FOREIGN KEY([idEntetFish])
REFERENCES [fish_entet] ([idEntet])
GO
ALTER TABLE [r_Reglement] CHECK CONSTRAINT [fk_reglement_fish_entet]
GO
ALTER TABLE [r_ReglementInFille]  WITH CHECK ADD FOREIGN KEY([idFille])
REFERENCES [s_Fille] ([idFille])
GO
ALTER TABLE [r_ReglementInFille]  WITH CHECK ADD FOREIGN KEY([idReglement])
REFERENCES [r_Reglement] ([idReglement])
GO
ALTER TABLE [s_Dossier]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [s_EmailsSettings]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [s_EmailsSettings]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [s_Fille]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [s_Fille]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [s_LiaisonUsers]  WITH CHECK ADD FOREIGN KEY([idDepot])
REFERENCES [b_Depot] ([idDepot])
GO
ALTER TABLE [s_LiaisonUsers]  WITH CHECK ADD FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [s_LiaisonUsers]  WITH CHECK ADD FOREIGN KEY([idTreso])
REFERENCES [b_Tresorerie] ([idTreso])
GO
ALTER TABLE [s_LiaisonUsers]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [s_LiaisonUsers]  WITH CHECK ADD FOREIGN KEY([idVille])
REFERENCES [b_Ville] ([idVille])
GO
ALTER TABLE [s_MenuInstall]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [s_MenuInstall]  WITH CHECK ADD FOREIGN KEY([idMenu])
REFERENCES [s_Menu] ([idMenu])
GO
ALTER TABLE [s_MenuInstall]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [s_MenuSubInstall]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [s_MenuSubInstall]  WITH CHECK ADD FOREIGN KEY([idSubMenu])
REFERENCES [s_MenuSub] ([idSubMenu])
GO
ALTER TABLE [s_MenuSubInstall]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [s_Roles]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [s_Settings]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [s_UserDossier]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [s_UserDossier]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [s_UserRoles]  WITH CHECK ADD FOREIGN KEY([idRole])
REFERENCES [s_Roles] ([idRole])
GO
ALTER TABLE [s_UserRoles]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [s_Users]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [sb_CreationBarCode]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [sb_CreationBarCode]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [sb_CreationBarCode]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [sc_calendar]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [sc_calendar]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [sc_schedule]  WITH CHECK ADD FOREIGN KEY([idCalendar])
REFERENCES [sc_calendar] ([idCalendar])
GO
ALTER TABLE [sc_schedule]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [sc_schedule]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idVille])
REFERENCES [b_Ville] ([idVille])
GO
ALTER TABLE [t_Client]  WITH CHECK ADD FOREIGN KEY([idVille])
REFERENCES [b_Ville] ([idVille])
GO
ALTER TABLE [t_ClientCredit]  WITH CHECK ADD FOREIGN KEY([idClient])
REFERENCES [t_Client] ([idClient])
GO
ALTER TABLE [t_ClientCredit]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [t_Fournisseur]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [t_Fournisseur]  WITH CHECK ADD FOREIGN KEY([idPays])
REFERENCES [b_Pays] ([idPays])
GO
ALTER TABLE [t_Fournisseur]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [t_Fournisseur]  WITH CHECK ADD FOREIGN KEY([idVille])
REFERENCES [b_Ville] ([idVille])
GO
ALTER TABLE [t_FournisseurCredit]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [t_FournisseurCredit]  WITH CHECK ADD FOREIGN KEY([idFournisseur])
REFERENCES [t_Fournisseur] ([idFournisseur])
GO
ALTER TABLE [tr_TresorerieEntet]  WITH CHECK ADD FOREIGN KEY([idDossier])
REFERENCES [s_Dossier] ([idDossier])
GO
ALTER TABLE [tr_TresorerieEntet]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [tr_TresorerieEntet]  WITH CHECK ADD FOREIGN KEY([idModRglm])
REFERENCES [b_ModRglm] ([idModRglm])
GO
ALTER TABLE [tr_TresorerieEntet]  WITH CHECK ADD FOREIGN KEY([idService])
REFERENCES [b_Service] ([idService])
GO
ALTER TABLE [tr_TresorerieEntet]  WITH CHECK ADD FOREIGN KEY([idTreso])
REFERENCES [b_Tresorerie] ([idTreso])
GO
ALTER TABLE [tr_TresorerieEntet]  WITH CHECK ADD FOREIGN KEY([idTreso_2])
REFERENCES [b_Tresorerie] ([idTreso])
GO
ALTER TABLE [tr_TresorerieEntet]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
ALTER TABLE [u_UniteMesure]  WITH CHECK ADD FOREIGN KEY([idGroup])
REFERENCES [s_GroupUsers] ([idGroup])
GO
ALTER TABLE [u_UniteMesure]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [s_Users] ([idUser])
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_ArticleInsertUpdate](
	@idArticle int =null,
	@refArticle nvarchar(500)=null,
	@codeBareArticle nvarchar(500)=null,
	@nomArticle nvarchar(500)=null,
	@descArticle nvarchar(500)=null,
	@favorisArticle bit=0,
	@photoArticle nvarchar(500)=null,
	@achatArticle bit=1,
	@venteArticle bit=1,
	@locationArticle bit=0,
	@typeArticle nvarchar(500)='Standard',
	@mesureArticle nvarchar(50)=null,
	@prixAchat_HT money =0,
	@prixAchat_HT_1 money =0,
	@prixAchat_TTC money =0,
	@prixAchat_TTC_1 money =0,
	@prixVente_HT money =0,
	@prixVente_HT_1 money =0,
	@prixVente_HT_2 money =0,
	@prixVente_TTC money =0,
	@prixVente_TTC_1 money =0,
	@prixVente_TTC_2 money =0,
	@prixlocation_HT money =0,
	@prixlocation_TTC money =0,
	@classmentArticle nvarchar(250)=null,
	@stkMinArticle float=null,
	@qteBox float=1,
	@wooArticle bit=0,
	@metaWooArticle nvarchar(max)=null,
	@metaArticle nvarchar(max)=null,
	@pourCentArticle float=0,
	@idFamille int =null,
	@idTaxeAchat int=null,
	@idTaxeVente int=null,
	@idUser nvarchar(450)=null,
	@idGroup int=null,
	@checkDureDevie bit=0,
	@stateDureDevie nvarchar(100)='',
	@dureDevie int=0,
	@checkBateau bit=0,
	@idUnite int=null,
	@checkMaintenance bit=0,
	@codePdFini int=0,
	@PdFini bit=0,
	@statment varchar(100)
	)as begin
	
		if(@statment='insert')
		begin
		 if not exists(select * from a_Article where idGroup=@idGroup and refArticle=@refArticle)
		 begin 
			INSERT INTO a_Article
				   ([refArticle]
				   ,[codeBareArticle]
				   ,[nomArticle]
				   ,[descArticle]
				   ,[favorisArticle]
				   ,[photoArticle]
				   ,[achatArticle]
				   ,[venteArticle]
				   ,[locationArticle]
				   ,[typeArticle]
				   ,[mesureArticle]
				   ,[prixAchat_HT]
				   ,[prixAchat_HT_1]
				   ,[prixAchat_TTC]
				   ,[prixAchat_TTC_1]
				   ,[prixVente_HT]
				   ,[prixVente_HT_1]
				   ,[prixVente_TTC]
				   ,[prixVente_TTC_1]
				   ,[prixlocation_HT]
				   ,[prixlocation_TTC]
				   ,[classmentArticle]
				   ,[stkMinArticle]
				   ,[qteBox]
				   ,[wooArticle]
				   ,[metaWooArticle]
				   ,[metaArticle]
				   ,[pourCentArticle]
				   ,[idFamille]
				   ,[idTaxeAchat]
				   ,[idTaxeVente]
				   ,[idUser]
				   ,[idGroup],checkDureDevie,stateDureDevie,dureDevie,prixVente_HT_2,prixVente_TTC_2,checkBateau,idUnite,checkMaintenance,codePdFini,PdFini)
     VALUES
           (@refArticle
           ,@codeBareArticle
           ,@nomArticle
           ,@descArticle
           ,@favorisArticle
           ,@photoArticle
           ,@achatArticle
           ,@venteArticle
           ,@locationArticle
           ,@typeArticle
           ,@mesureArticle
           ,@prixAchat_HT
           ,@prixAchat_HT_1
           ,@prixAchat_TTC
           ,@prixAchat_TTC_1
           ,@prixVente_HT
           ,@prixVente_HT_1
           ,@prixVente_TTC
           ,@prixVente_TTC_1
           ,@prixlocation_HT
           ,@prixlocation_TTC
           ,@classmentArticle
           ,@stkMinArticle
           ,@qteBox
           ,@wooArticle
           ,@metaWooArticle
           ,@metaArticle
           ,@pourCentArticle
           ,@idFamille
           ,@idTaxeAchat
           ,@idTaxeVente
           ,@idUser
           ,@idGroup,@checkDureDevie,@stateDureDevie,@dureDevie,@prixVente_HT_2,@prixVente_TTC_2,@checkBateau,@idUnite,@checkMaintenance,@codePdFini,@PdFini)
			select * from a_tableArticle where idArticle=@@IDENTITY
		 end
		 else
			select * from a_tableArticle where refArticle=@refArticle and idGroup=@idGroup  	
		end	
		else
		begin
			if(@photoArticle is not null)
			begin
				update a_Article set photoArticle=@photoArticle where idArticle=@idArticle
			end
			UPDATE a_Article
			   SET [refArticle] = @refArticle
				  ,[codeBareArticle] = @codeBareArticle
				  ,[nomArticle] = @nomArticle
				  ,[descArticle] = @descArticle
				  ,[favorisArticle] = @favorisArticle
				  ,[achatArticle] = @achatArticle
				  ,[venteArticle] = @venteArticle
				  ,[locationArticle] = @locationArticle
				  ,[typeArticle] = @typeArticle
				  ,[mesureArticle]=@mesureArticle
				  ,[prixAchat_HT] = @prixAchat_HT
				  ,[prixAchat_HT_1] = @prixAchat_HT_1
				  ,[prixAchat_TTC] = @prixAchat_TTC
				  ,[prixAchat_TTC_1] = @prixAchat_TTC_1
				  ,[prixVente_HT] = @prixVente_HT
				  ,[prixVente_HT_1] = @prixVente_HT_1
				  ,[prixVente_TTC] = @prixVente_TTC
				  ,[prixVente_TTC_1] = @prixVente_TTC_1
				  ,[prixlocation_HT] = @prixlocation_HT
				  ,[prixlocation_TTC] = @prixlocation_TTC
				  ,[classmentArticle] = @classmentArticle
				  ,[stkMinArticle] = @stkMinArticle,
					qteBox=@qteBox
				  ,[wooArticle] = @wooArticle
				  ,[metaWooArticle] = @metaWooArticle
				  ,[metaArticle] = @metaArticle
				  ,[pourCentArticle] = @pourCentArticle
				  ,[idFamille] = @idFamille
				  ,[idTaxeAchat] = @idTaxeAchat
				  ,[idTaxeVente] = @idTaxeVente
				  ,checkDureDevie=@checkDureDevie
				  ,stateDureDevie=@stateDureDevie
				  ,dureDevie=@dureDevie
				  ,prixVente_HT_2=@prixVente_HT_2
				  ,prixVente_TTC_2=@prixVente_TTC_2
				  ,idUnite=@idUnite
				  ,checkMaintenance=@checkMaintenance
				  ,codePdFini=@codePdFini,
				  PdFini=@PdFini
			 WHERE idArticle= @idArticle
			 select * from a_tableArticle where idArticle=@idArticle
		end
		
	end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_BateauInsertUpdate](
  @idBateau int=-1,
  @idArticle int=null,
  @idClient int=null,
  @dimensionX float =0,
  @dimensionY float=0,
  @prixM money=0,
  @checkCollaboration bit=0,
  @dateDebut datetime=null,
  @dateFin datetime=null,
  @valider bit=0,
  @clotur bit=0,
  @refArticle nvarchar(500)=null,
  @nomArticle nvarchar(500)=null,
  @photoArticle nvarchar(500)=null,
  @venteArticle bit=1,
  @prixVente_HT money =0,
  @prixVente_TTC money =0,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @stateDureDevie nvarchar(100)='',
  @checkBateau bit=1,
  @statment varchar(100)='insert')
  as begin
	if(@statment='insert')
	begin
	
		insert into a_Article
				   ([refArticle]			   
				   ,[nomArticle]
				   ,[photoArticle]
				   ,[venteArticle]
				   ,[prixVente_HT]
				   ,[prixVente_TTC]
				   ,[idUser]
				   ,[idGroup],stateDureDevie,checkBateau) values(@refArticle			   
				   ,@nomArticle
				   ,@photoArticle
				   ,@venteArticle
				   ,@prixVente_HT
				   ,@prixVente_TTC
				   ,@idUser
				   ,@idGroup,@stateDureDevie,@checkBateau)
		select @idArticle=idArticle from a_Article where idArticle=@@IDENTITY
		if(@idArticle is not null)
			begin
				insert into a_Bateau(idArticle,idClient,dimensionX,dimensionY,prixM,checkCollaboration,dateDebut,dateFin,valider,clotur)
				values(@idArticle,@idClient,@dimensionX,@dimensionY,@prixM,@checkCollaboration,@dateDebut,@dateFin,@valider,@clotur)
				select * from a_tableBateau where idBateau=@@IDENTITY
			end
			
	end
	else
	begin
		
		select @idArticle=a.idArticle from a_Article a inner join a_Bateau b on a.idArticle=b.idArticle where b.idBateau=@idBateau	
		if(@photoArticle is not null)
			begin
				update a_Article set photoArticle=@photoArticle where idArticle=@idArticle
			end
		update a_Article set [refArticle]=@refArticle			   
				   ,[nomArticle]=@nomArticle
				   ,[prixVente_HT]=@prixVente_HT
				   ,[prixVente_TTC]=@prixVente_TTC
				   ,stateDureDevie=@stateDureDevie where idArticle=@idArticle
		update a_Bateau set idClient=@idClient
							,dimensionX=@dimensionX,dimensionY=@dimensionY,
							prixM=@prixM,checkCollaboration=@checkCollaboration,
							dateDebut=@dateDebut,dateFin=@dateFin,valider=@valider,clotur=@clotur where idBateau=@idBateau
		select * from a_tableBateau where idBateau=@idBateau				
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [a_CheckRefCodeBarr](
 	@idGroup int,
 	@refArticle nvarchar(500)=null,
 	@codeBareArticle nvarchar(500)=null)
 	as begin
 		select (select COUNT(*) from a_Article where refArticle=@refArticle and idGroup=@idGroup) as 'countRef',
 				(select COUNT(*) from a_Article where codeBareArticle=@codeBareArticle and idGroup=@idGroup) as 'countCodeBare' 
 	end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_copierArticle](
@refArt varchar(500),
@refCopier varchar(500),
@idUser nvarchar(450),
@idGroup int
)
as begin
	  insert into a_Article([refArticle],[codeBareArticle],[nomArticle],[descArticle],[favorisArticle],[photoArticle],[achatArticle]
						   ,[venteArticle],[locationArticle],[typeArticle],[mesureArticle],[prixAchat_HT],[prixAchat_HT_1],[prixAchat_TTC]
				           ,[prixAchat_TTC_1],[prixVente_HT],[prixVente_HT_1],[prixVente_TTC],[prixVente_TTC_1],[prixlocation_HT]
				           ,[prixlocation_TTC],[classmentArticle],[stkMinArticle],[qteBox],[wooArticle],[metaWooArticle],[metaArticle]
				           ,[pourCentArticle],[idFamille],[idTaxeAchat],[idTaxeVente],[idUser]
				           ,[idGroup],checkDureDevie,stateDureDevie,dureDevie,prixVente_HT_2,prixVente_TTC_2,checkBateau,idUnite) 
	  select @refCopier,[codeBareArticle],[nomArticle],[descArticle],[favorisArticle],[photoArticle],[achatArticle]
						   ,[venteArticle],[locationArticle],[typeArticle],[mesureArticle],[prixAchat_HT],[prixAchat_HT_1],[prixAchat_TTC]
				           ,[prixAchat_TTC_1],[prixVente_HT],[prixVente_HT_1],[prixVente_TTC],[prixVente_TTC_1],[prixlocation_HT]
				           ,[prixlocation_TTC],[classmentArticle],[stkMinArticle],[qteBox],[wooArticle],[metaWooArticle],[metaArticle]
				           ,[pourCentArticle],[idFamille],[idTaxeAchat],[idTaxeVente],@idUser
				           ,@idGroup,checkDureDevie,stateDureDevie,dureDevie,prixVente_HT_2,prixVente_TTC_2,checkBateau,idUnite 
							from a_Article where refArticle = @refArt
							
							select * from a_tableArticle where refArticle=@refCopier
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_etat_pltLoteUpdate](
@idEntet int=null,
@idEntetFish int=null,
@numBonL_plt nvarchar(max)=null,
@facturNumL_plt nvarchar(max)=null,
@duaL_plt nvarchar(max)=null,
@loteL_plt nvarchar(max)=null,
@quantiteL_plt float=null,
@expeditoLP_plt nvarchar(max)=null,
@factureLP_plt nvarchar(max)=null,
@quantiteLP_plt float=null,
@DETLP_plt nvarchar(max)=null
  )
as begin
	if(@idEntetFish is not null)
	begin
	update fish_entet
	set numBonL_plt=@numBonL_plt,facturNumL_plt=@facturNumL_plt,duaL_plt=@duaL_plt,quantiteL_plt=@quantiteL_plt,LoteL_plt=@loteL_plt
	where idEntet=@idEntetFish
	end
	if (@idEntet is not null)
	begin
	update e_Entet
	set expeditoLP_plt=@expeditoLP_plt,factureLP_plt=@factureLP_plt,quantiteLP_plt=@quantiteLP_plt,DETLP_plt=@DETLP_plt
	where idEntet=@idEntet
	end
	exec dbo.etat_plt
end

        --numBonL_plt NVARCHAR(MAX),
        --dateL_plt DATE,
        --facturNumL_plt NVARCHAR(MAX),
        --duaL_plt NVARCHAR(MAX),
        --loteL_plt NVARCHAR(MAX),
        --quantiteL_plt FLOAT,
        --idEntet INT,
        --expeditoLP_plt NVARCHAR(MAX),
        --fechaLP_plt DATE,
        --factureLP_plt NVARCHAR(MAX),
        --dauLP_plt NVARCHAR(MAX),
        --loteLP_plt NVARCHAR(MAX),

        --quantiteLP_plt FLOAT
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_etat_pltUpdate](
@idEntet int=null,
@idEntetFish int=null,
@numBon_plt nvarchar(max)=null,
@facturNum_plt nvarchar(max)=null,
@dua_plt nvarchar(max)=null,
@quantite_plt float=null,
@expeditoP_plt nvarchar(max)=null,
@factureP_plt nvarchar(max)=null,
@quantiteP_plt float=null
  )
as begin
	if(@idEntetFish is not null)
	begin
	update fish_entet
	set numBon_plt=@numBon_plt,facturNum_plt=@facturNum_plt,dua_plt=@dua_plt,quantite_plt=@quantite_plt
	where idEntet=@idEntetFish
	end
	if (@idEntet is not null)
	begin
	update e_Entet
	set expeditoP_plt=@expeditoP_plt,factureP_plt=@factureP_plt,quantiteP_plt=@quantiteP_plt
	where idEntet=@idEntet
	end
	exec dbo.etat_plt
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_FamilleInsertUpdate](
  @idFamille int=null,
  @nomFamille nvarchar(max)=null,
  @CDE_FAO nvarchar(max)=null,
  @idNomScientifique bigint=null,
  @idTypeFamaille bigint=null,
  @idPays int=1,
  @desFamille nvarchar(500)=null,
  @photoFamille nvarchar(max)=null,
  @wooFamille bit=0,
  @parentId int =0,
  @idWooCategories int =null,
  @idUser nvarchar(450) =null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	
	if(@statment='insert')
	begin
		insert a_Famille(nomFamille,desFamille,photoFamille,wooFamille,parentId,idUser,idGroup,CDE_FAO,idNomScientifique,idPays,idTypeFamaille) 
		values (@nomFamille,@desFamille,@photoFamille,@wooFamille,@parentId,@idUser,@idGroup,@CDE_FAO,@idNomScientifique,@idPays,@idTypeFamaille)
		select * from a_tablefamille where idFamille=@@IDENTITY
	end	
	else
	begin
		if(@photoFamille is null)
			begin
				update a_Famille set nomFamille=@nomFamille,desFamille=@desFamille,wooFamille=@wooFamille,parentId=@parentId
				,CDE_FAO=@CDE_FAO,idNomScientifique=idNomScientifique,idPays=@idPays,idTypeFamaille=@idTypeFamaille
				where idFamille=@idFamille
				select * from a_tablefamille where idFamille=@idFamille
			end
		else
			begin
				update a_Famille set nomFamille=@nomFamille,desFamille=@desFamille,photoFamille=@photoFamille,wooFamille=@wooFamille,parentId=@parentId
				,CDE_FAO=@CDE_FAO,idNomScientifique=idNomScientifique,idPays=@idPays,idTypeFamaille=@idTypeFamaille
				where idFamille=@idFamille
				select * from a_tablefamille where idFamille=@idFamille
			end			
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_FamilleSelectByDate](
 @idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null,
@dateEntet date=null
)
  as begin
  if @dateEntet!=''
  begin
	select DISTINCT af.idFamille,af.nomFamille from a_Famille af inner join fish_entet fd ON af.idFamille = fd.idFamille

	where (@SelectALL=0 and fd.idGroup=@idGroup and fd.dateEntet=@dateEntet) or (@SelectALL=1 and fd.idUser=@idUser and fd.dateEntet=@dateEntet)
  end
  else
  begin
	select * from a_Famille where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_Generateur_Ref](
 	@idGroup int=1)
 	as begin
 		select top 1  refArticle  from a_Article 			
		where idGroup=@idGroup and refArticle like 'AR[0-9]%' 
		order by CAST(SUBSTRING(refArticle + '0', PATINDEX('%[0-9]%', refArticle + '0'), LEN(refArticle + '0')) AS numeric) desc
 	end

	select * from s_Users
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_Generateur_Ref2](
 	@idGroup int=1)
 	as begin
 		select top 1  refArticle from a_Article where idGroup=1 and refArticle like 'AR[0-9]%' order by refArticle desc
 	end

	select * from s_Users
	
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_GestionQte](
  @id int,
  @idDossier int,
  @idUser nvarchar(450),
  @SelectDoc bit=null,
  @dateD datetime=null,
  @dateE datetime=null,
  @statment varchar(100))
  as begin
	if(@statment='parArticle')
	begin
		select *,cmup*qteDepot as valeurCmup,firstPrix*qteDepot as valeurfirstPrix,lastPrix*qteDepot as valeurlastPrix 
		from a_tableGestionQte 
		where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and idArticle=@id) 
											or (@SelectDoc=0 and idDossier=@idDossier and idArticle=@id ))	
											and idDepot IS NOT NULL	
	end
	if(@statment='parFamille')
	begin
		select *,cmup*qteDepot as valeurCmup,firstPrix*qteDepot as valeurfirstPrix,lastPrix*qteDepot as valeurlastPrix 
		from a_tableGestionQte 
		where 
		((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and idFamille=@id) 
											or (@SelectDoc=0 and idDossier=@idDossier and idFamille=@id )) 	and idDepot IS NOT NULL	
	end
	if(@statment='parDepot')
	begin
		select *,cmup*qteDepot as valeurCmup,firstPrix*qteDepot as valeurfirstPrix,lastPrix*qteDepot as valeurlastPrix 
		from a_tableGestionQte 
		where 
		((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and idDepot=@id) 
											or (@SelectDoc=0 and idDossier=@idDossier and idDepot=@id ))
	end
	if(@statment='parDepotSample')
	begin
		select *,cmup*qteDepot as valeurCmup,firstPrix*qteDepot as valeurfirstPrix,lastPrix*qteDepot as valeurlastPrix 
		from a_tableGestionQte 
		where 
		((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and idDepot=@id) 
											or (@SelectDoc=0 and idDossier=@idDossier and idDepot=@id ))
	end
	if(@statment='parEmplacement')
	begin
		select *,cmup*qteDepot as valeurCmup,firstPrix*qteDepot as valeurfirstPrix,lastPrix*qteDepot as valeurlastPrix 
		from a_tableGestionQte 
		where 
		((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and idSupDepot=@id) 
											or (@SelectDoc=0 and idDossier=@idDossier and idSupDepot=@id ))
	end
	if(@statment='articleParDoc')
	begin
		if(@id=-1)
		begin
			select
			(CASE WHEN t.descType='INVENTAIRE' THEN 'Inventaire' 
				  WHEN t.descType='Mouvement transfert' THEN 'Mouvement Transfert' 
				  ELSE e.nom 
			 END) as nom
			,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.numFactur from e_Entet e
			inner join e_EntetLign eL on eL.idEntet=e.idEntet
			inner join e_TypeDoc t on t.codeType=e.codeType
			where 
			((@SelectDoc=1 and e.idUser=@idUser and e.idDossier=@idDossier and e.dateEntet between @dateD and @dateE) 
												or (@SelectDoc=0 and e.idDossier=@idDossier and e.dateEntet between @dateD and @dateE))
			group by eL.idArticle,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.nom,e.numFactur
		end
		else
		begin
			select
			(CASE WHEN t.descType='INVENTAIRE' THEN 'Inventaire' 
				  WHEN t.descType='Mouvement transfert' THEN 'Mouvement Transfert' 
				  ELSE e.nom 
			 END) as nom
			,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.numFactur from e_Entet e
			inner join e_EntetLign eL on eL.idEntet=e.idEntet
			inner join e_TypeDoc t on t.codeType=e.codeType
			where 
			((@SelectDoc=1 and e.idUser=@idUser and e.idDossier=@idDossier and idArticle=@id and e.dateEntet between @dateD and @dateE) 
												or (@SelectDoc=0 and e.idDossier=@idDossier and idArticle=@id and e.dateEntet between @dateD and @dateE))
			group by eL.idArticle,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.nom,e.numFactur
		end	
	end
	if(@statment='mvmArticle')
	begin
		if(@id=-1)
		begin
			
		select
			(CASE WHEN t.codeType='INVT' THEN 'Inventaire' 
				  WHEN t.codeType='MVTR' and e.idDepot IS NULL THEN 'Mouvement Transfert' 
				  WHEN t.codeType='MVTR' and s.idSupDepot IS NULL THEN 'Du '+d.nomDepot+' au '+d2.nomDepot
				  WHEN t.codeType='MVTR' and s.idSupDepot IS NOT NULL THEN 'Du '+d.nomDepot+' ( '+ s.nomSupDepot +' ) au ' +d2.nomDepot+' ( '+ s2.nomSupDepot +' ) '
				  ELSE e.nom 
			 END) as nom,
			(CASE WHEN t.codeType='MVTR' THEN d2.nomDepot
				  ELSE d.nomDepot
				  END) as nomDepot
			,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.dateEntet,e.numFactur from e_Entet e
			inner join e_EntetLign eL on eL.idEntet=e.idEntet
			left join b_Depot d on d.idDepot=e.idDepot
			left join b_Depot d2 on d2.idDepot=e.idDepot_2
			left join b_DepotSup s on s.idSupDepot=eL.idSupDepot
			left join b_DepotSup s2 on s2.idSupDepot=eL.idSupDepot_2
			inner join e_TypeDoc t on t.codeType=e.codeType and t.idDossier=e.idDossier
			where ((t.valStock=-1 or t.valStock=1) or ( e.codeType='MVTR' and e.valider=1))and
			((@SelectDoc=1 and e.idUser=@idUser and e.idDossier=@idDossier and e.dateEntet between @dateD and @dateE) 
												or (@SelectDoc=0 and e.idDossier=@idDossier and e.dateEntet between @dateD and @dateE)) 
			group by eL.idArticle,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.nom,e.idDepot,
			s.idSupDepot,d.nomDepot,d2.nomDepot,s.nomSupDepot,d2.nomDepot,s2.nomSupDepot,e.dateEntet,t.codeType,e.numFactur
		end
		else
		begin
		select
			(CASE WHEN t.codeType='INVT' THEN 'Inventaire' 
				  WHEN t.codeType='MVTR' and e.idDepot IS NULL THEN 'Mouvement Transfert' 
				  WHEN t.codeType='MVTR' and s.idSupDepot IS NULL THEN 'Du '+d.nomDepot+' au '+d2.nomDepot
				  WHEN t.codeType='MVTR' and s.idSupDepot IS NOT NULL THEN 'Du '+d.nomDepot+' ( '+ s.nomSupDepot +' ) au ' +d2.nomDepot+' ( '+ s2.nomSupDepot +' ) '
				  ELSE e.nom 
			 END) as nom,
			(CASE WHEN t.codeType='MVTR' THEN d2.nomDepot
				  ELSE d.nomDepot
				  END) as nomDepot
			,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.dateEntet,e.numFactur from e_Entet e
			inner join e_EntetLign eL on eL.idEntet=e.idEntet
			left join b_Depot d on d.idDepot=e.idDepot
			left join b_Depot d2 on d2.idDepot=e.idDepot_2
			left join b_DepotSup s on s.idSupDepot=eL.idSupDepot
			left join b_DepotSup s2 on s2.idSupDepot=eL.idSupDepot_2
			inner join e_TypeDoc t on t.codeType=e.codeType and t.idDossier=e.idDossier
			where ((t.valStock=-1 or t.valStock=1) or ( e.codeType='MVTR' and e.valider=1))and
			((@SelectDoc=1 and e.idUser=@idUser and e.idDossier=@idDossier and idArticle=@id and e.dateEntet between @dateD and @dateE) 
												or (@SelectDoc=0 and e.idDossier=@idDossier and idArticle=@id and e.dateEntet between @dateD and @dateE))
			group by eL.idArticle,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.nom,e.idDepot,
			s.idSupDepot,d.nomDepot,d2.nomDepot,s.nomSupDepot,d2.nomDepot,s2.nomSupDepot,e.dateEntet,t.codeType,e.numFactur
		end	
	end
	if(@statment='mvmFamille')
	begin
	if(@id=-1)
		begin
			select
		(CASE WHEN t.descType='INVENTAIRE' THEN 'Inventaire' 
		      WHEN t.descType='Mouvement transfert' THEN 'Mouvement Transfert' 
		      ELSE e.nom 
		 END) as nom,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,f.nomFamille,e.numFactur from e_Entet e
		inner join e_EntetLign eL on eL.idEntet=e.idEntet
		inner join e_TypeDoc t on t.codeType=e.codeType
		inner join a_Article a on a.idArticle=eL.idArticle
		inner join a_Famille f on f.idFamille=a.idFamille
		where 
		((@SelectDoc=1 and e.idUser=@idUser and e.idDossier=@idDossier and e.dateEntet between @dateD and @dateE) 
											or (@SelectDoc=0 and e.idDossier=@idDossier and e.dateEntet between @dateD and @dateE))
		group by eL.idArticle,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.nom,f.nomFamille,e.numFactur 
		end
		else 
		begin
			select
				(CASE WHEN t.descType='INVENTAIRE' THEN 'Inventaire' 
				  WHEN t.descType='Mouvement transfert' THEN 'Mouvement Transfert' 
				  ELSE e.nom 
				 END) as nom,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,f.nomFamille,e.numFactur from e_Entet e
				inner join e_EntetLign eL on eL.idEntet=e.idEntet
				inner join e_TypeDoc t on t.codeType=e.codeType
				inner join a_Article a on a.idArticle=eL.idArticle
				inner join a_Famille f on f.idFamille=a.idFamille
				where 
				((@SelectDoc=1 and e.idUser=@idUser and e.idDossier=@idDossier and f.idFamille=@id and e.dateEntet between @dateD and @dateE) 
													or (@SelectDoc=0 and e.idDossier=@idDossier and f.idFamille=@id and e.dateEntet between @dateD and @dateE))
				group by eL.idArticle,eL.refArticle,eL.descLign,eL.prixHT,eL.prixTTC,eL.qteLign,eL.lgnHT,eL.lgnTTC,t.descType,eL.idArticle,e.nom,f.nomFamille,e.numFactur 
		end
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [a_GestionQteEmplacement](
@idDepot int=null,
@idArticle int=null
)as
begin
	select * from a_tableGestionQte 
	where idSupDepot in( 
							select idSupDepot from b_DepotSup where idDepot=@idDepot 
						) and idArticle=@idArticle
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [a_LoteSelectByDate](
@dateEntet date=null
)
  as begin
  if @dateEntet!=''
  begin
	--select DISTINCT Lote from fish_entet where Lote is not null and dateEntet=@dateEntet
	select lote,dua from fish_entet where dateEntet=@dateEntet

  end
  else
  begin
	--select DISTINCT Lote,DUA from fish_entet where Lote is not null
	select lote,dua from fish_entet
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_DepotInsertUpdate](
@idDepot int=0,
@nomDepot nvarchar(100),
@adressDepot nvarchar(200),
@prcpDepot bit,
@idVille int=null,
@idPays int=null,
@idUser nvarchar(450) =null,
@idGroup int=null,
@SelectALL bit,
@statment varchar(100))
as begin
	if(@prcpDepot=1)
		begin
			if(@SelectALL=1)
				update b_Depot set prcpDepot=0 where idUser=@idUser
			else
				update b_Depot set prcpDepot=0 where idGroup=@idGroup	
		end
	if(@statment='insert')
	begin
		insert b_Depot(nomDepot,adressDepot,prcpDepot,idVille,idPays,idUser,idGroup) values (@nomDepot,@adressDepot,@prcpDepot,@idVille,@idPays,@idUser,@idGroup)
		select * from b_Depot where idDepot=@@IDENTITY
	end	
	else
	begin
		update b_Depot set nomDepot=@nomDepot,adressDepot=@nomDepot,prcpDepot=@prcpDepot,idVille=@idVille,idPays=@idPays where idDepot=@idDepot
		select * from b_Depot where idDepot=@idDepot
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_DepotSelect](
@idUser nvarchar(450),
@SelectALL bit,
@idGroup int=null
)as
begin
if not exists (select *FROM s_LiaisonUsers WHERE idUser = @idUser)
begin
	if(@SelectALL=1)
	begin 
		select * from b_Depot where idUser=@idUser order by prcpDepot desc
	end
	else
	begin
		select * from b_Depot where idGroup=@idGroup order by prcpDepot desc
	end
end
else
begin
	if(@SelectALL=1)
	begin 
		select d.* from s_LiaisonUsers l inner join b_Depot d ON d.idDepot = l.idDepot
		WHERE l.idUser = @idUser
		UNION All
		SELECT d.*
		FROM b_Depot d 
		WHERE d.idDepot NOT IN (
		  SELECT idDepot
		  FROM s_LiaisonUsers
		  WHERE idUser = @idUser) and d.idUser=@idUser
	end
	else
	begin
		select d.* from s_LiaisonUsers l inner join b_Depot d ON d.idDepot = l.idDepot
		WHERE l.idUser = @idUser
		UNION All
		SELECT d.*
		FROM b_Depot d 
		WHERE d.idDepot NOT IN (
		  SELECT idDepot
		  FROM s_LiaisonUsers
		  WHERE idUser = @idUser) and d.idGroup=@idGroup
	end
end
	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [b_DepotSupInsertUpdate](
@idDepot int=0,
@idSupDepot int=0,
@nomSupDepot nvarchar(100)=null,
@typeSupDepot nvarchar(100)=null,
@couloirX nvarchar(100)=null,
@rayonY nvarchar(100)=null,
@hauteur nvarchar(100)=null,
@codeBare nvarchar(100)=null,
@idUser nvarchar(450) =null,
@idGroup int=null,
@statment varchar(100))
as begin
	if(@statment='insert')
	begin
		insert b_DepotSup(nomSupDepot,typeSupDepot,couloirX,rayonY,hauteur,codeBare,idUser,idGroup,idDepot) 
		values (@nomSupDepot,@typeSupDepot,@couloirX,@rayonY,@hauteur,@codeBare,@idUser,@idGroup,@idDepot)
		select * from b_tableDepotSup where idSupDepot=@@IDENTITY
	end	
	else
	begin
		update b_DepotSup set nomSupDepot=@nomSupDepot,typeSupDepot=@typeSupDepot,couloirX=@couloirX,
		rayonY=@rayonY,hauteur=@hauteur,codeBare=@codeBare where idSupDepot=@idSupDepot
		select * from b_tableDepotSup where idSupDepot=@idSupDepot
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_ModRglmInsertUpdate](
  @idModRglm int =null,
  @nomModRglm nvarchar(100)=null,
  @categModRglm nvarchar(100)=null,
  @timbre money=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert b_ModRglm(nomModRglm ,categModRglm,timbre,idUser,idGroup) values (@nomModRglm ,@categModRglm,@timbre,@idUser,@idGroup)
		select * from b_ModRglm where idModRglm=@@IDENTITY
	end
	else
	begin
		update b_ModRglm set nomModRglm=@nomModRglm ,categModRglm=@categModRglm,timbre=@timbre where idModRglm=@idModRglm
		select * from b_ModRglm where idModRglm=@idModRglm
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [b_PaysInsertUpdate](
  @idPays int=null,
  @nomPays nvarchar(50)=null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert b_Pays(nomPays,idGroup) values (@nomPays,@idGroup)
		select * from b_Pays where idPays=@@IDENTITY
	end
	else
	begin
		update b_Pays set nomPays=@nomPays where idPays=@idPays
		select * from b_Pays where idPays=@idPays
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [b_PaysSelect](
  @idUser nvarchar(450),
  @idGroup int=null)
  as begin
	select d.* from s_LiaisonUsers l inner join b_Pays d ON d.idPays = l.idPays
			WHERE l.idUser = @idUser
			UNION All
			SELECT d.*
			FROM b_Pays d 
			WHERE d.idPays NOT IN (
			  SELECT idPays
			  FROM s_LiaisonUsers
			  WHERE idUser = @idUser) and d.idGroup=@idGroup
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_ProprieteInsertUpdate](
@idPropriete int=0,
@nomPropriete nvarchar(500),
@idUser nvarchar(450)=null,
@idGroup int=null,
@statment varchar(100))
as begin
	if(@statment='insert')
	begin
		insert b_Propriete(nomPropriete,idUser,idGroup) values (@nomPropriete,@idUser,@idGroup)
		select * from b_Propriete where idPropriete=@@IDENTITY
	end	
	else
	begin
		update b_Propriete set nomPropriete=@nomPropriete where idPropriete=@idPropriete
		select * from b_Propriete where idPropriete=@idPropriete
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_ServiceInsertUpdate](
  @idService int=null,
  @nomService nvarchar(200)=null,
  @descService nvarchar(300)=null,
  @idGroup int=null,
  @idUser nvarchar(450)=null,
  @statment varchar(100)='insert'
  )
  as begin
	if(@statment='insert')
	begin
		insert b_Service(nomService,descService,idGroup,idUser) values (@nomService,@descService,@idGroup,@idUser)
		select * from b_Service where idService=@@IDENTITY
	end
	else
	begin
		update b_Service set nomService=@nomService,descService=@descService where idService=@idService
		select * from b_Service where idService=@idService
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [b_TaxeInsertUpdate](
@idTaxe int =null,
@nomTaxe nvarchar(100)=null,
@typeTaxe nvarchar(100)=null,
@cauxTaxe int=null,
@idGroup int=null,
@statment varchar(100)
)
as begin
	if(@statment='insert')
	begin
		insert b_Taxe(nomTaxe,typeTaxe,cauxTaxe,idGroup) values (@nomTaxe,@typeTaxe,@cauxTaxe,@idGroup)
		select * from b_Taxe where idTaxe=@@IDENTITY
	end
	else
	begin
		update b_Taxe set nomTaxe=@nomTaxe,typeTaxe=@typeTaxe,cauxTaxe=@cauxTaxe where idTaxe=@idTaxe
		select * from b_Taxe where idTaxe=@idTaxe
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_TresorInsertUpdate](
  @idTreso int=null ,
  @nameTreso nvarchar(100),
  @ribTreso nvarchar(100),
  @adresseTreso nvarchar(100),
  @soldAutoriseTreso money=0,
  @cherfTreso money=0,
  @defaultTreso bit = 0,
  @idUser nvarchar(450)=null,
  @idGroup int =null,
  @SelectALL bit,
  @statment varchar(100))
  as begin
	if(@defaultTreso=1)
		begin
			if(@SelectALL=1)
				update b_Tresorerie set defaultTreso=0 where idUser=@idUser
			else
				update b_Tresorerie set defaultTreso=0 where idGroup=@idGroup	
		end
	if(@statment='insert')
	begin
		insert b_Tresorerie(nameTreso,ribTreso,adresseTreso,soldAutoriseTreso,cherfTreso,defaultTreso,idUser,idGroup) values (@nameTreso,@ribTreso,@adresseTreso,@soldAutoriseTreso,@cherfTreso,@defaultTreso,@idUser,@idGroup)
		select * from b_Tresorerie where idTreso=@@IDENTITY
	end
	else
	begin
		update b_Tresorerie set nameTreso=@nameTreso,ribTreso=@ribTreso,adresseTreso=@adresseTreso,soldAutoriseTreso=@soldAutoriseTreso,cherfTreso=@cherfTreso,defaultTreso=@defaultTreso where idTreso=@idTreso
		select * from b_Tresorerie where idTreso=@idTreso
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_TresorSelect](
  @idUser nvarchar(450),
  @SelectALL bit,
  @idGroup int=null)
  as begin
	if not exists (select *FROM s_LiaisonUsers WHERE idUser = @idUser)
		begin
			if(@SelectALL=1)
			begin 
				select * from b_Tresorerie where idUser=@idUser
			end
			else
			begin
				select * from b_Tresorerie where idGroup=@idGroup
			end
		end
	else
	begin
		if(@SelectALL=1)
		begin 
			select d.* from s_LiaisonUsers l inner join b_Tresorerie d ON d.idTreso = l.idTreso
			WHERE l.idUser = @idUser
			UNION All
			SELECT d.*
			FROM b_Tresorerie d 
			WHERE d.idTreso NOT IN (
			  SELECT idTreso
			  FROM s_LiaisonUsers
			  WHERE idUser = @idUser) and d.idUser=@idUser
		end
		else
		begin
			select d.* from s_LiaisonUsers l inner join b_Tresorerie d ON d.idTreso = l.idTreso
			WHERE l.idUser = @idUser
			UNION All
			SELECT d.*
			FROM b_Tresorerie d 
			WHERE d.idTreso NOT IN (
			  SELECT idTreso
			  FROM s_LiaisonUsers
			  WHERE idUser = @idUser) and d.idGroup=@idGroup
		end
	end	
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_VilleInsertUpdate](
  @idVille int=null,
  @nomVille nvarchar(50)=null,
  @idGroup int=null,
  @idPays int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert b_Ville(nomVille,idGroup,idPays) values (@nomVille,@idGroup,@idPays)
		select * from b_Ville b inner join b_Pays p on b.idPays=p.idPays where idVille=@@IDENTITY
	end
	else
	begin
		update b_Ville set nomVille=@nomVille,idPays=@idPays where idVille=@idVille
		select * from b_Ville b inner join b_Pays p on b.idPays=p.idPays where idVille=@idVille
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [b_VilleSelect](
  @idUser nvarchar(450),
  @idGroup int=null)
  as begin
  select v.*,p.nomPays from b_Ville v inner join b_Pays p on v.idPays=p.idPays where v.idGroup=@idGroup and p.idGroup=@idGroup
	--select d.* from s_LiaisonUsers l inner join b_Ville d ON d.idVille = l.idVille
	--		WHERE l.idUser = @idUser
	--		UNION All
	--		SELECT d.*
	--		FROM b_Ville d 
	--		WHERE d.idVille NOT IN (
	--		  SELECT idVille
	--		  FROM s_LiaisonUsers
	--		  WHERE idUser = @idUser) and d.idGroup=@idGroup
  end




GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [ch_ChiffreAffaire]
(
@name varchar(20),
@idDossier int,
@dateE datetime,
@dateS datetime
)
as
begin
declare @total money
	if @name='cacl'
	begin
		select @total=SUM(TT_ht) from t_Client c
		inner join e_Entet e on e.idClient=c.idClient
		where dateEntet between @dateS and @dateE and codeType='BLFC' and idDossier=@idDossier and valider=1
		select c.codeClient,c.nomClient,sum(TT_ht) as chiffre_affaire,(sum(TT_ht)*100)/@total as pour
		from t_Client c
		inner join e_Entet e on e.idClient=c.idClient
		 where dateEntet between @dateS and @dateE and codeType='BLFC' and idDossier=@idDossier and valider=1
		group by e.idClient,nomClient,codeClient
	end
	else if @name='caar'
	begin
		select @total=sum(prixHT * qteLign) from e_EntetLign el
		inner join e_Entet e on el.idEntet=e.idEntet
		where dateEntet between @dateS and @dateE and codeType='BLFC' and idDossier=@idDossier and valider=1
		select a.refArticle,a.nomArticle,sum(prixHT * qteLign) as chiffre_affaire, (sum(prixHT * qteLign)*100)/@total as pour from e_EntetLign el
		inner join e_Entet e on el.idEntet=e.idEntet
		inner join a_Article a on el.idArticle=a.idArticle
		where dateEntet between @dateS and @dateE and codeType='BLFC' and idDossier=@idDossier and valider=1
		group by a.idArticle,nomArticle,a.refArticle
	end
	else if @name='cafa'
	begin
		select @total=sum(prixHT * qteLign) from e_EntetLign el
		inner join e_Entet e on el.idEntet=e.idEntet
		where dateEntet between @dateS and @dateE and codeType='BLFC' and idDossier=@idDossier and valider=1
		select f.nomFamille,f.desFamille,sum(prixHT * qteLign) as chiffre_affaire, (sum(prixHT * qteLign)*100)/@total as pour from e_EntetLign el
		inner join e_Entet e on el.idEntet=e.idEntet
		inner join a_Article a on el.idArticle=a.idArticle
		left join a_Famille f on f.idFamille=a.idFamille
		where dateEntet between @dateS and @dateE and codeType='BLFC' and idDossier=@idDossier and valider=1
		group by f.nomFamille,f.desFamille,f.idFamille
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [d_DepartementInsertUpdate](
	    @idDepartement int =null
       ,@nomDepartement nvarchar(200) =null
       ,@descDepartement nvarchar(200)=null
       ,@idUser nvarchar(450)
       ,@idGroup int=null
       ,@statment varchar(100)='insert')
      as begin
		if(@statment='insert')
		begin
			INSERT INTO d_Departement
           ([nomDepartement]
           ,[descDepartement]
           ,[idUser]
           ,[idGroup])
     VALUES
           (@nomDepartement
           ,@descDepartement
           ,@idUser
           ,@idGroup)
           select * from d_tableDepartement where idDepartement=@@IDENTITY
		end
		else
		begin
			UPDATE d_Departement
			   SET [nomDepartement] = @nomDepartement
				  ,[descDepartement] = @descDepartement
			 WHERE idDepartement=@idDepartement
			 select * from d_tableDepartement where idDepartement=@idDepartement
		end
      end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [ds_Dashboard](
@idDossier int=null,
@dateD datetime,
@dateF datetime,
@statement nvarchar(200))
as begin
declare @tableMonths table(MonthNumber int)
;WITH AllMonths AS (
SELECT MONTH(@dateD) AS MonthNumber
UNION ALL
SELECT MonthNumber + 1
FROM AllMonths
WHERE MonthNumber < MONTH(@dateF))
insert into @tableMonths select AllMonths.MonthNumber from AllMonths
	if(@statement='lesTotals')
	begin		
		select (select count(*)  from e_Entet e where e.valider=1 and e.codeType='BLFC' and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier) as v_BLFC,
				(select count(*)  from e_Entet e where e.valider=1 and e.codeType='BLFFR' and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier) as v_BLFFR,
				(select count(*)  from e_Entet e where e.valider=1 and e.clotur=1 and e.codeType='BLFC' and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier) as c_BLFC,
				(select count(*)  from e_Entet e where e.valider=1 and e.clotur=1 and e.codeType='BLFFR' and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier) as c_BLFFR,
				(select  count(*)  from f_Ordre o where o.progressType='nv' and o.datePlanification between @dateD and @dateF and o.idDossier=@idDossier) as o_nv,
				(select  count(*)  from f_Ordre o where o.progressType='va' and o.datePlanification between @dateD and @dateF and o.idDossier=@idDossier)as o_va

		
	end
	else if(@statement='ventesAchats')
	begin	
		SELECT MonthNumber AS months,SUM(ISNULL(TT_ttc, 0)) AS total,codeType 
		FROM @tableMonths
		LEFT JOIN e_Entet ON MonthNumber = MONTH(dateEntet) AND (codeType='BLFFR' OR codeType='BLFC') AND idDossier=@idDossier
		GROUP BY MonthNumber,codeType
		ORDER BY MonthNumber 
	end
	else if(@statement='depensesRecettes')
	begin
		SELECT MonthNumber AS months,SUM(ISNULL(montant, 0)) AS total,codeType 
		FROM @tableMonths
		LEFT JOIN tr_TresorerieEntet ON MonthNumber = MONTH(dateTresoEntet) AND (codeType='RCT' OR codeType='DPS') AND idDossier=@idDossier
		GROUP BY MonthNumber,codeType
		ORDER BY MonthNumber 
	end
	else if (@statement='soldeCaisse')
	begin
		declare @table table(total money,codeType nvarchar(10),months int)	
		insert into @table(codeType,total,months) 	
		select codeType,ISNULL(SUM(montant),0) as total,MonthNumber AS months
		FROM @tableMonths
		LEFT JOIN tr_TresorerieEntet ON MonthNumber = MONTH(dateTresoEntet) AND (codeType='RCT' OR codeType='DPS') AND idDossier=@idDossier
		group by MonthNumber,codeType
		union all
		select 'DPS' as codeType,ISNULL(SUM(montant),0) as total,MonthNumber AS months
		FROM @tableMonths
		LEFT JOIN r_Reglement r ON MonthNumber = MONTH(dateReglement) 
		inner join e_TypeDoc t on t.codeType=r.codeType 
		where t.valCaisse=-1  AND r.idDossier=@idDossier
		group by MonthNumber
		union all
		select 'RCT' as codeType,ISNULL(SUM(montant),0) as total,MonthNumber AS months
		FROM @tableMonths
		LEFT JOIN r_Reglement r ON MonthNumber = MONTH(dateReglement)
		inner join e_TypeDoc t on t.codeType=r.codeType 
		where t.valCaisse=1  AND r.idDossier=@idDossier
		group by MonthNumber

		select codeType,sum(total) as total, months from @table 
		group by codeType, months
		order by months
	end
	else if (@statement='topFactures')
	begin		
		select TOP(5)* 
		from e_Entet 
		where codeType='BLFC' and dateEntet between @dateD and @dateF and idDossier=@idDossier 
		order by TT_MargeCmup desc
	end
	else if(@statement='topArticles')
	begin
		select TOP(5) SUM(l.qteLign*l.valStock*(-1))as countArticles,l.descLign 
		from e_Entet e 
		inner join e_EntetLign l on l.idEntet=e.idEntet
		where (e.codeType='BLFC' or e.codeType='BRC') and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier 
		group by l.descLign 
		order by SUM(l.qteLign*l.valStock*(-1)) desc
	end
	else if(@statement='clientsFideles')
	begin
		select TOP(10) SUM(e.TT_ttc) as TotalMarge,e.nom,c.teleClient,c.codeClient
		from e_Entet e
		inner join t_Client c on c.idClient=e.idClient
		where e.codeType='BLFC' and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier 
		group by e.nom,c.teleClient,c.codeClient
		order by SUM(e.TT_ttc) desc
	end
	else if(@statement='fournisseurFideles')
	begin
		select TOP(10) SUM(e.TT_ttc) as TotalMarge,e.nom,c.teleFournisseur,c.codeFournisseur
		from e_Entet e
		inner join t_Fournisseur c on c.idFournisseur=e.idFournisseur
		where e.codeType='BLFFR' and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier 
		group by e.nom,c.teleFournisseur,c.codeFournisseur
		order by SUM(e.TT_ttc) desc
	end
	else if(@statement='ca')
	begin
		select  isnull(SUM(e.TT_ttc),0) as ca,(select Objectif from s_Dossier s where s.idDossier=@idDossier) as Objectif
		from e_Entet e
		inner join t_Client c on c.idClient=e.idClient
		where e.codeType='BLFC' and e.dateEntet between @dateD and @dateF and e.idDossier=@idDossier 
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_ClotureEntet](
@idEntet int)
as begin
	update e_Entet set clotur=1,etatDoc='Payé' where idEntet=@idEntet
	select * from e_tableEntet where idEntet=@idEntet
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [e_ClotureEntetFish](
@idEntet int)
as begin
	update fish_entet set clotur=1,etatDoc='Payé' where idEntet=@idEntet
	select * from  v_fish_EntetSelect where idEntet=@idEntet
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EmailsInsertUpdate](
  @idEmail int=null,
  @to nvarchar(max),
  @subject nvarchar(max),
  @message nvarchar(max),
  @uid nvarchar(200)='0',
  @dateEmail datetime = null,
  @folder nvarchar(300)=null,
  @attachements nvarchar(max)=null,
  @seen bit=0,
  @fromName nvarchar(max)=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @statement nvarchar(250))
  as begin
	if(@statement='insert')
	begin
	if(@uid='0')
		begin
			insert into e_Emails([to],[subject],[message],[uid],[dateEmail],[folder],[attachements],[seen],[fromName],[idUser],[idGroup])
				values(@to,@subject,@message,@uid,@dateEmail,@folder,@attachements,@seen,@fromName,@idUser,@idGroup)
				select @idEmail=idEmail from e_Emails where idEmail=@@IDENTITY
		end
	else
		begin
			if not EXISTS (select * from e_Emails where [uid]=@uid)
			begin
				insert into e_Emails([to],[subject],[message],[uid],[dateEmail],[folder],[attachements],[seen],[fromName],[idUser],[idGroup])
					values(@to,@subject,@message,@uid,@dateEmail,@folder,@attachements,@seen,@fromName,@idUser,@idGroup)
				select @idEmail=idEmail from e_Emails where idEmail=@@IDENTITY	
			end
				
			else
				select @idEmail=null
		end
		
		select * from e_Emails e where  e.idEmail=@idEmail						
	end
	else 
	begin
		update e_Emails set 
				[to]=@to,
				[subject]=@subject,
				[message]=@message,
				[uid]=@uid,
				[dateEmail]=@dateEmail,
				[folder]=@folder,
				[attachements]=@attachements,
				[seen]=@seen,
				[fromName]=@fromName
				where idEmail=@idEmail
		select * from e_Emails e where  e.idEmail=@idEmail
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetArticleList](
	@idUser nvarchar(450),
	@SelectALL bit=null,
	@idGroup int=null,
	@modele nvarchar(500)='vente',
	@codeType nvarchar(500)=null,
	@idClient int=null,
	@idFamille int =null
	)
	as begin 
		if(@modele='vente')
		begin
			select * from a_tableArticle where 
			(venteArticle=1) 
			and ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
		end	
		if(@modele='achat')
		begin
			if @idFamille!=''
			begin
				select * from a_tableArticle where 
				(achatArticle=1)
				and ((@SelectALL=1 and  idUser=@idUser and idFamille=@idFamille) or (@SelectALL=0 and idGroup=@idGroup and idFamille=@idFamille))
			end
			else
			begin
				select * from a_tableArticle where 
				(achatArticle=1)
				and ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
			end
		end	
		if(@modele='inventaire')
		begin
			select * from a_tableArticle where 
			((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
		end
		if(@modele='Nomenclature')
		begin
			select * from a_tableArticle where 
			(typeArticle='Nomenclature')
			and ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
		end
		if(@modele='Fabrication')
		begin
			select * from a_tableArticle where 
			(typeArticle='Fabrication' or typeArticle='Nomenclature')
			and ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
		end
		if(@modele='factures')
		begin
			select * from e_tableEntet 
			where codeType=@codeType and (idClient=@idClient or idFournisseur=@idClient) and valider=1 and checkCopierVers=0
			and ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
		end
	end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetCopierAll](
@IdEntet int=null,
@newIdEntet int=null,
@CodeType varchar(20),
@CodeTypeCopier varchar(20),
@IdDossier int,
@IdUser nvarchar(450),
@statment nvarchar(200)='insertFirst')
as begin
	if(@statment='insertFirst')
	begin
		declare @Numfac int,@Valstock int,@Valcmup int,@identityLign int  
		if exists (select * from e_Entet where idEntet=@IdEntet and Valider=1)
				begin
					select @Numfac=e.numfacture,
							@Valstock=e.valStock,
							@Valcmup=e.valCmup  from e_TypeDoc e
							where e.codeType=@CodeTypeCopier and e.idDossier=@IdDossier
							
					insert into e_Entet(numFactur,refFactur,dateEntet,dateEcheanche,nom,info,valider,clotur,TT_ttc,TT_ht,TT_tva,TT_remis,TT_MargeCmup,TT_MargePxAcha
				   ,TT_TauxMargeCmup,TT_TauxMargePxAcha,timbre,TT_net,avance,etatDoc,numCheq,remiseGlobal,teypGlobal,tva,ttc,obs,checkExpiration,meta,idModRglm
				   ,idDepot,idDepot_2,idClient,idFournisseur,codeType,idDossier,idUser,idGroup,idVendeur,terms,metaImpression,proprieteClient,typeLigne
					,dateValidation,checkCopierVers)
				   (select @Numfac+1,numFactur,GETDATE(),dateEcheanche,nom,info,0,0,TT_ttc,TT_ht,TT_tva,TT_remis,TT_MargeCmup,TT_MargePxAcha,TT_TauxMargeCmup
				   ,TT_TauxMargePxAcha,timbre,TT_net,avance,'A préparer',numCheq,remiseGlobal,teypGlobal,tva,ttc,obs,checkExpiration,meta,idModRglm,idDepot,idDepot_2
				   ,idClient,idFournisseur,@codeTypeCopier,idDossier,@idUser,idGroup,idVendeur,terms,metaImpression,proprieteClient,typeLigne
					,dateValidation,checkCopierVers  from e_Entet where idEntet=@idEntet)
					select idEntet from e_Entet where idEntet = @@IDENTITY
					update e_TypeDoc set numFacture=@Numfac+1 where idDossier=@idDossier and codeType=@codeTypeCopier
				end		
	end
	else 
	begin
		select @Valstock=e.valStock,
			   @Valcmup=e.valCmup from e_TypeDoc e  
			   where e.codeType=@CodeTypeCopier and e.idDossier=@IdDossier
			   
				select * into tableTemporaire from e_EntetLign where idEntet=@idEntet
                 while (select COUNT(*) from tableTemporaire)>0
					 begin
					 declare @idLign int
					 select top 1 @idLign=idLign from tableTemporaire
					 insert into e_EntetLign(idEntet,idArticle,refArticle,descLign,qteLign,prixTTC,prixHT,lgnTTC,lgnHT,lgnRemise,lgnTVA,lgnCmup,lgnMargeCmup
					,lgnMargePxAcha,lgnTauxMargeCmup,lgnTauxMargePxAcha,valStock,valCmup,dateExpiration,meta,lgnUnite,lgnUrgence,idSupDepot,idSupDepot_2
					,idUser,dateLigne,sortOrder) select @newIdEntet,idArticle,refArticle,descLign,qteLign,prixTTC,prixHT,lgnTTC,lgnHT,lgnRemise,lgnTVA,lgnCmup,lgnMargeCmup
					,lgnMargePxAcha,lgnTauxMargeCmup,lgnTauxMargePxAcha,@valstock,@valcmup,dateExpiration,meta,lgnUnite,lgnUrgence,idSupDepot,idSupDepot_2
					,@idUser,dateLigne,sortOrder from tableTemporaire where idLign=@idLign
					select @identityLign=idLign from e_EntetLign where idLign=@@IDENTITY
					exec e_MargeFixed @identityLign
					delete from tableTemporaire where idLign=@idLign
					end
				drop table tableTemporaire
				update e_Entet set checkCopierVers=1 where idEntet=@idEntet
				exec e_EntetFixed @newIdEntet
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetFixed](
 @idEntet int)
 as begin
	declare @TT_ttc money,@TT_ht money,@TT_tva money,@TT_remis money
		
		select @TT_ttc=SUM(lgnTTC),
		@TT_ht=SUM(lgnHT),
		@TT_remis=SUM((qteLign*prixTTC)*lgnRemise/100) 
		 from e_EntetLign where idEntet=@idEntet
		 update e_Entet set TT_ttc=@TT_ttc,TT_ht=@TT_ht,TT_tva=@TT_ttc-@TT_ht,TT_remis=@TT_remis where idEntet=@idEntet
		 
		 select * from e_tableEntet where idEntet=@idEntet
 end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetInsertUpdate](
  @idEntet int=null,
  @numFactur int=null,
  @refFactur nvarchar(50)=null,
  @dateEntet datetime=null,
  @dateEcheanche datetime=null,
  @nom nvarchar(150)=null,
  @info nvarchar(150)=null,
  @timbre bit=0,
  @etatDoc nvarchar(50)='Validé',
  @numCheq nvarchar(50)=null,
  @tva bit=0,
  @ttc bit=0,
  @obs nvarchar(100)=null,
  @checkExpiration bit=0,
  @idModRglm int =null,
  @idDepot int =null,
  @idDepot_2 int =null,
  @idClient int=null,
  @idVendeur int=-1,
  @idFournisseur int=null,
  @codeType varchar(20),
  @idDossier int=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @terms nvarchar(max)=null,
  @proprieteClient nvarchar(max)=null,
  @typeLigne nvarchar(500)=null,
  @idFamille int=null,

  @tauxPlastique float=null,
  @idDestinataire int=null,
  @nomDestinataire nvarchar(max)=null,
  @truck nvarchar(max)=null,

  @LotePF nvarchar(max)=null,
  @MtPremier nvarchar(max)=null,
  @lote nvarchar(max)=null,
  @NumeroTaux int=null,
  @TauxGalce float=null,

  @InternationalCheck bit=0,
  @PesoBruto float=null,
  @MateriaPrima float=null,
  @PesoNetoEscurido float=null,
  @PesoNeto float=null,
  @idEntetS int=null,
  @statment varchar(100)='insert'
  )
  as begin
		if(@statment='insert')
		begin
			INSERT INTO e_Entet
           ([numFactur]
           ,[refFactur]
           ,[dateEntet]
           ,[dateEcheanche]
           ,[nom]
           ,[info]
           ,[timbre]
           ,[etatDoc]
           ,[numCheq]
           ,[tva]
           ,[ttc]
           ,[obs]
           ,[checkExpiration]
           ,[idModRglm]
           ,[idDepot]
           ,[idDepot_2]
           ,idVendeur
           ,[idClient]
           ,[idFournisseur]
           ,[codeType]
           ,[idDossier]
           ,[idUser]
           ,[idGroup]
           ,[terms]
           ,[proprieteClient]
           ,[typeLigne]
		   ,[idFamille]
		   ,tauxPlastique,idDestinataire,nomDestinataire,truck,LotePF,MtPremier,lote,NumeroTaux,TauxGalce,InternationalCheck,PesoBruto,MateriaPrima,PesoNetoEscurido,PesoNeto,idEntetS
		   )
     VALUES
           (@numFactur
           ,@refFactur
           ,@dateEntet
           ,@dateEcheanche
           ,@nom
           ,@info
           ,@timbre
           ,@etatDoc
           ,@numCheq
           ,@tva
           ,@ttc
           ,@obs
           ,@checkExpiration
           ,@idModRglm
           ,@idDepot
           ,@idDepot_2
           ,@idVendeur 
           ,@idClient
           ,@idFournisseur
           ,@codeType         
           ,@idDossier
           ,@idUser
           ,@idGroup
           ,@terms
           ,@proprieteClient
           ,@typeLigne
		   ,@idFamille,@tauxPlastique,@idDestinataire,@nomDestinataire,@truck,@LotePF,@MtPremier,@lote,@NumeroTaux,@TauxGalce,@InternationalCheck,@PesoBruto,@MateriaPrima,@PesoNetoEscurido,@PesoNeto,@idEntetS)
           update e_TypeDoc set numFacture=@numFactur where idDossier=@idDossier and codeType=@codeType
           select * from e_tableEntet where idEntet=@@IDENTITY
		end
		else
		begin
			UPDATE e_Entet
			   SET 
				   [refFactur] = @refFactur
				  ,[dateEntet] = @dateEntet
				  ,[dateEcheanche] = @dateEcheanche
				  ,[nom] = @nom
				  ,[info] = @info
				  ,timbre=@timbre
				  ,[etatDoc] = @etatDoc
				  ,[numCheq] = @numCheq
				  ,[obs] = @obs
				  ,[checkExpiration] = @checkExpiration
				  ,[idModRglm] = @idModRglm
				  ,[idClient] = @idClient
				  ,[idFournisseur] = @idFournisseur
				  ,[idVendeur]=@idVendeur
				  ,[terms]=@terms 
				  ,[proprieteClient]=@proprieteClient
				  ,[typeLigne]=@typeLigne
				  ,[idFamille]=@idFamille
				  ,tauxPlastique=@tauxPlastique
				  ,idDestinataire=@idDestinataire
				  ,nomDestinataire=@nomDestinataire
				  ,truck=@truck
				  ,LotePF=@LotePF,MtPremier=@MtPremier,lote=@lote,NumeroTaux=@NumeroTaux,TauxGalce=@TauxGalce,
				  InternationalCheck=@InternationalCheck,PesoBruto=@PesoBruto,MateriaPrima=@MateriaPrima,PesoNetoEscurido=@PesoNetoEscurido,PesoNeto=@PesoNeto,idEntetS=@idEntetS
			 WHERE idEntet=@idEntet
			 select * from e_tableEntet where idEntet=@idEntet
		end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetLignSortOrder](
 	@idLign int,@sortOrder int)
 	as begin
 		update e_EntetLign set sortOrder=@sortOrder where idLign=@idLign
 	end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetLignUpdateDateLigne](
  @idLign int=null,
  @dateLigne nvarchar(100)=null)
  as begin
	update e_EntetLign set dateLigne=@dateLigne where idLign=@idLign
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetSelect](
		@idUser nvarchar(450),
		@SelectDoc bit=null,
		@idDossier int=null,
		@codeType varchar(20),
		@dateStart datetime,
		@dateEnd datetime,
		@Filter varchar(100)='dateEntet'
		)
		as begin
			if(@Filter='dateEntet')
			begin
				select * from e_tableEntet where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and dateEntet between @dateStart and @dateEnd and codeType=@codeType) 
											or (@SelectDoc=0 and idDossier=@idDossier and dateEntet between @dateStart and @dateEnd and codeType=@codeType))
			end
			else 
			begin
				select * from e_tableEntet where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and dateEcheanche between @dateStart and @dateEnd and codeType=@codeType) 
											or (@SelectDoc=0 and idDossier=@idDossier and dateEcheanche between @dateStart and @dateEnd and codeType=@codeType))
			end
				
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [e_EntetUpdateCalc](
  @idEntet int=null,
  @SumNetWeight float=null,
  @SumUnitePrice float=null
  )
  as begin
	update e_Entet set SumNetWeight=@SumNetWeight,SumUnitePrice=@SumUnitePrice where idEntet=@idEntet
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetUpdatecertificatEuro](
  @idEntet int=null,
  @certificatEuro nvarchar(max)=null
  )
  as begin
	update e_Entet set certificatEuro=@certificatEuro where idEntet=@idEntet
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [e_EntetUpdatechangeDH](
  @idEntet int=null,
  @changeDH float=null
  )
  as begin
	update e_Entet set changeDH=@changeDH where idEntet=@idEntet
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetUpdateInfo](
  @idEntet int=null,
  @idFamille int=null,
  @frozenDate nvarchar(max),
  @lote nvarchar(max)
  )
  as begin
	update e_EntetLign set frozenDate=@frozenDate,lote=@lote where idLign in ( select idLign from e_EntetLign where idEntet=@idEntet and idArticle in (select distinct idArticle from e_tableEntetLign where idFamille=@idFamille))
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_EntetUpdateMeta](
  @idEntet int=null,
  @metaImpression nvarchar(max))
  as begin
	update e_Entet set metaImpression=@metaImpression where idEntet=@idEntet
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_LignEntetFishInsertUpdate](
  @idLign int=null,
  @idEntet int=null,
  @idFamille int =null,
  @quantite float =null,
  @descLign nvarchar(max)=null,
  @calibre nvarchar(max)=null,
  @prix float =null,
  @prixTotal float =null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @CodePLT nvarchar(max)=null,
  @PN float=null,
  @cais float=null,
  @caisINVT float=null,
  @PNINVT float=null,
  @statment varchar(100)='insert'
  )
  as begin
	 if(@statment='insert')
	 begin
		INSERT INTO [dbo].[fish_entetLign]
           ([idEntet]
           ,[idFamille]
           ,[descLign]
           ,[calibre]
           ,[quantite]
           ,[prix]
           ,[prixTotal]
		   ,CodePLT
		   ,PN
		   ,cais,caisINVT,PNINVT
		   )
     VALUES
           (@idEntet
           ,@idFamille
           ,@descLign,@calibre,@quantite, @prix,@prixTotal,@CodePLT,@PN,@cais,@caisINVT,@PNINVT)

          select @idLign=idLign from fish_entetLign where idLign=@@IDENTITY

          select * from e_fishtableEntetLign where idLign=@idLign
	 end
	 else
	 begin
		UPDATE fish_entetLign
		SET
			   [descLign] = @descLign
			  ,[quantite] = @quantite,
			  
           [prix]=@prix,
           [prixTotal]=@prixTotal
		   ,CodePLT=@CodePLT
		   ,PN=@PN
		   ,cais=@cais
		   ,caisINVT=@caisINVT
		   ,PNINVT=@PNINVT
		 WHERE idLign=@idLign
	 select * from e_fishtableEntetLign where idLign=@idLign
	 end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_LignEntetInsertUpdate](
  @idLign int=null,
  @idEntet int=null,
  @idArticle int=null,
  @refArticle nvarchar(500)=null,
  @descLign nvarchar(max)=null,
  @qteLign float=0,
  @prixTTC money=0,
  @prixHT money=0,
  @lgnTTC money=0,
  @lgnHT money=0,
  @lgnRemise money=0,
  @lgnTVA money=0,
  @lgnCmup money=0,
  @valStock int=0,
  @valCmup int=0,
  @dateExpiration datetime =null,
  @lgnUnite nvarchar(100)=null,
  @lgnUrgence nvarchar(100)=null,
  @idSupDepot int=null,
  @idSupDepot_2 int=null,
  @idUser nvarchar(450)=null,
  @numeroSerie nvarchar(250)=null,
  @idGroup int=null,
  @idDossier int =null,

  @PackageEmvase float=null,
  @GrossWeight float=null,
  @drainedNetWeight float=null,
  @NetWeight float=null,

  @DuaLigne nvarchar(max)=null,
  @LotePfLigne nvarchar(max)=null,
  @PesoNetoLigne float=0,
  @DateCongelationLigne date=null,
  @codePdFini nvarchar(max)=null,
  @statment varchar(100)='insert'
  )
  as begin
	 if(@statment='insert')
	 begin
		INSERT INTO e_EntetLign
           ([idEntet]
           ,[idArticle]
           ,[refArticle]
           ,[descLign]
           ,[qteLign]
           ,[prixTTC]
           ,[prixHT]
           ,[lgnTTC]
           ,[lgnHT]
           ,[lgnRemise]
           ,[lgnTVA]
           ,[lgnCmup]
           ,[valStock]
           ,[valCmup]
           ,[dateExpiration]
           ,[lgnUnite]
           ,[lgnUrgence]
           ,[idSupDepot]
           ,[idSupDepot_2]
           ,[idUser]
		   ,PackageEmvase,NetWeight,drainedNetWeight,GrossWeight,DuaLigne,LotePfLigne,PesoNetoLigne,DateCongelationLigne,codePdFini)
     VALUES
           (@idEntet
           ,@idArticle
           ,@refArticle
           ,@descLign
           ,@qteLign
           ,@prixTTC
           ,@prixHT
           ,@lgnTTC
           ,@lgnHT
           ,@lgnRemise
           ,@lgnTVA
           ,@lgnCmup
           ,@valStock
           ,@valCmup
           ,@dateExpiration
           ,@lgnUnite
           ,@lgnUrgence 
           ,@idSupDepot
           ,@idSupDepot_2
           ,@idUser,@PackageEmvase,@NetWeight,@drainedNetWeight,@GrossWeight,@DuaLigne,@LotePfLigne,@PesoNetoLigne,@DateCongelationLigne,@codePdFini
          )
		 --   if not exists(select * from e_Art_Depot where idArticle=@idArticle)
			--begin
			--	insert into e_Art_Depot (idArticle,idSupDepot,qteDepot,cmup,lastPrix,firstPrix,idDossier) 
			--	values(@idArticle,@idSupDepot,@qteLign,@prixHT,@prixHT,@prixHT,@idDossier)
			--end
			--else
			--begin
			--	update e_Art_Depot set qteDepot=@qteLign ,cmup=@prixHT where idArticle=@idArticle
			--end
		  
          select @idLign=idLign from e_EntetLign where idLign=@@IDENTITY
          exec e_MargeFixed @idLign
          if exists(select * from a_Article where idArticle=@idArticle and checkMaintenance=1)
          begin
			insert into Maint_A_Equipements (modeleEquipement, numeroSerie, coutEquipement, dateGarantie, dateEffet, idLign, idArticle, idUser, idGroup) 
			values ('', @numeroSerie, @prixHT, null, GETDATE(), @idLign, @idArticle, @idUser, @idGroup) 
          end
          select * from e_tableEntetLign where idLign=@idLign
	 end
	 else
	 begin
		UPDATE e_EntetLign
		SET
			   [descLign] = @descLign
			  ,[qteLign] = @qteLign
			  ,[prixTTC] = @prixTTC
			  ,[prixHT] = @prixHT
			  ,[lgnTTC] = @lgnTTC
			  ,[lgnHT] = @lgnHT
			  ,[lgnRemise] = @lgnRemise
			  ,[lgnTVA] = @lgnTVA
			  ,[lgnCmup] = @lgnCmup
			  ,[dateExpiration] = @dateExpiration
			  ,[lgnUnite] = @lgnUnite
			  ,[lgnUrgence] = @lgnUrgence
			  ,[idSupDepot] = @idSupDepot
			  ,[idSupDepot_2] = @idSupDepot_2
			  ,PackageEmvase=@PackageEmvase,NetWeight=@NetWeight,drainedNetWeight=@drainedNetWeight,GrossWeight=@GrossWeight,
			DuaLigne=@DuaLigne,LotePfLigne=@LotePfLigne,PesoNetoLigne=@PesoNetoLigne,DateCongelationLigne=@DateCongelationLigne,codePdFini=@codePdFini
		 WHERE idLign=@idLign
		 -- if not exists(select * from e_Art_Depot where idArticle=@idArticle)
			--begin
			--	insert into e_Art_Depot (idArticle,idSupDepot,qteDepot,cmup,lastPrix,firstPrix,idDossier) 
			--	values(@idArticle,@idSupDepot,@qteLign,@prixHT,@prixHT,@prixHT,@idDossier)
			--end
			--else
			--begin
			--	update e_Art_Depot set qteDepot=@qteLign ,cmup=@prixHT where idArticle=@idArticle
			--end
		exec e_MargeFixed @idLign 
	 select * from e_tableEntetLign where idLign=@idLign
	 end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_LignEntetUpdateQtebyDua](
  @idEntet int=null,
  @idFamille int=null,
  @DuaLigne nvarchar(max)=null,
  @qtebyDua float=null
  )
  as begin
  UPDATE e_EntetLign
		SET
			qtebyDua=@qtebyDua
		 WHERE idEntet=@idEntet and DuaLigne=@DuaLigne and idArticle in(select idArticle FROM a_Article where idFamille=@idFamille)
		 
	
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [e_LignEntetUpdateSinAgua](
  @idEntet int=null,
  @idFamille int=null,
  @SinAgua float=null
  )
  as begin
  UPDATE e_EntetLign
		SET
			SinAgua=@SinAgua
		 WHERE idEntet=@idEntet and idArticle in(select idArticle FROM a_Article where idFamille=@idFamille)
		 
	
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_MargeFixed](
@idLign int)
as begin
	declare @lgnMargePxAcha money,
	@lgnMargeCmup money,
	@codeType varchar(20),
	@lgnValeurCmup money,
	@lgnValeurPxAcha money,
	@lgnPxAcha money,
	@calculMarge bit,
	@idDossier int,
	@lgnCmup money,
	@lgnTauxMargeCmup money=0,
	@lgnTauxMargePxAcha money=0,
	@idEntet int
	select @codeType=e.codeType,@idDossier=e.idDossier,@idEntet=e.idEntet from e_EntetLign l 
	inner join e_Entet e on e.idEntet=l.idEntet where l.idLign=@idLign
	
	select @calculMarge=calculMarge from e_TypeDoc where idDossier=@idDossier and codeType=@codeType
	
	if(@calculMarge=1)
	begin 
		select @lgnMargePxAcha=(e.lgnHT-(e.qteLign*ISNULL(a.lastPrix,0))),
				@lgnMargeCmup =(e.lgnHT-(e.qteLign*ISNULL(a.cmup,0))) ,
				@lgnValeurPxAcha =(e.qteLign*ISNULL(a.lastPrix,0)),
				@lgnValeurCmup=(e.qteLign*ISNULL(a.cmup,0)),
				@lgnPxAcha =ISNULL(a.lastPrix,0),
				@lgnCmup=ISNULL(a.cmup,0)
				from e_EntetLign e inner join e_Art_Depot a on e.idArticle=a.idArticle
				inner join e_Entet en on en.idEntet=e.idEntet
				where idLign=@idLign and a.idDossier=en.idDossier and a.idDepot=en.idDepot
		if(@lgnValeurCmup<>0)	
		begin
			set @lgnTauxMargeCmup=(@lgnMargeCmup/@lgnValeurCmup)
		end	
		if(@lgnValeurPxAcha<>0)
		begin
			set @lgnTauxMargePxAcha=(@lgnMargePxAcha/@lgnValeurPxAcha)
		end
		update e_EntetLign set lgnMargePxAcha=@lgnMargePxAcha,
								lgnMargeCmup=@lgnMargeCmup,
								lgnValeurPxAcha=@lgnValeurPxAcha,
								lgnValeurCmup=@lgnValeurCmup,
								lgnPxAcha=@lgnPxAcha,
								lgnTauxMargeCmup=@lgnTauxMargeCmup,
								lgnTauxMargePxAcha=@lgnTauxMargePxAcha,
								lgnCmup=@lgnCmup where idLign=@idLign
		-------------------Marge TOtal
		declare @TT_MargeCmup money,@TT_MargePxAcha money,@TT_TauxMargeCmup money=0,@TT_TauxMargePxAcha money=0					
		select @TT_MargeCmup=SUM(lgnMargeCmup),
				@TT_MargePxAcha=SUM(lgnMargePxAcha),
				@TT_TauxMargeCmup=AVG(lgnTauxMargeCmup),
				@TT_TauxMargePxAcha=AVG(lgnTauxMargePxAcha)
				 from e_EntetLign where idEntet=@idEntet
		update e_Entet set TT_MargeCmup=@TT_MargeCmup,
						TT_MargePxAcha=@TT_MargePxAcha,
						TT_TauxMargeCmup=@TT_TauxMargeCmup,
						TT_TauxMargePxAcha=@TT_TauxMargePxAcha where idEntet=@idEntet		 	
	end		
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [e_selectCmupQte](
  @idArticle int,
  @idDepot int=null,
  @idDossier int=null,
  @idSupDepot int=null,
  @subDepot bit=0)
  as begin
	if(@subDepot=1)
	begin
		select * from e_Art_Depot where idArticle=@idArticle and idSupDepot=@idSupDepot and idDossier=@idDossier
	end
	else
	begin
		select * from e_Art_Depot where idArticle=@idArticle and idDepot=@idDepot and idDossier=@idDossier
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_TriggerDepot](
@idEntet int,--1
@idLign int,--2
@prixHT money,--3
@qteLign float,--4
@valStock int,--5
@valCmup int,--6
@idArticle int,--7
@idDepot int,--8
@idDepot_2 int,--9
@codeType varchar(20),--10
@idDossier int,--11
@statment varchar(100)='insert'--12
)
as begin
declare @oldQteDepot float,
		@oldCmup money,
		@newCmup money,
		@newQteDepot float
	if(@statment ='insert')
	begin
		 ------------ si table art_depot vide
		if not exists (select * from e_Art_Depot where idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier)
			begin
				insert into e_Art_Depot(idArticle,idDepot,qteDepot,cmup,firstPrix,idDossier) values(@idArticle,@idDepot,0,0,@prixHT,@idDossier)
			end	
		-------------get old QT et old CMUP
		select @oldCmup= isnull(cmup,0), @oldQteDepot = qteDepot from e_Art_Depot 
				where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
				update e_EntetLign set lastQte=@oldQteDepot where idLign=@idLign
		-------------culc cmup 	
		if @valcmup = 1 
			begin
				if(@oldCmup=0)
				begin
					set @oldCmup=@prixHT
				end	
				if (@oldQteDepot + @qteLign) <> 0 or @oldQteDepot>0
					begin 
						set @newCmup = ((@oldCmup * @oldQteDepot) + (@prixHT * @qteLign))/(@oldQteDepot + @qteLign)
						update e_Art_Depot set cmup = @newCmup,lastPrix=@prixHT  where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
						update e_EntetLign set lgnCmup = @newCmup where idLign = @idLign
					end
				else
					begin
						update e_Art_Depot set cmup = @prixHT  where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
					end
			end
		else
			begin
				update e_EntetLign set lgnCmup = @oldCmup where idLign = @idLign
			end	
		----------update qtt
		set @newQteDepot = (@qteLign) * (@valStock)
		if exists (select * from e_Art_Depot where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier)
			begin
				update e_Art_Depot set qteDepot = @oldQteDepot + @newQteDepot where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
				--if @codeType='MVTR'
				--	begin
				--	 ------------ si table art_depot vide
				--		if not exists (select * from e_Art_Depot where idArticle = @idArticle and idDepot = @idDepot_2 and idDossier=@idDossier)
				--			begin
				--				insert into e_Art_Depot(idArticle,idDepot,qteDepot,cmup,firstPrix,idDossier) values(@idArticle,@idDepot_2,0,0,@prixHT,@idDossier)
				--			end	
				--		select @oldQteDepot = qteDepot from e_Art_Depot 
				--			where  idArticle = @idArticle and idDepot = @idDepot_2 and idDossier=@idDossier
				--		update e_Art_Depot set qteDepot = @oldQteDepot - @newQteDepot  where  idArticle = @idArticle and idDepot = @idDepot_2 and idDossier=@idDossier			
				--	end
			end
	end
	if(@statment='delete')
	begin
	-------------get old QT et old CMUP
		select @oldCmup= isnull(cmup,0), @oldQteDepot = qteDepot from e_Art_Depot 
				where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
		
	 -------------culc cmup 	
		if @valcmup = 1 
			begin
			if(@oldCmup=0)
			begin
				set @oldCmup=@prixHT
			end
			if (@oldQteDepot - @qteLign) <> 0 
			begin
				set @newCmup = ((@oldCmup * @oldQteDepot) - (@prixHT * @qteLign))/(@oldQteDepot - @qteLign)
				update e_Art_Depot set cmup = @newCmup  where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier 
			end	
			else
			begin
				update e_Art_Depot set cmup = 0  where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
			end	
			end
	----------update qtt			
		set @newQteDepot = (@qteLign) * (@valstock)
		update e_Art_Depot set qteDepot = @oldQteDepot - @newQteDepot  where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
		--if @codeType='MVTR'
		--	begin 
		--		select @oldQteDepot = qteDepot from e_Art_Depot where  idArticle = @idArticle and idDepot = @idDepot_2 and idDossier=@idDossier
		--		update e_Art_Depot set qteDepot = @oldQteDepot + @newQteDepot where  idArticle = @idArticle and idDepot = @idDepot_2 and idDossier=@idDossier	
		--	end
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_TriggerSupDepot](
@idEntet int,--1
@idLign int,--2
@prixHT money,--3
@qteLign float,--4
@valStock int,--5
@valCmup int,--6
@idArticle int,--7
@idSupDepot int,--8
@idSupDepot_2 int,--9
@codeType varchar(20),--10
@idDossier int,--11
@statment varchar(100)='insert'--12
)
as begin
declare @oldQteDepot float,
		@oldCmup money,
		@newCmup money,
		@newQteDepot float
	if(@statment ='insert')
	begin
		 ------------ si table art_depot vide
		if not exists (select * from e_Art_Depot where idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier)
			begin
				insert into e_Art_Depot(idArticle,idSupDepot,qteDepot,cmup,firstPrix,idDossier) values(@idArticle,@idSupDepot,0,0,@prixHT,@idDossier)
			end	
		-------------get old QT et old CMUP
		select @oldCmup= isnull(cmup,0), @oldQteDepot = qteDepot from e_Art_Depot 
				where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier
		-------------culc cmup 	
		if @valcmup = 1 
			begin
				if(@oldCmup=0)
				begin
					set @oldCmup=@prixHT
				end	
				if (@oldQteDepot + @qteLign) <> 0
					begin 
						set @newCmup = ((@oldCmup * @oldQteDepot) + (@prixHT * @qteLign))/(@oldQteDepot + @qteLign)
						update e_Art_Depot set cmup = @newCmup,lastPrix=@prixHT  where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier
						update e_EntetLign set lgnCmup = @newCmup where idLign = @idLign
					end
				else
					begin
						update e_Art_Depot set cmup = @prixHT  where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier
					end
			end
		else
			begin
				update e_EntetLign set lgnCmup = @oldCmup where idLign = @idLign
			end	
		----------update qtt
		set @newQteDepot = (@qteLign) * (@valStock)
		if exists (select * from e_Art_Depot where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier)
			begin
				update e_Art_Depot set qteDepot = @oldQteDepot + @newQteDepot where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier
				--if @codeType='MVTR'
				--	begin
				--	 ------------ si table art_depot vide
				--		if not exists (select * from e_Art_Depot where idArticle = @idArticle and idSupDepot = @idSupDepot_2 and idDossier=@idDossier)
				--			begin
				--				insert into e_Art_Depot(idArticle,idSupDepot,qteDepot,cmup,firstPrix,idDossier) values(@idArticle,@idSupDepot_2 ,0,0,@prixHT,@idDossier)
				--			end	
				--		select @oldQteDepot = qteDepot from e_Art_Depot 
				--			where  idArticle = @idArticle and idSupDepot = @idSupDepot_2 and idDossier=@idDossier
				--		update e_Art_Depot set qteDepot = @oldQteDepot - @newQteDepot  where  idArticle = @idArticle and idSupDepot = @idSupDepot_2 and idDossier=@idDossier			
				--	end
			end
	end
	if(@statment='delete')
	begin
	-------------get old QT et old CMUP
		select @oldCmup= isnull(cmup,0), @oldQteDepot = qteDepot from e_Art_Depot 
				where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier
		
	 -------------culc cmup 	
		if @valcmup = 1 
			begin
			if(@oldCmup=0)
			begin
				set @oldCmup=@prixHT
			end
				if (@oldQteDepot - @qteLign) <> 0
				begin
					set @newCmup = ((@oldCmup * @oldQteDepot) - (@prixHT * @qteLign))/(@oldQteDepot - @qteLign)
					update e_Art_Depot set cmup = @newCmup  where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier 
				end	
				else
				begin
					update e_Art_Depot set cmup = @prixHT  where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier
				end	
			end
	----------update qtt			
		set @newQteDepot = (@qteLign) * (@valstock)
		update e_Art_Depot set qteDepot = @oldQteDepot - @newQteDepot  where  idArticle = @idArticle and idSupDepot = @idSupDepot and idDossier=@idDossier
		--if @codeType='MVTR'
		--	begin 
		--		select @oldQteDepot = qteDepot from e_Art_Depot where  idArticle = @idArticle and idSupDepot = @idSupDepot_2  and idDossier=@idDossier
		--		update e_Art_Depot set qteDepot = @oldQteDepot + @newQteDepot where  idArticle = @idArticle and idSupDepot = @idSupDepot_2  and idDossier=@idDossier	
		--	end
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_ValiderEntetAchat](
@idEntet int,
@idDossier int)
as begin

declare @TT_ttc money,@idFournisseur int,@codeType varchar(20),@valCaisse int,@valider bit
select @TT_ttc=TT_ttc,@idFournisseur=idFournisseur,@codeType=codeType,@valider=valider from e_Entet where idEntet=@idEntet
select @valCaisse=valCaisse from e_TypeDoc where codeType=@codeType and idDossier=@idDossier
UPDATE e_Entet set valider=~valider where idEntet=@idEntet
if not exists(Select * from t_FournisseurCredit where idFournisseur =@idFournisseur and idDossier=@idDossier)
begin
	insert into t_FournisseurCredit(idFournisseur,idDossier,credit) values(@idFournisseur,@idDossier,0)
end
if(@valider=1)
begin	
	update t_FournisseurCredit set credit=isnull(credit,0)-(@TT_ttc*@valCaisse) where idDossier=@idDossier and idFournisseur=@idFournisseur
	update e_Entet set etatDoc='saisir' where idEntet=@idEntet
end
else 
begin
	update t_FournisseurCredit set credit=ISNULL(credit,0) + (@TT_ttc*@valCaisse) where  idDossier=@idDossier and idFournisseur=@idFournisseur
	update e_Entet set etatDoc='Valider' where idEntet=@idEntet
end
select * from e_tableEntet where idEntet=@idEntet

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [e_ValiderEntetAchatFish](
@idEntet int,
@idDossier int)
as begin

declare @totalAchat float,@totalCharges float,@comission float,@idFournisseur int,@codeType varchar(20),@valCaisse int,@valider bit
select @totalAchat=totalAchat,@totalCharges=totalCharges,@comission=comission,@idFournisseur=idFournisseur,@codeType=codeType,@valider=valider from fish_entet where idEntet=@idEntet
UPDATE fish_entet set valider=~valider where idEntet=@idEntet
if not exists(Select * from t_FournisseurCredit where idFournisseur =@idFournisseur and idDossier=@idDossier)
begin
	insert into t_FournisseurCredit(idFournisseur,idDossier,credit) values(@idFournisseur,@idDossier,0)
end
if(@valider=1)
begin	
	update t_FournisseurCredit set credit=isnull(credit,0)-(@totalAchat+@totalCharges+@comission) where idDossier=@idDossier and idFournisseur=@idFournisseur
	update fish_entet set etatDoc='saisir' where idEntet=@idEntet
end
else 
begin
	update t_FournisseurCredit set credit=ISNULL(credit,0) + (@totalAchat+@totalCharges+@comission) where  idDossier=@idDossier and idFournisseur=@idFournisseur
	update fish_entet set etatDoc='Valider' where idEntet=@idEntet
end
select * from v_fish_EntetSelect where idEntet=@idEntet

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_ValiderEntetVente](
@idEntet int,
@idDossier int)
as begin

declare @TT_ttc money,@idClient int,@codeType varchar(20),@valCaisse int,@valider bit
select @TT_ttc=TT_ttc,@idClient=idClient,@codeType=codeType,@valider=valider from e_Entet where idEntet=@idEntet
select @valCaisse=valCaisse from e_TypeDoc where codeType=@codeType and idDossier=@idDossier
UPDATE e_Entet set valider=~valider where idEntet=@idEntet
if not exists(Select * from t_ClientCredit where idClient =@idClient and idDossier=@idDossier)
begin
	insert into t_ClientCredit(idClient,idDossier,credit) values(@idClient,@idDossier,0)
end
if(@valider=1)
begin	
	update t_ClientCredit set credit=isnull(credit,0)-(@TT_ttc*@valCaisse) where idDossier=@idDossier and idClient=@idClient
	update e_Entet set etatDoc='saisir' where idEntet=@idEntet
end
else 
begin
	update t_ClientCredit set credit=ISNULL(credit,0) + (@TT_ttc*@valCaisse) where  idDossier=@idDossier and idClient=@idClient
	update e_Entet set etatDoc='Valider' where idEntet=@idEntet
end
select * from e_tableEntet where idEntet=@idEntet

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [e_validerMouvementTransfert](
@idEntet int,
@idGroup int)
as begin
declare @idDepot int, @idDepot_2 int,@idDossier int,@idArticle int,@id int,@qteLign float,@prixHT money,@oldCmupDepot money,
@oldqteDepot float,@idSupDepot int,@idSupDepot_2 int, @oldqteSupDepot float,@oldCmupSupDepot money
update e_Entet set valider = 1, dateValidation=GETDATE() where idEntet=@idEntet  
select @idDepot=idDepot,@idDepot_2=idDepot_2,@idDossier=idDossier
from e_Entet 
where idEntet=@idEntet

declare @table table ( id int identity (1,1), idArticle int, qteLign float, prixHT money, idSupDepot int,idSupDepot_2 int)
insert into @table(
idArticle
,qteLign
,prixHT
,idSupDepot
,idSupDepot_2)
(select 
idArticle
,qteLign
,prixHT
,idSupDepot
,idSupDepot_2 
from e_EntetLign where idEntet=@idEntet)

while(select COUNT(*) from @table)>0
begin

select top 1 @id=id,@idArticle=idArticle,@qteLign=qteLign,@prixHT=prixHT,@idSupDepot=idSupDepot,@idSupDepot_2=idSupDepot_2 from @table

declare @newQteDepot float
declare @newCmupDepot money
declare @newQteSupDepot float 
declare @newCmupSupDepot money

if exists (select * from s_Settings where idGroup=@idGroup and subDepot=1)
begin 
	---- QteSupDepot et OldCmupSupDepot
	if not exists (select * from e_Art_Depot where idArticle = @idArticle and idSupDepot = @idSupDepot_2 and idDossier=@idDossier)
	begin
		insert into e_Art_Depot(idArticle,idSupDepot,qteDepot,cmup,firstPrix,idDossier) values(@idArticle,@idSupDepot_2,0,0,@prixHT,@idDossier)
	end	
	select @oldCmupSupDepot=cmup,@oldqteSupDepot=qteDepot from e_Art_Depot where idSupDepot = @idSupDepot_2 and idArticle=@idArticle and idDossier=@idDossier
	set @newQteSupDepot = @oldqteSupDepot + @qteLign

	if(@newQteSupDepot<>0)
	begin
		---- Update NewCmup SupDepot
			set @newCmupSupDepot =((@oldCmupSupDepot*@oldqteSupDepot)+(@qteLign * @prixHT))/@newQteSupDepot
			update e_Art_Depot set qteDepot = @newQteSupDepot, cmup = @newCmupSupDepot where idSupDepot = @idSupDepot_2 and idArticle=@idArticle and idDossier=@idDossier
	end
	else
		begin
			---- Update Qte et CMUP SupDepot
			update e_Art_Depot set qteDepot = @newQteSupDepot, cmup = @prixHT where idSupDepot = @idSupDepot_2 and idArticle=@idArticle and idDossier=@idDossier
		end

update e_Art_Depot set qteDepot = qteDepot - @qteLign where idSupDepot = @idSupDepot and idArticle=@idArticle and idDossier=@idDossier
end	
if not exists (select * from e_Art_Depot where idArticle = @idArticle and idDepot = @idDepot_2 and idDossier=@idDossier)
begin
	insert into e_Art_Depot(idArticle,idDepot,qteDepot,cmup,firstPrix,idDossier) values(@idArticle,@idDepot_2,0,0,@prixHT,@idDossier)
end	
select @oldCmupDepot=cmup,@oldqteDepot=qteDepot from e_Art_Depot where idDepot = @idDepot_2 and idArticle=@idArticle and idDossier=@idDossier
set @newQteDepot = @oldqteDepot + @qteLign

if(@newQteDepot<>0)
	begin	
		set @newCmupDepot=((@oldCmupDepot * @oldqteDepot)+(@qteLign * @prixHT))/@newQteDepot
		update e_Art_Depot set qteDepot = @newQteDepot, cmup = @newCmupDepot where idDepot = @idDepot_2 and idArticle=@idArticle and idDossier=@idDossier
	end
else
	begin
		update e_Art_Depot set qteDepot = @newQteDepot, cmup = @prixHT where idDepot = @idDepot_2 and idArticle=@idArticle and idDossier=@idDossier
	end

update e_Art_Depot set qteDepot = qteDepot - @qteLign where idDepot = @idDepot and idArticle=@idArticle and idDossier=@idDossier

delete from @table where id = @id
end
select * from e_tableEntet
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [et_EtatClients]
(
@typeEtat nvarchar(250)=null,
@dateCompStart datetime=null,
@dateCompEnd datetime =null,
@dateStart datetime=null,
@dateEnd datetime =null,
@idClient int=null,
@topClients int=1000,
@codeType nvarchar(20)=null,
@groupTime nvarchar(50)=null,
@palmares nvarchar(250)=null,
@classement nvarchar(150)=null,
@valorisation nvarchar(150)=null,
@statement nvarchar(50),
@idGroup int
)
as begin
	if(@statement='analyseClients')
		begin
			if(@typeEtat='activite')
				begin
					if(@idClient=-1)
						begin
							select Top (@topClients)* 
							from dbo.et_ActiviteClients(@dateCompStart,@dateCompEnd,@dateStart,@dateEnd,@idGroup) 
							order by chiffreAff desc	
						end
					else
						begin
							select * from dbo.et_ActiviteClients(@dateCompStart,@dateCompEnd,@dateStart,@dateEnd,@idGroup) 
							where idClient=@idClient 
							order by chiffreAff desc							
						end
				end
			if(@typeEtat='rentabilite')
				begin
					if(@idClient=-1)
						begin
							select Top (@topClients)* from dbo.et_RentabiliteClients(@dateStart,@dateEnd,@idGroup)
							order by Marge desc
						end
					else
						begin
							select * from dbo.et_RentabiliteClients(@dateStart,@dateEnd,@idGroup)
							where idClient=@idClient	
							order by Marge desc						
						end
				end
		end
	if(@statement='cadencierClients')
		begin
			select * from t_Client
		end	
	if(@statement='statistiquesClients')
		begin
			if(@typeEtat='parFamille')
				begin
					if(@idClient=-1)
						begin
							DECLARE @DynamicSQL NVARCHAR(MAX);
							SET @DynamicSQL = '
								SELECT Top ('+CAST(@topClients AS NVARCHAR(100))+')* 
								FROM dbo.et_StatistiquesClientsparFam(
									CONVERT(DATE, ' + QUOTENAME(@dateStart, '''') + ', 120),
									CONVERT(DATE, ' + QUOTENAME(@dateend, '''') + ', 120),
									' + CAST(@idGroup AS NVARCHAR(100)) + '
								)
								where codeType in(''' + REPLACE(@codeType, ',', ''',''') + ''')
								ORDER BY ' + QUOTENAME(@classement) + ' ' + @palmares;
							EXEC sp_executesql @DynamicSQL;
						end
					else
						begin
							DECLARE @DynamicSQL2 NVARCHAR(MAX);
							SET @DynamicSQL2 = '
								SELECT *
								FROM dbo.et_StatistiquesClientsparFam(
									CONVERT(DATE, ' + QUOTENAME(@dateStart, '''') + ', 120),
									CONVERT(DATE, ' + QUOTENAME(@dateend, '''') + ', 120),
									' + CAST(@idGroup AS NVARCHAR(100)) + '
								)
								where idClient='+CAST(@idClient AS NVARCHAR(100))+' and codeType in(''' + REPLACE(@codeType, ',', ''',''') + ''')
								ORDER BY ' + QUOTENAME(@classement) + ' ' + @palmares;
							EXEC sp_executesql @DynamicSQL2;							
						end
				end
			if(@typeEtat='rentabilite')
				begin
					if(@idClient=-1)
						begin
							select * from t_Client
						end
					else
						begin
							select * from t_Client					
						end
				end
		end
	if(@statement='mouvementsClients')
		begin
				if(@idClient=-1)
						begin
							DECLARE @DynamicSQL3 NVARCHAR(MAX);
							SET @DynamicSQL3 = '
								SELECT Top ('+ CAST(@topClients AS NVARCHAR(100))+')*
								FROM dbo.et_MouvementsClients(
								CONVERT(DATE, ' + QUOTENAME(@dateStart, '''') + ', 120),
								CONVERT(DATE, ' + QUOTENAME(@dateend, '''') + ', 120),
									' + CAST(@idGroup AS NVARCHAR(100)) + '
								)
								where codeType in(''' + REPLACE(@codeType, ',', ''',''') + ''')
								ORDER BY ' + QUOTENAME(@valorisation);	
							EXEC sp_executesql @DynamicSQL3;
						end
					else
						begin
							DECLARE @DynamicSQL4 NVARCHAR(MAX);
							SET @DynamicSQL = '
							SELECT *
							FROM dbo.et_MouvementsClients(
								CONVERT(DATE, ' + QUOTENAME(@dateStart, '''') + ', 120),
								CONVERT(DATE, ' + QUOTENAME(@dateend, '''') + ', 120),
								' + CAST(@idGroup AS NVARCHAR(100)) + '
							)
							where codeType in(''' + REPLACE(@codeType, ',', ''',''') + ''')
							ORDER BY ' + QUOTENAME(@valorisation);	
							EXEC sp_executesql @DynamicSQL4;					
						end
		end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [etat_plt]
AS
BEGIN
    DECLARE @table TABLE (
        id INT IDENTITY,
        idEntetFish INT,
        numBon_plt NVARCHAR(MAX),
        facturNum_plt NVARCHAR(MAX),
        dua_plt NVARCHAR(MAX),
        date_plt DATE,
        quantite_plt FLOAT,
        idEntet INT,
        expeditoP_plt NVARCHAR(MAX),
        fechaP_plt DATE,
        factureP_plt NVARCHAR(MAX),
        dauP_plt NVARCHAR(MAX),
        quantiteP_plt FLOAT
    )

    DECLARE @tableSecond TABLE (
        id INT IDENTITY,
        idEntet INT,
        expeditoP_plt NVARCHAR(MAX),
        fechaP_plt DATE,
        factureP_plt NVARCHAR(MAX),
        dauP_plt NVARCHAR(MAX),
        quantiteP_plt FLOAT
    )

    INSERT INTO @table(idEntetFish, numBon_plt, facturNum_plt, dua_plt, date_plt, quantite_plt)
    SELECT
        idEntet,
        CASE WHEN numBon_plt IS NULL THEN numFactur ELSE numBon_plt END AS numBon_plt,
        CASE WHEN facturNum_plt IS NULL THEN refFacturE ELSE facturNum_plt END AS facturNum_plt,
        CASE WHEN dua_plt IS NULL THEN DUA ELSE dua_plt END AS dua_plt,
        CASE WHEN date_plt IS NULL THEN dateEntet ELSE date_plt END AS date_plt,
        quantite_plt
    FROM fish_entet
    WHERE codetype = 'BLFISHINT'

    INSERT INTO @tableSecond(idEntet, expeditoP_plt, fechaP_plt, factureP_plt, dauP_plt, quantiteP_plt)
    SELECT
        e.idEntet,
        e.expeditoP_plt,
        CASE WHEN e.fechaP_plt IS NULL THEN e.dateEntet ELSE e.fechaP_plt END AS fechaP_plt,
        'F' + RIGHT('00000' + CAST(CASE WHEN e.factureP_plt IS NULL THEN e.numFactur ELSE e.factureP_plt END AS NVARCHAR), 5) AS factureP_plt,
        STUFF((SELECT ', ' + el.DuaLigne
               FROM e_EntetLign el
               WHERE e.idEntet = el.idEntet
               FOR XML PATH('')), 1, 2, '') AS dauP_plt,
        e.quantiteP_plt
    FROM e_Entet e
    WHERE codeType = 'pakinglist'

    DECLARE @id INT = 1

    WHILE (EXISTS(SELECT * FROM @tableSecond))
    BEGIN
        DECLARE @expeditoP_plt AS NVARCHAR(MAX)
        DECLARE @idEntet AS INT
        DECLARE @fechaP_plt AS DATE
        DECLARE @factureP_plt AS NVARCHAR(MAX)
        DECLARE @dauP_plt AS NVARCHAR(MAX)
        DECLARE @quantiteP_plt AS FLOAT

        IF NOT EXISTS (SELECT 1 FROM @table WHERE id = @id)
        BEGIN
            SELECT TOP 1
                @idEntet = idEntet,
                @expeditoP_plt = expeditoP_plt,
                @fechaP_plt = fechaP_plt,
                @factureP_plt = factureP_plt,
                @dauP_plt = dauP_plt,
                @quantiteP_plt = quantiteP_plt
            FROM @tableSecond
            WHERE id = @id

            INSERT INTO @table (idEntet, expeditoP_plt, fechaP_plt, factureP_plt, dauP_plt, quantiteP_plt)
            VALUES (@idEntet, @expeditoP_plt, @fechaP_plt, @factureP_plt, @dauP_plt, @quantiteP_plt)
        END
        ELSE
        BEGIN
            SELECT TOP 1
                @idEntet = idEntet,
                @expeditoP_plt = expeditoP_plt,
                @fechaP_plt = fechaP_plt,
                @factureP_plt = factureP_plt,
                @dauP_plt = dauP_plt,
                @quantiteP_plt = quantiteP_plt
            FROM @tableSecond
            WHERE id = @id

            UPDATE @table
            SET expeditoP_plt = @expeditoP_plt,
                fechaP_plt = @fechaP_plt,
                factureP_plt = @factureP_plt,
                dauP_plt = @dauP_plt,
                quantiteP_plt = @quantiteP_plt,
                idEntet = @idEntet
            WHERE id = @id
        END

        DELETE FROM @tableSecond WHERE id = @id
        SET @id = @id + 1
    END

    SELECT * FROM @table
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [etat_plt_lot]
AS
BEGIN
    DECLARE @table TABLE (
        id INT IDENTITY,
        idEntetFish INT,
        numBonL_plt NVARCHAR(MAX),
        dateL_plt DATE,
        facturNumL_plt NVARCHAR(MAX),
        duaL_plt NVARCHAR(MAX),
        loteL_plt NVARCHAR(MAX),
        quantiteL_plt FLOAT,
        idEntet INT,
        expeditoLP_plt NVARCHAR(MAX),
        fechaLP_plt DATE,
        factureLP_plt NVARCHAR(MAX),
        dauLP_plt NVARCHAR(MAX),
        DETLP_plt NVARCHAR(MAX),
        loteLP_plt NVARCHAR(MAX),

        quantiteLP_plt FLOAT
    )

    DECLARE @tableSecond TABLE (
        id INT IDENTITY,
        idEntet INT,
        expeditoLP_plt NVARCHAR(MAX),
        fechaLP_plt DATE,
        factureLP_plt NVARCHAR(MAX),
        dauLP_plt NVARCHAR(MAX),
        DETLP_plt NVARCHAR(MAX),
        loteLP_plt NVARCHAR(MAX),
        quantiteLP_plt FLOAT
    )

    INSERT INTO @table(idEntetFish, numBonL_plt, facturNumL_plt, duaL_plt, loteL_plt,dateL_plt, quantiteL_plt)
    SELECT
        idEntet,
        CASE WHEN numBonL_plt IS NULL THEN numFactur ELSE numBonL_plt END AS numBonL_plt,
        CASE WHEN facturNumL_plt IS NULL THEN refFacturE ELSE facturNumL_plt END AS facturNumL_plt,
        CASE WHEN duaL_plt IS NULL THEN DUA ELSE duaL_plt END AS duaL_plt,
        CASE WHEN loteL_plt IS NULL THEN Lote ELSE loteL_plt END AS loteL_plt,
        CASE WHEN dateL_plt IS NULL THEN dateEntet ELSE dateL_plt END AS dateL_plt,
        quantiteL_plt
    FROM fish_entet
    WHERE codetype = 'BLFISHINT'

    INSERT INTO @tableSecond(idEntet, expeditoLP_plt, fechaLP_plt, factureLP_plt, dauLP_plt,DETLP_plt,loteLP_plt, quantiteLP_plt)
    SELECT
        e.idEntet,
        e.expeditoLP_plt,
        CASE WHEN e.fechaLP_plt IS NULL THEN e.dateEntet ELSE e.fechaLP_plt END AS fechaLP_plt,
        'F' + RIGHT('00000' + CAST(CASE WHEN e.factureLP_plt IS NULL THEN e.numFactur ELSE e.factureLP_plt END AS NVARCHAR), 5) AS factureLP_plt,
        STUFF((SELECT ', ' + el.DuaLigne
               FROM e_EntetLign el
               WHERE e.idEntet = el.idEntet
               FOR XML PATH('')), 1, 2, '') AS dauLP_plt,
			   e.DETLP_plt,
		STUFF((SELECT ', ' + el.LotePfLigne
				FROM e_EntetLign el
				WHERE e.idEntet = el.idEntet
				FOR XML PATH('')), 1, 2, '') AS loteLP_plt,
        e.quantiteLP_plt
    FROM e_Entet e
    WHERE codeType = 'pakinglist'

    DECLARE @id INT = 1

    WHILE (EXISTS(SELECT * FROM @tableSecond))
    BEGIN
        DECLARE @expeditoLP_plt AS NVARCHAR(MAX)
        DECLARE @idEntet AS INT
        DECLARE @fechaLP_plt AS DATE
        DECLARE @factureLP_plt AS NVARCHAR(MAX)
        DECLARE @dauLP_plt AS NVARCHAR(MAX)
        DECLARE @DETLP_plt AS NVARCHAR(MAX)
        DECLARE @loteLP_plt AS NVARCHAR(MAX)
        DECLARE @quantiteLP_plt AS FLOAT

        IF NOT EXISTS (SELECT 1 FROM @table WHERE id = @id)
        BEGIN
            SELECT TOP 1
                @idEntet = idEntet,
                @expeditoLP_plt = expeditoLP_plt,
                @fechaLP_plt = fechaLP_plt,
                @factureLP_plt = factureLP_plt,
                @dauLP_plt = dauLP_plt,
                @loteLP_plt = loteLP_plt,
                @DETLP_plt = DETLP_plt,
                @quantiteLP_plt = quantiteLP_plt
            FROM @tableSecond
            WHERE id = @id

            INSERT INTO @table (idEntet, expeditoLP_plt, fechaLP_plt, factureLP_plt, dauLP_plt,DETLP_plt,loteLP_plt, quantiteLP_plt)
            VALUES (@idEntet, @expeditoLP_plt, @fechaLP_plt, @factureLP_plt, @dauLP_plt,@DETLP_plt,@loteLP_plt, @quantiteLP_plt)
        END
        ELSE
        BEGIN
            SELECT TOP 1
                @idEntet = idEntet,
                @expeditoLP_plt = expeditoLP_plt,
                @fechaLP_plt = fechaLP_plt,
                @factureLP_plt = factureLP_plt,
                @dauLP_plt = dauLP_plt,
                @loteLP_plt = loteLP_plt,
                @DETLP_plt = DETLP_plt,
                @quantiteLP_plt = quantiteLP_plt
            FROM @tableSecond
            WHERE id = @id

            UPDATE @table
            SET expeditoLP_plt = @expeditoLP_plt,
                fechaLP_plt = @fechaLP_plt,
                factureLP_plt = @factureLP_plt,
                dauLP_plt = @dauLP_plt,
                loteLP_plt = @loteLP_plt,
                DETLP_plt = @DETLP_plt,
                quantiteLP_plt = @quantiteLP_plt,
                idEntet = @idEntet
            WHERE id = @id
        END

        DELETE FROM @tableSecond WHERE id = @id
        SET @id = @id + 1
    END

    SELECT * FROM @table
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [f_FabricationInsertUpdate](
  @idFabrication int=null,
  @idArticle int =null,
  @reference nvarchar(200)=null,
  @info nvarchar(250)=null,
  @idUser nvarchar(450),
  @idGroup int=null,
  @statment varchar(200)='insert')
  as begin
	if(@statment='insert')
	begin
		insert f_Fabrication(idArticle,reference,info,idUser,idGroup) values (@idArticle,@reference,@info,@idUser,@idGroup)
		select * from f_tableFabrication where idFabrication=@@IDENTITY
	end
	else
	begin
		update f_Fabrication set idArticle=@idArticle,reference=@reference,info=@info where idFabrication=@idFabrication
		select * from f_tableFabrication where idFabrication=@idFabrication
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [f_LignFabrInsertUpdate](
	  @idFabrication int=null,
	  @idLignFab int =null,
	  @idLignArticle int=null,
	  @qteFabrication float=0,
	  @qteLignFabrication float=0,
	  @statment varchar(200)='insert')
  as begin
	if(@statment='insert')
	begin
		insert f_FabricationLign(idFabrication,idLignArticle,qteFabrication,qteLignFabrication) values (@idFabrication,@idLignArticle,@qteFabrication,@qteLignFabrication)
		select * from f_tableFabricationLign where idLignFab=@@IDENTITY
	end
	else
	begin
		update f_FabricationLign set qteFabrication=@qteFabrication,qteLignFabrication=@qteLignFabrication where idLignFab=@idLignFab
		select * from f_tableFabricationLign where idLignFab=@idLignFab
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [f_OrderLineInsert](
@qteOrdreLine float =0,
@typeOrdre nvarchar(10),
@valStock int= 0,
@idLignArticle int=null,
@idOrdre int=null)
as begin
	declare @idDepot int,@idSupDepot int,@idDossier int,@cmup money
	select 
	@idDepot=idDepot,@idSupDepot=idSupDepot,@idDossier=idDossier
	from f_Ordre where idOrdre=@idOrdre
	select @cmup=cmup from e_Art_Depot where idDepot=@idDepot and idDossier=@idDossier and idArticle=@idLignArticle
	insert into f_OrdreLine(qteOrdreLine,cmup,ttHT,typeOrdre,valStock,idLignArticle,idOrdre,idDepot,idSupDepot,idDossier)
	values(@qteOrdreLine,@cmup,@qteOrdreLine*@cmup,@typeOrdre,@valStock,@idLignArticle,@idOrdre,@idDepot,@idSupDepot,@idDossier)
	update e_Art_Depot set qteDepot=qteDepot+(@qteOrdreLine*@valStock) where idDepot=@idDepot and idDossier=@idDossier and idArticle=@idLignArticle
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [f_OrdreInsertUpdate](
  @idOrdre int=null,
  @numOrdre int =0,
  @qteOrdre float=null,
  @datePlanification datetime =null,
  @dateEndPlanification datetime =null,
  @progressType nvarchar(100)='nv',
  @positionOrdre int=0,
  @idDepot int=null,
  @idSupDepot int=null,
  @idFabrication int=null,
  @idArticle int=null,
  @idUser nvarchar(450),
  @idGroup int=null,
  @numberPerson int=null,
  @idDossier int=null,
  @statment varchar(200)='insert')
  as begin
	if(@statment='insert')
	begin
		insert f_Ordre(numOrdre,qteOrdre,datePlanification,dateEndPlanification,progressType,positionOrdre,idDepot,idSupDepot,idFabrication,idArticle,idUser,idGroup,idDossier,numberPerson)
		values (@numOrdre,@qteOrdre,@datePlanification,@dateEndPlanification,@progressType,@positionOrdre,@idDepot,@idSupDepot,@idFabrication,@idArticle,@idUser,@idGroup,@idDossier,@numberPerson)
		select @idOrdre=idOrdre from f_tableOrdre where idOrdre=@@IDENTITY
		if(@progressType='nv')
			begin		
			declare @TTHTC money
				select @TTHTC=isnull(sum((qteLignFabrication*cmup)/l.qteFabrication),0) from f_FabricationLign l 
					inner join e_Art_Depot a on a.idArticle=l.idLignArticle where a.idDepot=@idDepot and a.idDossier=@idDossier	 and l.idFabrication=@idFabrication	
				update f_Ordre set ttHT = @TTHTC   where  idOrdre = @idOrdre 
			end
		select * from f_tableOrdre where idOrdre=@idOrdre
	end
	else
	begin
		update f_Ordre set qteOrdre=@qteOrdre,datePlanification=@datePlanification
		,dateEndPlanification=@dateEndPlanification,idDepot=@idDepot,idSupDepot=@idSupDepot
		,idFabrication=@idFabrication,idArticle=@idArticle,numberPerson=@numberPerson where idOrdre=@idOrdre
		select * from f_tableOrdre where idOrdre=@idOrdre
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [f_OrdreLastNum](
		@idUser nvarchar(450),
		@SelectALL bit=null,
		@idGroup int=null,
		@idDossier int=null)
		as begin
			select top 1 numOrdre from f_Ordre 
			where (@SelectALL=1 and idUser=@idUser and idDossier=@idDossier) or (@SelectALL=0 and idDossier=@idDossier) order by numOrdre desc
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [f_OrdreLineInsertById](
@idOrdre int)
as begin
declare @qteFabrication float,@qteLignFabrication float,@qteOrdreLine float,@qteOrdre float,@idFabrication int,@idDepot int,@idSupDepot int,@idDossier int
	select @idFabrication=idFabrication,@qteOrdre=qteOrdre,
	@idDepot=idDepot,@idSupDepot=idSupDepot,@idDossier=idDossier
	from f_Ordre where idOrdre=@idOrdre
	insert into f_OrdreLine (qteOrdreLine,cmup,ttHT,idLignArticle,typeOrdre,valStock,idOrdre,idDepot,idSupDepot,idDossier) 
	select (qteLignFabrication*(@qteOrdre/qteFabrication)),d.cmup,d.cmup*(qteLignFabrication*(@qteOrdre/qteFabrication)),idLignArticle,
	'sorte',-1,@idOrdre,@idDepot,@idSupDepot,@idDossier
	from f_FabricationLign f inner join e_Art_Depot d on f.idLignArticle=d.idArticle where idFabrication=@idFabrication and d.idDossier=@idDossier and d.idDepot=@idDepot
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [f_OrdreSelect](
	@idUser nvarchar(450),
	@SelectDoc bit=null,
	@idGroup int=null,
	@idDossier int=null,
	@dateStart datetime,
    @dateEnd datetime,
	@Filter varchar(100)='createDate'
	)
	as begin
			if(@Filter='createDate')
			begin
				select * from f_tableOrdre where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and convert(varchar, createDate, 1)  between  convert(varchar,@dateStart, 1) and convert(varchar,@dateEnd, 1)) 
										or (@SelectDoc=0 and idDossier=@idDossier and convert(varchar, createDate, 1)  between  convert(varchar,@dateStart, 1) and convert(varchar,@dateEnd, 1)))
					
			end
			if(@Filter='datePlanification') 
			begin
				select * from f_tableOrdre where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and datePlanification between @dateStart and @dateEnd) 
											or (@SelectDoc=0 and idDossier=@idDossier and datePlanification between @dateStart and @dateEnd ))
			end
			if(@Filter='dateEndPlanification') 
			begin
				select * from f_tableOrdre where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and dateEndPlanification between @dateStart and @dateEnd) 
											or (@SelectDoc=0 and idDossier=@idDossier and dateEndPlanification between @dateStart and @dateEnd ))
			end	
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [f_uapdateOrdreProgressType](
@idOrdre int,
@qteOrdreValider float=0,
@qteOrdreTrash float=0,
@qteOrdreEnCours float=0,
@progressType nvarchar(200))
as begin
	declare @lastProgressType nvarchar(200),@idDepot int,@idSupDepot int,
			@idArticle int,@idFabrication int,@qteOrdre float,@idDossier int,@ttHT money
			
	select @lastProgressType=progressType,@idDepot=idDepot,@idArticle=idArticle,@idFabrication=idFabrication,@qteOrdre=qteOrdre,@idDossier=idDossier,@ttHT=ttHT
	 from f_Ordre where idOrdre=@idOrdre
	 
	if(@progressType<>@lastProgressType)
	begin
		update f_Ordre set valider=1 where idOrdre=@idOrdre
		if(@progressType<>'va')
		begin 
			insert into f_Ordre(numOrdre,
			qteOrdre,ttHT,
			dateEndPlanification,
			datePlanification,
			positionOrdre,
			progressType,
			idDepot,
			idSupDepot,
			idFabrication,
			idArticle,
			idUser,
			idGroup,
			idDossier)
			 select numOrdre,
			qteOrdre,ttHT,
			dateEndPlanification,
			datePlanification,
			positionOrdre,
			@progressType,
			idDepot,
			idSupDepot,
			idFabrication,
			idArticle,
			idUser,
			idGroup,
			idDossier from f_Ordre where idOrdre=@idOrdre
		end
		------------ si table art_depot vide
		if not exists (select * from e_Art_Depot where idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier)
			begin
				insert into e_Art_Depot(idArticle,idDepot,qteDepot,cmup,idDossier) values(@idArticle,@idDepot,0,0,@idDossier)
			end
			
		declare @oldCmul money,@oldQte float,@newCmul money
			-------------get Qte and prixHT	
			--select @prixHT=tt_HT from fab_EntetFabrication where idEntet=@idEntet	
		if(@progressType='va')
		begin
					if(@qteOrdreTrash>0)
					begin
						insert into f_Ordre(numOrdre,
							qteOrdre,ttHT,
							dateEndPlanification,
							datePlanification,
							positionOrdre,
							progressType,
							idDepot,
							idSupDepot,
							idFabrication,
							idArticle,
							idUser,
							idGroup,
							idDossier)
							 select numOrdre,
							@qteOrdreTrash,ttHT,
							dateEndPlanification,
							datePlanification,
							positionOrdre,
							'tr',
							idDepot,
							idSupDepot,
							idFabrication,
							idArticle,
							idUser,
							idGroup,
							idDossier from f_Ordre where idOrdre=@idOrdre
							declare @newId int
							select @newId=idOrdre from f_Ordre where idOrdre=@@IDENTITY
							exec f_OrdreLineInsertById @newId
					end
					if(@qteOrdreEnCours>0)
					begin
						insert into f_Ordre(numOrdre,
							qteOrdre,ttHT,
							dateEndPlanification,
							datePlanification,
							positionOrdre,
							progressType,
							idDepot,
							idSupDepot,
							idFabrication,
							idArticle,
							idUser,
							idGroup,
							idDossier)
							 select numOrdre,
							@qteOrdreEnCours,ttHT,
							dateEndPlanification,
							datePlanification,
							positionOrdre,
							'ec',
							idDepot,
							idSupDepot,
							idFabrication,
							idArticle,
							idUser,
							idGroup,
							idDossier from f_Ordre where idOrdre=@idOrdre
					end
					insert into f_Ordre(numOrdre,
							qteOrdre,ttHT,
							dateEndPlanification,
							datePlanification,
							positionOrdre,
							progressType,
							idDepot,
							idSupDepot,
							idFabrication,
							idArticle,
							idUser,
							idGroup,
							idDossier)
							 select numOrdre,
							@qteOrdreValider,ttHT,
							dateEndPlanification,
							datePlanification,
							positionOrdre,
							'va',
							idDepot,
							idSupDepot,
							idFabrication,
							idArticle,
							idUser,
							idGroup,
							idDossier from f_Ordre where idOrdre=@idOrdre
				-------------get old QT et old CMUP
				
				select @oldCmul= isnull(cmup,0), @oldQte = qteDepot from e_Art_Depot 
						where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
				
				-------------culc cmup 
				if(@oldCmul=0)
				begin
					set @oldCmul=@ttHT
				end
				if (@oldQte + @qteOrdreValider) <> 0
				begin 
					set @newCmul = ((@oldCmul * @oldQte) + (@ttHT * @qteOrdreValider))/(@oldQte + @qteOrdreValider)
					update e_Art_Depot set cmup = @newCmul,lastPrix = @ttHT  where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
				end	
				else
				begin
					update e_Art_Depot set cmup = @ttHT  where idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
				end
				update e_Art_Depot set qteDepot = @oldQte + @qteOrdreValider   where  idArticle = @idArticle and idDepot = @idDepot and idDossier=@idDossier
				update a_Article set prixAchat_HT=@ttHT where idArticle=@idArticle
		end
		else
		begin
			declare @tableLignFabrication table(id int identity(1,1),idLignArticle varchar(500),qteFabrication float,qteLignFabrication float)
			insert into @tableLignFabrication(idLignArticle,qteFabrication,qteLignFabrication) 
			select idLignArticle,qteFabrication,qteLignFabrication from f_FabricationLign where idFabrication=@idFabrication
			
			declare @id int,@idLignArticle int,@qteFabrication float,@qteLignFabrication float
			While (select COUNT(*) from @tableLignFabrication ) > 0
				begin
				select top 1 @id=id,@idLignArticle=idLignArticle,@qteFabrication=qteFabrication,@qteLignFabrication=qteLignFabrication from @tableLignFabrication 
				set	@qteFabrication = @qteLignFabrication*(@qteOrdre/@qteFabrication)
				if(@progressType='nv')
				begin					
					update e_Art_Depot set qteDepot = qteDepot + @qteFabrication   where  idArticle = @idLignArticle and idDepot = @idDepot and idDossier=@idDossier
				end
				if(@progressType='ec')
				begin
					update e_Art_Depot set qteDepot = qteDepot - @qteFabrication   where  idArticle = @idLignArticle and idDepot = @idDepot and idDossier=@idDossier
				end
				delete from @tableLignFabrication where id=@id
				end
		end
		
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [fich_fish_NomScientifiqueInsertUpdate](
@idNomScientifique int=0,
@NomScientifique nvarchar(max),
@statment varchar(100))
as begin
	if(@statment='insert')
	begin
		insert fish_NomScientifique(NomScientifique) values (@NomScientifique)
		select * from fish_NomScientifique where idNomScientifique=@@IDENTITY
	end	
	else
	begin
		update fish_NomScientifique set NomScientifique=@NomScientifique
		where idNomScientifique=@idNomScientifique
		select * from fish_NomScientifique where idNomScientifique=@idNomScientifique
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [fich_PortInsertUpdate](
@idPort int=0,
@nomPort nvarchar(max)=null,
@idUser nvarchar(max)=null,
@idGroup int =null,

@statment varchar(100))
as begin
	if(@statment='insert')
	begin
		insert fish_port(nomPort,idUser,idGroup) values (@nomPort,@idUser,@idGroup)
		select * from fish_port where idPort=@@IDENTITY
	end	
	else
	begin
		update fish_port set nomPort=@nomPort
		where idPort=@idPort
		select * from fish_port where idPort=@idPort
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [fich_TypeFamilleInsertUpdate](
@idTypeFamaille int=0,
@TypeFamaille nvarchar(max),
@statment varchar(100))
as begin
	if(@statment='insert')
	begin
		insert fish_TypeFamaille(TypeFamaille) values (@TypeFamaille)
		select * from fish_TypeFamaille where idTypeFamaille=@@IDENTITY
	end	
	else
	begin
		update fish_TypeFamaille set TypeFamaille=@TypeFamaille
		where idTypeFamaille=@idTypeFamaille
		select * from fish_TypeFamaille where idTypeFamaille=@idTypeFamaille
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [fish_EntetInsertUpdate](
@idEntet int =null,
@ETAT nvarchar(max)=null,
@kgRec float=null,
@valider bit=0,
@etatDoc nvarchar(50)=null,
@PM float=null,
@comission float=null,
@dateEntet date,
@idFamille int=null,
@idFournisseur int=null,
@idPort int=null,
@numFactur  int=null,
@refFacture nvarchar(max)=null,
@stockEntree float=null,
@stockTaxable float=null,
@totalAchat float=null,
@totalCharges float=null,
@idDossier int=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@codeType nvarchar(max)=null,
@DUA nvarchar(max)=null,
@barco nvarchar(max)=null,
@TotalCais float =null,
@TotalPN float=null,
@Lote nvarchar(max)=null,
@dateCongele date=null,
@idEntetS int=null,
@statment varchar(100)='insert'
)
as begin
		if(@statment='insert')
		begin
			insert into fish_entet(idUser,idDossier,idGroup,codeType,ETAT,PM,comission,dateEntet,idFamille,idFournisseur,idPort,numFactur,refFacture,stockEntree,stockTaxable,totalAchat,totalCharges,kgRec,etatDoc,valider,DUA,barco,TotalCais,TotalPN,Lote,dateCongele,idEntetS)
			values(@idUser,@idDossier,@idGroup,@codeType,@ETAT,@PM,@comission,@dateEntet,@idFamille,@idFournisseur,@idPort,@numFactur,@refFacture,@stockEntree,@stockTaxable,@totalAchat,@totalCharges,@kgRec,@etatDoc,@valider,@DUA,@barco,@TotalCais,@TotalPN,@Lote,@dateCongele,@idEntetS)
           update e_TypeDoc set numFacture=@numFactur where idDossier=@idDossier and codeType=@codeType
           select * from v_fish_EntetSelect where idEntet=@@IDENTITY
		end
		else
		begin
		update fish_entet
		set
		ETAT=@ETAT,
		PM=@PM,
		comission=@comission,
		dateEntet=@dateEntet,
		idFamille=@idFamille,
		idFournisseur=@idFournisseur,
		idPort=@idPort,
		numFactur=@numFactur,
		refFacture=@refFacture,
		stockEntree=@stockEntree,
		stockTaxable=@stockTaxable,
		totalAchat=@totalAchat,
		totalCharges=@totalCharges,
		kgRec=@kgRec,
		etatDoc=@etatDoc,
		valider=@valider,
		DUA=@DUA,
		barco=@barco,
		TotalCais=@TotalCais,
		TotalPN=@TotalPN,
		Lote=@Lote,
		dateCongele=@dateCongele,
		idEntetS=@idEntetS
		WHERE idEntet=@idEntet

			 select * from v_fish_EntetSelect where idEntet=@idEntet
		end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [fish_EntetSelect]
(
@idUser nvarchar(450),
@SelectDoc bit=null,
@idDossier int=null,
@codeType varchar(20)=null

)
as begin
	select fe.*,tf.nomFournisseur,ff.nomFamille,fp.nomPort,su.nomUser
	from fish_entet as fe left join a_Famille as ff on fe.idFamille=ff.idFamille
	left join fish_Port as fp on fe.idPort=fp.idPort
	left join t_Fournisseur as tf on fe.idFournisseur=tf.idFournisseur
	left join s_Users as su on fe.idUser=su.idUser
	where codeType=@codeType and idDossier=@idDossier
	--and fe.idUser=@idUser

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [fish_Stock](
@idUser nvarchar(450)='',
@idFamille int=0
)
as
begin
	DECLARE @table TABLE (
		id INT IDENTITY,
		dateEntre DATETIME,
		cEntre float,
		kgEntre FLOAT,
		dateSortie DATETIME,
		cSortie float,
		kgSortie FLOAT,
		lastLot nvarchar(max)
	)
	DECLARE @tableSecond TABLE (
		id INT IDENTITY,
		dateSortie DATETIME,
		cSortie float,
		kgSortie FLOAT
	)
	INSERT INTO @table (dateEntre, cEntre, kgEntre,lastLot)
	SELECT e.dateEntet, sum(el.qteLign) AS c, SUM(ISNULL(el.qteLign, 0)) * e.NumeroTaux AS kg,LotePF
	FROM e_tableEntet e
	INNER JOIN e_EntetLign el ON e.idEntet = el.idEntet AND e.codeType = 'BPI'
	inner join a_Article ar on el.idArticle=ar.idArticle
	where ar.idArticle=@idFamille
	GROUP BY e.idEntet, NumeroTaux, e.dateEntet,LotePF	
	INSERT INTO @tableSecond

SELECT  e.dateEntet ,sum( distinct el.PackageEmvase),sum(distinct el.PesoNetoLigne)
	FROM e_tableEntet e
	INNER JOIN e_EntetLign el ON e.idEntet = el.idEntet AND e.codeType = 'PAKINGLIST'
	where el.idArticle=@idFamille
	GROUP BY e.idEntet,e.dateEntet
	DECLARE @id INT = 1
	WHILE (EXISTS(SELECT * FROM @tableSecond))
	BEGIN
		DECLARE @dateEntet DATETIME;
		DECLARE @cais INT;
		DECLARE @PN FLOAT;
		IF NOT EXISTS (SELECT 1 FROM @table WHERE id = @id)
		BEGIN
			SELECT TOP 1 @dateEntet = dateSortie, @cais = cSortie, @PN = kgSortie
			FROM @tableSecond
			WHERE id = @id
			INSERT INTO @table (dateSortie, cSortie, kgSortie)
			VALUES (@dateEntet, @cais, @PN)
		END
		ELSE
		BEGIN
			SELECT TOP 1 @PN =kgSortie, @cais = cSortie, @dateEntet = dateSortie
			FROM @tableSecond where id=@id
			UPDATE @table
			SET dateSortie = @dateEntet, cSortie = @cais, kgSortie = @PN
			WHERE id = @id
		END
		DELETE FROM @tableSecond WHERE id = @id
		SET @id = @id + 1;
	END
	SELECT * FROM @table
end

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [hotel_B_BookingEnteteCalendarSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null,
@dateD datetime=null,
@dateE datetime=null
)
as begin	
			select * from hotel_tableBookingsEnteteCalendar where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) and 
			(bookingInDate between @dateD and @dateE or bookingOutDate between @dateD and @dateE) 
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [hotel_B_BookingEnteteCancel](
@idBookingEntete int,
@idDossier int
)
as begin	
	update hotel_B_BookingEntete set cancelDate=GETDATE(),cancel=1, idDossier=@idDossier where idBookingEntete=@idBookingEntete
	select * from hotel_tableBookingsEntete where idBookingEntete=@idBookingEntete
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [hotel_B_BookingEnteteInsertUpdate](
@idBookingEntete int=0,
@numBooking int=null,
@bookingInDate datetime=null,
@bookingOutDate datetime=null,
@tt_NbGuest int=0,
@idClient int=null,
@checkIn bit=0,
@checkInDate datetime=null,
@checkOut bit=0,
@checkOutDate datetime=null,
@message nvarchar(max)=null,
@comment nvarchar(max)=null,
@cancel bit=0,
@cancelDate datetime=null,
@nbNights int=0,
@infoClients nvarchar(max)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@idDossier int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert hotel_B_BookingEntete
		(numBooking,bookingInDate,bookingOutDate,tt_NbGuest,idClient,checkIn,checkInDate,checkOut,checkOutDate,[message],comment,cancel,cancelDate,
		 nbNights,infoClients,idUser,idGroup,idDossier) 
		 values 
		(@numBooking,@bookingInDate,@bookingOutDate,@tt_NbGuest,@idClient,@checkIn,@checkInDate,@checkOut,@checkOutDate,@message,@comment,@cancel,@cancelDate,
		 @nbNights,@infoClients,@idUser,@idGroup,@idDossier)
		select * from hotel_tableBookingsEntete where idBookingEntete=@@IDENTITY
	end	
	else
	begin
		update hotel_B_BookingEntete set 
		 numBooking=@numBooking
		,bookingInDate=@bookingInDate
		,bookingOutDate=@bookingOutDate
		,tt_NbGuest=@tt_NbGuest
		,idClient=@idClient
		,checkIn=@checkIn
		,checkInDate=@checkInDate
		,checkOut=@checkOut
		,checkOutDate=@checkOutDate
		,[message]=@message
		,comment=@comment
		,cancel=@cancel
		,cancelDate=@cancelDate
		,nbNights=@nbNights
		,infoClients=@infoClients
		where idBookingEntete=@idBookingEntete
		select * from hotel_tableBookingsEntete where idBookingEntete=@idBookingEntete
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [hotel_B_BookingEnteteSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null,
@dateD datetime=null,
@dateE datetime=null,
@statement nvarchar(500)
)
as begin	
		if(@statement='Bookings')
		begin
			select * from hotel_tableBookingsEntete where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) and 
			(bookingInDate between @dateD and @dateE or bookingOutDate between @dateD and @dateE) 
		end
		else if(@statement='CheckIns')
		begin
			select * from hotel_tableBookingsEntete where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) and 
			bookingInDate between @dateD and @dateE
		end
		else if(@statement='CheckOuts')
		begin
			select * from hotel_tableBookingsEntete where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) and 
			bookingOutDate between @dateD and @dateE
		end
		else if(@statement='Cancelled')
		begin
			select * from hotel_tableBookingsEntete where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) and 
			cancel=1 and cancelDate between @dateD and @dateE
		end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [hotel_B_BookingEnteteUpdateChecks](
@idBookingEntete int,
@statement nvarchar(500)
)
as begin	
	if(@statement='checkIn')
	begin
		update hotel_B_BookingEntete set checkInDate=GETDATE(),checkIn=1 where idBookingEntete=@idBookingEntete
	end
	else if(@statement='checkOut')
	begin
		update hotel_B_BookingEntete set checkOutDate=GETDATE(),checkOut=1 where idBookingEntete=@idBookingEntete
	end
	else if(@statement='checkInFalse')
	begin
		update hotel_B_BookingEntete set checkInDate=null,checkIn=0 where idBookingEntete=@idBookingEntete
	end
	else if(@statement='checkOutFalse')
	begin
		update hotel_B_BookingEntete set checkOutDate=null,checkOut=0 where idBookingEntete=@idBookingEntete
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Hotel_B_BookingExtrasInsertUpdate](
@idBookingExtra int=0,
@idBookingEntete int=null,
@idExtras int=null,
@description nvarchar(max)=null,
@qte int=0,
@prixExtra money=0,
@totalExtras money=0,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Hotel_B_BookingExtras
		(idBookingEntete,idExtras,[description],qte,prixExtra,totalExtras) 
		 values 
		(@idBookingEntete,@idExtras,@description,@qte,@prixExtra,@totalExtras)
		select * from hotel_tableBookingsExtras where idBookingExtra=@@IDENTITY
	end	
	else
	begin
		update Hotel_B_BookingExtras set 
		 idBookingEntete=@idBookingEntete
		,idExtras=@idExtras
		,[description]=@description
		,qte=@qte
		,prixExtra=@prixExtra
		,totalExtras=@totalExtras
		where idBookingExtra=@idBookingExtra
		select * from hotel_tableBookingsExtras where idBookingEntete=@idBookingEntete
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Hotel_B_BookingInvitesInsertUpdate](
@idBookingInvite int=0,
@nomInvite nvarchar(500),
@prenomInvite nvarchar(500),
@cinInvite nvarchar(20),
@ageInvite int,
@sexeInvite nvarchar(50),
@nationalite nvarchar(250),
@idBookingEntete int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Hotel_B_BookingInvites
		(nomInvite,prenomInvite,cinInvite,ageInvite,sexeInvite,nationalite,idBookingEntete) 
		 values 
		(@nomInvite,@prenomInvite,@cinInvite,@ageInvite,@sexeInvite,@nationalite,@idBookingEntete)
		select * from Hotel_B_BookingInvites where idBookingInvite=@@IDENTITY
	end	
	else
	begin
		update Hotel_B_BookingInvites set 
		 nomInvite=@nomInvite
		,prenomInvite=@prenomInvite
		,cinInvite=@cinInvite
		,ageInvite=@ageInvite
		,sexeInvite=@sexeInvite
		,nationalite=@nationalite
		,idBookingEntete=@idBookingEntete
		where idBookingInvite=@idBookingInvite
		select * from Hotel_B_BookingInvites where idBookingInvite=@idBookingInvite
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Hotel_B_BookingLigneInsertUpdate](
@idBookingLigne int=0,
@idBookingEntete int=null,
@idRoomType int=null,
@idUnit int=null,
@guests int=0,
@prixTTC money=0,
@prixHT money=0,
@priceModel bit=0,
@TTPrix_TTC money=0,
@TTPrix_HT money=0,
@lgnTVA int=0,
@idUser nvarchar(450)=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Hotel_B_BookingLigne
		(idBookingEntete,idRoomType,idUnit,guests,prixTTC,prixHT,priceModel,TTPrix_TTC,TTPrix_HT,lgnTVA,idUser) 
		 values 
		(@idBookingEntete,@idRoomType,@idUnit,@guests,@prixTTC,@prixHT,@priceModel,@TTPrix_TTC,@TTPrix_HT,@lgnTVA,@idUser)
		select * from hotel_tableBookingLigne where idBookingLigne=@@IDENTITY
	end	
	else
	begin
		update Hotel_B_BookingLigne set 
		 idBookingEntete=@idBookingEntete
		,idRoomType=@idRoomType
		,idUnit=@idUnit
		,guests=@guests
		,prixTTC=@prixTTC
		,prixHT=@prixHT
		,priceModel=@priceModel
		,TTPrix_TTC=@TTPrix_TTC
		,TTPrix_HT=@TTPrix_HT
		,lgnTVA=@lgnTVA
		,idUser=@idUser
		where idBookingLigne=@idBookingLigne
		select * from hotel_tableBookingLigne where idBookingLigne=@idBookingLigne
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Hotel_B_BookingPaymentInsertUpdate](
@idBookingPayment int=0,
@idBookingEntete int=null,
@comment nvarchar(max)=null,
@idModRglm int=null,
@montant money=0,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Hotel_B_BookingPayment
		(idBookingEntete,comment,idModRglm,montant) 
		 values 
		(@idBookingEntete,@comment,@idModRglm,@montant)
		select * from hotel_tableBookingsPayment where idBookingPayment=@@IDENTITY
	end	
	else
	begin
		update Hotel_B_BookingPayment set 
		 idBookingEntete=@idBookingEntete
		,comment=@comment
		,idModRglm=@idModRglm
		,montant=@montant
		where idBookingPayment=@idBookingPayment
		select * from hotel_tableBookingsPayment where idBookingPayment=@idBookingPayment
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [hotel_B_BookingRoomsList](
		@dateD datetime=null,
		@dateE datetime=null
		)
		as begin
			select * from hotel_tableRoomsEntete 
			where idUnit not in 
			( select l.idUnit from hotel_B_BookingEntete e inner join Hotel_B_BookingLigne l on l.idBookingEntete=e.idBookingEntete 
			WHERE (CONVERT(DATE,e.bookingInDate, 120) between CONVERT(DATE,@dateD, 120) and CONVERT(DATE,@dateE, 120) or CONVERT(DATE,e.bookingOutDate, 120) between CONVERT(DATE,@dateD, 120) and CONVERT(DATE,@dateE, 120)))

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [hotel_S_CategorieInsertUpdate](
  @idCategorie int=null,
  @categName nvarchar(500)=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert hotel_S_Categorie(categName,idUser,idGroup) values (@categName,@idUser,@idGroup)
		select * from hotel_S_Categorie where idCategorie=@@IDENTITY
	end
	else
	begin
		update hotel_S_Categorie set categName=@categName where idCategorie=@idCategorie
		select * from hotel_S_Categorie where idCategorie=@idCategorie
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [hotel_S_EquipementsInsertUpdate](
  @idRoomType int=null,
  @valeurEquip nvarchar(500)=null,
  @textEquip nvarchar(max)=null)
  as begin
		insert hotel_S_Equipements(idRoomType,valeurEquip,textEquip) values (@idRoomType,@valeurEquip,@textEquip)
		select * from hotel_S_Equipements where idRoomType=@idRoomType

  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [hotel_S_ExtrasInsertUpdate](
  @idExtras int=null,
  @extrasName nvarchar(500)=null,
  @descExtras nvarchar(max)=null,
  @prix_HT money=0,
  @idTaxeExtras int=null,
  @prix_TTC money=0,
  @sortExtras int=0,
  @qteMax nvarchar(500)=null,
  @photoExtras nvarchar(max)=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert hotel_S_Extras(extrasName,descExtras,prix_HT,idTaxeExtras,prix_TTC,sortExtras,qteMax,photoExtras,idUser,idGroup) 
		values (@extrasName,@descExtras,@prix_HT,@idTaxeExtras,@prix_TTC,@sortExtras,@qteMax,@photoExtras,@idUser,@idGroup)
		select * from hotel_S_Extras where idExtras=@@IDENTITY
	end
	else
	begin
		if(@photoExtras is not null)
			begin
				update hotel_S_Extras set photoExtras=@photoExtras where idExtras=@idExtras
			end
		update hotel_S_Extras set extrasName=@extrasName,descExtras=@descExtras,prix_HT=@prix_HT,idTaxeExtras=@idTaxeExtras,
		prix_TTC=@prix_TTC,sortExtras=@sortExtras,qteMax=@qteMax where idExtras=@idExtras
		select * from hotel_S_Extras where idExtras=@idExtras
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [hotel_S_RoomCategorieInsertUpdate](
  @idRoomType int=null,
  @idCategorie int=null)
  as begin
		delete from hotel_S_RoomCategorie where idRoomType=@idRoomType
		insert hotel_S_RoomCategorie(idRoomType,idCategorie) 
		values (@idRoomType,@idCategorie)
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [hotel_S_RoomTypeInsertUpdate](
  @idRoomType int=null,
  @nameRoomType nvarchar(500)=null,
  @descRoomType nvarchar(max)=null,
  @nbGuests int=0,
  @maxNbGuests int=0,
  @priceModel int=0,
  @prixLouer_HT money=0,
  @idTaxeLouer int=null,
  @prixVente_TTC money=0,
  @sortOrder int=0,
  @objectType nvarchar(250)=null,
  @photoRoomType nvarchar(500)=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @idCategorie int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert hotel_S_RoomType(nameRoomType,descRoomType,nbGuests,maxNbGuests,priceModel,prixLouer_HT,idTaxeLouer,prixVente_TTC,sortOrder,
		objectType,photoRoomType,idUser,idGroup) 
		values (@nameRoomType,@descRoomType,@nbGuests,@maxNbGuests,@priceModel,@prixLouer_HT,@idTaxeLouer,@prixVente_TTC,@sortOrder,
		@objectType,@photoRoomType,@idUser,@idGroup)
		select * from hotel_S_RoomType where idRoomType=@@IDENTITY
	end
	else
	begin
		if(@photoRoomType is not null)
			begin
				update hotel_S_RoomType set photoRoomType=@photoRoomType where idRoomType=@idRoomType
			end
		update hotel_S_RoomType set nameRoomType=@nameRoomType,descRoomType=@descRoomType,nbGuests=@nbGuests,maxNbGuests=@maxNbGuests,
		priceModel=@priceModel,prixLouer_HT=@prixLouer_HT,idTaxeLouer=@idTaxeLouer,prixVente_TTC=@prixVente_TTC,sortOrder=@sortOrder,
		objectType=@objectType where idRoomType=@idRoomType
		select * from hotel_S_RoomType where idRoomType=@idRoomType
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [hotel_S_UnitsInsertUpdate](
  @idUnit int=null,
  @unitName nvarchar(500)=null,
  @idRoomType int,
  @idUser nvarchar(450)=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert hotel_S_Units(unitName,idRoomType,idUser) values (@unitName,@idRoomType,@idUser)
		select * from hotel_S_Units where idUnit=@@IDENTITY
	end
	else
	begin
		update hotel_S_Units set unitName=@unitName,idRoomType=@idRoomType where idUnit=@idUnit
		select * from hotel_S_Units where idUnit=@idUnit
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [m_MargeEntet](
@idUser nvarchar(450),
@SelectDoc bit=null,
@idDossier int=null,
@statment nvarchar(200),
@dateStart datetime,
@dateEnd datetime)
as begin
if(@statment='parArticle')
begin
	select l.refArticle,a.nomArticle,l.lgnCmup,
	sum(l.lgnValeurCmup*l.valStock*-1) as valeur,
	sum(l.prixHT*l.qteLign*l.valStock*-1)/NULLIF(SUM(l.qteLign*l.valStock*-1),0) as 'prixHT' ,SUM(l.lgnHT*l.valStock*-1) as ca
	,SUM(l.qteLign*l.valStock*-1) as qteV,sum(l.lgnMargeCmup*l.valStock*-1) as marge,
	sum(l.lgnMargeCmup*l.valStock*-1)/NULLIF(sum(l.lgnValeurCmup*l.valStock*-1),0) as TauxMarge from e_Entet e 
inner join e_EntetLign l on e.idEntet=l.idEntet
inner join a_Article a on l.idArticle=a.idArticle
inner join e_TypeDoc t on e.codeType=t.codeType
where t.calculMarge=1 and t.idDossier=@idDossier and e.dateEntet between @dateStart and @dateEnd  and e.idDossier=@idDossier
and l.qteLign<>0 and l.lgnValeurCmup<>0
group by l.refArticle,a.nomArticle,l.lgnCmup
end
if(@statment='parFamille')
begin
	select f.nomFamille,l.lgnCmup,
	sum(l.lgnValeurCmup*l.valStock*-1) as valeur,
	sum(l.prixHT*l.qteLign*l.valStock*-1)/NULLIF(SUM(l.qteLign*l.valStock*-1),0) as 'prixHT' ,SUM(l.lgnHT*l.valStock*-1) as ca
	,SUM(l.qteLign*l.valStock*-1) as qteV,sum(l.lgnMargeCmup*l.valStock*-1) as marge,
	sum(l.lgnMargeCmup*l.valStock*-1)/NULLIF(sum(l.lgnValeurCmup*l.valStock*-1),0) as TauxMarge from e_Entet e 
inner join e_EntetLign l on e.idEntet=l.idEntet
inner join a_Article a on l.idArticle=a.idArticle
inner join a_Famille f on a.idFamille=f.idFamille
inner join e_TypeDoc t on e.codeType=t.codeType
where t.calculMarge=1 and t.idDossier=@idDossier and e.dateEntet between @dateStart and @dateEnd  and e.idDossier=@idDossier
and l.qteLign<>0 and l.lgnValeurCmup<>0
group by f.nomFamille,l.lgnCmup
end
if(@statment='parClient')
begin
	select c.nomClient,l.lgnCmup,
	sum(l.lgnValeurCmup*l.valStock*-1) as valeur,
	sum(l.prixHT*l.qteLign*l.valStock*-1)/NULLIF(SUM(l.qteLign*l.valStock*-1),0) as 'prixHT' ,SUM(l.lgnHT*l.valStock*-1) as ca
	,SUM(l.qteLign*l.valStock*-1) as qteV,sum(l.lgnMargeCmup*l.valStock*-1) as marge,
	sum(l.lgnMargeCmup*l.valStock*-1)/NULLIF(sum(l.lgnValeurCmup*l.valStock*-1),0) as TauxMarge from e_Entet e 
inner join e_EntetLign l on e.idEntet=l.idEntet
inner join a_Article a on l.idArticle=a.idArticle
inner join t_Client c on c.idClient=e.idClient
inner join e_TypeDoc t on e.codeType=t.codeType
where t.calculMarge=1 and t.idDossier=@idDossier and e.dateEntet between @dateStart and @dateEnd  and e.idDossier=@idDossier
and l.qteLign<>0 and l.lgnValeurCmup<>0
group by c.nomClient,l.lgnCmup
end	
if(@statment='parVille')
begin
	select v.nomVille,l.lgnCmup,
	sum(l.lgnValeurCmup*l.valStock*-1) as valeur,
	avg(l.prixHT) as 'prixHT' ,SUM(l.lgnHT*l.valStock*-1) as ca
	,SUM(l.qteLign*l.valStock*-1) as qteV,sum(l.lgnMargeCmup*l.valStock*-1) as marge,
	sum(l.lgnTauxMargeCmup*l.valStock*-1) as TauxMarge from e_Entet e 
inner join e_EntetLign l on e.idEntet=l.idEntet
inner join a_Article a on l.idArticle=a.idArticle
inner join t_Client c on c.idClient=e.idClient
inner join b_Ville v on v.idVille=c.idVille
inner join e_TypeDoc t on e.codeType=t.codeType
where t.calculMarge=1 and t.idDossier=@idDossier and e.dateEntet between @dateStart and @dateEnd  and e.idDossier=@idDossier
group by v.nomVille,l.lgnCmup
end	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Maint_A_EquipementsInsertUpdate](
  @idEquipement int=null,
  @modeleEquipement nvarchar(max)=null,
  @numeroSerie nvarchar(250)=null,
  @coutEquipement money=0,
  @typeTeam nvarchar(500)=null,
  @dateGarantie datetime=null,
  @dateEffet datetime=null,
  @idLign int=null,
  @idArticle int=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert into Maint_A_Equipements(modeleEquipement,numeroSerie,coutEquipement,dateGarantie,dateEffet,idLign,idArticle,idUser,idGroup) 
						   values (@modeleEquipement,@numeroSerie,@coutEquipement,@dateGarantie,@dateEffet,@idLign,@idArticle,@idUser,@idGroup)
		select * from Maint_A_Equipements where idEquipement=@@IDENTITY
	end
	else
	begin
		update Maint_A_Equipements set modeleEquipement=@modeleEquipement,numeroSerie=@numeroSerie,coutEquipement=@coutEquipement,
		dateGarantie=@dateGarantie,dateEffet=@dateEffet where idEquipement=@idEquipement
		select * from Maint_A_Equipements where idEquipement=@idEquipement
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Maint_R_RequestInsertUpdate](
  @idRequest int=null,
  @numRequest int=null,
  @nomRequest nvarchar(max)=null,
  @etatRequest nvarchar(250)=null,
  @typeMaint nvarchar(250)=null,
  @descMaint nvarchar(max)=null,
  @lieuMaint nvarchar(250)=null,
  @idTeam int=null,
  @idEquipement int=null,
  @progressType nvarchar(100)='nv',
  @positionOrdre int=0,
  @dateRequest datetime=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @idDossier int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert into Maint_R_Request(numRequest,nomRequest,etatRequest,typeMaint,descMaint,lieuMaint,idTeam,idEquipement,progressType,positionOrdre,dateRequest,idUser,idGroup,idDossier) 
						   values (@numRequest,@nomRequest,@etatRequest,@typeMaint,@descMaint,@lieuMaint,@idTeam,@idEquipement,@progressType,@positionOrdre,@dateRequest,@idUser,@idGroup,@idDossier)
		select * from Maint_R_Request where idRequest=@@IDENTITY
	end
	else
	begin
		update Maint_R_Request set numRequest=@numRequest,nomRequest=@nomRequest,etatRequest=@etatRequest,
		typeMaint=@typeMaint,descMaint=@descMaint,lieuMaint=@lieuMaint,idTeam=@idTeam,idEquipement=@idEquipement,progressType=@progressType,positionOrdre=@positionOrdre,dateRequest=@dateRequest where idRequest=@idRequest
		select * from Maint_R_Request where idRequest=@idRequest
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [Maint_R_RequestUpdateProgress](
@idRequest int,
@progressType nvarchar(200))
as begin
	update Maint_R_Request set progressType=@progressType where idRequest=@idRequest
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Maint_S_MemberInsert](
@idEmploye int=null,
@idFournisseur int=null,
@idTeam int=null)
as begin
insert into Maint_S_Member (idEmploye,idFournisseur,idTeam) values(@idEmploye,@idFournisseur,@idTeam)
select idMember from Maint_S_Member where idMember=@@IDENTITY
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Maint_S_TeamInsertUpdate](
  @idTeam int=null,
  @nomTeam nvarchar(500)=null,
  @typeTeam nvarchar(500)=null,
  @idUser nvarchar(450)=null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert into Maint_S_Team(nomTeam,typeTeam,idUser,idGroup) values (@nomTeam,@typeTeam,@idUser,@idGroup)
		select * from Maint_tableTeam where idTeam=@@IDENTITY
	end
	else
	begin
		update Maint_S_Team set nomTeam=@nomTeam,typeTeam=@typeTeam where idTeam=@idTeam
		select * from Maint_tableTeam where idTeam=@idTeam
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [p_CaissierInsertUpdate](
@idCaissier int=null,
@nameCaissier nvarchar(200)=null,
@userName nvarchar(200)=null,
@passCaissier nvarchar(100),
@adminCaissier bit=null,
@avoirCheck bit=null,
@prixCheck bit=null,
@remCheck bit=null,
@fermerCheck bit=null,
@archiveChecke bit=null,
@anulatinTicket bit=null,
@idGroup int=null,
@idUser nvarchar(450)=null,
@statment varchar(100)='insert'
)
as begin
if(@statment='insert')
		begin
			insert into p_Caissier(nameCaissier,passCaissier,adminCaissier,avoirCheck,prixCheck,remCheck,archiveChecke,fermerCheck,idUser,idGroup,anulatinTicket) 
			values (@nameCaissier,@passCaissier,@adminCaissier,@avoirCheck,@prixCheck,@remCheck,@archiveChecke,@fermerCheck,@idUser,@idGroup,@anulatinTicket)
			select * from p_Caissier where idCaissier=@@IDENTITY
		end
	else
	begin
		update p_Caissier set nameCaissier=@nameCaissier,passCaissier=@passCaissier,avoirCheck=@avoirCheck,prixCheck=@prixCheck
		,remCheck=@remCheck,archiveChecke=@archiveChecke,fermerCheck=@fermerCheck,anulatinTicket=@anulatinTicket
		where idCaissier=@idCaissier
		select * from p_Caissier where idCaissier=@idCaissier
	end	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [p_insertLigneTicket]
(
	@idTicket int,
	@idproduct int,
	@note nvarchar(max),
	@name nvarchar(max),
	@price money,
	@umvente varchar(20),
	@qte int,
	@rem float,
	@total money,
	@checkVenduGrand bit 
)
as
begin
	insert into p_Ticket_ligne (idproduct,price,qte,rem,total,umvente,checkVenduGrand,idTicket)
	values(@idproduct,@price,@qte,@rem,@total,@umvente,@checkVenduGrand,@idTicket)
	select * from p_tableTicketLigne where idLigne=@@IDENTITY
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [p_insertTicket](
	@idDossier int,
	@idGroup int,
	@total money,
	@idSession int,
	@idCaissier int
)
as
begin
	declare @numTicket int=0
	select @numTicket = isnull(numFacture ,0) + 1 from e_TypeDoc where codeType='POS' and idDossier=@idDossier
	update e_TypeDoc set numFacture=@numTicket  where codeType='POS' and idDossier=@idDossier
	insert into p_Ticket(numTicket,total,idCaissier,idSession) values(@numTicket,@total,@idCaissier,@idSession)
	select * from p_tableTicket where idTicket=@@IDENTITY
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [p_PosInsertUpdate](
@idPos int=null,
@tokenPos nvarchar(max)=null,
@namePos nvarchar(200)=null,
@titrePos nvarchar(200)=null,
@souTitrePos nvarchar(500)=null,
@checkEmail bit=0,
@emailSend nvarchar(200)=null,
@checkOpenSession bit=0,
@idTreso int,
@idDepot int,
@clientDivers int,
@idDossier int,
@idGroup int=null,
@idUser nvarchar(450)=null,
@statment varchar(100)='insert')
as begin
	if(@statment='insert')
	begin
		INSERT INTO p_Pos
           ([tokenPos]
           ,[namePos]
           ,[titrePos]
           ,[souTitrePos]
           ,[checkEmail]
           ,[emailSend]
           ,[checkOpenSession]
           ,[idTreso]
           ,[idDepot]
           ,[clientDivers]
           ,[idDossier]
           ,[idGroup]
           ,[idUser])
     VALUES
           (@tokenPos
           ,@namePos
           ,@titrePos
           ,@souTitrePos
           ,@checkEmail
           ,@emailSend
           ,@checkOpenSession
           ,@idTreso
           ,@idDepot
           ,@clientDivers
           ,@idDossier
           ,@idGroup
           ,@idUser)
           select * from p_tablePos where idPos=@@IDENTITY
	end
	else
	begin
		UPDATE p_Pos
		   SET [tokenPos] = @tokenPos
			  ,[namePos] = @namePos
			  ,[titrePos] = @titrePos
			  ,[souTitrePos] = @souTitrePos
			  ,[checkEmail] = @checkEmail
			  ,[emailSend] = @emailSend
			  ,[checkOpenSession] = @checkOpenSession
			  ,[idTreso] = @idTreso
			  ,[idDepot] = @idDepot
			  ,[clientDivers] = @clientDivers
			  ,[idDossier] = @idDossier
		 WHERE idPos=@idPos
	select * from p_tablePos where idPos=@idPos
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [p_SessionInsert]
(@idPos int,@idCaissier int,@solde money)
as
begin
	insert into p_Session (idPos,caissierOpen,dateOpen,soldeOpen)
	values (@idPos,@idCaissier,GETDATE(),@solde)
	select * from p_Session where idSession=(select max(idSession) from p_Session)
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [p_SessionInserUpdate](
@idSession int=-1,
@idPos int=-1,
@caissierOpen int=-1,
@soldeOpen money=0,
@caissierClose int=-1,
@soldeClose money=0,
@closed bit=0,
@totalCaissier money=0,
@statment varchar(100)='insert')
as begin
	if(@statment='insert')
		begin
			insert into p_Session(dateOpen,caissierOpen,soldeOpen,idPos,Closed) values(GETDATE(),@caissierOpen,@soldeOpen,@idPos,0)
			select * from p_Session where idSession = @@IDENTITY
		end
	else
	begin
		update P_Session set caissierClose=@caissierClose,soldeClose=@soldeClose,dateClose=GETDATE(),Closed=1 where idSession=@idSession 
	end	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [p_Ticket_RegInsert](
@idTicket int,
@idModRglm int,
@mantant money
)
as
begin
	insert into p_Ticket_Reg(idTicket,idModRglm,mantant)
	values(@idTicket,@idModRglm,@mantant)
	select * from p_Ticket_Reg where idPaiment=@@IDENTITY
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_C_CotisationsInsertUpdate](
@idCotisation int=0,
@codeCotis int=0,
@libelleCotis nvarchar(500)=null,
@partSalariel float=0,
@prestationSoc float=0,
@allFamilial float=0,
@formationProf float=0,
@plafond float=0,
@cotisationPatr float=0,
@tauxPenalite float=0,
@tauxMajoration1 float=0,
@tauxMajorationAutres float=0,
@typeCoti nvarchar(100)='Standard',
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_C_Cotisations
		(codeCotis,libelleCotis,partSalariel,prestationSoc,allFamilial,formationProf,plafond,cotisationPatr,tauxPenalite,tauxMajoration1,tauxMajorationAutres,typeCoti,idUser,idGroup) 
		 values 
		(@codeCotis,@libelleCotis,@partSalariel,@prestationSoc,@allFamilial,@formationProf,@plafond,@cotisationPatr,@tauxPenalite,@tauxMajoration1,@tauxMajorationAutres,@typeCoti,@idUser,@idGroup)
		select * from Paie_C_Cotisations where idCotisation=@@IDENTITY
	end	
	else
	begin
		update Paie_C_Cotisations set 
		 codeCotis=@codeCotis
		,libelleCotis=@libelleCotis
		,partSalariel=@partSalariel
		,prestationSoc=@prestationSoc
		,allFamilial=@allFamilial
		,formationProf=@formationProf
		,plafond=@plafond
		,cotisationPatr=@cotisationPatr
		,tauxPenalite=@tauxPenalite
		,tauxMajoration1=@tauxMajoration1
		,tauxMajorationAutres=@tauxMajorationAutres
		where idCotisation=@idCotisation
		select * from Paie_C_Cotisations where idCotisation=@idCotisation
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_C_RubriquesInsertUpdate](
@idRubrique int=0,
@codeRubrique int=0,
@libelleRubrique nvarchar(500)=null,
@codeExo nvarchar(max)=null,
@imposable bit=0,
@positive bit=0,
@valeur float=0,
@taux float=0,
@tauxPenalite float=0,
@tauxMajoration1 float=0,
@tauxMajorationAutres float=0,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_C_Rubriques
		(codeRubrique,libelleRubrique,codeExo,imposable,positive,valeur,taux,tauxPenalite,tauxMajoration1,tauxMajorationAutres,idUser,idGroup) 
		 values 
		(@codeRubrique,@libelleRubrique,@codeExo,@imposable,@positive,@valeur,@taux,@tauxPenalite,@tauxMajoration1,@tauxMajorationAutres,@idUser,@idGroup)
		select * from Paie_C_Rubriques where idRubrique=@@IDENTITY
	end	
	else
	begin
		update Paie_C_Rubriques set 
		 codeRubrique=@codeRubrique
		,libelleRubrique=@libelleRubrique
		,codeExo=@codeExo
		,imposable=@imposable
		,positive=@positive
		,valeur=@valeur
		,taux=@taux
		,tauxPenalite=@tauxPenalite
		,tauxMajoration1=@tauxMajoration1
		,tauxMajorationAutres=@tauxMajorationAutres
		where idRubrique=@idRubrique
		select * from Paie_C_Rubriques where idRubrique=@idRubrique
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_C_VariablesInsertUpdate](
@idVariable nvarchar(100)=null,
@codeVar int=null,
@libelleVar nvarchar(500)=null,
@valeurVar money=0,
@propreSal bit=0,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_C_Variables(codeVar,libelleVar,valeurVar,propreSal,idUser,idGroup) values (@codeVar,@libelleVar,@valeurVar,@propreSal,@idUser,@idGroup)
		select * from Paie_C_Variables where idVariable=@@IDENTITY
	end	
	else
	begin
		update Paie_C_Variables set 
		 codeVar=@codeVar
		,libelleVar=@libelleVar
		,valeurVar=@valeurVar
		,propreSal=@propreSal
		where idVariable=@idVariable
		select * from Paie_C_Variables where idVariable=@idVariable
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_AvanceInsertUpdate](
@idAvance int=null,
@idEmploye int=null,
@dateAvance datetime=null,
@montant money=0,
@idUser nvarchar(450)=null,
@idGroup int=null,
@cloturer bit=0,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_Calcul_Avance(idEmploye,dateAvance,montant,idUser,idGroup,cloturer) values (@idEmploye,@dateAvance,@montant,@idUser,@idGroup,@cloturer)
		select * from Paie_Calcul_tableAvance where idAvance=@@IDENTITY
	end	
	else
	begin
		update Paie_Calcul_Avance set 
		 idEmploye=@idEmploye
		,dateAvance=@dateAvance
		,montant=@montant
		,cloturer=@cloturer
		where idAvance=@idAvance
		select * from Paie_Calcul_tableAvance where idAvance=@idAvance
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_AvanceSelect](
		@idUser nvarchar(450),
		@SelectAll bit=null,
		@idGroup int=null,
		@dateD datetime,
		@dateE datetime
		)
		as begin
			select * from Paie_Calcul_tableAvance where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) and dateAvance between @dateD and @dateE
				
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_bulletin_insertUpdate](
@IdBulletin int=null ,
@numBulletin int=null,
@mois int=null,
@createdDate datetime=null,
@periodeD datetime=null,
@periodeF datetime=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@idDossier int=null,
@descPaie nvarchar(max)=null,
@cloturer bit=0,
@valider bit=0,
@satatment nvarchar(max)='insert')
as
begin
	if(@satatment='insert')
	begin
		insert into Paie_Calcul_bulletin(numBulletin ,mois ,createdDate ,periodeD ,periodeF ,idUser ,idGroup,idDossier,descPaie,cloturer, valider)
		values(@numBulletin ,@mois ,@createdDate ,@periodeD ,@periodeF ,@idUser ,@idGroup,@idDossier,@descPaie,@cloturer,@valider)
		select * from Paie_Calcul_bulletin where IdBulletin=@@IDENTITY
	end
	else
	begin
		update Paie_Calcul_bulletin
		set numBulletin=@numBulletin,mois=@mois,createdDate=@createdDate,periodeD=@periodeD,periodeF=@periodeF 
		,descPaie=@descPaie,cloturer=@cloturer,valider=@valider
		where IdBulletin=@IdBulletin
		select * from Paie_Calcul_bulletin where IdBulletin=@IdBulletin
	end
end 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_bulletin_select](
@idUser nvarchar(450)=null,
@idGroup int=null,
@dateStart datetime=null,
@dateEnd datetime=null)
as 
begin
select * from Paie_Calcul_bulletin where (idUser=@idUser or idGroup=@idGroup) and createdDate between @dateStart and @dateEnd
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_bulletinLigne_insertUpdate](
@IdBulletinLigne int =null,
@IdBulletin int=null,
@idEmploye int=null,
@SalaireBase float=0,
@totalPrixSupp float=0,
@nbHeurSup int=0,
@totalKgs float=0,
@totalPrixKgs float=0,
@salaireTotal float=0,
@nbJours int=0,
@nbconge int=0,
@nombreHeurs int=0,
@statement nvarchar(max)='insert'
)
as
begin
	if(@statement='insert')
	begin
		if not exists (select * FROM Paie_Calcul_bulletin_ligne WHERE idEmploye = @idEmploye and IdBulletin=@IdBulletin )
		begin
			insert into Paie_Calcul_bulletin_ligne(IdBulletin ,idEmploye ,SalaireBase ,totalPrixSupp ,nbHeurSup ,totalKgs ,totalPrixKgs ,salaireTotal ,nbJours,nbconge,nombreHeurs )
			values(@IdBulletin ,@idEmploye ,@SalaireBase ,@totalPrixSupp ,@nbHeurSup ,@totalKgs ,@totalPrixKgs ,@salaireTotal ,@nbJours,@nbconge,@nombreHeurs )
			select * from Paie_Calcul_bulletin_ligne where IdBulletinLigne=@@IDENTITY
		end
	end
	else if(@statement='updateAll')
	begin
		update Paie_Calcul_bulletin_ligne
		set SalaireBase=@SalaireBase,totalPrixSupp=@totalPrixSupp,nbHeurSup=@nbHeurSup,totalKgs=@totalKgs,
		totalPrixKgs=@totalPrixKgs ,salaireTotal=@totalPrixKgs ,nbJours =@nbJours,nbconge=@nbconge,nombreHeurs=@nombreHeurs where IdBulletin=@IdBulletin
		select * from Paie_Calcul_bulletin_ligne where IdBulletin=@IdBulletin
	end
	else
	begin
		update Paie_Calcul_bulletin_ligne
		set SalaireBase=@SalaireBase,totalPrixSupp=@totalPrixSupp,nbHeurSup=@nbHeurSup,totalKgs=@totalKgs,
		totalPrixKgs=@totalPrixKgs ,salaireTotal=@totalPrixKgs ,nbJours =@nbJours,nbconge=@nbconge,nombreHeurs=@nombreHeurs where IdBulletinLigne=@IdBulletinLigne
		select * from Paie_Calcul_bulletin_ligne where IdBulletinLigne=@IdBulletinLigne
	end
end 


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_CalcHTravail](
@idGroup int=null,
@idUser nvarchar(450)=null,
@SelectAll bit=0,
@dateD datetime,
@dateE datetime,
@idEmploye int
)
as begin
declare @DaysPresences float,@typeSalarie nvarchar(max),@checkPointage bit;
select @typeSalarie=typeSalarie,@checkPointage=checkPointage from Paie_E_Employe where idEmploye=@idEmploye
if((@typeSalarie='Fixe')and(@checkPointage=1))
begin
	select @DaysPresences = sum(case when ld.dateTimeRecord IS NULL then 0 else 1 end)
	from Paie_Z_UserDevice u
	inner join Paie_E_Employe e on e.idUserDevice = u.idUserDevice
	inner join Paie_Z_ZKTDevices z on z.idDevice = u.idDevice
	left join Paie_Z_LogData ld on ld.idUserDevice = u.idUserDevice
	where u.idUserDevice in (
		select idUserDevice
		from Paie_Z_LogData
	) 
	and cast(ld.dateTimeRecord as date) between @dateD and @dateE
	and u.idUserDevice IS NOT NULL 
	and e.idEmploye = @idEmploye
	select @DaysPresences as DaysPresences
end
else if ((@typeSalarie='Fixe')and(@checkPointage=0))
begin
	set @DaysPresences = 26;
	select @DaysPresences as DaysPresences;
end
else if((@typeSalarie='Horaire')and(@checkPointage=1))
begin
	CREATE TABLE #tempTable (
		id int,
		idEmploye int,
		idEntree int,
		idSortie int,
		timeEntree time,
		timeSortie time,
		dateTimeRecord datetime,
		duree time,
		idUser nvarchar(450),
		idGroup int,
		nameDevice nvarchar(250),
		matricule nvarchar(500),
		nomEmployee nvarchar(500),
	);
	INSERT INTO #tempTable
	EXEC Paie_Z_PointageSelect
		@idUser = @idUser,
		@SelectALL = @SelectAll,
		@idGroup = @idGroup,
		@dateD = @dateD,
		@dateE = @dateE

	SELECT @DaysPresences=SUM(DATEDIFF(HOUR, '0:00:00', duree)) 
	FROM #tempTable where idEmploye = @idEmploye; 

	DROP TABLE #tempTable;
	select @DaysPresences as DaysPresences
end
else if((@typeSalarie='Horaire')and(@checkPointage=0))
begin
	set @DaysPresences = 191;
	select @DaysPresences as DaysPresences;
end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_CloturerGrpEntete](
@idGrpEnt int)
as begin

IF OBJECT_ID(N'tempdb..#TEMPORY_TABLE_EMP') IS NOT NULL
BEGIN
DROP TABLE #TEMPORY_TABLE_EMP
END

SELECT idEmploye 
INTO #TEMPORY_TABLE_EMP
FROM Paie_Calcul_Entete where idGrpEnt=@idGrpEnt
while ( SELECT count(idEmploye) FROM #TEMPORY_TABLE_EMP) >0
begin
	declare @idEmploye int;
	select top 1 @idEmploye=idEmploye from #TEMPORY_TABLE_EMP
	update Paie_E_Conges set jCongeN+=1.5, jRestes+=1.5 where idEmploye=@idEmploye
	delete from #TEMPORY_TABLE_EMP where idEmploye=@idEmploye
end	
DROP TABLE #TEMPORY_TABLE_EMP
update Paie_Calcul_GrpEntete set cloturer=1 where idGrpEnt=@idGrpEnt
select * from Paie_Calcul_GrpEntete where idGrpEnt=@idGrpEnt
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_CongesInsertUpdate](
@idCng int=null,
@idEmploye int=null,
@periodeDebut datetime=null,
@periodeFin datetime=null,
@idGroup int=null,
@idUser nvarchar(450)=null,
@idDossier int =null,
@nbJours int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_Calcul_Conges
		(idEmploye,periodeDebut,periodeFin,idUser,idGroup,idDossier,nbJours) 
		 values 
		(@idEmploye,@periodeDebut,@periodeFin,@idUser,@idGroup,@idDossier,@nbJours)
		 select * from Paie_Calcul_tableConges where idCng=@@IDENTITY
	end	
	else
	begin
		update Paie_Calcul_Conges set 
		 idEmploye=@idEmploye
		,periodeDebut=@periodeDebut
		,periodeFin=@periodeFin
		,nbJours=@nbJours
		where idCng=@idCng
		select * from Paie_Calcul_tableConges where idCng=@idCng
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_CongesSelect](
@idUser nvarchar(450)=null,
@SelectALL bit=null,
@idGroup int=null,
@dateD datetime=null,
@dateE datetime=null
)
as begin
	select * from Paie_Calcul_tableConges where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup))
										and (periodeDebut between @dateD and @dateE) or (periodeFin between @dateE and @dateE)
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_DecompteSalaireEmp]
(@periodeDe datetime=null,@periodeFi datetime=null,@idModRglm int=null,@total money=0,@statement nvarchar(150))
as
begin
	if(@statement='parTotal')
	begin
		--SELECT
		--  em.nomEmployee,
		--  l.gains AS salary,em.idModRglm,
		--  FLOOR(@total / 200) AS Dec200,
		--  FLOOR((@total % 200) / 100) AS Dec100,
		--  FLOOR(((@total % 200) % 100) / 50) AS Dec50,
		--  FLOOR((((@total % 200) % 100) % 50) / 20) AS Dec20,
		--  FLOOR(((((@total % 200) % 100) % 50) % 20) / 10) AS Dec10,
		--  FLOOR((((((@total % 200) % 100) % 50) % 20) % 10) / 5) AS Dec5,
		--  FLOOR(((((((@total % 200) % 100) % 50) % 20) % 10) % 5) / 1) AS Dec1,
		--  FLOOR(((((((@total % 200) % 100) % 50) % 20) % 10) % 5 % 1) / 0.50) AS Dec050,
		--  FLOOR(((((((@total % 200) % 100) % 50) % 20) % 10) % 5 % 1 % 0.50) / 0.20) AS Dec020
		--FROM
		--  Paie_Calcul_LigneRubrique l
		--  INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
		--  INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
		--  INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
		--  INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
		--WHERE
		--  codeRubrique = 15
		--  AND periodeD = @periodeDe
		--  AND periodeF = @periodeFi
		--  AND em.idModRglm=@idModRglm
		--GROUP BY
		--  em.nomEmployee, l.gains, m.nomModRglm,em.idModRglm;
		select SalaireNet,Monetaire,decompte,valeur,nomModRglm,idModRglm,periodeD,periodeF from(
			SELECT
				sum(@total) AS SalaireNet,
				200 AS Monetaire,
				FLOOR(sum(@total) / 200) AS Decompte,
				FLOOR(sum(@total) / 200) * 200 AS Valeur,
				m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			  group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF
			  
			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				100 AS Monetaire,
				FLOOR((sum(@total) % 200) / 100) AS Decompte,
				FLOOR((sum(@total) % 200) / 100) * 100 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			 group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF
			 
			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				50 AS Monetaire,
				FLOOR(((sum(@total) % 200) % 100) / 50) AS Decompte,
				FLOOR(((sum(@total) % 200) % 100) / 50) * 50 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			 group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF
			 
			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				20 AS Monetaire,
				FLOOR((((sum(@total) % 200) % 100) % 50) / 20) AS Decompte,
				FLOOR((((sum(@total) % 200) % 100) % 50) / 20) * 20 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			  group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF
			  
			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				10 AS Monetaire,
				FLOOR(((((sum(@total) % 200) % 100) % 50) % 20) / 10) AS Decompte,
				FLOOR(((((sum(@total) % 200) % 100) % 50) % 20) / 10) * 10 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF

			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				5 AS Monetaire,
				FLOOR((((((sum(@total) % 200) % 100) % 50) % 20) % 10) / 5) AS Decompte,
				FLOOR((((((sum(@total) % 200) % 100) % 50) % 20) % 10) / 5) * 5 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF

			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				1 AS Monetaire,
				FLOOR(((((((sum(@total) % 200) % 100) % 50) % 20) % 10) % 5) / 1) AS Decompte,
				FLOOR(((((((sum(@total) % 200) % 100) % 50) % 20) % 10) % 5) / 1) * 1 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF

			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				0.50 AS Monetaire,
				FLOOR(((((((sum(@total) % 200) % 100) % 50) % 20) % 10) % 5 % 1) / 0.5) AS Decompte,
				FLOOR(((((((sum(@total) % 200) % 100) % 50) % 20) % 10) % 5 % 1) / 0.5) * 1 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF

			UNION ALL

			SELECT
			sum(@total) AS SalaireNet,
				0.20 AS Monetaire,
				FLOOR(((((((sum(@total) % 200) % 100) % 50) % 20) % 10) % 5 % 1 % 0.5) / 0.2) AS Decompte,
				FLOOR(((((((sum(@total) % 200) % 100) % 50) % 20) % 10) % 5 % 1 % 0.5) / 0.2) * 1 AS Valeur,m.nomModRglm,em.idModRglm,g.periodeD,g.periodeF
			FROM Paie_Calcul_LigneRubrique l
			INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
			INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
			INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
			INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
			WHERE l.codeRubrique = 15
			group by nomModRglm,em.idModRglm,Valeur,g.periodeD,g.periodeF
			  ) as t
			  WHERE periodeD = '2023/01/01'
			  AND periodeF = '2023/01/31'
			  and idModRglm=@idModRglm
			  group by Monetaire,decompte,valeur,SalaireNet,periodeD,periodeF,nomModRglm,idModRglm
			  order by Monetaire desc
	end
	else
	begin
		select (em.nomEmployee+' '+em.prenomEmployee) as nomEmployee,l.idEntete,l.gains,m.nomModRglm,g.periodeD,g.periodeF, 
		FLOOR(l.gains / 200) AS Dec200,
		FLOOR((l.gains % 200) / 100) AS Dec100,
		FLOOR(((l.gains % 200) % 100) / 50) AS Dec50,
		FLOOR((((l.gains % 200) % 100) % 50) / 20) AS Dec20,
		FLOOR(((((l.gains % 200) % 100) % 50) % 20) / 10) AS Dec10,
		FLOOR((((((l.gains % 200) % 100) % 50) % 20) % 10) / 5) AS Dec5,
		FLOOR(((((((l.gains % 200) % 100) % 50) % 20) % 10) % 5) / 1) AS Dec1,
		FLOOR(((((((l.gains % 200) % 100) % 50) % 20) % 10) % 5 % 1) / 0.50) AS Dec050,
		FLOOR(((((((l.gains % 200) % 100) % 50) % 20) % 10) % 5 % 1 % 0.50) / 0.20) AS Dec020 
		from Paie_Calcul_LigneRubrique l
		inner join Paie_Calcul_Entete e on e.idEntete=l.idEntete
		inner join Paie_Calcul_GrpEntete g on g.idGrpEnt=e.idGrpEnt
		inner join Paie_E_Employe em on em.idEmploye=e.idEmploye
		inner join b_ModRglm m on m.idModRglm=em.idModRglm
		where codeRubrique=15 and periodeD=@periodeDe and periodeF=@periodeFi AND em.idModRglm=@idModRglm
		group by em.nomEmployee,em.prenomEmployee,l.idEntete,l.gains,m.nomModRglm,g.periodeD,g.periodeF
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_EnteteInsertUpdate](
@idEntete int=null,
@idEmploye int=null,
@idGrpEnt int=null,
@salaireBase money=0,
@totalBrut money=0,
@joursTravail float=null,
@hS0 float=null,
@hS25 float=null,
@hS50 float=null,
@hS100 float=null,
@periodeD datetime=null,
@periodeF datetime=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		if not exists (select * FROM Paie_Calcul_tableEntete WHERE idEmploye = @idEmploye and idGrpEnt=@idGrpEnt )
		begin
			if not exists (select * FROM Paie_Calcul_tableEntete e inner join Paie_Calcul_GrpEntete g on e.idGrpEnt=g.idGrpEnt 
			WHERE e.idEmploye = @idEmploye and g.periodeD=@periodeD and g.periodeF=@periodeF )
			begin
				insert Paie_Calcul_Entete(idEmploye,idGrpEnt,salaireBase,totalBrut,joursTravail,hS0,hS25,hS50,hS100) 
				values (@idEmploye,@idGrpEnt,@salaireBase,@totalBrut,@joursTravail,@hS0,@hS25,@hS50,@hS100)
				select @idEntete=idEntete from Paie_Calcul_tableEntete where idEntete=@@IDENTITY
				insert into Paie_Calcul_LigneRubrique(idEntete,idCotisation,codeRubrique,libelleRubrique,taux,typeRubrique)
				select @idEntete,idCotisation,codeCotis,libelleCotis,partSalariel,'Cotisation' from Paie_C_Cotisations where idEmploye=@idEmploye
				select * from Paie_Calcul_tableEntete where idEntete=@idEntete
			end
		end
	end	
	else
	begin
		update Paie_Calcul_Entete set 
		 idEmploye=@idEmploye
		,idGrpEnt=@idGrpEnt
		,salaireBase=@salaireBase
		,totalBrut=@totalBrut
		,joursTravail=@joursTravail
		,hS0=@hS0
		,hS25=@hS25
		,hS50=@hS50
		,hS100=@hS100
		where idEntete=@idEntete
		select * from Paie_Calcul_tableEntete where idEntete=@idEntete
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_calcul_EtatPointage_H1]
(@mois int=null,
@idDossier int=null,
@idUser nvarchar(450)=null,
@idGroup int=null)
as
begin 
SELECT 
    pe.idEmploye,
    pe.matricule,
    pe.nomEmployee,
    pe.typePaie,
    pe.PrixKgs,
    l.idPointageLigne,l.HeureEntree,l.HeureSortire,l.kgs,l.idPointage,l.heureSupp,
    p.createdDate,
    SUM(DATEDIFF(HOUR, l.HeureEntree, l.HeureSortire)) AS nombreHeures
FROM 
    Paie_P_POINTAGE_LIGNE l
INNER JOIN 
    Paie_P_POINTAGE p ON l.idPointage = p.idPointage
INNER JOIN 
    Paie_E_Employe pe ON l.idEmploye = pe.idEmploye
WHERE 
    (pe.typePaie='Par quantite && Heur' or pe.typePaie='Par heure') 
    AND MONTH(p.createdDate) = @mois
    AND p.idDossier = @idDossier
	AND (p.idUser=@idUser or p.idGroup=@idGroup)
GROUP BY 
    pe.idEmploye,
    pe.matricule,
    pe.nomEmployee,
    pe.typePaie,
    pe.PrixKgs,l.idPointageLigne,l.HeureEntree,l.HeureSortire,l.kgs,l.idPointage,l.heureSupp,
    p.createdDate,
    p.createdDate
ORDER BY 
    pe.nomEmployee;

end



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_calcul_EtatPointage_P1]
(@mois int=null,
@idDossier int=null,
@idUser nvarchar(450)=null,
@idGroup int=null)
as
begin 
DECLARE @infoConge TABLE (
    idEmploye INT,
    nbJoursConge INT
);
insert into @infoConge(idEmploye,nbJoursConge) select idEmploye,SUM(nbJours) as nbJours from Paie_Calcul_Conges where month(periodeDebut)= @mois group by idEmploye

SELECT 
    pe.idEmploye,
    pe.matricule,
    pe.nomEmployee,
    pe.typePaie,
    pe.PrixKgs,
    l.idPointageLigne,l.HeureEntree,l.HeureSortire,l.kgs,l.idPointage,l.heureSupp,
    p.createdDate,
    SUM(DATEDIFF(HOUR, l.HeureEntree, l.HeureSortire)) AS nombreHeures
	,c.nbJoursConge
FROM 
    Paie_P_POINTAGE_LIGNE l
INNER JOIN 
    Paie_P_POINTAGE p ON l.idPointage = p.idPointage
INNER JOIN 
    Paie_E_Employe pe ON l.idEmploye = pe.idEmploye
left JOIN
	@infoConge c on c.idEmploye=pe.idEmploye
WHERE 
    pe.typePaie = 'Mensuel' 
    AND MONTH(p.createdDate) = @mois
    AND p.idDossier = @idDossier
	AND (p.idUser=@idUser or p.idGroup=@idGroup)
	
GROUP BY 
    pe.idEmploye,
    pe.matricule,
    pe.nomEmployee,
    pe.typePaie,
    pe.PrixKgs,l.idPointageLigne,l.HeureEntree,l.HeureSortire,l.kgs,l.idPointage,l.heureSupp,
    p.createdDate,
    p.createdDate,c.nbJoursConge
ORDER BY 
    pe.nomEmployee;


end



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [paie_calcul_EtatPointage_Q1]
(@mois int=null,
@idDossier int=null,
@idUser nvarchar(450)=null,
@idGroup int=null)
as
begin 

select pe.idEmploye,pe.matricule,pe.nomEmployee,pe.typePaie,pe.PrixKgs,l.*,p.createdDate from Paie_P_POINTAGE_LIGNE l inner join Paie_P_POINTAGE p on l.idPointage=p.idPointage
inner join Paie_E_Employe pe on l.idEmploye=pe.idEmploye
where (pe.typePaie='Par quantite && Heur')  and month(p.createdDate)=@mois and P.idDossier=@idDossier and (p.idUser=@idUser or p.idGroup=@idGroup)


end






GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_GrpEnteteInsertUpdate](
@idGrpEnt int=null,
@numPaie int=null,
@datePaie datetime=null,
@valider bit=0,
@cloturer bit=0,
@mois int=null,
@periodeD datetime=null,
@periodeF datetime=null,
@idDossier int=null,
@descPaie nvarchar(max)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_Calcul_GrpEntete(numPaie,datePaie,valider,cloturer,mois,periodeD,periodeF,idDossier,idUser,idGroup,descPaie) 
		values (@numPaie,@datePaie,@valider,@cloturer,@mois,@periodeD,@periodeF,@idDossier,@idUser,@idGroup,@descPaie)
		select * from Paie_Calcul_GrpEntete where idGrpEnt=@@IDENTITY
	end	
	else
	begin
		update Paie_Calcul_GrpEntete set 
		 numPaie=@numPaie
		,datePaie=@datePaie
		,valider=@valider
		,cloturer=@cloturer
		,mois=@mois
		,periodeD=@periodeD
		,periodeF=@periodeF
		,descPaie=@descPaie
		where idGrpEnt=@idGrpEnt
		select * from Paie_Calcul_GrpEntete where idGrpEnt=@idGrpEnt
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_GrpEnteteSelect](
@idUser nvarchar(450),
@SelectALL bit=null,
@idGroup int=null,
@dateD datetime,
@dateE datetime
)
as
begin

	select * from Paie_Calcul_GrpEntete where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) 
	and datePaie between @dateD and @dateE
	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_LigneCalcul]
(@idEntete int)
as
begin

IF OBJECT_ID(N'tempdb..#TEMPORY_TABLE_EXO') IS NOT NULL
BEGIN
DROP TABLE #TEMPORY_TABLE_EXO
END

IF OBJECT_ID(N'tempdb..#TEMPORY_TABLE_IMPO') IS NOT NULL
BEGIN
DROP TABLE #TEMPORY_TABLE_IMPO
END

declare @periodeD datetime,@periodeF datetime,@idEmploye int
declare @salaireBase money,@hs0 money,@hs25 money,@hs50 money,@hs100 money,@hs0Calc money,@hs25Calc money,@hs50Calc money,@hs100Calc money,
@hs0Taux money,@hs25Taux money,@hs50Taux money,@hs100Taux money,@avance money,@dateContra datetime,@ans float,@PRIME money,@joursTravail int,
@salaireGain money,@PRIMEDANCIENNETE money,@Taux money,@idDossier int,@MonthConge int=0,@NombreJrConges int=0

declare @tableCalcul table(id int identity(1,1),code int ,Libelle nvarchar(200),Base money,Taux money,Gain money,Retenu money)

---select périodeDébut, périodeFin et idEmploye
select @periodeD=g.periodeD,@periodeF=g.periodeF,@idEmploye=e.idEmploye,@idDossier=g.idDossier,@MonthConge=month(g.datePaie) from Paie_Calcul_GrpEntete g 
inner join Paie_Calcul_Entete e on e.idGrpEnt=g.idGrpEnt where e.idEntete=@idEntete

--select dateContrat, nombre d'années travaillées
select @dateContra = CAST(dateContrat AS date), @ans = DATEDIFF(YYYY, @dateContra, GETDATE()) 
FROM Paie_E_Contrat e WHERE idEmploye = @idEmploye AND @periodeD BETWEEN dateContrat AND @periodeF

select @salaireBase=salaireBase from Paie_E_Employe where idEmploye=@idEmploye
update Paie_Calcul_Entete set salaireBase=@salaireBase where idEmploye=@idEmploye

---select salaireDeBase, Jours/Heures Travaillées et Heures Supplémentaires
select @salaireBase=salaireBase,@joursTravail=joursTravail,
@hs0=hS0,
@hs0Calc=(salaireBase/191)*hS0,
@hs25=hS25,
@hs25Calc=hS25*((salaireBase/191)*(1+0.25)),
@hs50=hS50,
@hs50Calc=hS50*((salaireBase/191)*(1+0.5)),
@hs100=hS100,
@hs100Calc=hS100*((salaireBase/191)*(2))
from Paie_Calcul_Entete where idEntete=@idEntete

select @salaireGain=(@salaireBase/26)*@joursTravail

insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(1,'Nombre de jours travaillés',@salaireBase,@joursTravail,@salaireGain,0)
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(2,'Heures supplémentaires 0%',@hs0,0,@hs0Calc,0)
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(3,'Heures supplémentaires 25%',@hs25,0,@hs25Calc,0)
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(4,'Heures supplémentaires 50%',@hs50,0,@hs50Calc,0)
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(5,'Heures supplémentaires 100%',@hs100,0,@hs100Calc,0)

--select Conges
select @NombreJrConges=isnull(SUM(nbJours),0)  from Paie_Calcul_Conges c 
  where c.idEmploye=@idEmploye and MONTH(c.periodeDebut)=@MonthConge and MONTH(c.periodeFin)=@MonthConge and idDossier=@idDossier
if @NombreJrConges<>0
begin
	insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(16,'Congés',@salaireBase,@NombreJrConges,(@salaireBase/26)*@NombreJrConges,0)
	select @salaireGain=@salaireGain+((@salaireBase/26)*@NombreJrConges)
end
	
--select Avance
select @avance=isnull(SUM(montant),0) from Paie_Calcul_Avance 
where dateAvance between @periodeD and @periodeF and idEmploye=@idEmploye

select @salaireGain=(@salaireGain+@hs25Calc+@hs0Calc+@hs50Calc+@hs100Calc)
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(6,'Avance',0,0,0,@avance)

--select Prime d'ancienneté
select @Taux=
case 
when @ans>25 then 0.25
when @ans>20 then 0.2
when @ans>12 then 0.15
when @ans>5 then 0.1
when @ans>2 then  0.05 
else 0
END;
if(@Taux<> 0)
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(7,'Prime D ancienneté',@salaireGain*@Taux,@Taux,@salaireGain*@Taux,0)

--select Rubriques - Exonérations, salaire Brut Global et salaire Imposable
declare @codeExo nvarchar(200),@tauxExo float,@valueExo float,@LibelleEXO nvarchar(200),@imposable bit,@salerImpo float=0,
@salaireBrutGlobal float,@TotalExo float=0,@TotalCotisation float=0,@Plafon money=0
 
SELECT
l.idLigne,r.codeExo,l.valeur,l.taux,l.libelleRubrique,r.imposable,l.codeRubrique 
INTO #TEMPORY_TABLE_EXO
FROM Paie_Calcul_LigneRubrique l
inner join Paie_C_Rubriques r on l.idRubrique=r.idRubrique
where idEntete=@idEntete and typeRubrique='Rubrique' order by r.imposable
select @salaireBrutGlobal=@salaireGain
declare @id int,@code nvarchar(100)
while ( SELECT COUNT(*) FROM #TEMPORY_TABLE_EXO) >0
begin

	select top 1 @id=idLigne,@codeExo=codeExo,@valueExo=valeur,@tauxExo=taux,@LibelleEXO=libelleRubrique,@imposable=imposable,@code=codeRubrique
	 from #TEMPORY_TABLE_EXO
	if @imposable=0
		select @TotalExo=@TotalExo+ dbo.Paie_C_RubriquesTotalExo(
	   @codeExo,@valueExo,@salaireBase,@joursTravail)

	select @salaireBrutGlobal=@salaireBrutGlobal+@valueExo
	insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(@code,@LibelleEXO,0,@valueExo,@valueExo,0)
	delete from #TEMPORY_TABLE_EXO where idLigne=@id
end
select @salerImpo=@salaireBrutGlobal-@TotalExo
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(8,'Salaire Brut Global',@salaireBrutGlobal,0,0,0)
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(9,'Salaire Imposable',@salerImpo,0,0,0)
drop table #TEMPORY_TABLE_EXO

SELECT
l.idLigne,l.taux,l.libelleRubrique,c.plafond,l.codeRubrique
INTO #TEMPORY_TABLE_IMPO
FROM Paie_Calcul_LigneRubrique l
inner join Paie_C_Cotisations c on l.idCotisation=c.idCotisation
where idEntete=@idEntete and typeRubrique='Cotisation' 
 
while ( SELECT COUNT(*) FROM #TEMPORY_TABLE_IMPO) >0
begin
	select top 1 @id=idLigne,@tauxExo=taux,@LibelleEXO=libelleRubrique,@Plafon=plafond,@code=codeRubrique from #TEMPORY_TABLE_IMPO
	if(@salerImpo>@Plafon)
		begin
			select @TotalCotisation=@TotalCotisation+(@Plafon*(@tauxExo/100))
			insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(@code,@LibelleEXO,@salerImpo,@tauxExo,0,@Plafon*(@tauxExo/100))
		end
	else
begin
	select @TotalCotisation=@TotalCotisation+(@salerImpo*(@tauxExo/100))
	insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(@code,@LibelleEXO,@salerImpo,@tauxExo,0,@salerImpo*(@tauxExo/100))
end

delete from #TEMPORY_TABLE_IMPO where idLigne=@id
end
 
drop table #TEMPORY_TABLE_IMPO

--select Frais Profesiionnels
declare @fraiProf float=0
if(@salerImpo<=6500)
begin
	select @fraiProf=@salerImpo*0.35
end
else
begin
	select @fraiProf=@salerImpo*0.25
	if (@fraiProf>2917)
		select @fraiProf=2917
end
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(10,'Frais Professionnels',@fraiProf,0,0,0)

--select Salaire Net Imposable
declare @SalaireNetImposable float=0,@irBrut float=0
select @SalaireNetImposable=@salerImpo-@TotalCotisation-@fraiProf

insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(11,'Salaire Net Imposable SNI',@SalaireNetImposable,0,0,0)

--select IR Brut
if(@SalaireNetImposable<2501)
begin
	select @irBrut=0
end
else
if(@SalaireNetImposable<4166.67)
begin
	select @irBrut=(@SalaireNetImposable*0.1)-250
end
else
if(@SalaireNetImposable<5001)
begin
	select @irBrut=(@SalaireNetImposable*0.2)-666.67
end
else
if(@SalaireNetImposable<6666.67)
begin
	select @irBrut=(@SalaireNetImposable*0.3)-1166.67
end
else
if(@SalaireNetImposable<15000)
begin
	select @irBrut=(@SalaireNetImposable*0.34)-1433.33
end
else
	select @irBrut=(@SalaireNetImposable*0.38)-2033.33


insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(12,'IR Brut',0,0,0,@irBrut)

--select Charge de Famille
declare @abattement int=0,@nbEnfants int=0, @totalCharge float=0,@irNet float=0
select @abattement=abattement,@nbEnfants=nbEnfants from Paie_E_Employe where idEmploye=@idEmploye
if(@abattement=1)
begin
	select @totalCharge=(1+@nbEnfants)*30
	if(@totalCharge>180)
	  select @totalCharge=180
	insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(13,'Charges De Famille',@totalCharge,0,0,0)  
end

--select IR Net
if(@irBrut>0)
	select @irNet=@irBrut-@totalCharge
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(14,'IR Net',@irNet,0,0,0)

--select Salaire Net à Payer
declare @totalPay float=0 	
select @totalPay =@salaireBrutGlobal-@TotalCotisation-@irBrut-@totalCharge-@avance
insert @tableCalcul (code,Libelle,Base,Taux,Gain,Retenu) values(15,'Salaire Net à Payer',0,0,@totalPay,0)
delete from Paie_Calcul_LigneRubrique where idEntete=@idEntete and typeRubrique='Calcul'
insert into Paie_Calcul_LigneRubrique(idEntete,codeRubrique,libelleRubrique,base,taux,gains,retenues,typeRubrique) 
select @idEntete,code,Libelle,Base,Taux,Gain,Retenu,'Calcul' from @tableCalcul


--select Calcul Impression Bulletin
--select * from Paie_Calcul_LigneRubrique where idEntete=@idEntete and typeRubrique='Calcul'
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_LigneRubriqueInsertUpdate](
@idLigne int=null,
@idEntete int=null,
@idRubrique int=null,
@idCotisation int=null,
@idPret int=null,
@codeRubrique int=null,
@libelleRubrique nvarchar(500)=null,
@base money=0,
@taux float=0,
@gains money=0,
@retenues money=0,
@typeRubrique nvarchar(max),
@valeur int=0,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
	if not exists (select * FROM Paie_Calcul_LigneRubrique WHERE idRubrique = @idRubrique and idEntete=@idEntete)
		begin
		insert Paie_Calcul_LigneRubrique(idEntete,idRubrique,idCotisation,idPret,codeRubrique,libelleRubrique,base,taux,gains,retenues,typeRubrique,valeur) 
		values (@idEntete,@idRubrique,@idCotisation,@idPret,@codeRubrique,@libelleRubrique,@base,@taux,@gains,@retenues,@typeRubrique,@valeur)
		select * from Paie_Calcul_LigneRubrique where idLigne=@@IDENTITY
		end
	end	
	else
	begin
		update Paie_Calcul_LigneRubrique set 
		 idEntete=@idEntete
		,idRubrique=@idRubrique
		,idCotisation=@idCotisation
		,idPret=@idPret
		,codeRubrique=@codeRubrique
		,libelleRubrique=@libelleRubrique
		,base=@base
		,taux=@taux
		,gains=@gains
		,retenues=@retenues
		,typeRubrique=@typeRubrique
		,valeur=@valeur
		where idLigne=@idLigne
		select * from Paie_Calcul_LigneRubrique where idLigne=@idLigne
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Calcul_TotalReglement]
(@periodeDe datetime=null,@periodeFi datetime=null,@idGroup int)
as
begin
SELECT SUM(l.gains) AS TotalSalaireNet, m.nomModRglm,em.idModRglm
FROM Paie_Calcul_LigneRubrique l
INNER JOIN Paie_Calcul_Entete e ON e.idEntete = l.idEntete
INNER JOIN Paie_Calcul_GrpEntete g ON g.idGrpEnt = e.idGrpEnt
INNER JOIN Paie_E_Employe em ON em.idEmploye = e.idEmploye
INNER JOIN b_ModRglm m ON m.idModRglm = em.idModRglm
WHERE l.codeRubrique = 15
  AND g.periodeD = @periodeDe
  AND g.periodeF = @periodeFi
  and g.idGroup=@idGroup
group by m.nomModRglm ,em.idModRglm
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_E_CongesInsertUpdate](
@idConge int=0,
@idEmploye int=null,
@annee int=null,
@numberMonths int=null,
@jConsommes float=null,
@jCongeN_1 float=null,
@jCongeN float=null,
@jRestes float=null,
@idDossier int=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_E_Conges(idEmploye,annee,numberMonths,jConsommes,jCongeN_1,jCongeN,jRestes,idDossier,idUser,idGroup) 
					  values (@idEmploye,@annee,@numberMonths,@jConsommes,@jCongeN_1,@jCongeN,@jRestes,@idDossier,@idUser,@idGroup)
		--select * from Paie_E_tableConges where idConge=@@IDENTITY
	end	
	else
	begin
		update Paie_E_Conges set 
		idEmploye=@idEmploye,
		annee=@annee,
		numberMonths=@numberMonths,
		jConsommes=@jConsommes,
		jCongeN_1=@jCongeN_1,
		jCongeN=@jCongeN,
		jRestes=@jRestes
		where idConge=@idConge
		select * from Paie_E_tableConges where idConge=@idConge
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_E_ContratInsertUpdate](
@idContrat int=0,
@numContrat nvarchar(200)=null,
@dateContrat datetime =null,
@idProfil int=null,
@periodeD datetime=null,
@periodeF datetime=null,
@observationC nvarchar(max)=null,
@idEmploye int=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert paie_E_Contrat(numContrat,dateContrat,idProfil,periodeD,periodeF,observationC,idEmploye,idUser,idGroup) 
					  values (@numContrat,@dateContrat,@idProfil,@periodeD,@periodeF,@observationC,@idEmploye,@idUser,@idGroup)
		select * from Paie_E_tableContrat where idContrat=@@IDENTITY
	end	
	else
	begin
		update paie_E_Contrat set 
		numContrat=@numContrat,
		dateContrat=@dateContrat,
		idProfil=@idProfil,
		periodeD=@periodeD,
		periodeF=@periodeF,
		observationC=@observationC,
		idEmploye=@idEmploye
		where idContrat=@idContrat
		select * from Paie_E_tableContrat where idContrat=@idContrat
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_E_CotisationsEmployeInsert](
@idEmploye int,
@idCotisation int,
@codeCotis int)
as begin
	if not exists (select * FROM Paie_C_Cotisations WHERE idEmploye = @idEmploye and codeCotis=@codeCotis)
		begin
			insert into Paie_C_Cotisations(codeCotis,
			libelleCotis,
			partSalariel,
			prestationSoc,
			allFamilial,
			formationProf,
			plafond,
			cotisationPatr,
			tauxPenalite,tauxMajoration1,
			tauxMajorationAutres,typeCoti,idUser,idGroup,idEmploye)
			select codeCotis,
			libelleCotis,
			partSalariel,
			prestationSoc,
			allFamilial,
			formationProf,
			plafond,
			cotisationPatr,
			tauxPenalite,tauxMajoration1,
			tauxMajorationAutres,'Employe',idUser,idGroup,@idEmploye from Paie_C_Cotisations where idCotisation=@idCotisation
	
			select * from Paie_C_Cotisations where idCotisation=@@IDENTITY
		end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_E_EmployeInsertUpdate](
	    @idEmploye int =null
       ,@nomEmployee nvarchar(500) =null
       ,@prenomEmployee nvarchar(500) =null
       ,@matricule nvarchar(500) =null
       ,@titre nvarchar(max)=null
       ,@cinEmployee nvarchar(20)=null
       ,@nationalite nvarchar(max)=null
       ,@dateNaissance datetime=null
       ,@sitFamiliale nvarchar(500)=null
       ,@nbEnfants int=0
       ,@lieuNaissance nvarchar(150)=null
       ,@abattement int=0
       ,@email nvarchar(200)=null
       ,@genre nvarchar(200)=null
       ,@adresse nvarchar(500)=null
       ,@idVille int=null
       ,@observation nvarchar(max)=null
       ,@photo nvarchar(max)=null
       ,@idUser nvarchar(450)=null
       ,@idGroup int=null
       ,@idNiveau int=null
       ,@idCategorie int=null
       ,@idDepartement int=null
       ,@idFonction int=null
       ,@empCadre  nvarchar(200)=null
       ,@dateEntree datetime= NULL
	   ,@dateSortie datetime= NULL
	   ,@checkSortie bit= 0
	   ,@typePaie nvarchar(200)= NULL
	   ,@typeSalarie nvarchar(200)= NULL
	   ,@idModRglm int= NULL
	   ,@salaireBase money =0
	   ,@numCarte nvarchar(50)=NULL
	   ,@checkPointage bit= 0
	   ,@salaireFix bit= 0
	   ,@banque nvarchar(200)=NULL
	   ,@numCompte nvarchar(200)=NULL
	   ,@recharge nvarchar(200)= NULL
	   ,@traiteAssurVie nvarchar(200)= NULL
	   ,@dateAssurVie datetime=NULL
	   ,@plafondAssurVie float=0
	   ,@traiteAssurRetraite nvarchar(200)= NULL
	   ,@dateAssurRetraite datetime=NULL
	   ,@plafondAssurRetraite float=0
	   ,@idUserDevice int=null
	   ,@idPlanning int=null
	   ,@telephone nvarchar(30)=null
	   ,@busStation nvarchar(250)=null
	   ,@numDeclareEmp nvarchar(200)=null
	   ,@annee int=null,
	   @PrixHeurSup float=null
	   ,@idDossier int=null,
	   @PrixKgs float=null,@PrixParHeur float=null
       ,@statement varchar(100)='insert')
      as begin
		if(@statement='insert')
		begin
			INSERT INTO Paie_E_Employe
           ([nomEmployee]
           ,[prenomEmployee]
           ,[matricule]
           ,[titre]
           ,[cinEmployee]
           ,[nationalite]
           ,[dateNaissance]
           ,[sitFamiliale]
           ,[nbEnfants]
           ,[lieuNaissance]
           ,[abattement]
           ,[email]
           ,[genre]
           ,[adresse]
           ,[idVille]
           ,[observation]
           ,[photo]
           ,[idUser]
           ,[idGroup]
           ,[idNiveau]
           ,[idCategorie]
           ,[idDepartement]
           ,[idFonction]
           ,[empCadre]
           ,[dateEntree]
           ,[dateSortie]
           ,[checkSortie]
           ,[typePaie]
           ,[typeSalarie]
           ,[idModRglm]
           ,[salaireBase]
           ,[numCarte]
           ,[checkPointage]
           ,[salaireFix]
           ,[banque]
           ,[numCompte]
           ,[recharge]
           ,[traiteAssurVie]
           ,[dateAssurVie]
           ,[plafondAssurVie]
           ,[traiteAssurRetraite]
           ,[dateAssurRetraite]
           ,[plafondAssurRetraite]
           ,[idUserDevice]
           ,[idPlanning]
           ,[telephone]
           ,[busStation]
           ,[numDeclareEmp]
		   ,PrixKgs,
		   PrixHeurSup,PrixParHeur
           )
     VALUES
           (@nomEmployee
           ,@prenomEmployee
           ,@matricule
           ,@titre
           ,@cinEmployee
           ,@nationalite
           ,@dateNaissance
           ,@sitFamiliale
           ,@nbEnfants
           ,@lieuNaissance
           ,@abattement
           ,@email
           ,@genre
           ,@adresse
           ,@idVille
           ,@observation
           ,@photo
           ,@idUser
           ,@idGroup
           ,@idNiveau
           ,@idCategorie
           ,@idDepartement
           ,@idFonction
           ,@empCadre
           ,@dateEntree
           ,@dateSortie
           ,@checkSortie
           ,@typePaie
           ,@typeSalarie
           ,@idModRglm 
           ,@salaireBase
           ,@numCarte
           ,@checkPointage
           ,@salaireFix
           ,@banque
           ,@numCompte
           ,@recharge
           ,@traiteAssurVie
           ,@dateAssurVie
           ,@plafondAssurVie
           ,@traiteAssurRetraite
           ,@dateAssurRetraite
           ,@plafondAssurRetraite
           ,@idUserDevice
           ,@idPlanning
           ,@telephone
           ,@busStation
           ,@numDeclareEmp 
		   ,@PrixKgs
		   ,@PrixHeurSup,@PrixParHeur
           )
           select @idEmploye=idEmploye from Paie_E_tableEmploye where idEmploye=@@IDENTITY
           EXEC dbo.Paie_E_CongesInsertUpdate 0,@idEmploye,@annee,null,0,0,0,0,@idDossier,@idUser,@idGroup,'insert';
           select * from Paie_E_tableEmploye where idEmploye=@idEmploye
		end
		else
		begin
			UPDATE Paie_E_Employe
			   SET [nomEmployee] = @nomEmployee
				  ,[prenomEmployee] = @prenomEmployee
				  ,[matricule] = @matricule
				  ,[titre] = @titre
				  ,[cinEmployee] = @cinEmployee
				  ,[nationalite] = @nationalite
				  ,[dateNaissance] = @dateNaissance
				  ,[sitFamiliale] = @sitFamiliale
				  ,[nbEnfants] = @nbEnfants
				  ,[lieuNaissance] = @lieuNaissance
				  ,[abattement] = @abattement
				  ,[email] = @email
				  ,[genre] = @genre
				  ,[adresse] = @adresse
				  ,[idVille] = @idVille
				  ,[observation] = @observation
				  ,[photo]=@photo
				  ,[idNiveau]=@idNiveau
				  ,[idCategorie]=@idCategorie
				  ,[idDepartement]=@idDepartement
				  ,[idFonction]=@idFonction
				  ,[empCadre]=@empCadre
				  ,[dateEntree]=@dateEntree
				  ,[dateSortie]=@dateSortie
				  ,[checkSortie]=@checkSortie
				  ,[typePaie]=@typePaie
				  ,[typeSalarie]=@typeSalarie
				  ,[idModRglm]=@idModRglm
				  ,[salaireBase]=@salaireBase
				  ,[numCarte]=@numCarte
				  ,[checkPointage]=@checkPointage
				  ,[salaireFix]=@salaireFix
				  ,[banque]=@banque
				  ,[numCompte]=@numCompte
				  ,[recharge]=@recharge
				  ,[traiteAssurVie]=@traiteAssurVie
				  ,[dateAssurVie]=@dateAssurVie
				  ,[plafondAssurVie]=@plafondAssurVie
				  ,[traiteAssurRetraite]=@traiteAssurRetraite
				  ,[dateAssurRetraite]=@dateAssurRetraite
				  ,[plafondAssurRetraite]=@plafondAssurRetraite
				  ,[idUserDevice]=@idUserDevice
				  ,[idPlanning]=@idPlanning
				  ,[telephone]=@telephone
				  ,[busStation]=@busStation
				  ,[numDeclareEmp]=@numDeclareEmp
				  ,PrixKgs=@PrixKgs
				  ,PrixHeurSup=@PrixHeurSup
				  ,PrixParHeur=@PrixParHeur
			 WHERE idEmploye=@idEmploye
			 select * from Paie_E_tableEmploye where idEmploye=@idEmploye
		end
      end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [Paie_E_PretsInsertUpdate](
@idPret int=0,
@idEmploye int=null,
@reliquant money=0,
@montantTotal money=0,
@nbEcheance int=0,
@montantEcheance money=0,
@montantDernierEcheance money=0,
@dateEcheanceD datetime=null,
@dateEcheanceF datetime=null,
@codeRubrique nvarchar(50)=null,
@observation nvarchar(max)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_E_Prets(idEmploye,reliquant,montantTotal,nbEcheance,montantEcheance,montantDernierEcheance,dateEcheanceD,
							dateEcheanceF,codeRubrique,observation,idUser,idGroup) 
					values (@idEmploye,@reliquant,@montantTotal,@nbEcheance,@montantEcheance,@montantDernierEcheance,@dateEcheanceD,
							@dateEcheanceF,@codeRubrique,@observation,@idUser,@idGroup)
		select * from Paie_E_tablePrets where idPret=@@IDENTITY
	end	
	else
	begin
		update Paie_E_Prets set 
		idEmploye=@idEmploye,
		reliquant=@reliquant,
		montantTotal=@montantTotal,
		nbEcheance=@nbEcheance,
		montantEcheance=@montantEcheance,
		montantDernierEcheance=@montantDernierEcheance,
		dateEcheanceD=@dateEcheanceD,
		dateEcheanceF=@dateEcheanceF,
		codeRubrique=@codeRubrique,
		observation=@observation
		where idPret=@idPret
		select * from Paie_E_tablePrets where idPret=@idPret
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_I_CategorieInsertUpdate](
@idCategorie int=0,
@nomCategorie nvarchar(500)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert paie_I_Categorie(nomCategorie,idUser,idGroup) values (@nomCategorie,@idUser,@idGroup)
		select * from paie_I_Categorie where idCategorie=@@IDENTITY
	end	
	else
	begin
		update paie_I_Categorie set nomCategorie=@nomCategorie where idCategorie=@idCategorie
		select * from paie_I_Categorie where idCategorie=@idCategorie
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_I_DepartementInsertUpdate](
@idDepartement int=0,
@nomDepartement nvarchar(500)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert paie_I_Departement(nomDepartement,idUser,idGroup) values (@nomDepartement,@idUser,@idGroup)
		select * from paie_I_Departement where idDepartement=@@IDENTITY
	end	
	else
	begin
		update paie_I_Departement set nomDepartement=@nomDepartement where idDepartement=@idDepartement
		select * from paie_I_Departement where idDepartement=@idDepartement
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_I_FonctionInsertUpdate](
@idFonction int=0,
@nomFonction nvarchar(500)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert paie_I_Fonction(nomFonction,idUser,idGroup) values (@nomFonction,@idUser,@idGroup)
		select * from paie_I_Fonction where idFonction=@@IDENTITY
	end	
	else
	begin
		update paie_I_Fonction set nomFonction=@nomFonction where idFonction=@idFonction
		select * from paie_I_Fonction where idFonction=@idFonction
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_I_NiveauInsertUpdate](
@idNiveau int=0,
@nomNiveau nvarchar(500)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert paie_I_Niveau(nomNiveau,idUser,idGroup) values (@nomNiveau,@idUser,@idGroup)
		select * from paie_I_Niveau where idNiveau=@@IDENTITY
	end	
	else
	begin
		update paie_I_Niveau set nomNiveau=@nomNiveau where idNiveau=@idNiveau
		select * from paie_I_Niveau where idNiveau=@idNiveau
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [paie_I_ProfilContratInsertUpdate](
@idProfil int=0,
@nomProfil nvarchar(500)=null,
@partSalariel bit=0,
@allFamiliel bit=0,
@formationProf bit=0,
@cotisationPatr bit=0,
@iR bit=0,
@plafondIR float=0,
@typeProfil nvarchar(500)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert paie_I_ProfilContrat(nomProfil,partSalariel,allFamiliel,formationProf,cotisationPatr,iR,plafondIR,typeProfil,idUser,idGroup) 
						  values (@nomProfil,@partSalariel,@allFamiliel,@formationProf,@cotisationPatr,@iR,@plafondIR,@typeProfil,@idUser,@idGroup)
		select * from paie_I_ProfilContrat where idProfil=@@IDENTITY
	end	
	else
	begin
		update paie_I_ProfilContrat set 
		 nomProfil=@nomProfil
		,partSalariel=@partSalariel
		,allFamiliel=@allFamiliel
		,formationProf=@formationProf
		,cotisationPatr=@cotisationPatr
		,iR=@iR
		,plafondIR=@plafondIR
		,typeProfil=@typeProfil
		where idProfil=@idProfil
		select * from paie_I_ProfilContrat where idProfil=@idProfil
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_I_TauxFraisProfInsertUpdate](
@idTaux int=0,
@codeTaux nvarchar(500)=null,
@libelleTaux nvarchar(500)=null,
@taux float=0,
@plafond float=0,
@refTaux nvarchar(500)=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert paie_I_TauxFraisProf(codeTaux,libelleTaux,taux,plafond,refTaux,idUser,idGroup) values (@codeTaux,@libelleTaux,@taux,@plafond,@refTaux,@idUser,@idGroup)
		select * from paie_I_TauxFraisProf where idTaux=@@IDENTITY
	end	
	else
	begin
		update paie_I_TauxFraisProf set 
		 codeTaux=@codeTaux
		,libelleTaux=@libelleTaux
		,taux=@taux
		,plafond=@plafond
		,refTaux=@refTaux
		where idTaux=@idTaux
		select * from paie_I_TauxFraisProf where idTaux=@idTaux
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [paie_p_CalculEmpSalaire](
@idEmploye int ,
@annee int ,
@mois int 
)
as
begin

--DECLARE @idEmploye AS INT = 3;
--DECLARE @annee AS INT = 2024;
--DECLARE @mois AS INT = 6;
DECLARE @kgs AS float;
DECLARE @PrixKgs AS float;
DECLARE @salaireBase AS float;
DECLARE @typePaie AS NVARCHAR(MAX);
declare @heureSupp as float;
DECLARE @nombreHeurs int;
DECLARE @nombrJour int;
declare @salaireFinal float;
declare @prixJours as float;
declare @prixHeur as float;
-- Declare a temporary table
DECLARE @infoEmp TABLE (
    idEmploye INT,
    nomEmployee NVARCHAR(MAX),
    prenomEmployee NVARCHAR(MAX),
    idPointage INT,
    createdDate DATE,
    HeureEntree TIME,
    HeureSortire TIME,
    kgs float,
    heureSupp float,
    PrixKgs float,
    salaireBase float,
    typePaie NVARCHAR(MAX),
    nombreHeurs TIME
);

-- Insert into the temporary table using your query
INSERT INTO @infoEmp (idEmploye,nomEmployee,prenomEmployee,idPointage,createdDate,HeureEntree,HeureSortire,kgs,heureSupp,PrixKgs,salaireBase,typePaie,nombreHeurs)
SELECT pe.idEmploye,pe.nomEmployee,pe.prenomEmployee,p.idPointage,p.createdDate,pl.HeureEntree,pl.HeureSortire,pl.kgs,pl.heureSupp,pe.PrixKgs,pe.salaireBase,pe.typePaie,
    CONVERT(TIME, DATEADD(SECOND, DATEDIFF(SECOND, pl.HeureEntree, pl.HeureSortire), 0)) AS nombreHeurs
FROM 
    Paie_P_POINTAGE p
INNER JOIN 
    Paie_P_POINTAGE_LIGNE pl ON p.idPointage = pl.idPointage
INNER JOIN 
    Paie_E_tableEmploye pe ON pl.idEmploye = pe.idEmploye
WHERE 
    pe.idEmploye = @idEmploye
    AND YEAR(p.createdDate) = @annee
    AND MONTH(p.createdDate) = @mois
ORDER BY 
    pe.nomEmployee;

--SELECT * FROM @infoEmp;
SELECT @kgs = SUM(kgs) FROM @infoEmp;
SELECT @PrixKgs = SUM(PrixKgs) FROM @infoEmp;
SELECT @heureSupp = SUM(heureSupp) FROM @infoEmp;
SELECT @nombrJour = count(*) FROM @infoEmp;
SELECT TOP 1 @salaireBase = salaireBase FROM @infoEmp;
SELECT TOP 1 @typePaie = typePaie FROM @infoEmp;
SELECT @nombreHeurs = SUM(DATEDIFF(HOUR, '00:00:00', nombreHeurs))
FROM @infoEmp;

--SELECT @nombrJour as nombrJour,@kgs AS kgs,@PrixKgs as PrixKgs,
--       @salaireBase AS salaireBase,
--       @typePaie AS typePaie,
--       @nombreHeurs AS nombreHeurs,
--	   @heureSupp as heureSupp



if(@typePaie='Par heure')
begin
select @prixJours=@salaireBase/26
select @prixHeur=@prixJours/8
select @salaireFinal=@prixJours*@nombrJour+(@prixHeur*@heureSupp)

select @salaireFinal as salaireFinal ,@prixJours as prixJours,(@prixHeur*@heureSupp) as totalprixSupp,@prixHeur as prixHeur,@heureSupp as heureSupp
end
else if(@typePaie='Par quantite && prix')
begin

select @prixJours=@salaireBase/26
select @prixHeur=@prixJours/8
select @salaireFinal=@prixJours*@nombrJour+(@prixHeur*@heureSupp)
select @salaireFinal as salaireFinal ,@prixJours as prixJours,(@prixHeur*@heureSupp) as totalprixSupp,@prixHeur as prixHeur,@heureSupp as heureSupp
end
else 
begin
SELECT @nombrJour as nombrJour,@kgs AS kgs,@PrixKgs as PrixKgs,
       @salaireBase AS salaireBase,
       @typePaie AS typePaie,
       @nombreHeurs AS nombreHeurs
end


--select * from Paie_E_Employe
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [paie_p_pointage_delete]
(
@idPointage int)
as
begin

delete from Paie_P_POINTAGE_LIGNE where idPointage=@idPointage
delete from Paie_P_POINTAGE where idPointage=@idPointage

end



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_p_pointage_select](
		@idUser nvarchar(450),
		@idGroup int=null,
		@dateStart datetime,
		@dateEnd datetime,
		@idDossier int=null
		)
		as begin
		  select * from Paie_P_POINTAGE p where p.idUser=@idUser and p.idGroup=@idGroup and idDossier=@idDossier and p.createdDate between @dateStart and @dateEnd

			
				
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [paie_p_pointageInfoEmp](
@idEmploye int ,
@annee int ,
@mois int 
)
as
begin
DECLARE @kgs AS FLOAT;
DECLARE @PrixKgs AS FLOAT;
DECLARE @salaireBase AS FLOAT;
DECLARE @SBI AS FLOAT;
DECLARE @CNSS AS FLOAT;
DECLARE @AMO AS FLOAT;
DECLARE @Frai_prof AS FLOAT;
DECLARE @SNI AS FLOAT;
DECLARE @IR_BRUT AS FLOAT;
DECLARE @IR_NET AS FLOAT;
DECLARE @NET_PAYE AS FLOAT;
DECLARE @typePaie AS NVARCHAR(MAX);
DECLARE @heureSupp AS FLOAT;
DECLARE @nombreHeurs INT;
DECLARE @nombrJour INT;
DECLARE @salaireBrutGlobal AS FLOAT;
DECLARE @prixJours AS FLOAT;
DECLARE @prixParHeur AS FLOAT;
DECLARE @prixHeurSup AS FLOAT;
DECLARE @nbconge AS INT = 0;
DECLARE @avance AS FLOAT = 0;
DECLARE @prime AS FLOAT = 0;
DECLARE @matricule AS NVARCHAR(500);
DECLARE @TAUX as float=0;
DECLARE @SOMME_A_DEDUIRE AS FLOAT=0;
DECLARE @sitFamiliale AS NVARCHAR(500);
DECLARE @CH AS FLOAT=0;
DECLARE @nbEnfants AS int=0;
DECLARE @SALAIRE_BASE_1 AS float=0;
DECLARE @salaireBrutGlobal_1 as float=0;
DECLARE @JOURSABCENT AS INT =0;
DECLARE @J_CONGE_N_1 AS float =0;
DECLARE @J_CONGE_N AS float =0;
DECLARE @J_CONSOMMES AS float =0;
DECLARE @J_RESTES AS float =0;


-- Declare a temporary table
DECLARE @infoEmp TABLE (
    idEmploye INT,
    nomEmployee NVARCHAR(MAX),
    prenomEmployee NVARCHAR(MAX),
	matricule nvarchar(500),
    idPointage INT,
    createdDate DATE,
    HeureEntree TIME,
    HeureSortire TIME,
    kgs FLOAT,
    heureSupp FLOAT,
    PrixKgs FLOAT,
    salaireBase FLOAT,
    typePaie NVARCHAR(MAX),
    nombreHeurs TIME,
    PrixHeurSup FLOAT,
    PrixParHeur FLOAT,
	sitFamiliale nvarchar(500),
	nbEnfants int
);

-- Insert into the temporary table using your query
INSERT INTO @infoEmp (
    idEmploye, nomEmployee, prenomEmployee,matricule, idPointage, createdDate, HeureEntree, HeureSortire, kgs, heureSupp, PrixKgs, salaireBase, typePaie, nombreHeurs, PrixHeurSup, PrixParHeur,sitFamiliale,nbEnfants
)
SELECT 
    pe.idEmploye, pe.nomEmployee, pe.prenomEmployee,pe.matricule, p.idPointage, p.createdDate, pl.HeureEntree, pl.HeureSortire, pl.kgs, pl.heureSupp, pe.PrixKgs, pe.salaireBase, pe.typePaie,
    CONVERT(TIME, DATEADD(SECOND, DATEDIFF(SECOND, pl.HeureEntree, pl.HeureSortire), 0)) AS nombreHeurs, PrixHeurSup, PrixParHeur,pe.sitFamiliale,pe.nbEnfants
FROM 
    Paie_P_POINTAGE p
INNER JOIN 
    Paie_P_POINTAGE_LIGNE pl ON p.idPointage = pl.idPointage
INNER JOIN 
    Paie_E_tableEmploye pe ON pl.idEmploye = pe.idEmploye
WHERE 
    pe.idEmploye = @idEmploye
    AND YEAR(p.createdDate) = @annee
    AND MONTH(p.createdDate) = @mois
ORDER BY 
    pe.nomEmployee;
--CONGE


select @J_CONGE_N_1=jCongeN from Paie_E_tableConges where idEmploye=@idEmploye
select @J_CONGE_N_1=jCongeN_1 from Paie_E_tableConges where idEmploye=@idEmploye
select @J_CONSOMMES=jConsommes from Paie_E_tableConges where idEmploye=@idEmploye
select @J_RESTES=jRestes from Paie_E_tableConges where idEmploye=@idEmploye

-- Calculations
SELECT @kgs = SUM(kgs) FROM @infoEmp;
SELECT @PrixKgs = PrixKgs FROM @infoEmp;
SELECT @heureSupp = SUM(heureSupp) FROM @infoEmp;
SELECT @nombrJour = COUNT(*) FROM @infoEmp;
SELECT TOP 1 @salaireBase = salaireBase FROM @infoEmp;
SELECT TOP 1 @prixHeurSup = prixHeurSup FROM @infoEmp;
SELECT TOP 1 @prixParHeur = PrixParHeur FROM @infoEmp;
SELECT TOP 1 @typePaie = typePaie FROM @infoEmp;
SELECT TOP 1 @matricule = matricule FROM @infoEmp;
SELECT TOP 1 @sitFamiliale = sitFamiliale FROM @infoEmp;
SELECT TOP 1 @nbEnfants = nbEnfants FROM @infoEmp;

SELECT @avance = SUM(montant) 
FROM Paie_Calcul_Avance 
WHERE MONTH(dateAvance) = @mois 
  AND YEAR(dateAvance) = @annee 
  AND idEmploye = @idEmploye;
if(@avance is null)
	select @avance=0


SELECT @nombreHeurs = SUM(DATEDIFF(HOUR, '00:00:00', nombreHeurs))
FROM @infoEmp;

SELECT @nbconge = ISNULL(SUM(nbJours), 0) 
FROM Paie_Calcul_Conges 
WHERE idEmploye = @idEmploye 
  AND (MONTH(periodeDebut) = @mois AND YEAR(periodeDebut) = @annee);

-- Calculations based on type of pay
IF (@typePaie = 'Par heure')
BEGIN
    SELECT @prixJours = @salaireBase / 26;
    SELECT @salaireBrutGlobal = (@prixJours * (@nombrJour + @nbconge)) + (@prixParHeur * @nombreHeurs) + (@prixHeurSup * @heureSupp);
END
ELSE IF (@typePaie = 'Par quantite && Heur')
BEGIN
    SELECT @prixJours = @salaireBase / 26;
    SELECT @salaireBrutGlobal = (@prixJours * (@nombrJour + @nbconge)) + (@PrixKgs * @kgs) + (@prixHeurSup * @heureSupp);
END
ELSE
BEGIN
    SELECT @prixJours = @salaireBase / 26;
    SELECT @salaireBrutGlobal = @prixJours * (@nombrJour + @nbconge) + (@prixHeurSup * @heureSupp);
END;
select @salaireBrutGlobal_1=@salaireBrutGlobal
SELECT @SALAIRE_BASE_1=@salaireBrutGlobal
SELECT @SBI = @salaireBrutGlobal - @prime;
    SELECT @CNSS = @SBI * 0.0448;
    IF (@CNSS > 6000)
    BEGIN
        SELECT @CNSS = 6000;
    END;
    SELECT @AMO = @SBI * 0.0226;
    IF (@AMO > 6000)
    BEGIN
        SELECT @AMO = 6000;
    END;
    IF (@SBI <= 6500)
    BEGIN
        SELECT @Frai_prof = @SBI * 0.35;
        IF (@Frai_prof > 2275)
        BEGIN
            SELECT @Frai_prof = 2275;
        END;
    END
    ELSE
    BEGIN
        SELECT @Frai_prof = @SBI * 0.25;
        IF (@Frai_prof > 2917)
        BEGIN
            SELECT @Frai_prof = 2917;
        END;
    END;
	if(@matricule is null or @matricule='')
	begin
		select @CNSS=0
	end
	select @SNI=@salaireBrutGlobal-@CNSS-@AMO-@Frai_prof
	select @TAUX=case when (@SNI>0 and @SNI<=2500) then 0
					when  (@SNI >2500 and @SNI<=4166.66) then 0.1
					when  (@SNI >4166.66 and @SNI<=5000) then 0.2
					when  (@SNI >5000 and @SNI<=6666.67) then 0.3
					when  (@SNI >6666.67 and @SNI<=15000) then 0.34
					when  (@SNI >6666.67 and @SNI<=15000) then 0.38
					
					else 0
					end
	select @SOMME_A_DEDUIRE=case when (@SNI>0 and @SNI<=2500) then 0
					when  (@SNI >2500 and @SNI<=4166.66) then 250
					when  (@SNI >4166.66 and @SNI<=5000) then 666.67
					when  (@SNI >5000 and @SNI<=6666.67) then 1166.67
					when  (@SNI >6666.67 and @SNI<=15000) then 1433.33
					when  (@SNI >6666.67 and @SNI<=15000) then 2033.33
					
					else 0
					end
	select @IR_BRUT=(@SNI*@TAUX)-@SOMME_A_DEDUIRE
	SELECT @CH=case when @sitFamiliale='Marié(e)' then 30
	else 0 
	end
	SELECT @CH=@CH+@nbEnfants*30
	if(@CH>30)
	begin
		select @CH=180
	end
	
	select @IR_NET=@IR_BRUT-@CH
	if(@IR_NET<0) select @IR_NET=0
	select @salaireBrutGlobal=@salaireBrutGlobal-@CNSS-@AMO-@Frai_prof-@IR_NET-@avance
	select @JOURSABCENT=26-@nombrJour+@nbconge

	--DECLARE @J_CONGE_N_1 AS INT =0;
--DECLARE @J_CONGE_N AS INT =0;
--DECLARE @J_CONSOMMES AS INT =0;
--DECLARE @J_RESTES AS INT =0;
 SELECT 
        (@PrixKgs * @kgs) AS totalPrixKgs, 
        @kgs AS totalKgs, 
        @nombrJour AS nombrJour, 
        @nombreHeurs AS nombreHeurs, 
        @salaireBase AS salaireBase, 
        @salaireBrutGlobal AS salaireBrutGlobal,  
		@SNI as Salaire_net_impossable,
        (@prixParHeur * @nombreHeurs) AS prix_heurs,
        (@PrixKgs * @kgs) AS prix_kgs_heurs,
        (@prixHeurSup * @heureSupp) AS totalprixSupp, 
        @heureSupp AS heureSupp, 
        @nbconge AS nbconge,
		@avance AS avance, 
        @SBI AS SBI, 
        @CNSS AS CNSS,
        @AMO AS AMO, 
        @Frai_prof AS Frais_prof,
		@IR_BRUT AS IR_BRUT,
		@CH AS CH,
		@IR_NET AS IR_NET,
		@SALAIRE_BASE_1 AS SALAIRE_BASE_1,@salaireBrutGlobal_1 as salaireBrutGlobal_1,
		@JOURSABCENT as JOURSABCENT,
		@J_CONGE_N as J_CONGE_N,
		@J_CONGE_N_1 as J_CONGE_N_1,
		@J_CONSOMMES as J_CONSOMMES,
		@J_RESTES as J_RESTES

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_P_PointageInsertUpdate](
@idPointage int=0,
@createdDate datetime=null,
@descrPointage nvarchar(max)=null,
@mois nvarchar(100) = null,
@numPointage int = null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@idDossier int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		
		insert Paie_P_POINTAGE(createdDate,descrPointage,mois,numPointage,idUser,idGroup,idDossier) 
						values (@createdDate,@descrPointage,@mois,@numPointage,@idUser,@idGroup,@idDossier)
		select * from Paie_P_POINTAGE where idPointage=@@IDENTITY
		
	end	
	else 
	begin
		update Paie_P_POINTAGE
		set createdDate=@createdDate,descrPointage=@descrPointage,mois=@mois,idUser=@idUser
		where idPointage=@idPointage
		select * from Paie_P_POINTAGE where idPointage=@@IDENTITY
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_P_PointageLigneInsertUpdate](
@idPointage int=null,
@idPointageLigne int=null,
@idEmploye int=null,
@HeureEntree time=null,
@HeureSortire time=null,
@kgs float=null,
@heureSupp int=0,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		
		declare @createdDate datetime;
		select @createdDate=createdDate from Paie_P_POINTAGE where idPointage=@idPointage
		
		if not exists (select * FROM Paie_P_tablePointageLigne WHERE idEmploye = @idEmploye and idPointage=@idPointage) and @idEmploye in (select idEmploye from Paie_E_Employe pe where pe.idEmploye not in(select idEmploye from Paie_P_POINTAGE_LIGNE pl2 inner join Paie_P_POINTAGE po on pl2.idPointage=po.idPointage where createdDate=@createdDate))
		begin
			insert Paie_P_POINTAGE_LIGNE(idEmploye,HeureEntree,HeureSortire,kgs,idPointage,heureSupp) 
							values (@idEmploye,@HeureEntree,@HeureSortire,@kgs,@idPointage,@heureSupp)
			select * from Paie_P_tablePointageLigne where idPointageLigne=@@IDENTITY
		end
		
	end	
	else if(@statement='updateAll')
	begin
		update Paie_P_POINTAGE_LIGNE
		set HeureEntree=@HeureEntree,HeureSortire=@HeureSortire,kgs=@kgs,heureSupp=@heureSupp
		where idPointage=@idPointage
		select * from Paie_P_tablePointageLigne where idPointage=@idPointage
	end
	else 
	begin
		update Paie_P_POINTAGE_LIGNE
		set HeureEntree=@HeureEntree,HeureSortire=@HeureSortire,kgs=@kgs,heureSupp=@heureSupp
		where idPointageLigne=@idPointageLigne
		select * from Paie_P_tablePointageLigne where idPointageLigne=@idPointageLigne
	end
end

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Z_LogDataInsertUpdate](
@idLogData int=0,
@dateTimeRecord datetime=null,
@timeRecord time=null,
@uniqueId nvarchar(100) = null,
@idDevice int = null,
@enrolNumber int = null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@idEmploye int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		declare @idUserDevice int 
		select top 1 @idUserDevice=d.idUserDevice, @idEmploye=e.idEmploye from Paie_Z_UserDevice d
		inner join Paie_E_Employe e on e.idUserDevice=d.idUserDevice
		where idDevice=@idDevice and enrolNumber=@enrolNumber
		if not exists (select * from Paie_Z_LogData where idUserDevice=@idUserDevice and idGroup=@idGroup and uniqueId=@uniqueId)
		begin
			insert Paie_Z_LogData(idUserDevice,dateTimeRecord,uniqueId,timeRecord,idUser,idGroup,idEmploye) 
						  values (@idUserDevice,@dateTimeRecord,@uniqueId,@timeRecord,@idUser,@idGroup,@idEmploye)
			select * from Paie_Z_LogData where idLogData=@@IDENTITY
		end
	end	
	else 
	begin
		insert Paie_Z_LogData(idUserDevice,dateTimeRecord,timeRecord,idUser,idGroup,idEmploye) 
						  values (@enrolNumber,@dateTimeRecord,@timeRecord,@idUser,@idGroup,@idEmploye)
		select * from Paie_Z_tablePointage where idLogData=@@IDENTITY
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Z_LogDataSelect](
@idUser nvarchar(450)=null,
@SelectALL bit=null,
@idGroup int=null,
@dateD datetime=null,
@dateE datetime=null
)
as begin

	select * from Paie_Z_tablePointage where dateTimeRecord between @dateD and @dateE
	--where ((@SelectALL=1 and  idUser=@idUser) or (@SelectALL=0 and idGroup=@idGroup)) and 

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Z_PlanningInsertUpdate](
@idPlanning int=0,
@nomPlanning nvarchar(500)=null,
@heureDepartDe time=null,
@heureDepartA time=null,
@heurePauseDe time=null,
@heurePauseA time=null,
@heureSortie time=null,
@checkPause bit=0,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_Z_Planning(
								nomPlanning
								,heureDepartDe
								,heureDepartA
								,heurePauseDe
								,heurePauseA
								,heureSortie
								,checkPause
								,idUser
								,idGroup) 
		values (
				@nomPlanning
				,@heureDepartDe
				,@heureDepartA
				,@heurePauseDe
				,@heurePauseA
				,@heureSortie
				,@checkPause
				,@idUser
				,@idGroup)
		select * from Paie_Z_Planning where idPlanning=@@IDENTITY
	end	
	else                                                                                                
	begin
		update Paie_Z_Planning set 
								nomPlanning=@nomPlanning
								,heureDepartDe=@heureDepartDe
								,heureDepartA=@heureDepartA
								,heurePauseDe=@heurePauseDe
								,heurePauseA=@heurePauseA
								,heureSortie=@heureSortie
								,checkPause=@checkPause
		where idPlanning=@idPlanning
		select * from Paie_Z_Planning where idPlanning=@idPlanning
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Z_PointageSelect](
@idUser nvarchar(450)=null,
@SelectALL bit=null,
@idGroup int=null,
@dateD datetime=null,
@dateE datetime=null
)
as begin
declare @row_num int,@id int,@idEmploye int=-1,@dateTimeRecord datetime,@timeRecord time,@idUser1 nvarchar(450), @idGroup1 int, @idLogData int, @nameDevice nvarchar(250),@matricule nvarchar(500), @enrolNumber int
declare @table2 table ( id int identity (1,1), idEmploye int,idEntree int,idSortie int, timeEntree time, timeSortie time,dateTimeRecord dateTime ,duree time,idUser nvarchar(450), idGroup int, nameDevice nvarchar(250),matricule nvarchar(500),enrolNumber int)
declare @table table ( id int identity (1,1), idEmploye int, dateTimeRecord datetime, row_num int, timeRecord time,idUser nvarchar(450), idGroup int, idLogData int, nameDevice nvarchar(250),matricule nvarchar(500),enrolNumber int)
insert into @table(
idEmploye
,dateTimeRecord
,row_num
,timeRecord
,idUser
,idGroup
,idLogData
,nameDevice
,matricule
,enrolNumber)
(select 
idEmploye
,dateTimeRecord
,ROW_NUMBER() OVER (PARTITION BY idEmploye,cast(dateTimeRecord as date) ORDER BY cast(dateTimeRecord as date),timeRecord) AS row_num
,timeRecord
,idUser
,idGroup
,idLogData
,nameDevice
,matricule
,enrolNumber
from Paie_Z_tablePointage where idGroup=@idGroup and cast(dateTimeRecord as date) between @dateD and @dateE)

while(select COUNT(*) from @table)>0
begin
select top 1 @id=id,@row_num=row_num,@idEmploye=idEmploye,@dateTimeRecord=dateTimeRecord,@timeRecord=timeRecord,@idUser1=idUser,@idGroup1=idGroup,@idLogData=idLogData,@nameDevice=nameDevice,@matricule=matricule,@enrolNumber=enrolNumber
from @table
if((@row_num+1) % 2=0)
	begin
		insert into @table2(
		idEmploye
		,timeEntree
		,dateTimeRecord
		,idUser
		,idGroup
		,idEntree
		,nameDevice
		,matricule
		,enrolNumber)
		values
		(@idEmploye
		,@timeRecord
		,@dateTimeRecord
		,@idUser1
		,@idGroup1
		,@idLogData
		,@nameDevice
		,@matricule
		,@enrolNumber)
	end
	else
	begin
		update @table2 set timeSortie=@timeRecord , duree = CONVERT(time, DATEADD(second, DATEDIFF(second, timeEntree, @timeRecord), '00:00:00')),
		idSortie=@idLogData
		WHERE id = (
		  SELECT MAX(id) FROM @table2
		);
	end
delete from @table where id=@id
end

select t2.*, (e.nomEmployee+' '+e.prenomEmployee) as nomEmploye from @table2 t2
inner join Paie_E_Employe e on t2.idEmploye=e.idEmploye
where cast(dateTimeRecord as date) between @dateD and @dateE and ((@SelectALL=1 and  t2.idUser=@idUser) or (@SelectALL=0 and t2.idGroup=@idGroup))

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [Paie_Z_PointageSelectAbsents](
@idGroup int=null,
@dateD datetime=null,
@dateE datetime=null
)
as begin

select (e.nomEmployee+' '+e.prenomEmployee) as nomEmploye,e.matricule , z.nameDevice ,u.* from Paie_Z_UserDevice u
inner join Paie_E_Employe e on e.idUserDevice=u.idUserDevice
inner join Paie_Z_ZKTDevices z on z.idDevice=u.idDevice
where u.idUserDevice not in( 
select idUserDevice from Paie_Z_LogData 
where cast(dateTimeRecord as date) between @dateD and @dateE and idUserDevice is not null and idGroup=@idGroup)

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [Paie_Z_UserDeviceInsertUpdate](
@idUserDevice int=0,
@enrolNumber int=null,
@name nvarchar(500)=null,
@passwordU nvarchar(100)=null,
@idDevice int=null,
@idUser nvarchar(450)=null,
@idGroup int=null)
as begin
	if not exists (select * from Paie_Z_UserDevice where enrolNumber=@enrolNumber and idGroup=@idGroup and idDevice=@idDevice)
	begin
		insert Paie_Z_UserDevice(enrolNumber,name,passwordU,idDevice,idUser,idGroup) 
					  values (@enrolNumber,@name,@passwordU,@idDevice,@idUser,@idGroup)
		select * from Paie_Z_UserDevice where idUserDevice=@@IDENTITY
	end	
	else
	begin
		select * from Paie_Z_UserDevice where enrolNumber=@enrolNumber and idGroup=@idGroup and idDevice=@idDevice
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [Paie_Z_ZKTDevicesInsertUpdate](
@idDevice int=0,
@nameDevice nvarchar(500)=null,
@ipDevice nvarchar(200)=null,
@portDevice int=4370,
@machingNumber int=1,
@idUser nvarchar(450)=null,
@idGroup int=null,
@statement varchar(100)='insert')
as begin
	if(@statement='insert')
	begin
		insert Paie_Z_ZKTDevices(nameDevice,ipDevice,portDevice,machingNumber,idUser,idGroup) 
					  values (@nameDevice,@ipDevice,@portDevice,@machingNumber,@idUser,@idGroup)
		select * from Paie_Z_ZKTDevices where idDevice=@@IDENTITY
	end	
	else
	begin
		update Paie_Z_ZKTDevices set 
		nameDevice=@nameDevice,
		ipDevice=@ipDevice,
		portDevice=@portDevice,
		machingNumber=@machingNumber
		where idDevice=@idDevice
		select * from Paie_Z_ZKTDevices where idDevice=@idDevice
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [pos_insertArticle](
@idArticle int=null,
@codeBareArticle nvarchar(500),
@favorisArticle bit,
@idFamille int,
@idGroup int,
@nomArticle nvarchar(500),
@photoArticle nvarchar(500),
@prixVente_HT money,
@prixVente_TTC money,
@refArticle nvarchar(500)
)
as
begin
	if @idArticle is null
	begin
		insert into a_Article(codeBareArticle,favorisArticle,idFamille,nomArticle,photoArticle,prixVente_HT,prixVente_TTC,refArticle,idGroup)
		values(@codeBareArticle,@favorisArticle,@idFamille,@nomArticle,@photoArticle,@prixVente_HT,@prixVente_TTC,@refArticle,@idGroup)
		select @idArticle=@@IDENTITY from a_Article
	end
	else
	begin
		update a_Article set codeBareArticle=@codeBareArticle,favorisArticle=@favorisArticle,idFamille=@idFamille,nomArticle=@nomArticle ,photoArticle=@photoArticle ,
		prixVente_HT=@prixVente_HT ,prixVente_TTC=@prixVente_TTC ,refArticle=@refArticle,idGroup=@idGroup where idArticle=@idArticle
	end
	select * from a_tableArticle
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [r_ReglementCopier](
@idReglement int,
@idDossier int,
@codeTypeCopier varchar(20),
@idUser nvarchar(450))
as begin
	declare @numFactur int,@newIdEntet int,@valstock int,@valcmup int

		select @numFactur=isnull(Numfacture,0),
					@valstock=valstock,
					@valcmup=valcmup  from e_TypeDoc 
					where codeType=@codeTypeCopier and idDossier=@idDossier
					
		insert into r_Reglement(numReglement,
		dateReglement,banque,numCheque,
		dateEcheanche,nom,info,etatReg,
		idModRglm,idTreso,idClient,idFournisseur,
		codeType,idUser,idDossier,idEntet,idGroup,montant)
		 select @numFactur+1,
		dateReglement,banque,numCheque,
		dateEcheanche,nom,info,etatReg,
		idModRglm,idTreso,idClient,idFournisseur,
		@codeTypeCopier,@idUser,idDossier,idEntet,idGroup,montant from r_Reglement where idReglement=@idReglement

end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [r_ReglementInsertUpdate](
	   @idReglement int =null
       ,@numReglement int =null
      ,@dateReglement datetime =getdate
      ,@banque nvarchar(100)=null
      ,@numCheque nvarchar(100)=null
      ,@dateEcheanche datetime=null
      ,@nom nvarchar(100)=null
      ,@info nvarchar(200)=null
      ,@etatReg nvarchar(100)='saisir'
      ,@idModRglm int =null
      ,@idTreso int =null
      ,@idClient int =null
      ,@idFournisseur int=null
      ,@codeType varchar(20)
      ,@idUser nvarchar(450)
      ,@idDossier int=null
      ,@idEntet int =null
      ,@idGroup int=null,
      @montant money=0
      ,@statment varchar(100)='insert')
      as begin
		
		if(@statment='insert')
		begin
			if(@idFournisseur is not null)
				begin
					INSERT INTO r_Reglement
				   ([numReglement]
				   ,[dateReglement]
				   ,[banque]
				   ,[numCheque]
				   ,[dateEcheanche]
				   ,[nom]
				   ,[info]
				   ,[etatReg]
				   ,[idModRglm]
				   ,[idTreso]
				   ,[idClient]
				   ,[idFournisseur]
				   ,[codeType]
				   ,[idUser]
				   ,[idDossier] 
				   ,[montant]
				   ,[idGroup],
				   idEntetFish)
				VALUES
				   (@numReglement
				   ,@dateReglement
				   ,@banque
				   ,@numCheque
				   ,@dateEcheanche
				   ,@nom
				   ,@info
				   ,@etatReg
				   ,@idModRglm
				   ,@idTreso
				   ,@idClient
				   ,@idFournisseur
				   ,@codeType
				   ,@idUser
				   ,@idDossier
				   ,@montant
				   ,@idGroup
				   ,@idEntet
				   )
			end
			else
			begin
				INSERT INTO r_Reglement
				   ([numReglement]
				   ,[dateReglement]
				   ,[banque]
				   ,[numCheque]
				   ,[dateEcheanche]
				   ,[nom]
				   ,[info]
				   ,[etatReg]
				   ,[idModRglm]
				   ,[idTreso]
				   ,[idClient]
				   ,[idFournisseur]
				   ,[codeType]
				   ,[idUser]
				   ,[idDossier] 
				   ,[montant]
				   ,[idGroup],
				   idEntet
				   )
				VALUES
				   (@numReglement
				   ,@dateReglement
				   ,@banque
				   ,@numCheque
				   ,@dateEcheanche
				   ,@nom
				   ,@info
				   ,@etatReg
				   ,@idModRglm
				   ,@idTreso
				   ,@idClient
				   ,@idFournisseur
				   ,@codeType
				   ,@idUser
				   ,@idDossier
				   ,@montant
				   ,@idGroup
				   ,@idEntet
				   )
			end
           update e_TypeDoc set numFacture=@numReglement where idDossier=@idDossier and codeType=@codeType
           select * from r_tableReglement where idReglement=@@IDENTITY
		end
		else
		begin
			if(@idFournisseur is not null)
			begin
				UPDATE r_Reglement
			   SET [numReglement] = @numReglement
				  ,[dateReglement] = @dateReglement
				  ,[banque] = @banque
				  ,[numCheque] = @numCheque
				  ,[dateEcheanche] = @dateEcheanche
				  ,[nom] = @nom
				  ,[info] = @info
				  ,[etatReg] = @etatReg
				  ,[idModRglm] = @idModRglm
				  ,[idTreso] = @idTreso
				  ,[idClient] = @idClient
				  ,[idFournisseur] = @idFournisseur
				  ,[codeType] = @codeType
				  ,[idUser] = @idUser
				  ,[idDossier] = @idDossier
				  ,[idEntetFish] = @idEntet
				  ,[montant] = @montant
				  ,[idGroup] = @idGroup
			 WHERE idReglement=@idReglement
			 update t_FournisseurCredit set credit=isnull(credit,0) - @montant where idFournisseur =@idFournisseur and idDossier=@idDossier
				update b_SoldTresorerie set soldTresorerie =isnull(soldTresorerie,0) - @montant where idTreso =@idTreso and idDossier=@idDossier
			end
			else
			begin
			UPDATE r_Reglement
			   SET [numReglement] = @numReglement
				  ,[dateReglement] = @dateReglement
				  ,[banque] = @banque
				  ,[numCheque] = @numCheque
				  ,[dateEcheanche] = @dateEcheanche
				  ,[nom] = @nom
				  ,[info] = @info
				  ,[etatReg] = @etatReg
				  ,[idModRglm] = @idModRglm
				  ,[idTreso] = @idTreso
				  ,[idClient] = @idClient
				  ,[idFournisseur] = @idFournisseur
				  ,[codeType] = @codeType
				  ,[idUser] = @idUser
				  ,[idDossier] = @idDossier
				  ,[idEntet] = @idEntet
				  ,[montant] = @montant
				  ,[idGroup] = @idGroup
			 WHERE idReglement=@idReglement
			end
			 select * from r_tableReglement where idReglement=@idReglement
		end
      end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [r_ReglementSelect](
		@idGroup int=null,
		@SelectDoc bit=null,
		@idDossier int=null,
		@codeType varchar(20)=null,
		@dateStart datetime=null,
		@dateEnd datetime=null,
		@Filter varchar(100)='dateReglement')
		as begin
			if(@Filter='dateReglement')
			begin
				select * from r_tableReglement where ((@SelectDoc=1 and idGroup=@idGroup and idDossier=@idDossier and dateReglement between @dateStart and @dateEnd and codeType=@codeType) 
											or (@SelectDoc=0 and idDossier=@idDossier and dateReglement between @dateStart and @dateEnd and codeType=@codeType))
			end
			else 
			begin
				select * from r_tableReglement where ((@SelectDoc=1 and idGroup=@idGroup and idDossier=@idDossier and dateEcheanche between @dateStart and @dateEnd and codeType=@codeType) 
											or (@SelectDoc=0 and idDossier=@idDossier and dateEcheanche between @dateStart and @dateEnd and codeType=@codeType))
			end
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_DossierInsertUapdate](
@idDossier int=0,
@Nom_dossier nvarchar(100)=null,
@Activite nvarchar(100)=null,
@Adresse nvarchar(100)=null,
@Complement nvarchar(100)=null,
@Cp nvarchar(100)=null,
@Region nvarchar(100)=null,
@Ville nvarchar(100)=null,
@Pays nvarchar(100)=null,
@Fix nvarchar(100)=null,
@Sitee nvarchar(100)=null,
@Tele nvarchar(100)=null,
@Email nvarchar(100)=null,
@Cnss nvarchar(100)=null,
@Patente nvarchar(100)=null,
@Iff nvarchar(100)=null,
@Rc nvarchar(100)=null,
@Ice nvarchar(100)=null,
@Entet_dossier nvarchar(500)=null,
@Pied_dossier nvarchar(500)=null,
@Style_dossier nvarchar(200)=null,
@Logo nvarchar(500)=null,
@Body_color nvarchar(100)=null,
@header_color nvarchar(100)=null,
@domainName nvarchar(500)=null,
@wooClientKey nvarchar(max)=null,
@wooClientSecret nvarchar(max)=null,
@Objectif nvarchar(max)=null,
@update varchar(100)=null,
@idUser nvarchar(450)=null,
@dateExeEnd datetime=null,
@dateExeStart datetime=null,
@idGroup int=null,
@statment varchar(100))
as begin
	
	if(@statment='insert')
	begin
		insert into 
		s_dossier(nom_dossier,activite,adresse,complement,cp,ville,region,pays,tele,fix,email,sitee,cnss,patente,iff,rc,ice,Objectif,idGroup)
		 values(@Nom_dossier,@Activite,@Adresse,@Complement,@Cp,@Ville,@Region,@Pays,@Tele,@Fix,@Email,@Sitee,@Cnss,@Patente,@Iff,@Rc,@Ice,@Objectif,@idGroup)
		 select @idDossier =idDossier from s_Dossier where idDossier=@@IDENTITY 
		 insert into s_UserDossier(idUser,idDossier) values(@idUser,@idDossier)
		 exec s_TypeDocInsert @idDossier
		select * from s_Dossier where idDossier=@idDossier
	end
	else
	begin
		if(@update='Generale-tab')
		begin
		update s_dossier set Nom_dossier=@Nom_dossier,
                      Activite = @Activite,
                      Adresse = @Adresse,
                      Complement = @Complement,
                      Cp = @Cp,
                      Region = @Region,
                      Ville = @Ville,
                      Pays = @Pays,
                      Fix = @Fix,
                      Sitee = @Sitee,
                      Tele = @Tele,
                      Email = @Email,
                      Cnss = @Cnss,
                      Patente = @Patente,
                      Iff = @Iff,
                      Rc = @Rc,
                      Ice = @Ice,
					  Objectif=@Objectif
                      where idDossier = @idDossier
         select * from s_dossier where idDossier=@idDossier             
		end
		if(@update='Mise-page-tab')
		begin
			update s_dossier set Style_dossier=@Style_dossier , Entet_dossier=@Entet_dossier,Pied_dossier=@Pied_dossier where idDossier=@idDossier
			select * from s_dossier where idDossier=@idDossier
		end
		if(@update='Woocommerce-tab')
		begin
			update s_dossier set domainName=@domainName,wooClientKey=@wooClientKey,wooClientSecret=@wooClientSecret where idDossier=@idDossier
			select * from s_dossier where idDossier=@idDossier
		end
		if(@update='Exercice-tab')
		begin
			update s_dossier set dateExeEnd=@dateExeEnd,dateExeStart=@dateExeStart where idDossier=@idDossier
			select * from s_dossier where idDossier=@idDossier
		end
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_EmailsSettingsInsertUpdate](
  @idESettings int=null,
  @urlServer nvarchar(500),
  @urlAttach nvarchar(500),
  @hostSm nvarchar(200),
  @usernameSm nvarchar(500),
  @passwordSm nvarchar(50),
  @portSm int=0,
  @fromNameSm nvarchar(500),
  @checkSMTP bit=0,
  @hostIm nvarchar(200),
  @usernameIm nvarchar(500),
  @passwordIm nvarchar(50),
  @portIm int=0,
  @idUser nvarchar(450)=null,
  @idGroup int=null)
  as begin
	if not exists (select *FROM s_EmailsSettings WHERE idGroup = @idGroup)
	begin
		insert s_EmailsSettings
		(urlServer,urlAttach,hostSm,usernameSm,passwordSm,portSm,fromNameSm,checkSMTP,hostIm,usernameIm,passwordIm,portIm,idUser,idGroup) 
		values (@urlServer,@urlAttach,@hostSm,@usernameSm,@passwordSm,@portSm,@fromNameSm,@checkSMTP,@hostIm,@usernameIm,@passwordIm,@portIm
		,@idUser,@idGroup)
		select * from s_EmailsSettings where idESettings=@@IDENTITY
	end	
	else
	begin
		UPDATE s_EmailsSettings
		   SET [urlServer] = @urlServer
			  ,[urlAttach] = @urlAttach
			  ,[hostSm] = @hostSm
			  ,[usernameSm] = @usernameSm
			  ,[passwordSm] = @passwordSm
			  ,[portSm] = @portSm
			  ,[fromNameSm] = @fromNameSm
			  ,[checkSMTP] = @checkSMTP
			  ,[hostIm] = @hostIm
			  ,[usernameIm] = @usernameIm
			  ,[passwordIm] = @passwordIm
			  ,[portIm] = @portIm
		 WHERE idESettings=@idESettings
		 select * from s_EmailsSettings where idGroup = @idGroup
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [s_FileInsert](
@nameFile nvarchar(max),
@pathFile nvarchar(max),
@typeFile nvarchar(100),
@sizeFile varchar(max))
as begin
insert into s_Fille (nameFile,pathFile,typeFile,sizeFile) values(@nameFile,@pathFile,@typeFile,@sizeFile)
select idFille from s_Fille where idFille=@@IDENTITY
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_insertDefaultDatabase](
@idGroup int
)
as begin

INSERT b_Ville (nomVille,idGroup) VALUES (N'Tétouan',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Tanger',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Rabat',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Casablanca',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Hociema',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Fès',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Kénitra',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Agadir',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Larache',@idGroup)
INSERT b_Ville (nomVille,idGroup) VALUES (N'Meknès',@idGroup)

INSERT b_Pays (nomPays,idGroup) VALUES ( N'Maroc',@idGroup)
INSERT b_Pays (nomPays,idGroup) VALUES (N'España',@idGroup)
INSERT b_Pays (nomPays,idGroup) VALUES (N'France',@idGroup)
INSERT b_Pays (nomPays,idGroup) VALUES (N'Belgique',@idGroup)

INSERT u_UniteMesure (descUnite,prcpUnite,idGroup) VALUES ( N'U',1,@idGroup)
INSERT u_UniteMesure (descUnite,idGroup) VALUES (N'KG',@idGroup)
INSERT u_UniteMesure (descUnite,idGroup) VALUES (N'm²',@idGroup)
INSERT u_UniteMesure (descUnite,idGroup) VALUES (N'L',@idGroup)

INSERT b_ModRglm (nomModRglm,categModRglm,timbre,idGroup) VALUES ( 'Espece','Espece',0,@idGroup)
INSERT b_ModRglm (nomModRglm,categModRglm,timbre,idGroup) VALUES ( 'Chèque','Chèque',0,@idGroup)
INSERT b_ModRglm (nomModRglm,categModRglm,timbre,idGroup) VALUES ( 'Effet_de_commerce','Effet_de_commerce',0,@idGroup)
INSERT b_ModRglm (nomModRglm,categModRglm,timbre,idGroup) VALUES ( 'Virement_bancaire','Virement_bancaire',0,@idGroup)
INSERT b_ModRglm (nomModRglm,categModRglm,timbre,idGroup) VALUES ( 'Prélèvement','Prélèvement',0,@idGroup)
INSERT b_ModRglm (nomModRglm,categModRglm,timbre,idGroup) VALUES ( 'Carte_bancaire','Carte_bancaire',0,@idGroup)

insert s_Roles(nameRole,idGroup,selectByUser,selectALL,selectDoc) values('DefaultRole',@idGroup,0,0,0)

INSERT s_Settings (currencyFormat, qteFormat, tvaCheck, ttcCheck, subDepot, idGroup) 
VALUES (N'[{"pattern":"# !","precision":"4","symbol":"DH","decimal":",","separator":" "}]', N'[{"pattern":"# !","precision":"0","symbol":" ","decimal":",","separator":" "}]',
 0, 0, 0, @idGroup)
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_LiaisonUsersInsertUpdate](
@idDepot int=null,
@idVille int=null,
@idPays int=null,
@idUser nvarchar(450) =null,
@idTreso int=null)
as begin
	if not exists (select * from s_LiaisonUsers where idUser=@idUser)
	begin
		insert s_LiaisonUsers(idDepot,idTreso,idVille,idPays,idUser) values (@idDepot,@idTreso,@idVille,@idPays,@idUser)
		select * from s_LiaisonUsers where idUser=@idUser
	end	
	else
	begin
		update s_LiaisonUsers set idDepot=@idDepot,idTreso=@idTreso,idVille=@idVille,idPays=@idPays where idUser=@idUser
		select * from s_LiaisonUsers where idUser=@idUser

	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_RoleSelect](
@idUser nvarchar(450))
as begin
select r.* from s_Roles r inner join s_UserRoles u on u.idRole=r.idRole where u.idUser=@idUser
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_RolesInsertUpdate](
  @idRole int=null,
  @nameRole nvarchar(max),
  @insertRole bit =1,
  @updateRole bit=1,
  @deleteRole bit=1,
  @selectByUser bit=0,
  @selectALL bit=0,
  @selectDoc bit=0,
  @selectArticles bit=0,
  @imprimerRole bit=1,
  @valider bit=1,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert s_Roles(nameRole,insertRole,updateRole,deleteRole,selectByUser,selectALL,selectDoc,idGroup,imprimerRole,valider,selectArticles) 
		values (@nameRole,@insertRole,@updateRole,@deleteRole,@selectByUser,@selectALL,@selectDoc,@idGroup,@imprimerRole,@valider,@selectArticles)
		select * from s_Roles where idRole=@@IDENTITY
	end	
	else
	begin
		UPDATE s_Roles
		   SET [nameRole] = @nameRole
			  ,[insertRole] = @insertRole
			  ,[updateRole] = @updateRole
			  ,[deleteRole] = @deleteRole
			  ,[selectByUser] = @selectByUser
			  ,[selectALL] = @selectALL
			  ,[selectDoc] = @selectDoc
			  ,imprimerRole = @imprimerRole
			  ,valider = @valider
			  ,selectArticles=@selectArticles
		 WHERE idRole=@idRole
		 select * from s_Roles where idRole=@idRole
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_selectAllNotification](
@idDossier int=null,
@idUser nvarchar(450)=null)
as begin
declare @numberDayAlert int=2
declare @firstDate date,@lastDate date

	set @lastDate=DATEADD(day, @numberDayAlert, CAST(GETDATE() AS date))
	set @firstDate=GETDATE()

declare @LOCAL_TABLEVARIABLE TABLE
	(column_1 nvarchar(max), 
	 column_2 nvarchar(max),  
	 column_3 nvarchar(max),
	 column_4 nvarchar(max), 
	 column_5 nvarchar(max), 
	 column_6 nvarchar(max),
	 name_Alert nvarchar(max)  
	)		
	
insert into @LOCAL_TABLEVARIABLE select ar.refArticle,ar.nomArticle,dp.nomDepot,db.qteDepot,ar.stkMinArticle,'','stockAlert' from a_Article ar 
		inner join e_Art_Depot db on ar.idArticle=db.idArticle
		inner join b_Depot dp on dp.idDepot=db.idDepot 
		where (ar.stkMinArticle>=db.qteDepot or ar.stkMinArticle=0) and db.idDossier=@idDossier	
		
insert into @LOCAL_TABLEVARIABLE select ar.refArticle,ar.nomArticle,dp.nomDepot,db.qteDepot,ar.stkMinArticle,'','stockAlertFavoris' from a_Article ar 
		inner join e_Art_Depot db on ar.idArticle=db.idArticle
		inner join b_Depot dp on dp.idDepot=db.idDepot 
		where (ar.stkMinArticle>=db.qteDepot or ar.stkMinArticle=0) and db.idDossier=@idDossier	 and ar.favorisArticle=1
		
insert into @LOCAL_TABLEVARIABLE  select c.nomClient,c.soldAutoriseClient,cc.credit,'','','','soldClientAlert' from t_Client c 
		inner join t_ClientCredit cc on cc.idClient=c.idClient
		where cc.credit>=c.soldAutoriseClient and cc.idDossier=@idDossier 	
					
insert into @LOCAL_TABLEVARIABLE  select f.nomFournisseur,f.soldAutoriseFournisseur,cf.credit,'','','','soldFourAlert' from t_Fournisseur f 
		inner join t_FournisseurCredit cf on cf.idFournisseur=f.idFournisseur
		where cf.credit>=f.soldAutoriseFournisseur and cf.idDossier=@idDossier 		

insert into @LOCAL_TABLEVARIABLE select e.numFactur,e.Nom,e.dateEcheanche,e.TT_ttc,'','','blClient' from e_Entet e
		where e.dateEcheanche between @firstDate and @lastDate and e.idDossier=@idDossier and e.codeType='BLFC'		
		
insert into @LOCAL_TABLEVARIABLE select e.numFactur,e.Nom,e.dateEcheanche,e.TT_ttc,'','','blFou' from e_Entet e 
		where e.dateEcheanche between @firstDate and @lastDate and e.idDossier=@idDossier and e.codeType='BLFFR'	
		
insert into @LOCAL_TABLEVARIABLE select r.dateReglement,r.dateEcheanche,t.nameTreso,r.nom,r.numCheque,r.Montant, 'chequeClient' 
		from r_Reglement r inner join b_Tresorerie t on r.idTreso=t.idTreso
		where r.dateEcheanche between @firstDate and @lastDate and r.idDossier=@idDossier and r.codeType='CHFFC'	

insert into @LOCAL_TABLEVARIABLE select r.dateReglement,r.dateEcheanche,t.nameTreso,r.nom,r.numCheque,r.Montant, 'chequeFor' 
		from r_Reglement r inner join b_Tresorerie t on r.idTreso=t.idTreso
		where r.dateEcheanche between @firstDate and @lastDate and r.idDossier=@idDossier and r.codeType='CHFFF'	
		
insert into @LOCAL_TABLEVARIABLE select e.numFactur,e.refFactur,e.dateEntet,e.TT_ht,l.refArticle,
		CASE WHEN s.idSupDepot IS NULL THEN 'Mouvement Transfert du '+d.nomDepot+' au '+d2.nomDepot
			 WHEN s.idSupDepot IS NOT NULL THEN 'Mouvement Transfert du '+d.nomDepot+' ( '+ s.nomSupDepot +' ) au ' +d2.nomDepot+' ( '+ s2.nomSupDepot +' ) '
			 END AS 'Mouvement Transfert',
		'MouvementTransfert' from e_Entet e 
		inner join e_EntetLign l on l.idEntet=e.idEntet
		inner join b_Depot d on d.idDepot=e.idDepot
		inner join b_Depot d2 on d2.idDepot=e.idDepot_2
		left join b_DepotSup s on s.idSupDepot=l.idSupDepot
		left join b_DepotSup s2 on s2.idSupDepot=l.idSupDepot_2
		where e.dateValidation between @firstDate and @lastDate and e.idDossier=@idDossier and e.codeType='MVTR'	
		and valider=1 and e.idDepot_2 in ( select idDepot from b_Depot where e.idUser=@idUser)	

insert into @LOCAL_TABLEVARIABLE select a.refArticle,a.nomArticle,e.numFactur,e.nom,'','','DureeDevie' from e_Entet e 
inner join e_EntetLign l on e.idEntet=l.idEntet 
inner join a_Article a on a.idArticle=l.idArticle
where a.checkDureDevie=1 and e.codeType='BLFC' 
and ( (a.stateDureDevie='jour' and dateadd(DAY,a.dureDevie,l.createDate) between  GETDATE() and dateadd(DAY,2,GETDATE()))
	or ( a.stateDureDevie='mois' and dateadd(MONTH,a.dureDevie,l.createDate) between  GETDATE() and dateadd(DAY,2,GETDATE()))
	or ( a.stateDureDevie='annee' and dateadd(MONTH,a.dureDevie,l.createDate) between  GETDATE() and dateadd(DAY,2,GETDATE()) )
)
		
select * from @LOCAL_TABLEVARIABLE			
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [s_SettingsUpdate](
  @currencyFormat nvarchar(max),
  @qteFormat nvarchar(max),
  @tvaCheck bit=0,
  @ttcCheck bit=0,
  @subDepot bit=0,
  @idGroup int=null)
  as begin
	if exists(select * from s_Settings where idGroup=@idGroup)
	begin
		update s_Settings 
		set currencyFormat=@currencyFormat,qteFormat=@qteFormat,tvaCheck=@tvaCheck,ttcCheck =@ttcCheck ,subDepot=@subDepot where idGroup=@idGroup
	end
	else
	begin
		insert into s_Settings(currencyFormat,qteFormat,tvaCheck,ttcCheck,subDepot,idGroup) 
		values (@currencyFormat,@qteFormat,@tvaCheck,@ttcCheck,@subDepot,@idGroup)
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_TypeDocInsert](
@idDossier int)
as begin
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BAVFR', @idDossier, 0, N'B.AVOIR-FR', N'B.AVOIR-FR', -1, 0, 0, 0, -1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BCC', @idDossier, 0, N'B.COMMANDE-CL', N'B.COMMANDE-CL', 0, 0, 0, 0, 0, 0, 1)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BCFR', @idDossier, 0, N'B.PRODUCTION', N'B.PRODUCTION', 1, 1, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BLFC', @idDossier, 0, N'B.LIVRAISON-CL', N'B.LIVRAISON-CL', -1, 0, 0, 0, 1, 0, 1)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BLFFR', @idDossier, 0, N'B.LIVRAISON-FR', N'B.LIVRAISON-FR', 1, 1, 1, 1, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BRC', @idDossier, 0, N'B.AVOIR-CL', N'B.AVOIR-CL', 1, 0, 0, 0, -1, 0, 1)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BRFR', @idDossier, 0, N'B.RETOUR-FR', N'B.RETOUR-FR', -1, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'CHFFC', @idDossier, 0, N'CHEQUE/EFFET', N'CHEQUE/EFFET', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'DVS', @idDossier, 0, N'DEVIS', N'DEVIS', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'EFFETCL', @idDossier, 0, N'Effet_de_commerce', N'Effet_de_commerce', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'ESPC', @idDossier, 0, N'ESPECE', N'ESPECE', 0, 0, 0, 0, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'FC', @idDossier, 0, N'FACTURE-CL', N'FACTURE-CL', 0, 0, 0, 0, 0, 0, 1)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'INVT', @idDossier, 0, N'INVENTAIRE', N'INVENTAIRE', 1, 1, 1, 1, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'IPYC', @idDossier, 0, N'IMPAYES', N'IMPAYES', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'MVTR', @idDossier, 0, N'Mouvement transfert', N'Mouvement transfert', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'PRLCL', @idDossier, 0, N'Prélèvement', N'Prélèvement', 0, 0, 0, 0, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'PYC', @idDossier, 0, N'PAYES', N'PAYES', 0, 0, 0, 0, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'RNDC', @idDossier, 0, N'RENDU', N'RENDU', 0, 0, 0, 0, -1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'VRMBNQCL', @idDossier, 0, N'Virement_bancaire', N'Virement_bancaire', 0, 0, 0, 0, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BCHV', @idDossier, 0, N'BON DE CHARGEMENT', N'BON DE CHARGEMENT', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'ESPF', @idDossier, 0, N'ESPECE', N'ESPECE', 0, 0, 0, 0, -1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'CHFFF', @idDossier, 0, N'CHEQUE/EFFET', N'CHEQUE/EFFET', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'EFFETFR', @idDossier, 0, N'Effet_de_commerce', N'Effet_de_commerce', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'VRMBNQFR', @idDossier, 0, N'Virement_bancaire', N'Virement_bancaire', 0, 0, 0, 0, -1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'PRLFR', @idDossier, 0, N'Prélèvement', N'Prélèvement', 0, 0, 0, 0, -1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'PYF', @idDossier, 0, N'PAYES', N'PAYES', 0, 0, 0, 0, -1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'IPYF', @idDossier, 0, N'IMPAYES', N'IMPAYES', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'RNDF', @idDossier, 0, N'RENDU', N'RENDU', 0, 0, 0, 0, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'CPTCPT', @idDossier, 0, N'CPT à CPT', N'CPT à CPT', 0, 0, 0, 0, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'RCT', @idDossier, 0, N'RECETTES', N'RECETTES', 0, 0, 0, 0, 1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'DPS', @idDossier, 0, N'DÉPENSES', N'DÉPENSES', 0, 0, 0, 0, -1, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'FFR', @idDossier, 0, N'FACTURE', N'FACTURE', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'FPRV', @idDossier, 0, N'FACTURE_PROFORMA', N'FACTURE_PROFORMA', 0, 0, 0, 0, 0, 0, 1)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'FPRA', @idDossier, 0, N'FACTURE_PROFORMA', N'FACTURE_PROFORMA', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BLFISH', @idDossier, 0, N'FACTURE_PROFORMA', N'FACTURE_PROFORMA', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'PAKINGLIST', @idDossier, 0, N'PAKINGLIST', N'PAKINGLIST', 0, 0, 0, 0, 0, 0, 0)
INSERT [e_TypeDoc] ([codeType], [idDossier], [numFacture], [nomFacture], [descType], [valStock], [valCmup], [valFifo], [valLifo], [valCaisse], [codeCl_FR], [calculMarge]) VALUES (N'BPI', @idDossier, 0, N'BPI', N'BPI', 1, 1, 0, 0, 0, 0, 0)
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [s_updateTypeDoc](
@idDossier int,
@codeType varchar(20),
@descType nvarchar(100),
@numFacture int,
@nomFacture nvarchar(250),
@valStock int,
@valCmup int,

@valCaisse int
)
as begin
	update e_TypeDoc set descType=@descType, numFacture=@numFacture, nomFacture=@nomFacture, valStock=@valStock, valCmup=@valCmup,
	valCaisse=@valCaisse where idDossier=@idDossier and codeType=@codeType
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [s_UserCheck](
@emailUser nvarchar(200),
@userName nvarchar(200))
as begin
	select COUNT(*) from s_Users where emailUser=@emailUser or userName=@userName
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [s_UserInsert](
@idUser nvarchar(450),
@nomUser nvarchar(200),
@emailUser nvarchar(200)='',
@userName nvarchar(200),
@passwordUser nvarchar(max)=null,
@typeAdmin bit,
@idGroup int,
@statment varchar(100)='insert')
as begin
	if(@statment='insert')
		begin
			insert into s_Users(idUser,nomUser,emailUser,userName,passwordUser,typeAdmin,idGroup) values (@idUser,@nomUser,@emailUser,@userName,@passwordUser,@typeAdmin,@idGroup)
			select idUser,nomUser,userName,typeAdmin from s_Users where idUser=@idUser
		end
	else
	begin
		if(@passwordUser is not null)
		begin
			update s_Users set passwordUser=@passwordUser where idUser=@idUser
		end
		update s_Users set userName=@userName,nomUser=@nomUser,emailUser=@emailUser,typeAdmin=@typeAdmin where idUser=@idUser
		select idUser,nomUser,userName,typeAdmin from s_Users where idUser=@idUser
	end	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [s_UserRolesUpdate](
  @idRole int=null,
  @idUser nvarchar(450))
  as begin
	if exists(select * from s_UserRoles where idUser=@idUser)
	begin
		update s_UserRoles set idRole=@idRole where idUser=@idUser
	end
	else
	begin
		insert into s_UserRoles(idRole,idUser) values (@idRole,@idUser)
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [sb_CreationBarCodeInsertUpdate](
@idCreation int=null,
@dimensionW float=null,
@dimensionH float=null,
@vBarWidth int=null,
@vBarHeight int=null,
@meta NVARCHAR(MAX)=null,
@codeType varchar(250)=null,
@idDossier int=null,
@idUser nvarchar(450)=null,
@idGroup int=null
)
as begin
	if exists(select * from sb_CreationBarCode where idUser=@idUser and idGroup=@idGroup)
	begin
		update sb_CreationBarCode 
		set dimensionW=@dimensionW,dimensionH=@dimensionH,vBarWidth=@vBarWidth,vBarHeight=@vBarHeight,meta=@meta,codeType=@codeType,
			 idUser=@idUser
		where idCreation=@idCreation
		select * from sb_CreationBarCode where idCreation=@idCreation
	end
	else
	begin
		insert into sb_CreationBarCode(dimensionW,dimensionH,vBarWidth,vBarHeight,meta,codeType,idDossier,idUser,idGroup) 
		values(@dimensionW,@dimensionH,@vBarWidth,@vBarHeight,@meta,@codeType,@idDossier,@idUser,@idGroup)
		select * from sb_CreationBarCode where idCreation=@@IDENTITY
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [sc_calendarInsertUpdate](
  @idCalendar int=null,
  @name nvarchar(500)=null,
  @checked bit=1,
  @color varchar(100)=null,
  @bgColor varchar(100)=null,
  @borderColor varchar(100)=null,
  @dragBgColor varchar(100)=null,
  @idUser nvarchar(450) =null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert sc_calendar(name,checked,color,bgColor,borderColor,dragBgColor,idUser,idGroup) 
		values (@name,@checked,@color,@bgColor,@borderColor,@dragBgColor,@idUser,@idGroup)
		select * from sc_calendar where idCalendar=@@IDENTITY
	end	
	else
	begin
		update sc_calendar set name=@name,checked=@checked,color=@color,bgColor=@bgColor,borderColor=@borderColor,dragBgColor=@dragBgColor
		where idCalendar=@idCalendar
		select * from sc_calendar where idCalendar=@idCalendar
	
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [sc_scheduleInsertUpdate](
  @idSchedule int=null,
  @title nvarchar(max)=null,
  @body nvarchar(max)=null,
  @isAllday bit=0,
  @start datetime=null,
  @endd datetime=null,
  @heureStart time=null,
  @heureEndd time=null,
  @isPrivate bit=0,
  @nomTier nvarchar(500)=null,
  @idCalendar int=null,
  @idUser nvarchar(450) =null,
  @idGroup int=null,
  @statment varchar(100))
  as begin
	if(@statment='insert')
	begin
		insert sc_schedule(title,body,isAllday,start,endd,heureStart,heureEndd,isPrivate,nomTier,idCalendar,idUser,idGroup) 
		values (@title,@body,@isAllday,@start,@endd,@heureStart,@heureEndd,@isPrivate,@nomTier,@idCalendar,@idUser,@idGroup)
		select * from sc_schedule where idSchedule=@@IDENTITY
	end	
	else
	begin
		update sc_schedule set title=@title,body=@body,isAllday=@isAllday,start=@start,endd=@endd,heureStart=@heureStart,
		heureEndd=@heureEndd,isPrivate=@isPrivate,nomTier=@nomTier
		where idSchedule=@idSchedule
		select * from sc_schedule where idSchedule=@idSchedule
	end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_ClientInsertUpdate](
@idClient int=null,
@codeClient nvarchar(50)=null,
@nomClient nvarchar(200)=null,
@adresseClient nvarchar(200)=null,
@postalClient nvarchar(50)=null,
@iceClient nvarchar(50)=null,
@cnssClient nvarchar(50)=null,
@nifClient nvarchar(50)=null,
@patenteClient nvarchar(50)=null,
@siegeClient nvarchar(50)=null,
@banqueClient nvarchar(50)=null,
@ribClient nvarchar(50)=null,
@soldAutoriseClient money = 0,
@frmJuridiqueClient nvarchar(50)=null,
@emailClient nvarchar(250)=null,
@teleClient nvarchar(250)=null,
@fixClient nvarchar(250)=null,
@typeClient nvarchar(250)=null,
@contratClient bit = 0,
@vendeurClient bit = 0,
@distributeur bit = 0,
@idVille int=null,
@idPays int =null,
@idUser nvarchar(450) =null,
@idGroup int =null,
@cinClient nvarchar(50)=null,
@potentielClt nvarchar(500)=null,
@categorieClt nvarchar(500)=null,
@origineContact nvarchar(500)=null,
@siteweb nvarchar(max)=null,
@propriete nvarchar(max)=null,
@incoterms nvarchar(max)=null,
@autorizacion nvarchar(max)=null,

@statment varchar(100)
)
as begin
	if(@statment='insert')
	begin
		insert t_Client(codeClient,
		nomClient,adresseClient,postalClient,
		iceClient,cnssClient,nifClient,
		patenteClient,siegeClient,banqueClient,
		ribClient,soldAutoriseClient,frmJuridiqueClient,
		emailClient,teleClient,fixClient,
		typeClient,contratClient,vendeurClient,distributeur,idVille,idPays,idUser,idGroup,cinClient,potentielClt,categorieClt,origineContact,siteweb,propriete,incoterms,autorizacion) 
		values (@codeClient,
		@nomClient,@adresseClient,@postalClient,
		@iceClient,@cnssClient,@nifClient,
		@patenteClient,@siegeClient,@banqueClient,
		@ribClient,@soldAutoriseClient,@frmJuridiqueClient,
		@emailClient,@teleClient,@fixClient,
		@typeClient,@contratClient,@vendeurClient,@distributeur,@idVille,@idPays,@idUser,@idGroup,@cinClient,@potentielClt,@categorieClt,@origineContact,@siteweb
		,@propriete,@incoterms,@autorizacion)
		select * from t_tableClient where idClient=@@IDENTITY
	end	
	else
	begin
		update t_Client set codeClient=@codeClient,
		nomClient=@nomClient,adresseClient=@adresseClient,postalClient=@postalClient,
		iceClient=@iceClient,cnssClient=@cnssClient,nifClient=@nifClient,
		patenteClient=@patenteClient,siegeClient=@siegeClient,banqueClient=@banqueClient,
		ribClient=@ribClient,soldAutoriseClient=@soldAutoriseClient,frmJuridiqueClient=@frmJuridiqueClient,
		emailClient=@emailClient,teleClient=@teleClient,fixClient=@fixClient,
		typeClient=@typeClient,contratClient=@contratClient,vendeurClient=@vendeurClient,distributeur=@distributeur,
		idVille=@idVille,idPays=@idPays,cinClient=@cinClient,potentielClt=@potentielClt,categorieClt=@categorieClt,origineContact=@origineContact,
		siteweb=@siteweb, propriete=@propriete,
		incoterms=@incoterms,
		autorizacion=@autorizacion
		where idClient=@idClient
		select * from t_tableClient where idClient=@idClient
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_CompteCient]
  (
  @idDossier int=null,
  @idClient int=null,
  @dateStart datetime,
  @dateEnd datetime,
  @statment varchar(100)='DocClient')
  as begin
	if(@statment='DocClient')
		begin
			if(@idClient=-1)
			begin
				select e.*,d.descType,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType 
				where e.idDossier=@idDossier 
				and dateEntet between @dateStart and @dateEnd and e.idClient is not null and e.idDossier = d.idDossier
			end
			else
			begin
				select e.*,d.descType,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType 
				where e.idClient=@idClient and e.idDossier=@idDossier 
				and dateEntet between @dateStart and @dateEnd and e.idDossier = d.idDossier
			end			
		end
	if(@statment='DocClientDetail')
		begin
		if(@idClient=-1)
			begin
				select e.*,d.descType,l.*,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType inner join e_EntetLign l on e.idEntet=l.idEntet  
				where e.idDossier=@idDossier and dateEntet between @dateStart and @dateEnd and e.idClient is not null
				and e.idDossier = d.idDossier
			end
			else
			begin
				select e.*,d.descType,l.*,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType inner join e_EntetLign l on e.idEntet=l.idEntet  
				where e.idClient=@idClient and e.idDossier=@idDossier and dateEntet between @dateStart and @dateEnd
				and e.idDossier = d.idDossier
			end	
		end	
	if(@statment='GrandLiveClient')
		begin
			if(@idClient=-1)
			begin
				select 'A' as doc ,e.numFactur,cast(e.dateEntet as date)as dateEntet,(e.TT_ttc*d.valStock*-1) as TT_ttc,d.descType,e.etatDoc,e.codeType,e.nom,e.idClient,e.createDate from e_tableEntet e 
			  inner join e_TypeDoc d on e.codeType =d.codeType where (e.codeType='BLFC' or e.codeType='BRC') 
			  and e.idDossier=@idDossier and dateEntet between @dateStart and @dateEnd and e.idClient is not null
			  and e.idDossier = d.idDossier
			UNION ALL
			  select 'B' as doc, r.numReglement,cast(r.dateReglement as date)as dateEntet,(r.montant* d.valCaisse*-1),CASE
				WHEN r.numCheque='' THEN d.descType
				WHEN r.numCheque is null THEN d.descType
				ELSE d.descType+'( '+r.numCheque+' )'
				END, r.etatReg,r.codeType,r.nom,r.idClient,r.createDate  from r_Reglement r 
			  inner join e_TypeDoc d on r.codeType=d.codeType where 
			  r.idDossier=@idDossier and dateReglement between @dateStart and @dateEnd
			  and (d.valCaisse<>0  or d.codeType='IPYC') and r.idDossier = d.idDossier and r.idClient is not null
			  order by cast(dateEntet as date),createDate,doc
			end
			else
			begin
			
				select 'A' as doc ,e.numFactur,cast(e.dateEntet as date)as dateEntet,(e.TT_ttc*d.valStock*-1) as TT_ttc,d.descType,e.etatDoc,e.codeType,e.createDate from e_tableEntet e 
			  inner join e_TypeDoc d on e.codeType =d.codeType where (e.codeType='BLFC' or e.codeType='BRC') 
			  and e.idDossier=@idDossier and dateEntet between @dateStart and @dateEnd and e.idClient=@idClient 
			  and e.idDossier = d.idDossier
			UNION ALL
			  select 'B' as doc, r.numReglement,cast(r.dateReglement as date)as dateEntet,(r.montant* d.valCaisse*-1),CASE
				WHEN r.numCheque='' THEN d.descType
				WHEN r.numCheque is null THEN d.descType
				ELSE d.descType+'( '+r.numCheque+' )'
				END, r.etatReg,r.codeType,r.createDate from r_Reglement r 
			  inner join e_TypeDoc d on r.codeType=d.codeType where 
			  r.idDossier=@idDossier and dateReglement between @dateStart and @dateEnd and r.idClient=@idClient 
			  and (d.valCaisse<>0 or d.codeType='IPYC') and r.idDossier = d.idDossier
			  order by cast(dateEntet as date),createDate,doc 
			end
			
			  
		end	
	if(@statment='SoldeCreditClient')
		begin
			 SELECT e.codeClient,e.idClient,e.nomClient, ISNULL(SUM(e.TT_ttc*d.valCaisse),0) AS credit,
			 isnull((SELECT ISNULL(SUM(r.montant),0) AS debit
			  FROM r_Reglement r
			  INNER JOIN e_TypeDoc d ON r.codeType = d.codeType
			  WHERE d.valCaisse <> 0 AND r.idDossier = d.idDossier and r.idClient=e.idClient and r.idDossier=@idDossier
			  group by r.idClient,r.nom),0) AS debit
			  FROM e_tableEntet e
			  INNER JOIN e_TypeDoc d ON e.codeType = d.codeType 
			  WHERE (e.codeType='BLFC' OR e.codeType='BRC') and e.idDossier=d.idDossier and e.valider=1 and e.idDossier=@idDossier
			  group by e.idClient,e.nomClient,e.codeClient
		end	
  end
  
  
--select * from r_Reglement r 
--	  inner join e_TypeDoc d on r.codeType=d.codeType
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_CompteFournisseur]
  (
  @idDossier int=null,
  @idFournisseur int=null,
  @dateStart datetime,
  @dateEnd datetime,
  @statment varchar(100)='DocFournisseur')
  as begin
	if(@statment='DocFournisseur')
		begin
			if(@idFournisseur=-1)
			begin
				select e.*,d.descType,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType 
				where e.idFournisseur is not null and e.idDossier=@idDossier 
				and dateEntet between @dateStart and @dateEnd and e.idDossier = d.idDossier
			end
			else
			begin
				select e.*,d.descType,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType 
				where e.idFournisseur=@idFournisseur and e.idDossier=@idDossier 
				and dateEntet between @dateStart and @dateEnd and e.idDossier = d.idDossier
			end
			
		end
	if(@statment='DocFournisseurDetail')
		begin
		if(@idFournisseur=-1)
			begin
				select e.*,d.descType,l.*,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType inner join e_EntetLign l on e.idEntet=l.idEntet  
			where e.idFournisseur is not null and e.idDossier=@idDossier 
			and dateEntet between @dateStart and @dateEnd and e.idDossier = d.idDossier
			end
			else
			begin
				select e.*,d.descType,l.*,d.valCaisse from e_tableEntet e inner join e_TypeDoc d on e.codeType =d.codeType inner join e_EntetLign l on e.idEntet=l.idEntet  
			where e.idFournisseur=@idFournisseur and e.idDossier=@idDossier 
			and dateEntet between @dateStart and @dateEnd and e.idDossier = d.idDossier
			end
			
		end	
	if(@statment='GrandLiveFournisseur')
		begin
			if(@idFournisseur=-1)
			begin
				select 'A' as doc ,e.numFactur,cast(e.dateEntet as date)as dateEntet,(e.TT_ttc*d.valStock*-1) as TT_ttc,d.descType,e.etatDoc,e.codeType,e.nom,e.idFournisseur,e.createDate 
				from e_tableEntet e 
			  inner join e_TypeDoc d on e.codeType =d.codeType where (e.codeType='BLFFR' or e.codeType='BAVFR') 
			  and e.idDossier=@idDossier and dateEntet between @dateStart and @dateEnd and e.idFournisseur is not null
			  and e.idDossier = d.idDossier
			UNION ALL
			  select 'B' as doc, r.numReglement,cast(r.dateReglement as date)as dateEntet,(r.montant* d.valCaisse*-1),CASE
				WHEN r.numCheque='' THEN d.descType
				WHEN r.numCheque is null THEN d.descType
				ELSE d.descType+'( '+r.numCheque+' )'
				END, r.etatReg,r.codeType,r.nom,r.idFournisseur,r.createDate  from r_Reglement r 
			  inner join e_TypeDoc d on r.codeType=d.codeType where 
			  r.idDossier=@idDossier and dateReglement between @dateStart and @dateEnd
			  and d.valCaisse<>0 and r.idDossier = d.idDossier and r.idFournisseur is not null
			  order by cast(dateEntet as date),createDate,doc
			end
			else
			begin
				select 'A' as doc ,e.numFactur,cast(e.dateEntet as date)as dateEntet,(e.TT_ttc*d.valStock*-1) as TT_ttc,d.descType,e.etatDoc,e.codeType,e.createDate from e_tableEntet e 
			  inner join e_TypeDoc d on e.codeType =d.codeType where (e.codeType='BLFFR' or e.codeType='BAVFR') 
			  and e.idDossier=@idDossier and dateEntet between @dateStart and @dateEnd and e.idFournisseur=@idFournisseur 
			  and e.idDossier = d.idDossier
			UNION ALL
			  select 'B' as doc, r.numReglement,cast(r.dateReglement as date)as dateEntet,(r.montant* d.valCaisse*-1),CASE
				WHEN r.numCheque='' THEN d.descType
				WHEN r.numCheque is null THEN d.descType
				ELSE d.descType+'( '+r.numCheque+' )'
				END, r.etatReg,r.codeType,r.createDate from r_Reglement r 
			  inner join e_TypeDoc d on r.codeType=d.codeType where 
			  r.idDossier=@idDossier and dateReglement between @dateStart and @dateEnd and r.idFournisseur=@idFournisseur 
			  and d.valCaisse<>0 and r.idDossier = d.idDossier
			  order by cast(dateEntet as date),createDate,doc
			end
		end		  
	if(@statment='SoldeCreditFournisseur')
		begin
			 SELECT e.codeFournisseur,e.idFournisseur,e.nomFournisseur, ISNULL(SUM(e.TT_ttc*d.valCaisse),0) AS credit,
			 isnull((SELECT ISNULL(SUM(r.montant),0) AS debit
			  FROM r_Reglement r
			  INNER JOIN e_TypeDoc d ON r.codeType = d.codeType
			  WHERE d.valCaisse <> 0 AND r.idDossier = d.idDossier and r.idFournisseur=e.idFournisseur and r.idDossier=@idDossier
			  group by r.idFournisseur,r.nom),0) AS debit
			  FROM e_tableEntet e
			  INNER JOIN e_TypeDoc d ON e.codeType = d.codeType 
			  WHERE (e.codeType='BLFFR' OR e.codeType='BAVFR') and e.idDossier=d.idDossier and e.valider=1 and e.idDossier=@idDossier
			  group by e.codeFournisseur,e.idFournisseur,e.nomFournisseur
		end			
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_CompteFournisseurFish]
  (
  @idDossier int=null,
  @idFournisseur int=null,
  @dateStart datetime,
  @dateEnd datetime,
  @statment varchar(100)='EtatFournisseur')
  as begin
	if(@statment='EtatFournisseur')
		begin
			if(@idFournisseur=-1)
			begin
				select e.*,fet.* from v_fish_EntetSelect as e 
				left join fish_entetLign fet on e.idEntet=fet.idEntet
				where e.valider=1 and e.idFournisseur is not null and e.idDossier=@idDossier 
				and dateEntet between @dateStart and @dateEnd
			end
			else
			begin
				select e.*,fet.* from v_fish_EntetSelect e
				left join fish_entetLign fet on e.idEntet=fet.idEntet
				where e.valider=1 and e.idFournisseur=@idFournisseur and e.idDossier=@idDossier 
				and dateEntet between @dateStart and @dateEnd
			end
			
		end
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [t_EtatAchatFish]
  (
  @idDossier int=null,
  @dateStart datetime,
  @dateEnd datetime)
  as begin
	select e.*,fet.* from v_fish_EntetSelect as e 
	left join fish_entetLign fet on e.idEntet=fet.idEntet
	where e.idFournisseur is not null and e.idDossier=@idDossier 
	and dateEntet between @dateStart and @dateEnd
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_EtatProductionFish]
  (
  @idDossier int=null,
  @dateStart datetime,
  @dateEnd datetime)
  as begin
  select * from e_Entet as ee inner join e_EntetLign as el on ee.idEntet=el.idEntet where dateEntet between @dateStart and @dateEnd
  --select * from e_Entet as ee inner join e_EntetLign as el on ee.idEntet=el.idEntet   where dateEntet between '01-04-2024' and '01-05-2024'

	--select * from e_EntetLign as eel inner join e_Entet as ee on eel.idEntet=ee.idEntet   where MONTH(dateEntet)=3 and YEAR(dateEntet)=2024
	
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_EtatProductionFish_calc_mp_montant]
  (
  @idDossier int=null,
  @date date)
  as begin
	select ISNULL(sum(stockEntree),0) as MP,ISNULL(sum(totalAchat),0) as MONTANT from v_fish_EntetSelect where dateEntet = @date
  end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_FournisseurInsertUpdate](
@idFournisseur int=null,
@codeFournisseur nvarchar(50)=null,
@nomFournisseur nvarchar(200)=null,
@adresseFournisseur nvarchar(200)=null,
@postalFournisseur nvarchar(50)=null,
@iceFournisseur nvarchar(50)=null,
@cnssFournisseur nvarchar(50)=null,
@nifFournisseur nvarchar(50)=null,
@patenteFournisseur nvarchar(50)=null,
@siegeFournisseur nvarchar(50)=null,
@banqueFournisseur nvarchar(50)=null,
@ribFournisseur nvarchar(50)=null,
@soldAutoriseFournisseur money = 0,
@frmJuridiqueFournisseur nvarchar(50)=null,
@emailFournisseur nvarchar(250)=null,
@teleFournisseur nvarchar(250)=null,
@fixFournisseur nvarchar(250)=null,
@typeFournisseur nvarchar(250)=null,
@contratFournisseur bit = 0,
@fournisseur bit = 0,
@sous_traitance bit = 0,
@idVille int=null,
@idPays int =null,
@idUser nvarchar(450) =null,
@idGroup int =null,
@cinFournisseur nvarchar(50)=null,
@potentielFR nvarchar(500)=null,
@categorieFR nvarchar(500)=null,
@origineContactFR nvarchar(500)=null,
@sitewebFr nvarchar(max)=null,
@statment varchar(100)
)
as begin
	if(@statment='insert')
	begin
		insert t_Fournisseur(codeFournisseur,
		nomFournisseur,adresseFournisseur,postalFournisseur,
		iceFournisseur,cnssFournisseur,nifFournisseur,
		patenteFournisseur,siegeFournisseur,banqueFournisseur,
		ribFournisseur,soldAutoriseFournisseur,frmJuridiqueFournisseur,
		emailFournisseur,teleFournisseur,fixFournisseur,
		typeFournisseur,contratFournisseur,fournisseur,sous_traitance,idVille,idPays,idUser,idGroup,cinFournisseur,potentielFR,categorieFR,origineContactFR,
		sitewebFr) 
		values (@codeFournisseur,
		@nomFournisseur,@adresseFournisseur,@postalFournisseur,
		@iceFournisseur,@cnssFournisseur,@nifFournisseur,
		@patenteFournisseur,@siegeFournisseur,@banqueFournisseur,
		@ribFournisseur,@soldAutoriseFournisseur,@frmJuridiqueFournisseur,
		@emailFournisseur,@teleFournisseur,@fixFournisseur,
		@typeFournisseur,@contratFournisseur,@fournisseur,@sous_traitance,@idVille,@idPays,@idUser,@idGroup,@cinFournisseur,@potentielFR,@categorieFR,
		@origineContactFR,@sitewebFr)
		select * from t_tableFournisseur where idFournisseur=@@IDENTITY
	end	
	else
	begin
		update t_Fournisseur set codeFournisseur=@codeFournisseur,
		nomFournisseur=@nomFournisseur,adresseFournisseur=@adresseFournisseur,postalFournisseur=@postalFournisseur,
		iceFournisseur=@iceFournisseur,cnssFournisseur=@cnssFournisseur,nifFournisseur=@nifFournisseur,
		patenteFournisseur=@patenteFournisseur,siegeFournisseur=@siegeFournisseur,banqueFournisseur=@banqueFournisseur,
		ribFournisseur=@ribFournisseur,soldAutoriseFournisseur=@soldAutoriseFournisseur,frmJuridiqueFournisseur=@frmJuridiqueFournisseur,
		emailFournisseur=@emailFournisseur,teleFournisseur=@teleFournisseur,fixFournisseur=@fixFournisseur,
		typeFournisseur=@typeFournisseur,contratFournisseur=@contratFournisseur,fournisseur=@fournisseur,sous_traitance=@sous_traitance,
		idVille=@idVille,idPays=@idPays,cinFournisseur=@cinFournisseur,potentielFR=@potentielFR,categorieFR=@categorieFR,origineContactFR=@origineContactFR,
		sitewebFr=@sitewebFr where idFournisseur=@idFournisseur
		select * from t_tableFournisseur where idFournisseur=@idFournisseur
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_Generateur_CL_FR](
@idGroup int,
@Statement varchar(100))
as 
begin
	if(@Statement='Client')
		begin 
			select top 1 codeClient from t_Client
			where idGroup=@idGroup and codeClient like 'CL[0-9]%' 
			order by CAST(SUBSTRING(codeClient + '0', PATINDEX('%[0-9]%', codeClient + '0'), LEN(codeClient + '0')) AS numeric) desc
		end
	if(@Statement='Fournisseur')
		begin 
			select top 1 codeFournisseur from t_Fournisseur
			where idGroup=@idGroup and codeFournisseur like 'FR[0-9]%' 
			order by CAST(SUBSTRING(codeFournisseur + '0', PATINDEX('%[0-9]%', codeFournisseur + '0'), LEN(codeFournisseur + '0')) AS numeric) desc
		end	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [t_ListEmailsParTiers](
@idGroup int=null,
@id int=null,
@typeTier nvarchar(200)
)
as begin
	if(@typeTier='Client')
	begin
		SELECT emailClient as email from t_Client where idClient=@id and idGroup=@idGroup
	end
	if(@typeTier='Fournisseur')
	begin
		SELECT emailFournisseur as email from t_Fournisseur where idFournisseur=@id and idGroup=@idGroup
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [t_SalarieInsertUpdate](
@idSalarie int=null,
@nomSalarie nvarchar(200)=null,
@prenomSalarie nvarchar(200)=null,
@age int=null,
@post nvarchar(50)=null,
@salaire float=null,
@DateEntree date=null,
@statment varchar(100)
)
as begin
	if(@statment='insert')
	begin
		insert into t_salarie(nomSalarie,prenomSalarie,age,post,salaire,DateEntree) 
		values 
		(@nomSalarie,@prenomSalarie,@age,@post,@salaire,@DateEntree)
		select * from t_salarie where idSalarie=@@IDENTITY
	end	
	else
	begin
		update t_salarie set nomSalarie=@nomSalarie,prenomSalarie=@prenomSalarie,age=@age,post=@post,salaire=@salaire,DateEntree=@DateEntree 
		where idSalarie=@idSalarie
		select * from t_salarie where idSalarie=@idSalarie
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [t_salarieSelect]
  (
  @dateStart date=null,
  @dateEnd date=null
  )
as begin
	if @dateStart !='' or @dateEnd !=''

	begin
	SELECT *
	  FROM t_salarie
	  where DateEntree between @dateStart and @dateEnd

	end
	else
	begin
		select * from t_salarie
	end
	
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [t_tableTier](
@idGroup int=null)
as begin
select id, code, nom, email, typeTier, idGroup, idUser
from(
select idClient as id,codeClient as code, nomClient as nom, emailClient as email, 'Client' as typeTier, idGroup, idUser 
from t_Client
union all
select idFournisseur as id,codeFournisseur as code,nomFournisseur as nom, emailFournisseur as email, 'Fournisseur' as typeTier , idGroup, idUser 
from t_Fournisseur
)as t where idGroup=@idGroup 
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [tr_MvmCaisse](@idDossier int,@dateD datetime,@dateF datetime,@idTreso int,@statement nvarchar(200)='table')
as begin 
if(@statement='table')
begin
 SELECT DISTINCT tbl.num, tbl.dateEntet, tbl.montantDepenses, tbl.montantRecettes, tbl.TypeDoc, tbl.codeType, tbl.nom
FROM (
  SELECT r.numReglement as num, r.dateReglement as dateEntet,
   (CASE WHEN d.valCaisse=-1 THEN r.montant ELSE 0 END) as montantDepenses,
    (CASE WHEN d.valCaisse=1 THEN r.montant ELSE 0 END) as montantRecettes,
    CASE WHEN r.codeType='ESPC' or r.codeType='ESPF' THEN 'Versement D''' + d.descType + ' - ' + r.nom
		WHEN r.codeType='IPYC' or r.codeType='IPYF' THEN  d.descType + ' N° : '+ r.numCheque + + ' - ' + r.nom
         WHEN r.codeType='PYC'  or r.codeType='PYF' THEN  d.descType + ' N° : '+ r.numCheque + + ' - ' + r.nom
         WHEN r.codeType='PRLCL'  or r.codeType='PRLFR' THEN ' Montant '+ d.descType + ' N° : '+ r.numCheque + + ' - ' + r.nom
         WHEN r.codeType='VRMBNQCL'  or r.codeType='VRMBNQFR' THEN ' Virement Reçu de ' + r.nom
         WHEN r.codeType='RNDF'  or r.codeType='RNDC' THEN ' Rendu de ' + r.nom
    END as TypeDoc, 
    r.codeType, r.nom
  FROM r_Reglement r
  INNER JOIN e_TypeDoc d ON r.codeType=d.codeType
   where r.idDossier=@idDossier and r.dateReglement between @dateD and @dateF and r.idTreso=@idTreso and (r.codeType<>'CHFFC' and r.codeType<>'CHFFF' 
   and r.codeType<>'EFFETCL' and r.codeType<>'EFFETFR')
) AS tbl
 union all 
 select t.numTresoEntet as num,t.dateTresoEntet as dateEntet,t.montant as montantDepenses,null as montantRecettes,
 'Dépenses de la caisse : '+tr.nameTreso as TypeDoc,t.codeType,'' as nom from tr_TresorerieEntet t
 inner join b_Tresorerie tr on tr.idTreso=t.idTreso
 where t.codeType='DPS' and t.idDossier=@idDossier and t.dateTresoEntet between @dateD and @dateF and t.idTreso=@idTreso
 union all
 select t.numTresoEntet as num,t.dateTresoEntet as dateEntet,null as montantDepenses,t.montant as montantRecettes,
 'Recettes de la caisse : '+tr.nameTreso as TypeDoc,t.codeType,'' as nom from tr_TresorerieEntet t
 inner join b_Tresorerie tr on tr.idTreso=t.idTreso
 where t.codeType='RCT' and t.idDossier=@idDossier and t.dateTresoEntet between @dateD and @dateF and t.idTreso=@idTreso 
 union all 
 select t.numTresoEntet as num,t.dateTresoEntet as dateEntet,t.montant as montantDepenses,null as montantRecettes,
 'Virement à la caisse : ' + tr.nameTreso as TypeDoc,t.codeType,'' as nom from tr_TresorerieEntet t
 inner join b_Tresorerie tr on tr.idTreso=t.idTreso_2
 where t.codeType='CPTCPT' and t.idDossier=@idDossier and t.dateTresoEntet between @dateD and @dateF and t.idTreso=@idTreso
 union all 
  select t.numTresoEntet as num,t.dateTresoEntet as dateEntet,null as montantDepenses,t.montant as montantRecettes,
  'Reçu du virement de la caisse : ' +tr.nameTreso as TypeDoc,t.codeType,'' as nom from tr_TresorerieEntet t
 inner join b_Tresorerie tr on tr.idTreso=t.idTreso
 where t.codeType='CPTCPT' and t.idDossier=@idDossier and t.dateTresoEntet between @dateD and @dateF and t.idTreso_2=@idTreso
end
else
begin
	select soldTresorerie from b_SoldTresorerie where idTreso=@idTreso and idDossier=@idDossier
end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [tr_TresoEntetInsertUpdate](
@idTresoEntet int =null,
@numTresoEntet int =null,
@dateTresoEntet datetime=null,
@dateEcheanche datetime=null,
@banque nvarchar(150)=null,
@numCheque nvarchar(150)=null,
@etatDoc nvarchar(50)='Validé',
@montant money=0,
@descTresoEntet nvarchar(300)=null,
@codeType varchar(20),
@idModRglm int=null,
@idTreso int=null,
@idTreso_2 int=null,
@idService int=null,
@idUser nvarchar(450)=null,
@idGroup int=null,
@idDossier int=null,
@statment varchar(100)='insert')
as begin
	if(@statment='insert')
	begin
		INSERT INTO tr_TresorerieEntet
           ([numTresoEntet]
           ,[dateTresoEntet]
           ,[dateEcheanche]
           ,[banque]
           ,[numCheque]
           ,[etatDoc]
           ,[montant]
           ,[descTresoEntet]
           ,[codeType]
           ,[idModRglm]
           ,[idTreso]
           ,[idTreso_2]
           ,[idService]
           ,[idUser]
           ,[idGroup]
           ,[idDossier])
     VALUES
           (@numTresoEntet
           ,@dateTresoEntet
           ,@dateEcheanche
           ,@banque
           ,@numCheque
           ,@etatDoc
           ,@montant
           ,@descTresoEntet
           ,@codeType
           ,@idModRglm
           ,@idTreso
           ,@idTreso_2
           ,@idService
           ,@idUser
           ,@idGroup
           ,@idDossier)
           update e_TypeDoc set numFacture=@numTresoEntet where idDossier=@idDossier and codeType=@codeType
      select * from tr_tableTresorerieEntet where  idTresoEntet=@@IDENTITY  
	end
	else 
	begin
		UPDATE tr_TresorerieEntet
		   SET [numTresoEntet] = @numTresoEntet
			  ,[dateTresoEntet] = @dateTresoEntet
			  ,[dateEcheanche] = @dateEcheanche
			  ,[banque] = @banque
			  ,[numCheque] = @numCheque
			  ,[etatDoc] = @etatDoc
			  ,[montant] = @montant
			  ,[descTresoEntet] = @descTresoEntet
			  ,[idModRglm] = @idModRglm
			  ,[idTreso] = @idTreso
			  ,[idTreso_2] = @idTreso_2
			  ,[idService] = @idService
		 WHERE idTresoEntet=@idTresoEntet
		select * from tr_tableTresorerieEntet where idTresoEntet=@idTresoEntet  
	end
end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [tr_TresoEntetSelect](
		@idUser nvarchar(450),
		@SelectDoc bit=null,
		@idDossier int=null,
		@codeType varchar(20),
		@dateStart datetime,
		@dateEnd datetime,
		@Filter varchar(100)='dateTresoEntet'
		)
		as begin
			if(@Filter='dateTresoEntet')
			begin
				select * from tr_tableTresorerieEntet where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and dateTresoEntet between @dateStart and @dateEnd and codeType=@codeType) 
											or (@SelectDoc=0 and idDossier=@idDossier and dateTresoEntet between @dateStart and @dateEnd and codeType=@codeType))
			end
			else 
			begin
				select * from tr_tableTresorerieEntet where ((@SelectDoc=1 and idUser=@idUser and idDossier=@idDossier and dateEcheanche between @dateStart and @dateEnd and codeType=@codeType) 
											or (@SelectDoc=0 and idDossier=@idDossier and dateEcheanche between @dateStart and @dateEnd and codeType=@codeType))
			end
				
		end
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [u_UniteMesureInsertUpdate](
  @idUnite int=null,
  @descUnite nvarchar(100)=null,
  @prcpUnite bit,
  @idGroup int=null,
  @idUser nvarchar(450)=null,
  @SelectALL bit,
  @statment varchar(100))
  as begin
  if(@prcpUnite=1)
		begin
			if(@SelectALL=1)
				update u_UniteMesure set prcpUnite=0 where idUser=@idUser
			else
				update u_UniteMesure set prcpUnite=0 where idGroup=@idGroup	
		end
	if(@statment='insert')
	begin
		insert u_UniteMesure(descUnite,prcpUnite,idGroup,idUser) values (@descUnite,@prcpUnite,@idGroup,@idUser)
		select * from u_UniteMesure where idUnite=@@IDENTITY
	end
	else
	begin
		update u_UniteMesure set descUnite=@descUnite,prcpUnite=@prcpUnite where idUnite=@idUnite
		select * from u_UniteMesure where idUnite=@idUnite
	end
  end
GO
