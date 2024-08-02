using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;
using testdb.Models;

namespace ERP_Anass_backend
{
    public class DbContextERP : DbContext
    {
        public DbContextERP(DbContextOptions<DbContextERP> options) : base(options) { }
        public DbSet<Article> Article { get; set; }
        public DbSet<Familly> Familly { get; set; }
        public virtual DbSet<AArticle> AArticles { get; set; }

        public virtual DbSet<AArticleInFille> AArticleInFilles { get; set; }

        public virtual DbSet<ABateau> ABateaus { get; set; }

        public virtual DbSet<AFamille> AFamilles { get; set; }

        public virtual DbSet<BDepot> BDepots { get; set; }

        public virtual DbSet<BDepotSup> BDepotSups { get; set; }

        public virtual DbSet<BModRglm> BModRglms { get; set; }

        public virtual DbSet<BPay> BPays { get; set; }

        public virtual DbSet<BPropriete> BProprietes { get; set; }

        public virtual DbSet<BService> BServices { get; set; }

        public virtual DbSet<BSoldTresorerie> BSoldTresoreries { get; set; }

        public virtual DbSet<BTaxe> BTaxes { get; set; }

        public virtual DbSet<BTresorerie> BTresoreries { get; set; }

        public virtual DbSet<BVille> BVilles { get; set; }

        public virtual DbSet<DDepartement> DDepartements { get; set; }

        public virtual DbSet<EArtDepot> EArtDepots { get; set; }

        public virtual DbSet<EEmail> EEmails { get; set; }

        public virtual DbSet<EEntet> EEntets { get; set; }

        public virtual DbSet<EEntetLign> EEntetLigns { get; set; }

        public virtual DbSet<EFilleInEntet> EFilleInEntets { get; set; }

        public virtual DbSet<ETypeDoc> ETypeDocs { get; set; }

        public virtual DbSet<FFabrication> FFabrications { get; set; }

        public virtual DbSet<FFabricationLign> FFabricationLigns { get; set; }

        public virtual DbSet<FOrdre> FOrdres { get; set; }

        public virtual DbSet<FOrdreLine> FOrdreLines { get; set; }

        public virtual DbSet<FishCharge> FishCharges { get; set; }

        public virtual DbSet<FishEntet> FishEntets { get; set; }

        public virtual DbSet<FishEntetLign> FishEntetLigns { get; set; }

        public virtual DbSet<FishFamille> FishFamilles { get; set; }

        public virtual DbSet<FishNomScientifique> FishNomScientifiques { get; set; }

        public virtual DbSet<FishPort> FishPorts { get; set; }

        public virtual DbSet<FishTypeFamaille> FishTypeFamailles { get; set; }

        public virtual DbSet<HotelBBookingEntete> HotelBBookingEntetes { get; set; }

        public virtual DbSet<HotelBBookingExtra> HotelBBookingExtras { get; set; }

        public virtual DbSet<HotelBBookingInvite> HotelBBookingInvites { get; set; }

        public virtual DbSet<HotelBBookingLigne> HotelBBookingLignes { get; set; }

        public virtual DbSet<HotelBBookingPayment> HotelBBookingPayments { get; set; }

        public virtual DbSet<HotelBFilleInBookingEntete> HotelBFilleInBookingEntetes { get; set; }

        public virtual DbSet<HotelSCategorie> HotelSCategories { get; set; }

        public virtual DbSet<HotelSEquipement> HotelSEquipements { get; set; }

        public virtual DbSet<HotelSExtra> HotelSExtras { get; set; }

        public virtual DbSet<HotelSRoomCategorie> HotelSRoomCategories { get; set; }

        public virtual DbSet<HotelSRoomType> HotelSRoomTypes { get; set; }

        public virtual DbSet<HotelSUnit> HotelSUnits { get; set; }

        public virtual DbSet<MaintAEquipement> MaintAEquipements { get; set; }

        public virtual DbSet<MaintRRequest> MaintRRequests { get; set; }

        public virtual DbSet<MaintSMember> MaintSMembers { get; set; }

        public virtual DbSet<MaintSTeam> MaintSTeams { get; set; }

        public virtual DbSet<PCaissier> PCaissiers { get; set; }

        public virtual DbSet<PFamille> PFamilles { get; set; }

        public virtual DbSet<PModRglm> PModRglms { get; set; }

        public virtual DbSet<PPo> PPos { get; set; }

        public virtual DbSet<PSession> PSessions { get; set; }

        public virtual DbSet<PTicket> PTickets { get; set; }

        public virtual DbSet<PTicketLigne> PTicketLignes { get; set; }

        public virtual DbSet<PTicketReg> PTicketRegs { get; set; }

        public virtual DbSet<PaieCCotisation> PaieCCotisations { get; set; }

        public virtual DbSet<PaieCRubrique> PaieCRubriques { get; set; }

        public virtual DbSet<PaieCRubriquesExo> PaieCRubriquesExos { get; set; }

        public virtual DbSet<PaieCVariable> PaieCVariables { get; set; }

        public virtual DbSet<PaieCalculAvance> PaieCalculAvances { get; set; }

        public virtual DbSet<PaieCalculBulletin> PaieCalculBulletins { get; set; }

        public virtual DbSet<PaieCalculBulletinLigne> PaieCalculBulletinLignes { get; set; }

        public virtual DbSet<PaieCalculConge> PaieCalculConges { get; set; }

        public virtual DbSet<PaieCalculEntete> PaieCalculEntetes { get; set; }

        public virtual DbSet<PaieCalculGrpEntete> PaieCalculGrpEntetes { get; set; }

        public virtual DbSet<PaieCalculLigneRubrique> PaieCalculLigneRubriques { get; set; }

        public virtual DbSet<PaieEConge> PaieEConges { get; set; }

        public virtual DbSet<PaieEContrat> PaieEContrats { get; set; }

        public virtual DbSet<PaieEEmploye> PaieEEmployes { get; set; }

        public virtual DbSet<PaieEPret> PaieEPrets { get; set; }

        public virtual DbSet<PaieICategorie> PaieICategories { get; set; }

        public virtual DbSet<PaieIDepartement> PaieIDepartements { get; set; }

        public virtual DbSet<PaieIFonction> PaieIFonctions { get; set; }

        public virtual DbSet<PaieINiveau> PaieINiveaus { get; set; }

        public virtual DbSet<PaieIProfilContrat> PaieIProfilContrats { get; set; }

        public virtual DbSet<PaieITauxFraisProf> PaieITauxFraisProfs { get; set; }

        public virtual DbSet<PaiePPointage> PaiePPointages { get; set; }

        public virtual DbSet<PaiePPointageLigne> PaiePPointageLignes { get; set; }

        public virtual DbSet<PaieZLogDatum> PaieZLogData { get; set; }

        public virtual DbSet<PaieZPlanning> PaieZPlannings { get; set; }

        public virtual DbSet<PaieZUserDevice> PaieZUserDevices { get; set; }

        public virtual DbSet<PaieZZktdevice> PaieZZktdevices { get; set; }

        public virtual DbSet<RReglement> RReglements { get; set; }

        public virtual DbSet<RReglementInFille> RReglementInFilles { get; set; }

        public virtual DbSet<SDossier> SDossiers { get; set; }

        public virtual DbSet<SEmailsSetting> SEmailsSettings { get; set; }

        public virtual DbSet<SFille> SFilles { get; set; }

        public virtual DbSet<SGroupUser> SGroupUsers { get; set; }

        public virtual DbSet<SLiaisonUser> SLiaisonUsers { get; set; }

        public virtual DbSet<SMenu> SMenus { get; set; }

        public virtual DbSet<SMenuInstall> SMenuInstalls { get; set; }

        public virtual DbSet<SMenuSub> SMenuSubs { get; set; }

        public virtual DbSet<SMenuSubInstall> SMenuSubInstalls { get; set; }

        public virtual DbSet<SRole> SRoles { get; set; }

        public virtual DbSet<SSetting> SSettings { get; set; }

        public virtual DbSet<SUser> SUsers { get; set; }

        public virtual DbSet<SbCreationBarCode> SbCreationBarCodes { get; set; }

        public virtual DbSet<ScCalendar> ScCalendars { get; set; }

        public virtual DbSet<ScSchedule> ScSchedules { get; set; }

        public virtual DbSet<TClient> TClients { get; set; }

        public virtual DbSet<TClientCredit> TClientCredits { get; set; }

        public virtual DbSet<TFournisseur> TFournisseurs { get; set; }

        public virtual DbSet<TFournisseurCredit> TFournisseurCredits { get; set; }

        public virtual DbSet<TSalarie> TSalaries { get; set; }

        public virtual DbSet<TrTresorerieEntet> TrTresorerieEntets { get; set; }

        public virtual DbSet<UUniteMesure> UUniteMesures { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.idArticle);
                entity.HasOne(e => e.Familly)
                .WithMany(e => e.Article)
                .HasForeignKey(e => e.FamilyID)
                .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Familly>(entity =>
            {
                entity.HasKey(e => e.idFamilly);
                entity.HasMany(e => e.Article);
            });
            modelBuilder.Entity<AArticle>(entity =>
            {
                entity.HasKey(e => e.IdArticle).HasName("PK__a_Articl__6719B9B36422FA22");

                entity.ToTable("a_Article");

                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.AchatArticle).HasColumnName("achatArticle");
                entity.Property(e => e.CheckBateau).HasColumnName("checkBateau");
                entity.Property(e => e.CheckDureDevie).HasColumnName("checkDureDevie");
                entity.Property(e => e.CheckMaintenance).HasColumnName("checkMaintenance");
                entity.Property(e => e.ClassmentArticle)
                    .HasMaxLength(250)
                    .HasColumnName("classmentArticle");
                entity.Property(e => e.CodeBareArticle)
                    .HasMaxLength(500)
                    .HasColumnName("codeBareArticle");
                entity.Property(e => e.CodePdFini).HasColumnName("codePdFini");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DescArticle)
                    .HasMaxLength(500)
                    .HasColumnName("descArticle");
                entity.Property(e => e.DureDevie).HasColumnName("dureDevie");
                entity.Property(e => e.FavorisArticle).HasColumnName("favorisArticle");
                entity.Property(e => e.IdFamille).HasColumnName("idFamille");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdTaxeAchat).HasColumnName("idTaxeAchat");
                entity.Property(e => e.IdTaxeVente).HasColumnName("idTaxeVente");
                entity.Property(e => e.IdUnite).HasColumnName("idUnite");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdWooProducts).HasColumnName("idWooProducts");
                entity.Property(e => e.LocationArticle).HasColumnName("locationArticle");
                entity.Property(e => e.MesureArticle)
                    .HasMaxLength(50)
                    .HasColumnName("mesureArticle");
                entity.Property(e => e.MetaArticle).HasColumnName("metaArticle");
                entity.Property(e => e.MetaWooArticle).HasColumnName("metaWooArticle");
                entity.Property(e => e.NomArticle)
                    .HasMaxLength(500)
                    .HasColumnName("nomArticle");
                entity.Property(e => e.PhotoArticle)
                    .HasMaxLength(500)
                    .HasColumnName("photoArticle");
                entity.Property(e => e.PourCentArticle).HasColumnName("pourCentArticle");
                entity.Property(e => e.PrixAchatHt)
                    .HasColumnType("money")
                    .HasColumnName("prixAchat_HT");
                entity.Property(e => e.PrixAchatHt1)
                    .HasColumnType("money")
                    .HasColumnName("prixAchat_HT_1");
                entity.Property(e => e.PrixAchatTtc)
                    .HasColumnType("money")
                    .HasColumnName("prixAchat_TTC");
                entity.Property(e => e.PrixAchatTtc1)
                    .HasColumnType("money")
                    .HasColumnName("prixAchat_TTC_1");
                entity.Property(e => e.PrixVenteHt)
                    .HasColumnType("money")
                    .HasColumnName("prixVente_HT");
                entity.Property(e => e.PrixVenteHt1)
                    .HasColumnType("money")
                    .HasColumnName("prixVente_HT_1");
                entity.Property(e => e.PrixVenteHt2)
                    .HasColumnType("money")
                    .HasColumnName("prixVente_HT_2");
                entity.Property(e => e.PrixVenteTtc)
                    .HasColumnType("money")
                    .HasColumnName("prixVente_TTC");
                entity.Property(e => e.PrixVenteTtc1)
                    .HasColumnType("money")
                    .HasColumnName("prixVente_TTC_1");
                entity.Property(e => e.PrixVenteTtc2)
                    .HasColumnType("money")
                    .HasColumnName("prixVente_TTC_2");
                entity.Property(e => e.PrixlocationHt)
                    .HasColumnType("money")
                    .HasColumnName("prixlocation_HT");
                entity.Property(e => e.PrixlocationTtc)
                    .HasColumnType("money")
                    .HasColumnName("prixlocation_TTC");
                entity.Property(e => e.QteBox).HasColumnName("qteBox");
                entity.Property(e => e.RefArticle)
                    .HasMaxLength(500)
                    .HasColumnName("refArticle");
                entity.Property(e => e.StateDureDevie)
                    .HasMaxLength(100)
                    .HasColumnName("stateDureDevie");
                entity.Property(e => e.StkMinArticle).HasColumnName("stkMinArticle");
                entity.Property(e => e.TypeArticle)
                    .HasMaxLength(500)
                    .HasColumnName("typeArticle");
                entity.Property(e => e.VenteArticle).HasColumnName("venteArticle");
                entity.Property(e => e.WooArticle).HasColumnName("wooArticle");

                entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.AArticles)
                    .HasForeignKey(d => d.IdFamille)
                    .HasConstraintName("FK__a_Article__idFam__7C1A6C5A");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.AArticles)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__a_Article__idGro__7D0E9093");

                entity.HasOne(d => d.IdTaxeAchatNavigation).WithMany(p => p.AArticleIdTaxeAchatNavigations)
                    .HasForeignKey(d => d.IdTaxeAchat)
                    .HasConstraintName("FK__a_Article__idTax__7E02B4CC");

                entity.HasOne(d => d.IdTaxeVenteNavigation).WithMany(p => p.AArticleIdTaxeVenteNavigations)
                    .HasForeignKey(d => d.IdTaxeVente)
                    .HasConstraintName("FK__a_Article__idTax__7EF6D905");

                entity.HasOne(d => d.IdUniteNavigation).WithMany(p => p.AArticles)
                    .HasForeignKey(d => d.IdUnite)
                    .HasConstraintName("FK__a_Article__idUni__7FEAFD3E");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AArticles)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__a_Article__idUse__00DF2177");
            });

            modelBuilder.Entity<AArticleInFille>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("a_ArticleInFille");

                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.IdFille).HasColumnName("idFille");

                entity.HasOne(d => d.IdArticleNavigation).WithMany()
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("FK__a_Article__idArt__01D345B0");

                entity.HasOne(d => d.IdFilleNavigation).WithMany()
                    .HasForeignKey(d => d.IdFille)
                    .HasConstraintName("FK__a_Article__idFil__02C769E9");
            });

            modelBuilder.Entity<ABateau>(entity =>
            {
                entity.HasKey(e => e.IdBateau).HasName("PK__a_Bateau__8303C1652CEDC140");

                entity.ToTable("a_Bateau");

                entity.Property(e => e.IdBateau).HasColumnName("idBateau");
                entity.Property(e => e.CheckCollaboration).HasColumnName("checkCollaboration");
                entity.Property(e => e.Clotur).HasColumnName("clotur");
                entity.Property(e => e.DateDebut)
                    .HasColumnType("datetime")
                    .HasColumnName("dateDebut");
                entity.Property(e => e.DateFin)
                    .HasColumnType("datetime")
                    .HasColumnName("dateFin");
                entity.Property(e => e.DimensionX).HasColumnName("dimensionX");
                entity.Property(e => e.DimensionY).HasColumnName("dimensionY");
                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.PrixM)
                    .HasColumnType("money")
                    .HasColumnName("prixM");
                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.IdArticleNavigation).WithMany(p => p.ABateaus)
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("FK__a_Bateau__idArti__03BB8E22");

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.ABateaus)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__a_Bateau__idClie__04AFB25B");
            });

            modelBuilder.Entity<AFamille>(entity =>
            {
                entity.HasKey(e => e.IdFamille).HasName("PK__a_Famill__CC8A49782C7E39D3");

                entity.ToTable("a_Famille");

                entity.Property(e => e.IdFamille).HasColumnName("idFamille");
                entity.Property(e => e.CdeFao).HasColumnName("CDE_FAO");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DesFamille)
                    .HasMaxLength(500)
                    .HasColumnName("desFamille");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdNomScientifique).HasColumnName("idNomScientifique");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdTypeFamaille).HasColumnName("idTypeFamaille");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdWooCategories).HasColumnName("idWooCategories");
                entity.Property(e => e.NomFamille)
                    .HasMaxLength(250)
                    .HasColumnName("nomFamille");
                entity.Property(e => e.ParentId).HasColumnName("parentId");
                entity.Property(e => e.PhotoFamille).HasColumnName("photoFamille");
                entity.Property(e => e.WooFamille).HasColumnName("wooFamille");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.AFamilles)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__a_Famille__idGro__05A3D694");

                entity.HasOne(d => d.IdNomScientifiqueNavigation).WithMany(p => p.AFamilles)
                    .HasForeignKey(d => d.IdNomScientifique)
                    .HasConstraintName("FK_a_Famillefish_NomScientifique");

                entity.HasOne(d => d.IdPaysNavigation).WithMany(p => p.AFamilles)
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("FK_a_Famillefish_b_Pays");

                entity.HasOne(d => d.IdTypeFamailleNavigation).WithMany(p => p.AFamilles)
                    .HasForeignKey(d => d.IdTypeFamaille)
                    .HasConstraintName("FK_a_Famille_fish_TypeFamaille");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AFamilles)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__a_Famille__idUse__0697FACD");
            });

            modelBuilder.Entity<BDepot>(entity =>
            {
                entity.HasKey(e => e.IdDepot).HasName("PK__b_Depot__F1B853A3BEB7A511");

                entity.ToTable("b_Depot");

                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.AdressDepot)
                    .HasMaxLength(200)
                    .HasColumnName("adressDepot");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdVille).HasColumnName("idVille");
                entity.Property(e => e.NomDepot)
                    .HasMaxLength(100)
                    .HasColumnName("nomDepot");
                entity.Property(e => e.PrcpDepot).HasColumnName("prcpDepot");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BDepots)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_Depot__idGroup__0A688BB1");

                entity.HasOne(d => d.IdPaysNavigation).WithMany(p => p.BDepots)
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("FK__b_Depot__idPays__0B5CAFEA");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.BDepots)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__b_Depot__idUser__0C50D423");

                entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.BDepots)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK__b_Depot__idVille__0D44F85C");
            });

            modelBuilder.Entity<BDepotSup>(entity =>
            {
                entity.HasKey(e => e.IdSupDepot).HasName("PK__b_DepotS__411440C9D14DCF4D");

                entity.ToTable("b_DepotSup");

                entity.Property(e => e.IdSupDepot).HasColumnName("idSupDepot");
                entity.Property(e => e.CodeBare)
                    .HasMaxLength(100)
                    .HasColumnName("codeBare");
                entity.Property(e => e.CouloirX)
                    .HasMaxLength(100)
                    .HasColumnName("couloirX");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.Hauteur)
                    .HasMaxLength(100)
                    .HasColumnName("hauteur");
                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.InfoSupDepot)
                    .HasMaxLength(300)
                    .HasColumnName("infoSupDepot");
                entity.Property(e => e.NomSupDepot)
                    .HasMaxLength(100)
                    .HasColumnName("nomSupDepot");
                entity.Property(e => e.PrcpSupDepot).HasColumnName("prcpSupDepot");
                entity.Property(e => e.RayonY)
                    .HasMaxLength(100)
                    .HasColumnName("rayonY");
                entity.Property(e => e.TypeSupDepot)
                    .HasMaxLength(100)
                    .HasColumnName("typeSupDepot");

                entity.HasOne(d => d.IdDepotNavigation).WithMany(p => p.BDepotSups)
                    .HasForeignKey(d => d.IdDepot)
                    .HasConstraintName("FK__b_DepotSu__idDep__0E391C95");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BDepotSups)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_DepotSu__idGro__0F2D40CE");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.BDepotSups)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__b_DepotSu__idUse__10216507");
            });

            modelBuilder.Entity<BModRglm>(entity =>
            {
                entity.HasKey(e => e.IdModRglm).HasName("PK__b_ModRgl__07F252FE436F7847");

                entity.ToTable("b_ModRglm");

                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.CategModRglm)
                    .HasMaxLength(100)
                    .HasColumnName("categModRglm");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomModRglm)
                    .HasMaxLength(100)
                    .HasColumnName("nomModRglm");
                entity.Property(e => e.Timbre)
                    .HasColumnType("money")
                    .HasColumnName("timbre");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BModRglms)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_ModRglm__idGro__11158940");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.BModRglms)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__b_ModRglm__idUse__1209AD79");
            });

            modelBuilder.Entity<BPay>(entity =>
            {
                entity.HasKey(e => e.IdPays).HasName("PK__b_Pays__BD257B67F1018B34");

                entity.ToTable("b_Pays");

                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.NomPays)
                    .HasMaxLength(50)
                    .HasColumnName("nomPays");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BPays)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_Pays__idGroup__12FDD1B2");
            });

            modelBuilder.Entity<BPropriete>(entity =>
            {
                entity.HasKey(e => e.IdPropriete).HasName("PK__b_Propri__B315A60B58F0AEBB");

                entity.ToTable("b_Propriete");

                entity.Property(e => e.IdPropriete).HasColumnName("idPropriete");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomPropriete)
                    .HasMaxLength(500)
                    .HasColumnName("nomPropriete");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BProprietes)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_Proprie__idGro__13F1F5EB");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.BProprietes)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__b_Proprie__idUse__14E61A24");
            });

            modelBuilder.Entity<BService>(entity =>
            {
                entity.HasKey(e => e.IdService).HasName("PK__b_Servic__0E3EA45B6E72B811");

                entity.ToTable("b_Service");

                entity.Property(e => e.IdService).HasColumnName("idService");
                entity.Property(e => e.DescService)
                    .HasMaxLength(300)
                    .HasColumnName("descService");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomService)
                    .HasMaxLength(200)
                    .HasColumnName("nomService");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BServices)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_Service__idGro__15DA3E5D");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.BServices)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__b_Service__idUse__16CE6296");
            });

            modelBuilder.Entity<BSoldTresorerie>(entity =>
            {
                entity.HasKey(e => new { e.IdTreso, e.IdDossier }).HasName("PK__b_SoldTr__47A377971E1310B8");

                entity.ToTable("b_SoldTresorerie");

                entity.Property(e => e.IdTreso).HasColumnName("idTreso");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.SoldTresorerie)
                    .HasColumnType("money")
                    .HasColumnName("soldTresorerie");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.BSoldTresoreries)
                    .HasForeignKey(d => d.IdDossier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__b_SoldTre__idDos__17C286CF");

                entity.HasOne(d => d.IdTresoNavigation).WithMany(p => p.BSoldTresoreries)
                    .HasForeignKey(d => d.IdTreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__b_SoldTre__idTre__18B6AB08");
            });

            modelBuilder.Entity<BTaxe>(entity =>
            {
                entity.HasKey(e => e.IdTaxe).HasName("PK__b_Taxe__C3E11D6649505FF4");

                entity.ToTable("b_Taxe");

                entity.Property(e => e.IdTaxe).HasColumnName("idTaxe");
                entity.Property(e => e.CauxTaxe).HasColumnName("cauxTaxe");
                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.NomTaxe)
                    .HasMaxLength(100)
                    .HasColumnName("nomTaxe");
                entity.Property(e => e.TypeTaxe)
                    .HasMaxLength(100)
                    .HasColumnName("typeTaxe");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BTaxes)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_Taxe__idGroup__19AACF41");
            });

            modelBuilder.Entity<BTresorerie>(entity =>
            {
                entity.HasKey(e => e.IdTreso).HasName("PK__b_Tresor__0393F6035C83AC24");

                entity.ToTable("b_Tresorerie");

                entity.Property(e => e.IdTreso).HasColumnName("idTreso");
                entity.Property(e => e.AdresseTreso)
                    .HasMaxLength(100)
                    .HasColumnName("adresseTreso");
                entity.Property(e => e.CherfTreso)
                    .HasColumnType("money")
                    .HasColumnName("cherfTreso");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DefaultTreso).HasColumnName("defaultTreso");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NameTreso)
                    .HasMaxLength(100)
                    .HasColumnName("nameTreso");
                entity.Property(e => e.RibTreso)
                    .HasMaxLength(100)
                    .HasColumnName("ribTreso");
                entity.Property(e => e.SoldAutoriseTreso)
                    .HasColumnType("money")
                    .HasColumnName("soldAutoriseTreso");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BTresoreries)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_Tresore__idGro__1A9EF37A");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.BTresoreries)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__b_Tresore__idUse__1B9317B3");
            });

            modelBuilder.Entity<BVille>(entity =>
            {
                entity.HasKey(e => e.IdVille).HasName("PK__b_Ville__A33D0147277D3BB4");

                entity.ToTable("b_Ville");

                entity.Property(e => e.IdVille).HasColumnName("idVille");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.NomVille)
                    .HasMaxLength(50)
                    .HasColumnName("nomVille");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.BVilles)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__b_Ville__idGroup__1C873BEC");

                entity.HasOne(d => d.IdPaysNavigation).WithMany(p => p.BVilles)
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("fk_b_ville_b_pays");
            });

            modelBuilder.Entity<DDepartement>(entity =>
            {
                entity.HasKey(e => e.IdDepartement).HasName("PK__d_Depart__9E93B3EBF32C9097");

                entity.ToTable("d_Departement");

                entity.Property(e => e.IdDepartement).HasColumnName("idDepartement");
                entity.Property(e => e.DescDepartement)
                    .HasMaxLength(200)
                    .HasColumnName("descDepartement");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomDepartement)
                    .HasMaxLength(200)
                    .HasColumnName("nomDepartement");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.DDepartements)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__d_Departe__idGro__1E6F845E");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.DDepartements)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__d_Departe__idUse__1F63A897");
            });

            modelBuilder.Entity<EArtDepot>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("e_Art_Depot");

                entity.Property(e => e.Cmup)
                    .HasColumnType("money")
                    .HasColumnName("cmup");
                entity.Property(e => e.FirstPrix)
                    .HasColumnType("money")
                    .HasColumnName("firstPrix");
                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdSupDepot).HasColumnName("idSupDepot");
                entity.Property(e => e.LastPrix)
                    .HasColumnType("money")
                    .HasColumnName("lastPrix");
                entity.Property(e => e.QteDepot).HasColumnName("qteDepot");

                entity.HasOne(d => d.IdDepotNavigation).WithMany()
                    .HasForeignKey(d => d.IdDepot)
                    .HasConstraintName("FK__e_Art_Dep__idDep__2057CCD0");

                entity.HasOne(d => d.IdDossierNavigation).WithMany()
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__e_Art_Dep__idDos__214BF109");

                entity.HasOne(d => d.IdSupDepotNavigation).WithMany()
                    .HasForeignKey(d => d.IdSupDepot)
                    .HasConstraintName("FK__e_Art_Dep__idSup__22401542");
            });

            modelBuilder.Entity<EEmail>(entity =>
            {
                entity.HasKey(e => e.IdEmail).HasName("PK__e_Emails__DF5377108F312834");

                entity.ToTable("e_Emails");

                entity.Property(e => e.IdEmail).HasColumnName("idEmail");
                entity.Property(e => e.Attachements).HasColumnName("attachements");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateEmail)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEmail");
                entity.Property(e => e.Folder)
                    .HasMaxLength(300)
                    .HasColumnName("folder");
                entity.Property(e => e.FromName).HasColumnName("fromName");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Message).HasColumnName("message");
                entity.Property(e => e.Seen).HasColumnName("seen");
                entity.Property(e => e.Subject).HasColumnName("subject");
                entity.Property(e => e.To).HasColumnName("to");
                entity.Property(e => e.Uid)
                    .HasMaxLength(200)
                    .HasColumnName("uid");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.EEmails)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__e_Emails__idGrou__2334397B");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.EEmails)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__e_Emails__idUser__24285DB4");

                entity.HasMany(d => d.IdFilles).WithMany(p => p.IdEmails)
                    .UsingEntity<Dictionary<string, object>>(
                        "EFilleInEmail",
                        r => r.HasOne<SFille>().WithMany()
                            .HasForeignKey("IdFille")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__e_FilleIn__idFil__336AA144"),
                        l => l.HasOne<EEmail>().WithMany()
                            .HasForeignKey("IdEmail")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__e_FilleIn__idEma__32767D0B"),
                        j =>
                        {
                            j.HasKey("IdEmail", "IdFille").HasName("PK__e_FilleI__46347D03E0F491FE");
                            j.ToTable("e_FilleInEmails");
                            j.IndexerProperty<int>("IdEmail").HasColumnName("idEmail");
                            j.IndexerProperty<int>("IdFille").HasColumnName("idFille");
                        });
            });

            modelBuilder.Entity<EEntet>(entity =>
            {
                entity.HasKey(e => e.IdEntet).HasName("PK__e_Entet__53DEA1117F1E3259");

                entity.ToTable("e_Entet");

                entity.Property(e => e.IdEntet).HasColumnName("idEntet");
                entity.Property(e => e.Avance)
                    .HasColumnType("money")
                    .HasColumnName("avance");
                entity.Property(e => e.CertificatEuro).HasColumnName("certificatEuro");
                entity.Property(e => e.ChangeDh).HasColumnName("changeDH");
                entity.Property(e => e.CheckCopierVers).HasColumnName("checkCopierVers");
                entity.Property(e => e.CheckExpiration).HasColumnName("checkExpiration");
                entity.Property(e => e.Clotur).HasColumnName("clotur");
                entity.Property(e => e.CodeType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codeType");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateEcheanche)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEcheanche");
                entity.Property(e => e.DateEntet)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEntet");
                entity.Property(e => e.DateValidation)
                    .HasColumnType("datetime")
                    .HasColumnName("dateValidation");
                entity.Property(e => e.DetlpPlt).HasColumnName("DETLP_plt");
                entity.Property(e => e.EtatDoc)
                    .HasMaxLength(50)
                    .HasColumnName("etatDoc");
                entity.Property(e => e.ExpeditoLpPlt).HasColumnName("expeditoLP_plt");
                entity.Property(e => e.ExpeditoPPlt).HasColumnName("expeditoP_plt");
                entity.Property(e => e.FactureLpPlt).HasColumnName("factureLP_plt");
                entity.Property(e => e.FacturePPlt).HasColumnName("factureP_plt");
                entity.Property(e => e.FechaLpPlt).HasColumnName("fechaLP_plt");
                entity.Property(e => e.FechaPPlt).HasColumnName("fechaP_plt");
                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.IdDepot2).HasColumnName("idDepot_2");
                entity.Property(e => e.IdDestinataire).HasColumnName("idDestinataire");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdEntetS).HasColumnName("idEntetS");
                entity.Property(e => e.IdFamille).HasColumnName("idFamille");
                entity.Property(e => e.IdFournisseur).HasColumnName("idFournisseur");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdVendeur).HasColumnName("idVendeur");
                entity.Property(e => e.Info)
                    .HasMaxLength(150)
                    .HasColumnName("info");
                entity.Property(e => e.Lote).HasColumnName("lote");
                entity.Property(e => e.LotePf).HasColumnName("LotePF");
                entity.Property(e => e.Meta).HasColumnName("meta");
                entity.Property(e => e.MetaImpression).HasColumnName("metaImpression");
                entity.Property(e => e.Nom)
                    .HasMaxLength(150)
                    .HasColumnName("nom");
                entity.Property(e => e.NomDestinataire).HasColumnName("nomDestinataire");
                entity.Property(e => e.NumCheq)
                    .HasMaxLength(50)
                    .HasColumnName("numCheq");
                entity.Property(e => e.NumFactur).HasColumnName("numFactur");
                entity.Property(e => e.Obs)
                    .HasMaxLength(100)
                    .HasColumnName("obs");
                entity.Property(e => e.ProprieteClient).HasColumnName("proprieteClient");
                entity.Property(e => e.QuantiteLpPlt).HasColumnName("quantiteLP_plt");
                entity.Property(e => e.QuantitePPlt).HasColumnName("quantiteP_plt");
                entity.Property(e => e.RefFactur)
                    .HasMaxLength(50)
                    .HasColumnName("refFactur");
                entity.Property(e => e.RemiseGlobal)
                    .HasColumnType("money")
                    .HasColumnName("remiseGlobal");
                entity.Property(e => e.TauxPlastique).HasColumnName("tauxPlastique");
                entity.Property(e => e.Terms).HasColumnName("terms");
                entity.Property(e => e.TeypGlobal).HasColumnName("teypGlobal");
                entity.Property(e => e.Timbre).HasColumnName("timbre");
                entity.Property(e => e.Truck).HasColumnName("truck");
                entity.Property(e => e.TtHt)
                    .HasColumnType("money")
                    .HasColumnName("TT_ht");
                entity.Property(e => e.TtMargeCmup)
                    .HasColumnType("money")
                    .HasColumnName("TT_MargeCmup");
                entity.Property(e => e.TtMargePxAcha)
                    .HasColumnType("money")
                    .HasColumnName("TT_MargePxAcha");
                entity.Property(e => e.TtNet)
                    .HasColumnType("money")
                    .HasColumnName("TT_net");
                entity.Property(e => e.TtRemis)
                    .HasColumnType("money")
                    .HasColumnName("TT_remis");
                entity.Property(e => e.TtTauxMargeCmup)
                    .HasColumnType("money")
                    .HasColumnName("TT_TauxMargeCmup");
                entity.Property(e => e.TtTauxMargePxAcha)
                    .HasColumnType("money")
                    .HasColumnName("TT_TauxMargePxAcha");
                entity.Property(e => e.TtTtc)
                    .HasColumnType("money")
                    .HasColumnName("TT_ttc");
                entity.Property(e => e.TtTva)
                    .HasColumnType("money")
                    .HasColumnName("TT_tva");
                entity.Property(e => e.Ttc).HasColumnName("ttc");
                entity.Property(e => e.Tva).HasColumnName("tva");
                entity.Property(e => e.TypeLigne)
                    .HasMaxLength(500)
                    .HasColumnName("typeLigne");
                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.EEntets)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__e_Entet__idClien__251C81ED");

                entity.HasOne(d => d.IdDepotNavigation).WithMany(p => p.EEntetIdDepotNavigations)
                    .HasForeignKey(d => d.IdDepot)
                    .HasConstraintName("FK__e_Entet__idDepot__2610A626");

                entity.HasOne(d => d.IdDepot2Navigation).WithMany(p => p.EEntetIdDepot2Navigations)
                    .HasForeignKey(d => d.IdDepot2)
                    .HasConstraintName("FK__e_Entet__idDepot__2704CA5F");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.EEntets)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__e_Entet__idDossi__27F8EE98");

                entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.EEntets)
                    .HasForeignKey(d => d.IdFamille)
                    .HasConstraintName("FK_e_entet_a_famille");

                entity.HasOne(d => d.IdFournisseurNavigation).WithMany(p => p.EEntets)
                    .HasForeignKey(d => d.IdFournisseur)
                    .HasConstraintName("FK__e_Entet__idFourn__28ED12D1");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.EEntets)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__e_Entet__idGroup__29E1370A");

                entity.HasOne(d => d.IdModRglmNavigation).WithMany(p => p.EEntets)
                    .HasForeignKey(d => d.IdModRglm)
                    .HasConstraintName("FK__e_Entet__idModRg__2AD55B43");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.EEntets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__e_Entet__idUser__2BC97F7C");
            });

            modelBuilder.Entity<EEntetLign>(entity =>
            {
                entity.HasKey(e => e.IdLign).HasName("PK__e_EntetL__143910CCFFFD03D9");

                entity.ToTable("e_EntetLign");

                entity.Property(e => e.IdLign).HasColumnName("idLign");
                entity.Property(e => e.CodePdFini).HasColumnName("codePdFini");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateExpiration)
                    .HasColumnType("datetime")
                    .HasColumnName("dateExpiration");
                entity.Property(e => e.DateLigne)
                    .HasMaxLength(100)
                    .HasColumnName("dateLigne");
                entity.Property(e => e.DescLign).HasColumnName("descLign");
                entity.Property(e => e.DrainedNetWeight).HasColumnName("drainedNetWeight");
                entity.Property(e => e.FrozenDate).HasColumnName("frozenDate");
                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.IdEntet).HasColumnName("idEntet");
                entity.Property(e => e.IdSupDepot).HasColumnName("idSupDepot");
                entity.Property(e => e.IdSupDepot2).HasColumnName("idSupDepot_2");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.LastQte).HasColumnName("lastQte");
                entity.Property(e => e.LgnCmup)
                    .HasColumnType("money")
                    .HasColumnName("lgnCmup");
                entity.Property(e => e.LgnHt)
                    .HasColumnType("money")
                    .HasColumnName("lgnHT");
                entity.Property(e => e.LgnMargeCmup)
                    .HasColumnType("money")
                    .HasColumnName("lgnMargeCmup");
                entity.Property(e => e.LgnMargePxAcha)
                    .HasColumnType("money")
                    .HasColumnName("lgnMargePxAcha");
                entity.Property(e => e.LgnPxAcha)
                    .HasColumnType("money")
                    .HasColumnName("lgnPxAcha");
                entity.Property(e => e.LgnRemise)
                    .HasColumnType("money")
                    .HasColumnName("lgnRemise");
                entity.Property(e => e.LgnTauxMargeCmup)
                    .HasColumnType("money")
                    .HasColumnName("lgnTauxMargeCmup");
                entity.Property(e => e.LgnTauxMargePxAcha)
                    .HasColumnType("money")
                    .HasColumnName("lgnTauxMargePxAcha");
                entity.Property(e => e.LgnTtc)
                    .HasColumnType("money")
                    .HasColumnName("lgnTTC");
                entity.Property(e => e.LgnTva)
                    .HasColumnType("money")
                    .HasColumnName("lgnTVA");
                entity.Property(e => e.LgnUnite)
                    .HasMaxLength(100)
                    .HasColumnName("lgnUnite");
                entity.Property(e => e.LgnUrgence)
                    .HasMaxLength(100)
                    .HasColumnName("lgnUrgence");
                entity.Property(e => e.LgnValeurCmup)
                    .HasColumnType("money")
                    .HasColumnName("lgnValeurCmup");
                entity.Property(e => e.LgnValeurPxAcha)
                    .HasColumnType("money")
                    .HasColumnName("lgnValeurPxAcha");
                entity.Property(e => e.Lote).HasColumnName("lote");
                entity.Property(e => e.Meta).HasColumnName("meta");
                entity.Property(e => e.PrixHt)
                    .HasColumnType("money")
                    .HasColumnName("prixHT");
                entity.Property(e => e.PrixTtc)
                    .HasColumnType("money")
                    .HasColumnName("prixTTC");
                entity.Property(e => e.QteLign).HasColumnName("qteLign");
                entity.Property(e => e.QtebyDua).HasColumnName("qtebyDua");
                entity.Property(e => e.RefArticle)
                    .HasMaxLength(500)
                    .HasColumnName("refArticle");
                entity.Property(e => e.SortOrder).HasColumnName("sortOrder");
                entity.Property(e => e.ValCmup).HasColumnName("valCmup");
                entity.Property(e => e.ValStock).HasColumnName("valStock");

                entity.HasOne(d => d.IdArticleNavigation).WithMany(p => p.EEntetLigns)
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("FK__e_EntetLi__idArt__2DB1C7EE");

                entity.HasOne(d => d.IdEntetNavigation).WithMany(p => p.EEntetLigns)
                    .HasForeignKey(d => d.IdEntet)
                    .HasConstraintName("FK__e_EntetLi__idEnt__2EA5EC27");

                entity.HasOne(d => d.IdSupDepotNavigation).WithMany(p => p.EEntetLignIdSupDepotNavigations)
                    .HasForeignKey(d => d.IdSupDepot)
                    .HasConstraintName("FK__e_EntetLi__idSup__308E3499");

                entity.HasOne(d => d.IdSupDepot2Navigation).WithMany(p => p.EEntetLignIdSupDepot2Navigations)
                    .HasForeignKey(d => d.IdSupDepot2)
                    .HasConstraintName("FK__e_EntetLi__idSup__2F9A1060");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.EEntetLigns)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__e_EntetLi__idUse__318258D2");
            });

            modelBuilder.Entity<EFilleInEntet>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("e_FilleInEntet");

                entity.Property(e => e.IdEntet).HasColumnName("idEntet");
                entity.Property(e => e.IdFille).HasColumnName("idFille");

                entity.HasOne(d => d.IdEntetNavigation).WithMany()
                    .HasForeignKey(d => d.IdEntet)
                    .HasConstraintName("FK__e_FilleIn__idEnt__345EC57D");

                entity.HasOne(d => d.IdFilleNavigation).WithMany()
                    .HasForeignKey(d => d.IdFille)
                    .HasConstraintName("FK__e_FilleIn__idFil__3552E9B6");
            });

            modelBuilder.Entity<ETypeDoc>(entity =>
            {
                entity.HasKey(e => new { e.CodeType, e.IdDossier }).HasName("PK__e_TypeDo__DEFF6F468DB4A912");

                entity.ToTable("e_TypeDoc");

                entity.Property(e => e.CodeType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codeType");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.CalculMarge).HasColumnName("calculMarge");
                entity.Property(e => e.CodeClFr).HasColumnName("codeCl_FR");
                entity.Property(e => e.DescType)
                    .HasMaxLength(100)
                    .HasColumnName("descType");
                entity.Property(e => e.NomFacture)
                    .HasMaxLength(250)
                    .HasColumnName("nomFacture");
                entity.Property(e => e.NumFacture).HasColumnName("numFacture");
                entity.Property(e => e.ValCaisse).HasColumnName("valCaisse");
                entity.Property(e => e.ValCmup).HasColumnName("valCmup");
                entity.Property(e => e.ValFifo).HasColumnName("valFifo");
                entity.Property(e => e.ValLifo).HasColumnName("valLifo");
                entity.Property(e => e.ValStock).HasColumnName("valStock");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.ETypeDocs)
                    .HasForeignKey(d => d.IdDossier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__e_TypeDoc__idDos__36470DEF");
            });

            modelBuilder.Entity<FFabrication>(entity =>
            {
                entity.HasKey(e => e.IdFabrication).HasName("PK__f_Fabric__C10A431E8106A8EB");

                entity.ToTable("f_Fabrication");

                entity.Property(e => e.IdFabrication).HasColumnName("idFabrication");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Info)
                    .HasMaxLength(250)
                    .HasColumnName("info");
                entity.Property(e => e.Reference)
                    .HasMaxLength(200)
                    .HasColumnName("reference");

                entity.HasOne(d => d.IdArticleNavigation).WithMany(p => p.FFabrications)
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("FK__f_Fabrica__idArt__373B3228");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FFabrications)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__f_Fabrica__idGro__382F5661");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.FFabrications)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__f_Fabrica__idUse__39237A9A");
            });

            modelBuilder.Entity<FFabricationLign>(entity =>
            {
                entity.HasKey(e => e.IdLignFab).HasName("PK__f_Fabric__F8C72471FCD7CE4D");

                entity.ToTable("f_FabricationLign");

                entity.Property(e => e.IdLignFab).HasColumnName("idLignFab");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdFabrication).HasColumnName("idFabrication");
                entity.Property(e => e.IdLignArticle).HasColumnName("idLignArticle");
                entity.Property(e => e.QteFabrication).HasColumnName("qteFabrication");
                entity.Property(e => e.QteLignFabrication).HasColumnName("qteLignFabrication");

                entity.HasOne(d => d.IdFabricationNavigation).WithMany(p => p.FFabricationLigns)
                    .HasForeignKey(d => d.IdFabrication)
                    .HasConstraintName("FK__f_Fabrica__idFab__3A179ED3");

                entity.HasOne(d => d.IdLignArticleNavigation).WithMany(p => p.FFabricationLigns)
                    .HasForeignKey(d => d.IdLignArticle)
                    .HasConstraintName("FK__f_Fabrica__idLig__3B0BC30C");
            });

            modelBuilder.Entity<FOrdre>(entity =>
            {
                entity.HasKey(e => e.IdOrdre).HasName("PK__f_Ordre__C8AD1C42449B5826");

                entity.ToTable("f_Ordre");

                entity.Property(e => e.IdOrdre).HasColumnName("idOrdre");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateEndPlanification)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEndPlanification");
                entity.Property(e => e.DatePlanification)
                    .HasColumnType("datetime")
                    .HasColumnName("datePlanification");
                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdFabrication).HasColumnName("idFabrication");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdSupDepot).HasColumnName("idSupDepot");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NumOrdre).HasColumnName("numOrdre");
                entity.Property(e => e.NumberPerson).HasColumnName("numberPerson");
                entity.Property(e => e.PositionOrdre).HasColumnName("positionOrdre");
                entity.Property(e => e.ProgressType)
                    .HasMaxLength(100)
                    .HasColumnName("progressType");
                entity.Property(e => e.QteOrdre).HasColumnName("qteOrdre");
                entity.Property(e => e.TtHt)
                    .HasColumnType("money")
                    .HasColumnName("ttHT");
                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.IdArticleNavigation).WithMany(p => p.FOrdres)
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("FK__f_Ordre__idArtic__3BFFE745");

                entity.HasOne(d => d.IdDepotNavigation).WithMany(p => p.FOrdres)
                    .HasForeignKey(d => d.IdDepot)
                    .HasConstraintName("FK__f_Ordre__idDepot__3CF40B7E");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.FOrdres)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__f_Ordre__idDossi__3DE82FB7");

                entity.HasOne(d => d.IdFabricationNavigation).WithMany(p => p.FOrdres)
                    .HasForeignKey(d => d.IdFabrication)
                    .HasConstraintName("FK__f_Ordre__idFabri__3EDC53F0");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FOrdres)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__f_Ordre__idGroup__3FD07829");

                entity.HasOne(d => d.IdSupDepotNavigation).WithMany(p => p.FOrdres)
                    .HasForeignKey(d => d.IdSupDepot)
                    .HasConstraintName("FK__f_Ordre__idSupDe__40C49C62");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.FOrdres)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__f_Ordre__idUser__41B8C09B");
            });

            modelBuilder.Entity<FOrdreLine>(entity =>
            {
                entity.HasKey(e => e.IdOrdreLine).HasName("PK__f_OrdreL__A8F09F55E111731B");

                entity.ToTable("f_OrdreLine");

                entity.Property(e => e.IdOrdreLine).HasColumnName("idOrdreLine");
                entity.Property(e => e.Cmup)
                    .HasColumnType("money")
                    .HasColumnName("cmup");
                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdLignArticle).HasColumnName("idLignArticle");
                entity.Property(e => e.IdOrdre).HasColumnName("idOrdre");
                entity.Property(e => e.IdSupDepot).HasColumnName("idSupDepot");
                entity.Property(e => e.QteOrdreLine).HasColumnName("qteOrdreLine");
                entity.Property(e => e.TtHt)
                    .HasColumnType("money")
                    .HasColumnName("ttHT");
                entity.Property(e => e.TypeOrdre)
                    .HasMaxLength(10)
                    .HasColumnName("typeOrdre");
                entity.Property(e => e.ValStock).HasColumnName("valStock");

                entity.HasOne(d => d.IdDepotNavigation).WithMany(p => p.FOrdreLines)
                    .HasForeignKey(d => d.IdDepot)
                    .HasConstraintName("FK__f_OrdreLi__idDep__42ACE4D4");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.FOrdreLines)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__f_OrdreLi__idDos__43A1090D");

                entity.HasOne(d => d.IdLignArticleNavigation).WithMany(p => p.FOrdreLines)
                    .HasForeignKey(d => d.IdLignArticle)
                    .HasConstraintName("FK__f_OrdreLi__idLig__44952D46");

                entity.HasOne(d => d.IdOrdreNavigation).WithMany(p => p.FOrdreLines)
                    .HasForeignKey(d => d.IdOrdre)
                    .HasConstraintName("FK__f_OrdreLi__idOrd__4589517F");

                entity.HasOne(d => d.IdSupDepotNavigation).WithMany(p => p.FOrdreLines)
                    .HasForeignKey(d => d.IdSupDepot)
                    .HasConstraintName("FK__f_OrdreLi__idSup__467D75B8");
            });

            modelBuilder.Entity<FishCharge>(entity =>
            {
                entity.HasKey(e => e.IdCharge).HasName("PK__fish_cha__5B96E1AC749E3A9D");

                entity.ToTable("fish_charge");

                entity.Property(e => e.IdCharge).HasColumnName("idCharge");
                entity.Property(e => e.Cout).HasColumnName("cout");
                entity.Property(e => e.IdEntet).HasColumnName("idEntet");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdService).HasColumnName("idService");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FishCharges)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_charge_s_GroupUsers");

                entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.FishCharges)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("FK_fish_charge_b_Service");
            });

            modelBuilder.Entity<FishEntet>(entity =>
            {
                entity.HasKey(e => e.IdEntet).HasName("PK__fish_ent__53DEA1113C7FFD0D");

                entity.ToTable("fish_entet");

                entity.Property(e => e.IdEntet).HasColumnName("idEntet");
                entity.Property(e => e.Barco).HasColumnName("barco");
                entity.Property(e => e.Clotur).HasColumnName("clotur");
                entity.Property(e => e.CodeType).HasColumnName("codeType");
                entity.Property(e => e.Comission).HasColumnName("comission");
                entity.Property(e => e.DateCongele).HasColumnName("dateCongele");
                entity.Property(e => e.DateEntet).HasColumnName("dateEntet");
                entity.Property(e => e.DateLPlt).HasColumnName("dateL_plt");
                entity.Property(e => e.DatePlt).HasColumnName("date_plt");
                entity.Property(e => e.Dua).HasColumnName("DUA");
                entity.Property(e => e.DuaLPlt).HasColumnName("duaL_plt");
                entity.Property(e => e.DuaPlt).HasColumnName("dua_plt");
                entity.Property(e => e.Etat).HasColumnName("ETAT");
                entity.Property(e => e.EtatDoc)
                    .HasMaxLength(50)
                    .HasColumnName("etatDoc");
                entity.Property(e => e.FacturNumLPlt).HasColumnName("facturNumL_plt");
                entity.Property(e => e.FacturNumPlt).HasColumnName("facturNum_plt");
                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdEntetS).HasColumnName("idEntetS");
                entity.Property(e => e.IdFamille).HasColumnName("idFamille");
                entity.Property(e => e.IdFournisseur).HasColumnName("idFournisseur");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdPort).HasColumnName("idPort");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.KgRec).HasColumnName("kgRec");
                entity.Property(e => e.LoteLPlt).HasColumnName("LoteL_plt");
                entity.Property(e => e.NumBonLPlt).HasColumnName("numBonL_plt");
                entity.Property(e => e.NumBonPlt).HasColumnName("numBon_plt");
                entity.Property(e => e.NumFactur).HasColumnName("numFactur");
                entity.Property(e => e.Pm).HasColumnName("PM");
                entity.Property(e => e.QuantiteLPlt).HasColumnName("quantiteL_plt");
                entity.Property(e => e.QuantitePlt).HasColumnName("quantite_plt");
                entity.Property(e => e.RefFacture).HasColumnName("refFacture");
                entity.Property(e => e.StockEntree).HasColumnName("stockEntree");
                entity.Property(e => e.StockTaxable).HasColumnName("stockTaxable");
                entity.Property(e => e.TotalAchat).HasColumnName("totalAchat");
                entity.Property(e => e.TotalCharges).HasColumnName("totalCharges");
                entity.Property(e => e.TotalPn).HasColumnName("TotalPN");
                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.FishEntets)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK_fish_entet_t_Client");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.FishEntets)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("fk_fish_entet_s_dossier");

                entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.FishEntets)
                    .HasForeignKey(d => d.IdFamille)
                    .HasConstraintName("FK_fish_entet_a_Famille");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FishEntets)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK_fish_entet_s_GroupUsers");

                entity.HasOne(d => d.IdPaysNavigation).WithMany(p => p.FishEntets)
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("fk_fish_entet_b_Pays");

                entity.HasOne(d => d.IdPortNavigation).WithMany(p => p.FishEntets)
                    .HasForeignKey(d => d.IdPort)
                    .HasConstraintName("fk_fish_entet_fish_port");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.FishEntets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_fish_entet_s_User");
            });

            modelBuilder.Entity<FishEntetLign>(entity =>
            {
                entity.HasKey(e => e.IdLign).HasName("PK__fish_ent__143910CC6021B68B");

                entity.ToTable("fish_entetLign");

                entity.Property(e => e.IdLign).HasColumnName("idLign");
                entity.Property(e => e.Cais).HasColumnName("cais");
                entity.Property(e => e.CaisInvt).HasColumnName("caisINVT");
                entity.Property(e => e.Calibre).HasColumnName("calibre");
                entity.Property(e => e.CodePlt).HasColumnName("CodePLT");
                entity.Property(e => e.DescLign).HasColumnName("descLign");
                entity.Property(e => e.IdEntet).HasColumnName("idEntet");
                entity.Property(e => e.IdFamille).HasColumnName("idFamille");
                entity.Property(e => e.Pn).HasColumnName("PN");
                entity.Property(e => e.Pninvt).HasColumnName("PNINVT");
                entity.Property(e => e.Prix).HasColumnName("prix");
                entity.Property(e => e.PrixTotal).HasColumnName("prixTotal");
                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.HasOne(d => d.IdEntetNavigation).WithMany(p => p.FishEntetLigns)
                    .HasForeignKey(d => d.IdEntet)
                    .HasConstraintName("FK_fish_entetLign_fish_entet");

                entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.FishEntetLigns)
                    .HasForeignKey(d => d.IdFamille)
                    .HasConstraintName("FK_fish_entetLign_a_famille");
            });

            modelBuilder.Entity<FishFamille>(entity =>
            {
                entity.HasKey(e => e.IdFamille).HasName("PK__fish_famille");

                entity.ToTable("fish_famille");

                entity.Property(e => e.IdFamille).HasColumnName("idFamille");
                entity.Property(e => e.CdeFao).HasColumnName("CDE_FAO");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdNomScientifique).HasColumnName("idNomScientifique");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdTypeFamaille).HasColumnName("idTypeFamaille");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Marchandises).HasColumnName("marchandises");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FishFamilles)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_famille_s_GroupUsers");

                entity.HasOne(d => d.IdNomScientifiqueNavigation).WithMany(p => p.FishFamilles)
                    .HasForeignKey(d => d.IdNomScientifique)
                    .HasConstraintName("FK_fish_famille_fish_NomScientifique");

                entity.HasOne(d => d.IdPaysNavigation).WithMany(p => p.FishFamilles)
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("FK_fish_famille_b_pays");

                entity.HasOne(d => d.IdTypeFamailleNavigation).WithMany(p => p.FishFamilles)
                    .HasForeignKey(d => d.IdTypeFamaille)
                    .HasConstraintName("FK_fish_famille_fish_TypeFamaille");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.FishFamilles)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_fish_famille_s_Users");
            });

            modelBuilder.Entity<FishNomScientifique>(entity =>
            {
                entity.HasKey(e => e.IdNomScientifique).HasName("PK__fish_Nom__8FBA4602A68646FB");

                entity.ToTable("fish_NomScientifique");

                entity.Property(e => e.IdNomScientifique).HasColumnName("idNomScientifique");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FishNomScientifiques)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_NomScientifique_s_GroupUsers");
            });

            modelBuilder.Entity<FishPort>(entity =>
            {
                entity.HasKey(e => e.IdPort).HasName("PK__fish_por__BE0CD9EE2D94B3B9");

                entity.ToTable("fish_port");

                entity.Property(e => e.IdPort).HasColumnName("idPort");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomPort).HasColumnName("nomPort");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FishPorts)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("fk_fish_port_s_GroupUsers");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.FishPorts)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("fk_fish_port_s_user");
            });

            modelBuilder.Entity<FishTypeFamaille>(entity =>
            {
                entity.HasKey(e => e.IdTypeFamaille).HasName("PK__fish_Typ__9820EADC476505A7");

                entity.ToTable("fish_TypeFamaille");

                entity.Property(e => e.IdTypeFamaille).HasColumnName("idTypeFamaille");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FishTypeFamailles)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_TypeFamaille_s_GroupUsers");
            });

            modelBuilder.Entity<HotelBBookingEntete>(entity =>
            {
                entity.HasKey(e => e.IdBookingEntete).HasName("PK__hotel_B___EF8BA5E9340E3854");

                entity.ToTable("hotel_B_BookingEntete");

                entity.Property(e => e.IdBookingEntete).HasColumnName("idBookingEntete");
                entity.Property(e => e.BookingInDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bookingInDate");
                entity.Property(e => e.BookingOutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bookingOutDate");
                entity.Property(e => e.Cancel).HasColumnName("cancel");
                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cancelDate");
                entity.Property(e => e.CheckIn).HasColumnName("checkIn");
                entity.Property(e => e.CheckInDate)
                    .HasColumnType("datetime")
                    .HasColumnName("checkInDate");
                entity.Property(e => e.CheckOut).HasColumnName("checkOut");
                entity.Property(e => e.CheckOutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("checkOutDate");
                entity.Property(e => e.Comment).HasColumnName("comment");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.InfoClients).HasColumnName("infoClients");
                entity.Property(e => e.Message).HasColumnName("message");
                entity.Property(e => e.NbNights).HasColumnName("nbNights");
                entity.Property(e => e.NumBooking).HasColumnName("numBooking");
                entity.Property(e => e.TotalEnteteHt)
                    .HasColumnType("money")
                    .HasColumnName("totalEnteteHT");
                entity.Property(e => e.TotalEnteteTtc)
                    .HasColumnType("money")
                    .HasColumnName("totalEnteteTTC");
                entity.Property(e => e.TotalEnteteUnPaye)
                    .HasColumnType("money")
                    .HasColumnName("totalEnteteUnPaye");
                entity.Property(e => e.TtNbGuest).HasColumnName("tt_NbGuest");

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.HotelBBookingEntetes)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__hotel_B_B__idCli__5A846E65");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.HotelBBookingEntetes)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__hotel_B_B__idDos__5B78929E");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.HotelBBookingEntetes)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__hotel_B_B__idGro__5C6CB6D7");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HotelBBookingEntetes)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__hotel_B_B__idUse__5D60DB10");
            });

            modelBuilder.Entity<HotelBBookingExtra>(entity =>
            {
                entity.HasKey(e => e.IdBookingExtra).HasName("PK__Hotel_B___C131B493378C5998");

                entity.ToTable("Hotel_B_BookingExtras");

                entity.Property(e => e.IdBookingExtra).HasColumnName("idBookingExtra");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.Description).HasColumnName("description");
                entity.Property(e => e.IdBookingEntete).HasColumnName("idBookingEntete");
                entity.Property(e => e.IdExtras).HasColumnName("idExtras");
                entity.Property(e => e.PrixExtra)
                    .HasColumnType("money")
                    .HasColumnName("prixExtra");
                entity.Property(e => e.Qte).HasColumnName("qte");
                entity.Property(e => e.TotalExtras)
                    .HasColumnType("money")
                    .HasColumnName("totalExtras");

                entity.HasOne(d => d.IdBookingEnteteNavigation).WithMany(p => p.HotelBBookingExtras)
                    .HasForeignKey(d => d.IdBookingEntete)
                    .HasConstraintName("FK__Hotel_B_B__idBoo__5E54FF49");

                entity.HasOne(d => d.IdExtrasNavigation).WithMany(p => p.HotelBBookingExtras)
                    .HasForeignKey(d => d.IdExtras)
                    .HasConstraintName("FK__Hotel_B_B__idExt__5F492382");
            });

            modelBuilder.Entity<HotelBBookingInvite>(entity =>
            {
                entity.HasKey(e => e.IdBookingInvite).HasName("PK__Hotel_B___8A4162E267075D60");

                entity.ToTable("Hotel_B_BookingInvites");

                entity.Property(e => e.IdBookingInvite).HasColumnName("idBookingInvite");
                entity.Property(e => e.AgeInvite).HasColumnName("ageInvite");
                entity.Property(e => e.CinInvite)
                    .HasMaxLength(20)
                    .HasColumnName("cinInvite");
                entity.Property(e => e.IdBookingEntete).HasColumnName("idBookingEntete");
                entity.Property(e => e.Nationalite)
                    .HasMaxLength(250)
                    .HasColumnName("nationalite");
                entity.Property(e => e.NomInvite)
                    .HasMaxLength(500)
                    .HasColumnName("nomInvite");
                entity.Property(e => e.PrenomInvite)
                    .HasMaxLength(500)
                    .HasColumnName("prenomInvite");
                entity.Property(e => e.SexeInvite)
                    .HasMaxLength(50)
                    .HasColumnName("sexeInvite");

                entity.HasOne(d => d.IdBookingEnteteNavigation).WithMany(p => p.HotelBBookingInvites)
                    .HasForeignKey(d => d.IdBookingEntete)
                    .HasConstraintName("FK__Hotel_B_B__idBoo__603D47BB");
            });

            modelBuilder.Entity<HotelBBookingLigne>(entity =>
            {
                entity.HasKey(e => e.IdBookingLigne).HasName("PK__Hotel_B___D0F4C35EB8625D64");

                entity.ToTable("Hotel_B_BookingLigne");

                entity.Property(e => e.IdBookingLigne).HasColumnName("idBookingLigne");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.Guests).HasColumnName("guests");
                entity.Property(e => e.IdBookingEntete).HasColumnName("idBookingEntete");
                entity.Property(e => e.IdRoomType).HasColumnName("idRoomType");
                entity.Property(e => e.IdUnit).HasColumnName("idUnit");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.LgnTva).HasColumnName("lgnTVA");
                entity.Property(e => e.PriceModel).HasColumnName("priceModel");
                entity.Property(e => e.PrixHt)
                    .HasColumnType("money")
                    .HasColumnName("prixHT");
                entity.Property(e => e.PrixTtc)
                    .HasColumnType("money")
                    .HasColumnName("prixTTC");
                entity.Property(e => e.TtprixHt)
                    .HasColumnType("money")
                    .HasColumnName("TTPrix_HT");
                entity.Property(e => e.TtprixTtc)
                    .HasColumnType("money")
                    .HasColumnName("TTPrix_TTC");

                entity.HasOne(d => d.IdBookingEnteteNavigation).WithMany(p => p.HotelBBookingLignes)
                    .HasForeignKey(d => d.IdBookingEntete)
                    .HasConstraintName("FK__Hotel_B_B__idBoo__61316BF4");

                entity.HasOne(d => d.IdRoomTypeNavigation).WithMany(p => p.HotelBBookingLignes)
                    .HasForeignKey(d => d.IdRoomType)
                    .HasConstraintName("FK__Hotel_B_B__idRoo__6225902D");

                entity.HasOne(d => d.IdUnitNavigation).WithMany(p => p.HotelBBookingLignes)
                    .HasForeignKey(d => d.IdUnit)
                    .HasConstraintName("FK__Hotel_B_B__idUni__6319B466");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HotelBBookingLignes)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Hotel_B_B__idUse__640DD89F");
            });

            modelBuilder.Entity<HotelBBookingPayment>(entity =>
            {
                entity.HasKey(e => e.IdBookingPayment).HasName("PK__Hotel_B___0E4EF227B98C8182");

                entity.ToTable("Hotel_B_BookingPayment");

                entity.Property(e => e.IdBookingPayment).HasColumnName("idBookingPayment");
                entity.Property(e => e.Comment).HasColumnName("comment");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DatePayment)
                    .HasColumnType("datetime")
                    .HasColumnName("datePayment");
                entity.Property(e => e.IdBookingEntete).HasColumnName("idBookingEntete");
                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.Montant)
                    .HasColumnType("money")
                    .HasColumnName("montant");

                entity.HasOne(d => d.IdBookingEnteteNavigation).WithMany(p => p.HotelBBookingPayments)
                    .HasForeignKey(d => d.IdBookingEntete)
                    .HasConstraintName("FK__Hotel_B_B__idBoo__6501FCD8");

                entity.HasOne(d => d.IdModRglmNavigation).WithMany(p => p.HotelBBookingPayments)
                    .HasForeignKey(d => d.IdModRglm)
                    .HasConstraintName("FK__Hotel_B_B__idMod__65F62111");
            });

            modelBuilder.Entity<HotelBFilleInBookingEntete>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("hotel_B_FilleInBookingEntete");

                entity.Property(e => e.IdBookingEntete).HasColumnName("idBookingEntete");
                entity.Property(e => e.IdFille).HasColumnName("idFille");

                entity.HasOne(d => d.IdBookingEnteteNavigation).WithMany()
                    .HasForeignKey(d => d.IdBookingEntete)
                    .HasConstraintName("FK__hotel_B_F__idBoo__66EA454A");

                entity.HasOne(d => d.IdFilleNavigation).WithMany()
                    .HasForeignKey(d => d.IdFille)
                    .HasConstraintName("FK__hotel_B_F__idFil__67DE6983");
            });

            modelBuilder.Entity<HotelSCategorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie).HasName("PK__hotel_S___8A3D24089B0DDAC1");

                entity.ToTable("hotel_S_Categorie");

                entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");
                entity.Property(e => e.CategName)
                    .HasMaxLength(500)
                    .HasColumnName("categName");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.HotelSCategories)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__hotel_S_C__idGro__68D28DBC");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HotelSCategories)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__hotel_S_C__idUse__69C6B1F5");
            });

            modelBuilder.Entity<HotelSEquipement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("hotel_S_Equipements");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdRoomType).HasColumnName("idRoomType");
                entity.Property(e => e.TextEquip).HasColumnName("textEquip");
                entity.Property(e => e.ValeurEquip)
                    .HasMaxLength(500)
                    .HasColumnName("valeurEquip");

                entity.HasOne(d => d.IdRoomTypeNavigation).WithMany()
                    .HasForeignKey(d => d.IdRoomType)
                    .HasConstraintName("FK__hotel_S_E__idRoo__6ABAD62E");
            });

            modelBuilder.Entity<HotelSExtra>(entity =>
            {
                entity.HasKey(e => e.IdExtras).HasName("PK__hotel_S___56B7E5378449ABA0");

                entity.ToTable("hotel_S_Extras");

                entity.Property(e => e.IdExtras).HasColumnName("idExtras");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DescExtras).HasColumnName("descExtras");
                entity.Property(e => e.ExtrasName)
                    .HasMaxLength(500)
                    .HasColumnName("extrasName");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdTaxeExtras).HasColumnName("idTaxeExtras");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.PhotoExtras).HasColumnName("photoExtras");
                entity.Property(e => e.PrixHt)
                    .HasColumnType("money")
                    .HasColumnName("prix_HT");
                entity.Property(e => e.PrixTtc)
                    .HasColumnType("money")
                    .HasColumnName("prix_TTC");
                entity.Property(e => e.QteMax)
                    .HasMaxLength(500)
                    .HasColumnName("qteMax");
                entity.Property(e => e.SortExtras).HasColumnName("sortExtras");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.HotelSExtras)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__hotel_S_E__idGro__6BAEFA67");

                entity.HasOne(d => d.IdTaxeExtrasNavigation).WithMany(p => p.HotelSExtras)
                    .HasForeignKey(d => d.IdTaxeExtras)
                    .HasConstraintName("FK__hotel_S_E__idTax__6CA31EA0");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HotelSExtras)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__hotel_S_E__idUse__6D9742D9");
            });

            modelBuilder.Entity<HotelSRoomCategorie>(entity =>
            {
                entity.HasKey(e => new { e.IdRoomType, e.IdCategorie });

                entity.ToTable("hotel_S_RoomCategorie");

                entity.Property(e => e.IdRoomType).HasColumnName("idRoomType");
                entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");
            });

            modelBuilder.Entity<HotelSRoomType>(entity =>
            {
                entity.HasKey(e => e.IdRoomType).HasName("PK__hotel_S___9D810D3FDD8616BB");

                entity.ToTable("hotel_S_RoomType");

                entity.Property(e => e.IdRoomType).HasColumnName("idRoomType");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DescRoomType).HasColumnName("descRoomType");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdTaxeLouer).HasColumnName("idTaxeLouer");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.MaxNbGuests).HasColumnName("maxNbGuests");
                entity.Property(e => e.NameRoomType)
                    .HasMaxLength(500)
                    .HasColumnName("nameRoomType");
                entity.Property(e => e.NbGuests).HasColumnName("nbGuests");
                entity.Property(e => e.ObjectType)
                    .HasMaxLength(250)
                    .HasColumnName("objectType");
                entity.Property(e => e.PhotoRoomType)
                    .HasMaxLength(500)
                    .HasColumnName("photoRoomType");
                entity.Property(e => e.PriceModel).HasColumnName("priceModel");
                entity.Property(e => e.PrixLouerHt)
                    .HasColumnType("money")
                    .HasColumnName("prixLouer_HT");
                entity.Property(e => e.PrixVenteTtc)
                    .HasColumnType("money")
                    .HasColumnName("prixVente_TTC");
                entity.Property(e => e.SortOrder).HasColumnName("sortOrder");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.HotelSRoomTypes)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__hotel_S_R__idGro__6E8B6712");

                entity.HasOne(d => d.IdTaxeLouerNavigation).WithMany(p => p.HotelSRoomTypes)
                    .HasForeignKey(d => d.IdTaxeLouer)
                    .HasConstraintName("FK__hotel_S_R__idTax__6F7F8B4B");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HotelSRoomTypes)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__hotel_S_R__idUse__7073AF84");
            });

            modelBuilder.Entity<HotelSUnit>(entity =>
            {
                entity.HasKey(e => e.IdUnit).HasName("PK__hotel_S___34420721A31B2E3B");

                entity.ToTable("hotel_S_Units");

                entity.Property(e => e.IdUnit).HasColumnName("idUnit");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdRoomType).HasColumnName("idRoomType");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.UnitName)
                    .HasMaxLength(500)
                    .HasColumnName("unitName");

                entity.HasOne(d => d.IdRoomTypeNavigation).WithMany(p => p.HotelSUnits)
                    .HasForeignKey(d => d.IdRoomType)
                    .HasConstraintName("FK__hotel_S_U__idRoo__7167D3BD");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HotelSUnits)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__hotel_S_U__idUse__725BF7F6");
            });

            modelBuilder.Entity<MaintAEquipement>(entity =>
            {
                entity.HasKey(e => e.IdEquipement).HasName("PK__Maint_A___87E05D1F9B0D1F8B");

                entity.ToTable("Maint_A_Equipements");

                entity.Property(e => e.IdEquipement).HasColumnName("idEquipement");
                entity.Property(e => e.CoutEquipement)
                    .HasColumnType("money")
                    .HasColumnName("coutEquipement");
                entity.Property(e => e.DateEffet)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEffet");
                entity.Property(e => e.DateGarantie)
                    .HasColumnType("datetime")
                    .HasColumnName("dateGarantie");
                entity.Property(e => e.IdArticle).HasColumnName("idArticle");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdLign).HasColumnName("idLign");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.ModeleEquipement).HasColumnName("modeleEquipement");
                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(250)
                    .HasColumnName("numeroSerie");

                entity.HasOne(d => d.IdArticleNavigation).WithMany(p => p.MaintAEquipements)
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("FK__Maint_A_E__idArt__73501C2F");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.MaintAEquipements)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Maint_A_E__idGro__74444068");

                entity.HasOne(d => d.IdLignNavigation).WithMany(p => p.MaintAEquipements)
                    .HasForeignKey(d => d.IdLign)
                    .HasConstraintName("FK__Maint_A_E__idLig__753864A1");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.MaintAEquipements)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Maint_A_E__idUse__762C88DA");
            });

            modelBuilder.Entity<MaintRRequest>(entity =>
            {
                entity.HasKey(e => e.IdRequest).HasName("PK__Maint_R___F4A4109EE2C16E2E");

                entity.ToTable("Maint_R_Request");

                entity.Property(e => e.IdRequest).HasColumnName("idRequest");
                entity.Property(e => e.DateRequest)
                    .HasColumnType("datetime")
                    .HasColumnName("dateRequest");
                entity.Property(e => e.DescMaint).HasColumnName("descMaint");
                entity.Property(e => e.EtatRequest)
                    .HasMaxLength(250)
                    .HasColumnName("etatRequest");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdEquipement).HasColumnName("idEquipement");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdTeam).HasColumnName("idTeam");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.LieuMaint)
                    .HasMaxLength(250)
                    .HasColumnName("lieuMaint");
                entity.Property(e => e.NomRequest).HasColumnName("nomRequest");
                entity.Property(e => e.NumRequest).HasColumnName("numRequest");
                entity.Property(e => e.PositionOrdre).HasColumnName("positionOrdre");
                entity.Property(e => e.ProgressType)
                    .HasMaxLength(100)
                    .HasColumnName("progressType");
                entity.Property(e => e.TypeMaint)
                    .HasMaxLength(250)
                    .HasColumnName("typeMaint");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.MaintRRequests)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__Maint_R_R__idDos__7720AD13");

                entity.HasOne(d => d.IdEquipementNavigation).WithMany(p => p.MaintRRequests)
                    .HasForeignKey(d => d.IdEquipement)
                    .HasConstraintName("FK__Maint_R_R__idEqu__7814D14C");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.MaintRRequests)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Maint_R_R__idGro__7908F585");

                entity.HasOne(d => d.IdTeamNavigation).WithMany(p => p.MaintRRequests)
                    .HasForeignKey(d => d.IdTeam)
                    .HasConstraintName("FK__Maint_R_R__idTea__79FD19BE");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.MaintRRequests)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Maint_R_R__idUse__7AF13DF7");
            });

            modelBuilder.Entity<MaintSMember>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Maint_S_Member");

                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdFournisseur).HasColumnName("idFournisseur");
                entity.Property(e => e.IdMember)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idMember");
                entity.Property(e => e.IdTeam).HasColumnName("idTeam");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany()
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Maint_S_M__idEmp__7BE56230");

                entity.HasOne(d => d.IdFournisseurNavigation).WithMany()
                    .HasForeignKey(d => d.IdFournisseur)
                    .HasConstraintName("FK__Maint_S_M__idFou__7CD98669");

                entity.HasOne(d => d.IdTeamNavigation).WithMany()
                    .HasForeignKey(d => d.IdTeam)
                    .HasConstraintName("FK__Maint_S_M__idTea__7DCDAAA2");
            });

            modelBuilder.Entity<MaintSTeam>(entity =>
            {
                entity.HasKey(e => e.IdTeam).HasName("PK__Maint_S___BCD885CFE1376C3C");

                entity.ToTable("Maint_S_Team");

                entity.Property(e => e.IdTeam).HasColumnName("idTeam");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomTeam)
                    .HasMaxLength(500)
                    .HasColumnName("nomTeam");
                entity.Property(e => e.TypeTeam)
                    .HasMaxLength(500)
                    .HasColumnName("typeTeam");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.MaintSTeams)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Maint_S_T__idGro__7EC1CEDB");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.MaintSTeams)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Maint_S_T__idUse__7FB5F314");
            });

            modelBuilder.Entity<PCaissier>(entity =>
            {
                entity.HasKey(e => e.IdCaissier).HasName("PK__p_Caissi__A1A63F8DB2FF02F3");

                entity.ToTable("p_Caissier");

                entity.Property(e => e.IdCaissier).HasColumnName("idCaissier");
                entity.Property(e => e.AdminCaissier).HasColumnName("adminCaissier");
                entity.Property(e => e.AnulatinTicket).HasColumnName("anulatinTicket");
                entity.Property(e => e.ArchiveChecke).HasColumnName("archiveChecke");
                entity.Property(e => e.AvoirCheck).HasColumnName("avoirCheck");
                entity.Property(e => e.FermerCheck).HasColumnName("fermerCheck");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NameCaissier)
                    .HasMaxLength(200)
                    .HasColumnName("nameCaissier");
                entity.Property(e => e.PassCaissier)
                    .HasMaxLength(100)
                    .HasColumnName("passCaissier");
                entity.Property(e => e.PrixCheck).HasColumnName("prixCheck");
                entity.Property(e => e.RemCheck).HasColumnName("remCheck");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PCaissiers)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__p_Caissie__idGro__00AA174D");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PCaissiers)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__p_Caissie__idUse__019E3B86");
            });

            modelBuilder.Entity<PFamille>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("p_Famille");

                entity.Property(e => e.IdFamille).HasColumnName("idFamille");
                entity.Property(e => e.IdPos).HasColumnName("idPos");

                entity.HasOne(d => d.IdFamilleNavigation).WithMany()
                    .HasForeignKey(d => d.IdFamille)
                    .HasConstraintName("FK__p_Famille__idFam__02925FBF");

                entity.HasOne(d => d.IdPosNavigation).WithMany()
                    .HasForeignKey(d => d.IdPos)
                    .HasConstraintName("FK__p_Famille__idPos__038683F8");
            });

            modelBuilder.Entity<PModRglm>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("p_ModRglm");

                entity.Property(e => e.Defaults).HasColumnName("defaults");
                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.IdPos).HasColumnName("idPos");

                entity.HasOne(d => d.IdModRglmNavigation).WithMany()
                    .HasForeignKey(d => d.IdModRglm)
                    .HasConstraintName("FK__p_ModRglm__idMod__047AA831");

                entity.HasOne(d => d.IdPosNavigation).WithMany()
                    .HasForeignKey(d => d.IdPos)
                    .HasConstraintName("FK__p_ModRglm__idPos__056ECC6A");
            });

            modelBuilder.Entity<PPo>(entity =>
            {
                entity.HasKey(e => e.IdPos).HasName("PK__p_Pos__3D78A0B7B32D34E0");

                entity.ToTable("p_Pos");

                entity.Property(e => e.IdPos).HasColumnName("idPos");
                entity.Property(e => e.CheckEmail).HasColumnName("checkEmail");
                entity.Property(e => e.CheckOpenSession).HasColumnName("checkOpenSession");
                entity.Property(e => e.ClientDivers).HasColumnName("clientDivers");
                entity.Property(e => e.EmailSend)
                    .HasMaxLength(200)
                    .HasColumnName("emailSend");
                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdTreso).HasColumnName("idTreso");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.MsgPos)
                    .HasMaxLength(200)
                    .HasColumnName("msgPos");
                entity.Property(e => e.NamePos)
                    .HasMaxLength(200)
                    .HasColumnName("namePos");
                entity.Property(e => e.SouTitrePos)
                    .HasMaxLength(500)
                    .HasColumnName("souTitrePos");
                entity.Property(e => e.TitrePos)
                    .HasMaxLength(200)
                    .HasColumnName("titrePos");
                entity.Property(e => e.TokenPos).HasColumnName("tokenPos");

                entity.HasOne(d => d.ClientDiversNavigation).WithMany(p => p.PPos)
                    .HasForeignKey(d => d.ClientDivers)
                    .HasConstraintName("FK__p_Pos__clientDiv__0662F0A3");

                entity.HasOne(d => d.IdDepotNavigation).WithMany(p => p.PPos)
                    .HasForeignKey(d => d.IdDepot)
                    .HasConstraintName("FK__p_Pos__idDepot__075714DC");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.PPos)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__p_Pos__idDossier__084B3915");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PPos)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__p_Pos__idGroup__093F5D4E");

                entity.HasOne(d => d.IdTresoNavigation).WithMany(p => p.PPos)
                    .HasForeignKey(d => d.IdTreso)
                    .HasConstraintName("FK__p_Pos__idTreso__0A338187");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PPos)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__p_Pos__idUser__0B27A5C0");
            });

            modelBuilder.Entity<PSession>(entity =>
            {
                entity.HasKey(e => e.IdSession).HasName("PK__p_Sessio__ADE2668F5D786F8C");

                entity.ToTable("p_Session");

                entity.Property(e => e.IdSession).HasColumnName("idSession");
                entity.Property(e => e.CaissierClose).HasColumnName("caissierClose");
                entity.Property(e => e.CaissierOpen).HasColumnName("caissierOpen");
                entity.Property(e => e.Closed).HasColumnName("closed");
                entity.Property(e => e.DateClose)
                    .HasColumnType("datetime")
                    .HasColumnName("dateClose");
                entity.Property(e => e.DateOpen)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOpen");
                entity.Property(e => e.IdPos).HasColumnName("idPos");
                entity.Property(e => e.SoldeClose)
                    .HasColumnType("money")
                    .HasColumnName("soldeClose");
                entity.Property(e => e.SoldeOpen)
                    .HasColumnType("money")
                    .HasColumnName("soldeOpen");
                entity.Property(e => e.TotalCaissier)
                    .HasColumnType("money")
                    .HasColumnName("totalCaissier");

                entity.HasOne(d => d.CaissierCloseNavigation).WithMany(p => p.PSessionCaissierCloseNavigations)
                    .HasForeignKey(d => d.CaissierClose)
                    .HasConstraintName("FK__p_Session__caiss__0D0FEE32");

                entity.HasOne(d => d.CaissierOpenNavigation).WithMany(p => p.PSessionCaissierOpenNavigations)
                    .HasForeignKey(d => d.CaissierOpen)
                    .HasConstraintName("FK__p_Session__caiss__0C1BC9F9");

                entity.HasOne(d => d.IdPosNavigation).WithMany(p => p.PSessions)
                    .HasForeignKey(d => d.IdPos)
                    .HasConstraintName("FK__p_Session__idPos__0E04126B");
            });

            modelBuilder.Entity<PTicket>(entity =>
            {
                entity.HasKey(e => e.IdTicket).HasName("PK__p_Ticket__22B1456F3065CB00");

                entity.ToTable("p_Ticket");

                entity.Property(e => e.IdTicket).HasColumnName("idTicket");
                entity.Property(e => e.DateCancel)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCancel");
                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreation");
                entity.Property(e => e.IdCaissier).HasColumnName("idCaissier");
                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.IdSession).HasColumnName("idSession");
                entity.Property(e => e.IsCancel).HasColumnName("isCancel");
                entity.Property(e => e.IsClosed).HasColumnName("isClosed");
                entity.Property(e => e.NumTicket).HasColumnName("numTicket");
                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdCaissierNavigation).WithMany(p => p.PTickets)
                    .HasForeignKey(d => d.IdCaissier)
                    .HasConstraintName("FK__p_Ticket__idCais__0EF836A4");

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.PTickets)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__p_Ticket__idClie__0FEC5ADD");

                entity.HasOne(d => d.IdSessionNavigation).WithMany(p => p.PTickets)
                    .HasForeignKey(d => d.IdSession)
                    .HasConstraintName("FK__p_Ticket__idSess__10E07F16");
            });

            modelBuilder.Entity<PTicketLigne>(entity =>
            {
                entity.HasKey(e => e.IdLigne).HasName("PK__p_Ticket__408FD6F4123DC466");

                entity.ToTable("p_Ticket_ligne");

                entity.Property(e => e.IdLigne).HasColumnName("idLigne");
                entity.Property(e => e.CheckVenduGrand).HasColumnName("checkVenduGrand");
                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreation");
                entity.Property(e => e.IdTicket).HasColumnName("idTicket");
                entity.Property(e => e.Idproduct).HasColumnName("idproduct");
                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");
                entity.Property(e => e.Qte).HasColumnName("qte");
                entity.Property(e => e.Rem).HasColumnName("rem");
                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("total");
                entity.Property(e => e.Umvente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("umvente");

                entity.HasOne(d => d.IdTicketNavigation).WithMany(p => p.PTicketLignes)
                    .HasForeignKey(d => d.IdTicket)
                    .HasConstraintName("FK__p_Ticket___idTic__12C8C788");

                entity.HasOne(d => d.IdproductNavigation).WithMany(p => p.PTicketLignes)
                    .HasForeignKey(d => d.Idproduct)
                    .HasConstraintName("FK__p_Ticket___idpro__11D4A34F");
            });

            modelBuilder.Entity<PTicketReg>(entity =>
            {
                entity.HasKey(e => e.IdPaiment).HasName("PK__p_Ticket__430DC81233861774");

                entity.ToTable("p_Ticket_Reg");

                entity.Property(e => e.IdPaiment).HasColumnName("idPaiment");
                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.IdTicket).HasColumnName("idTicket");
                entity.Property(e => e.Mantant)
                    .HasColumnType("money")
                    .HasColumnName("mantant");

                entity.HasOne(d => d.IdModRglmNavigation).WithMany(p => p.PTicketRegs)
                    .HasForeignKey(d => d.IdModRglm)
                    .HasConstraintName("FK__p_Ticket___idMod__13BCEBC1");

                entity.HasOne(d => d.IdTicketNavigation).WithMany(p => p.PTicketRegs)
                    .HasForeignKey(d => d.IdTicket)
                    .HasConstraintName("FK__p_Ticket___idTic__14B10FFA");
            });

            modelBuilder.Entity<PaieCCotisation>(entity =>
            {
                entity.HasKey(e => e.IdCotisation).HasName("PK__Paie_C_C__6159288BFAC35F45");

                entity.ToTable("Paie_C_Cotisations");

                entity.Property(e => e.IdCotisation).HasColumnName("idCotisation");
                entity.Property(e => e.AllFamilial).HasColumnName("allFamilial");
                entity.Property(e => e.CodeCotis).HasColumnName("codeCotis");
                entity.Property(e => e.CotisationPatr).HasColumnName("cotisationPatr");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.FormationProf).HasColumnName("formationProf");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.LibelleCotis)
                    .HasMaxLength(500)
                    .HasColumnName("libelleCotis");
                entity.Property(e => e.PartSalariel).HasColumnName("partSalariel");
                entity.Property(e => e.Plafond).HasColumnName("plafond");
                entity.Property(e => e.PrestationSoc).HasColumnName("prestationSoc");
                entity.Property(e => e.TauxMajoration1).HasColumnName("tauxMajoration1");
                entity.Property(e => e.TauxMajorationAutres).HasColumnName("tauxMajorationAutres");
                entity.Property(e => e.TauxPenalite).HasColumnName("tauxPenalite");
                entity.Property(e => e.TypeCoti)
                    .HasMaxLength(100)
                    .HasColumnName("typeCoti");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieCCotisations)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_C_Co__idEmp__15A53433");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieCCotisations)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_C_Co__idGro__1699586C");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieCCotisations)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_C_Co__idUse__178D7CA5");
            });

            modelBuilder.Entity<PaieCRubrique>(entity =>
            {
                entity.HasKey(e => e.IdRubrique).HasName("PK__Paie_C_R__72CA0C17E9CC074A");

                entity.ToTable("Paie_C_Rubriques");

                entity.Property(e => e.IdRubrique).HasColumnName("idRubrique");
                entity.Property(e => e.CodeExo).HasColumnName("codeExo");
                entity.Property(e => e.CodeRubrique).HasColumnName("codeRubrique");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Imposable).HasColumnName("imposable");
                entity.Property(e => e.LibelleRubrique)
                    .HasMaxLength(500)
                    .HasColumnName("libelleRubrique");
                entity.Property(e => e.Positive).HasColumnName("positive");
                entity.Property(e => e.Taux).HasColumnName("taux");
                entity.Property(e => e.TauxMajoration1).HasColumnName("tauxMajoration1");
                entity.Property(e => e.TauxMajorationAutres).HasColumnName("tauxMajorationAutres");
                entity.Property(e => e.TauxPenalite).HasColumnName("tauxPenalite");
                entity.Property(e => e.Valeur).HasColumnName("valeur");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieCRubriques)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_C_Ru__idGro__1881A0DE");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieCRubriques)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_C_Ru__idUse__1975C517");
            });

            modelBuilder.Entity<PaieCRubriquesExo>(entity =>
            {
                entity.HasKey(e => e.IdExo).HasName("PK__Paie_C_R__3F0AA960AF69F1C7");

                entity.ToTable("Paie_C_RubriquesExo");

                entity.Property(e => e.IdExo).HasColumnName("idExo");
                entity.Property(e => e.CodeExo)
                    .HasMaxLength(200)
                    .HasColumnName("codeExo");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.LibelleExo)
                    .HasMaxLength(500)
                    .HasColumnName("libelleExo");
            });

            modelBuilder.Entity<PaieCVariable>(entity =>
            {
                entity.HasKey(e => e.IdVariable).HasName("PK__Paie_C_V__EF2620BCC122025B");

                entity.ToTable("Paie_C_Variables");

                entity.Property(e => e.IdVariable).HasColumnName("idVariable");
                entity.Property(e => e.CodeVar)
                    .HasMaxLength(100)
                    .HasColumnName("codeVar");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.LibelleVar)
                    .HasMaxLength(500)
                    .HasColumnName("libelleVar");
                entity.Property(e => e.PropreSal).HasColumnName("propreSal");
                entity.Property(e => e.ValeurVar)
                    .HasColumnType("money")
                    .HasColumnName("valeurVar");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieCVariables)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_C_Va__idGro__1A69E950");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieCVariables)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_C_Va__idUse__1B5E0D89");
            });

            modelBuilder.Entity<PaieCalculAvance>(entity =>
            {
                entity.HasKey(e => e.IdAvance).HasName("PK__Paie_Cal__B1657DC64C0008D9");

                entity.ToTable("Paie_Calcul_Avance");

                entity.Property(e => e.IdAvance).HasColumnName("idAvance");
                entity.Property(e => e.Cloturer).HasColumnName("cloturer");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateAvance)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAvance");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Montant)
                    .HasColumnType("money")
                    .HasColumnName("montant");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieCalculAvances)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_Calc__idEmp__1C5231C2");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieCalculAvances)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_Calc__idGro__1D4655FB");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieCalculAvances)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_Calc__idUse__1E3A7A34");
            });

            modelBuilder.Entity<PaieCalculBulletin>(entity =>
            {
                entity.HasKey(e => e.IdBulletin).HasName("PK__Paie_Cal__66989D1EC8F3C161");

                entity.ToTable("Paie_Calcul_bulletin");

                entity.Property(e => e.Cloturer).HasColumnName("cloturer");
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");
                entity.Property(e => e.DescPaie).HasColumnName("descPaie");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Mois).HasColumnName("mois");
                entity.Property(e => e.NumBulletin).HasColumnName("numBulletin");
                entity.Property(e => e.PeriodeD)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeD");
                entity.Property(e => e.PeriodeF)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeF");
                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.PaieCalculBulletins)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("fk_Paie_Calcul_bulletin_dossier");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieCalculBulletins)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("fk_Paie_Calcul_bulletin_groupUser");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieCalculBulletins)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("fk_Paie_Calcul_bulletin_user");
            });

            modelBuilder.Entity<PaieCalculBulletinLigne>(entity =>
            {
                entity.HasKey(e => e.IdBulletinLigne).HasName("PK__Paie_Cal__13B8C3BB214F0CFF");

                entity.ToTable("Paie_Calcul_bulletin_ligne");

                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.NbHeurSup).HasColumnName("nbHeurSup");
                entity.Property(e => e.NbJours).HasColumnName("nbJours");
                entity.Property(e => e.Nbconge).HasColumnName("nbconge");
                entity.Property(e => e.NombreHeurs).HasColumnName("nombreHeurs");
                entity.Property(e => e.SalaireTotal).HasColumnName("salaireTotal");
                entity.Property(e => e.TotalKgs).HasColumnName("totalKgs");
                entity.Property(e => e.TotalPrixKgs).HasColumnName("totalPrixKgs");
                entity.Property(e => e.TotalPrixSupp).HasColumnName("totalPrixSupp");

                entity.HasOne(d => d.IdBulletinNavigation).WithMany(p => p.PaieCalculBulletinLignes)
                    .HasForeignKey(d => d.IdBulletin)
                    .HasConstraintName("fk_Paie_Calcul_bulletin_ligne_bulletin");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieCalculBulletinLignes)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("fk_Paie_Calcul_bulletin_ligne_Employee");
            });

            modelBuilder.Entity<PaieCalculConge>(entity =>
            {
                entity.HasKey(e => e.IdCng).HasName("PK__Paie_Cal__398F16C83A17AFA3");

                entity.ToTable("Paie_Calcul_Conges");

                entity.Property(e => e.IdCng).HasColumnName("idCng");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NbJours).HasColumnName("nbJours");
                entity.Property(e => e.PeriodeDebut)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeDebut");
                entity.Property(e => e.PeriodeFin)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeFin");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.PaieCalculConges)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__Paie_Calc__idDos__23F3538A");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieCalculConges)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_Calc__idEmp__24E777C3");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieCalculConges)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_Calc__idGro__25DB9BFC");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieCalculConges)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_Calc__idUse__26CFC035");
            });

            modelBuilder.Entity<PaieCalculEntete>(entity =>
            {
                entity.HasKey(e => e.IdEntete).HasName("PK__Paie_Cal__D60AEBB80E676EE7");

                entity.ToTable("Paie_Calcul_Entete");

                entity.Property(e => e.IdEntete).HasColumnName("idEntete");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.HS0).HasColumnName("hS0");
                entity.Property(e => e.HS100).HasColumnName("hS100");
                entity.Property(e => e.HS25).HasColumnName("hS25");
                entity.Property(e => e.HS50).HasColumnName("hS50");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGrpEnt).HasColumnName("idGrpEnt");
                entity.Property(e => e.JoursTravail).HasColumnName("joursTravail");
                entity.Property(e => e.SalaireBase)
                    .HasColumnType("money")
                    .HasColumnName("salaireBase");
                entity.Property(e => e.TotalBrut)
                    .HasColumnType("money")
                    .HasColumnName("totalBrut");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieCalculEntetes)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_Calc__idEmp__27C3E46E");

                entity.HasOne(d => d.IdGrpEntNavigation).WithMany(p => p.PaieCalculEntetes)
                    .HasForeignKey(d => d.IdGrpEnt)
                    .HasConstraintName("FK__Paie_Calc__idGrp__28B808A7");
            });

            modelBuilder.Entity<PaieCalculGrpEntete>(entity =>
            {
                entity.HasKey(e => e.IdGrpEnt).HasName("PK__Paie_Cal__576CEFB610A65BCB");

                entity.ToTable("Paie_Calcul_GrpEntete");

                entity.Property(e => e.IdGrpEnt).HasColumnName("idGrpEnt");
                entity.Property(e => e.Cloturer).HasColumnName("cloturer");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DatePaie)
                    .HasColumnType("datetime")
                    .HasColumnName("datePaie");
                entity.Property(e => e.DescPaie).HasColumnName("descPaie");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Mois).HasColumnName("mois");
                entity.Property(e => e.NumPaie).HasColumnName("numPaie");
                entity.Property(e => e.PeriodeD)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeD");
                entity.Property(e => e.PeriodeF)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeF");
                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.PaieCalculGrpEntetes)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__Paie_Calc__idDos__29AC2CE0");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieCalculGrpEntetes)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_Calc__idGro__2AA05119");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieCalculGrpEntetes)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_Calc__idUse__2B947552");
            });

            modelBuilder.Entity<PaieCalculLigneRubrique>(entity =>
            {
                entity.HasKey(e => e.IdLigne).HasName("PK__Paie_Cal__408FD6F4B693FF52");

                entity.ToTable("Paie_Calcul_LigneRubrique");

                entity.Property(e => e.IdLigne).HasColumnName("idLigne");
                entity.Property(e => e.Base)
                    .HasColumnType("money")
                    .HasColumnName("base");
                entity.Property(e => e.CodeRubrique).HasColumnName("codeRubrique");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.Gains)
                    .HasColumnType("money")
                    .HasColumnName("gains");
                entity.Property(e => e.IdCotisation).HasColumnName("idCotisation");
                entity.Property(e => e.IdEntete).HasColumnName("idEntete");
                entity.Property(e => e.IdPret).HasColumnName("idPret");
                entity.Property(e => e.IdRubrique).HasColumnName("idRubrique");
                entity.Property(e => e.LibelleRubrique)
                    .HasMaxLength(500)
                    .HasColumnName("libelleRubrique");
                entity.Property(e => e.Position).HasColumnName("position");
                entity.Property(e => e.Retenues)
                    .HasColumnType("money")
                    .HasColumnName("retenues");
                entity.Property(e => e.Taux).HasColumnName("taux");
                entity.Property(e => e.TypeRubrique).HasColumnName("typeRubrique");
                entity.Property(e => e.Valeur).HasColumnName("valeur");

                entity.HasOne(d => d.IdEnteteNavigation).WithMany(p => p.PaieCalculLigneRubriques)
                    .HasForeignKey(d => d.IdEntete)
                    .HasConstraintName("FK__Paie_Calc__idEnt__2C88998B");
            });

            modelBuilder.Entity<PaieEConge>(entity =>
            {
                entity.HasKey(e => e.IdConge).HasName("PK__Paie_E_C__51C97AAB85C611E9");

                entity.ToTable("Paie_E_Conges");

                entity.Property(e => e.IdConge).HasColumnName("idConge");
                entity.Property(e => e.Annee).HasColumnName("annee");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.JCongeN).HasColumnName("jCongeN");
                entity.Property(e => e.JCongeN1).HasColumnName("jCongeN_1");
                entity.Property(e => e.JConsommes).HasColumnName("jConsommes");
                entity.Property(e => e.JRestes).HasColumnName("jRestes");
                entity.Property(e => e.NumberMonths).HasColumnName("numberMonths");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.PaieEConges)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__Paie_E_Co__idDos__2D7CBDC4");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieEConges)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_E_Co__idEmp__2E70E1FD");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieEConges)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_E_Co__idGro__2F650636");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieEConges)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_E_Co__idUse__30592A6F");
            });

            modelBuilder.Entity<PaieEContrat>(entity =>
            {
                entity.HasKey(e => e.IdContrat).HasName("PK__Paie_E_C__2A0DE1E8B3429FB7");

                entity.ToTable("Paie_E_Contrat");

                entity.Property(e => e.IdContrat).HasColumnName("idContrat");
                entity.Property(e => e.DateContrat)
                    .HasColumnType("datetime")
                    .HasColumnName("dateContrat");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdProfil).HasColumnName("idProfil");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NumContrat)
                    .HasMaxLength(200)
                    .HasColumnName("numContrat");
                entity.Property(e => e.ObservationC).HasColumnName("observationC");
                entity.Property(e => e.PeriodeD)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeD");
                entity.Property(e => e.PeriodeF)
                    .HasColumnType("datetime")
                    .HasColumnName("periodeF");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieEContrats)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_E_Co__idEmp__314D4EA8");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieEContrats)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_E_Co__idGro__324172E1");

                entity.HasOne(d => d.IdProfilNavigation).WithMany(p => p.PaieEContrats)
                    .HasForeignKey(d => d.IdProfil)
                    .HasConstraintName("FK__Paie_E_Co__idPro__3335971A");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieEContrats)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_E_Co__idUse__3429BB53");

                entity.HasMany(d => d.IdFilles).WithMany(p => p.IdContrats)
                    .UsingEntity<Dictionary<string, object>>(
                        "PaieEFilleInContrat",
                        r => r.HasOne<SFille>().WithMany()
                            .HasForeignKey("IdFille")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__Paie_E_Fi__idFil__3F9B6DFF"),
                        l => l.HasOne<PaieEContrat>().WithMany()
                            .HasForeignKey("IdContrat")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__Paie_E_Fi__idCon__3EA749C6"),
                        j =>
                        {
                            j.HasKey("IdContrat", "IdFille").HasName("PK__Paie_E_F__B36AEBFBC72E890A");
                            j.ToTable("Paie_E_FilleInContrat");
                            j.IndexerProperty<int>("IdContrat").HasColumnName("idContrat");
                            j.IndexerProperty<int>("IdFille").HasColumnName("idFille");
                        });
            });

            modelBuilder.Entity<PaieEEmploye>(entity =>
            {
                entity.HasKey(e => e.IdEmploye).HasName("PK__Paie_E_E__97B32F2A937E683A");

                entity.ToTable("Paie_E_Employe");

                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.Abattement).HasColumnName("abattement");
                entity.Property(e => e.Adresse)
                    .HasMaxLength(500)
                    .HasColumnName("adresse");
                entity.Property(e => e.Banque)
                    .HasMaxLength(200)
                    .HasColumnName("banque");
                entity.Property(e => e.BusStation)
                    .HasMaxLength(250)
                    .HasColumnName("busStation");
                entity.Property(e => e.CheckPointage).HasColumnName("checkPointage");
                entity.Property(e => e.CheckSortie).HasColumnName("checkSortie");
                entity.Property(e => e.CinEmployee)
                    .HasMaxLength(20)
                    .HasColumnName("cinEmployee");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateAssurRetraite)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAssurRetraite");
                entity.Property(e => e.DateAssurVie)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAssurVie");
                entity.Property(e => e.DateEntree)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEntree");
                entity.Property(e => e.DateNaissance)
                    .HasColumnType("datetime")
                    .HasColumnName("dateNaissance");
                entity.Property(e => e.DateSortie)
                    .HasColumnType("datetime")
                    .HasColumnName("dateSortie");
                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");
                entity.Property(e => e.EmpCadre)
                    .HasMaxLength(200)
                    .HasColumnName("empCadre");
                entity.Property(e => e.Genre)
                    .HasMaxLength(200)
                    .HasColumnName("genre");
                entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");
                entity.Property(e => e.IdDepartement).HasColumnName("idDepartement");
                entity.Property(e => e.IdFonction).HasColumnName("idFonction");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.IdNiveau).HasColumnName("idNiveau");
                entity.Property(e => e.IdPlanning).HasColumnName("idPlanning");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdUserDevice).HasColumnName("idUserDevice");
                entity.Property(e => e.IdVille).HasColumnName("idVille");
                entity.Property(e => e.LieuNaissance)
                    .HasMaxLength(150)
                    .HasColumnName("lieuNaissance");
                entity.Property(e => e.Matricule)
                    .HasMaxLength(500)
                    .HasColumnName("matricule");
                entity.Property(e => e.Nationalite).HasColumnName("nationalite");
                entity.Property(e => e.NbEnfants).HasColumnName("nbEnfants");
                entity.Property(e => e.NomEmployee)
                    .HasMaxLength(500)
                    .HasColumnName("nomEmployee");
                entity.Property(e => e.NumCarte)
                    .HasMaxLength(50)
                    .HasColumnName("numCarte");
                entity.Property(e => e.NumCompte)
                    .HasMaxLength(200)
                    .HasColumnName("numCompte");
                entity.Property(e => e.NumDeclareEmp)
                    .HasMaxLength(200)
                    .HasColumnName("numDeclareEmp");
                entity.Property(e => e.Observation).HasColumnName("observation");
                entity.Property(e => e.Photo).HasColumnName("photo");
                entity.Property(e => e.PlafondAssurRetraite).HasColumnName("plafondAssurRetraite");
                entity.Property(e => e.PlafondAssurVie).HasColumnName("plafondAssurVie");
                entity.Property(e => e.PrenomEmployee)
                    .HasMaxLength(500)
                    .HasColumnName("prenomEmployee");
                entity.Property(e => e.Recharge)
                    .HasMaxLength(200)
                    .HasColumnName("recharge");
                entity.Property(e => e.SalaireBase)
                    .HasColumnType("money")
                    .HasColumnName("salaireBase");
                entity.Property(e => e.SalaireFix).HasColumnName("salaireFix");
                entity.Property(e => e.SitFamiliale)
                    .HasMaxLength(500)
                    .HasColumnName("sitFamiliale");
                entity.Property(e => e.Telephone)
                    .HasMaxLength(30)
                    .HasColumnName("telephone");
                entity.Property(e => e.Titre).HasColumnName("titre");
                entity.Property(e => e.TraiteAssurRetraite)
                    .HasMaxLength(200)
                    .HasColumnName("traiteAssurRetraite");
                entity.Property(e => e.TraiteAssurVie)
                    .HasMaxLength(200)
                    .HasColumnName("traiteAssurVie");
                entity.Property(e => e.TypePaie)
                    .HasMaxLength(200)
                    .HasColumnName("typePaie");
                entity.Property(e => e.TypeSalarie)
                    .HasMaxLength(200)
                    .HasColumnName("typeSalarie");

                entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdCategorie)
                    .HasConstraintName("FK__Paie_E_Em__idCat__351DDF8C");

                entity.HasOne(d => d.IdDepartementNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdDepartement)
                    .HasConstraintName("FK__Paie_E_Em__idDep__361203C5");

                entity.HasOne(d => d.IdFonctionNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdFonction)
                    .HasConstraintName("FK__Paie_E_Em__idFon__370627FE");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paie_E_Em__idGro__37FA4C37");

                entity.HasOne(d => d.IdModRglmNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdModRglm)
                    .HasConstraintName("FK__Paie_E_Em__idMod__38EE7070");

                entity.HasOne(d => d.IdNiveauNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdNiveau)
                    .HasConstraintName("FK__Paie_E_Em__idNiv__39E294A9");

                entity.HasOne(d => d.IdPlanningNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdPlanning)
                    .HasConstraintName("FK__Paie_E_Em__idPla__3AD6B8E2");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paie_E_Em__idUse__3BCADD1B");

                entity.HasOne(d => d.IdUserDeviceNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdUserDevice)
                    .HasConstraintName("FK__Paie_E_Em__idUse__3CBF0154");

                entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.PaieEEmployes)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK__Paie_E_Em__idVil__3DB3258D");
            });

            modelBuilder.Entity<PaieEPret>(entity =>
            {
                entity.HasKey(e => e.IdPret).HasName("PK__Paie_E_P__B41BA71774103744");

                entity.ToTable("Paie_E_Prets");

                entity.Property(e => e.IdPret).HasColumnName("idPret");
                entity.Property(e => e.CodeRubrique)
                    .HasMaxLength(50)
                    .HasColumnName("codeRubrique");
                entity.Property(e => e.DateEcheanceD)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEcheanceD");
                entity.Property(e => e.DateEcheanceF)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEcheanceF");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.MontantDernierEcheance)
                    .HasColumnType("money")
                    .HasColumnName("montantDernierEcheance");
                entity.Property(e => e.MontantEcheance)
                    .HasColumnType("money")
                    .HasColumnName("montantEcheance");
                entity.Property(e => e.MontantTotal)
                    .HasColumnType("money")
                    .HasColumnName("montantTotal");
                entity.Property(e => e.NbEcheance).HasColumnName("nbEcheance");
                entity.Property(e => e.Observation).HasColumnName("observation");
                entity.Property(e => e.Reliquant)
                    .HasColumnType("money")
                    .HasColumnName("reliquant");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieEPrets)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_E_Pr__idEmp__408F9238");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieEPrets)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_E_Pr__idGro__4183B671");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieEPrets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_E_Pr__idUse__4277DAAA");
            });

            modelBuilder.Entity<PaieICategorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie).HasName("PK__paie_I_C__8A3D2408E6D8ED01");

                entity.ToTable("paie_I_Categorie");

                entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomCategorie)
                    .HasMaxLength(500)
                    .HasColumnName("nomCategorie");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieICategories)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__paie_I_Ca__idGro__436BFEE3");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieICategories)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__paie_I_Ca__idUse__4460231C");
            });

            modelBuilder.Entity<PaieIDepartement>(entity =>
            {
                entity.HasKey(e => e.IdDepartement).HasName("PK__paie_I_D__9E93B3EBC1C59A28");

                entity.ToTable("paie_I_Departement");

                entity.Property(e => e.IdDepartement).HasColumnName("idDepartement");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomDepartement)
                    .HasMaxLength(500)
                    .HasColumnName("nomDepartement");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieIDepartements)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__paie_I_De__idGro__45544755");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieIDepartements)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__paie_I_De__idUse__46486B8E");
            });

            modelBuilder.Entity<PaieIFonction>(entity =>
            {
                entity.HasKey(e => e.IdFonction).HasName("PK__paie_I_F__14817A4816B153EE");

                entity.ToTable("paie_I_Fonction");

                entity.Property(e => e.IdFonction).HasColumnName("idFonction");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomFonction)
                    .HasMaxLength(500)
                    .HasColumnName("nomFonction");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieIFonctions)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__paie_I_Fo__idGro__473C8FC7");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieIFonctions)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__paie_I_Fo__idUse__4830B400");
            });

            modelBuilder.Entity<PaieINiveau>(entity =>
            {
                entity.HasKey(e => e.IdNiveau).HasName("PK__paie_I_N__8D81C23E32EBD846");

                entity.ToTable("paie_I_Niveau");

                entity.Property(e => e.IdNiveau).HasColumnName("idNiveau");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomNiveau)
                    .HasMaxLength(500)
                    .HasColumnName("nomNiveau");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieINiveaus)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__paie_I_Ni__idGro__4924D839");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieINiveaus)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__paie_I_Ni__idUse__4A18FC72");
            });

            modelBuilder.Entity<PaieIProfilContrat>(entity =>
            {
                entity.HasKey(e => e.IdProfil).HasName("PK__paie_I_P__2389837BE75EC0D2");

                entity.ToTable("paie_I_ProfilContrat");

                entity.Property(e => e.IdProfil).HasColumnName("idProfil");
                entity.Property(e => e.AllFamiliel).HasColumnName("allFamiliel");
                entity.Property(e => e.CotisationPatr).HasColumnName("cotisationPatr");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.FormationProf).HasColumnName("formationProf");
                entity.Property(e => e.IR).HasColumnName("iR");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomProfil)
                    .HasMaxLength(500)
                    .HasColumnName("nomProfil");
                entity.Property(e => e.PartSalariel).HasColumnName("partSalariel");
                entity.Property(e => e.PlafondIr).HasColumnName("plafondIR");
                entity.Property(e => e.TypeProfil)
                    .HasMaxLength(500)
                    .HasColumnName("typeProfil");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieIProfilContrats)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__paie_I_Pr__idGro__4B0D20AB");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieIProfilContrats)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__paie_I_Pr__idUse__4C0144E4");
            });

            modelBuilder.Entity<PaieITauxFraisProf>(entity =>
            {
                entity.HasKey(e => e.IdTaux).HasName("PK__paie_I_T__C3E0C46D489FAE11");

                entity.ToTable("paie_I_TauxFraisProf");

                entity.Property(e => e.IdTaux).HasColumnName("idTaux");
                entity.Property(e => e.CodeTaux)
                    .HasMaxLength(500)
                    .HasColumnName("codeTaux");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.LibelleTaux)
                    .HasMaxLength(500)
                    .HasColumnName("libelleTaux");
                entity.Property(e => e.Plafond).HasColumnName("plafond");
                entity.Property(e => e.RefTaux)
                    .HasMaxLength(500)
                    .HasColumnName("refTaux");
                entity.Property(e => e.Taux).HasColumnName("taux");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieITauxFraisProfs)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__paie_I_Ta__idGro__4CF5691D");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieITauxFraisProfs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__paie_I_Ta__idUse__4DE98D56");
            });

            modelBuilder.Entity<PaiePPointage>(entity =>
            {
                entity.HasKey(e => e.IdPointage).HasName("PK__Paie_P_P__3875EEE7C9C81FCF");

                entity.ToTable("Paie_P_POINTAGE");

                entity.Property(e => e.IdPointage).HasColumnName("idPointage");
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");
                entity.Property(e => e.DescrPointage).HasColumnName("descrPointage");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Mois).HasColumnName("mois");
                entity.Property(e => e.NumPointage).HasColumnName("numPointage");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.PaiePPointages)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("fk_pointage_dossier");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaiePPointages)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("fk_Paie_P_POINTAGE_idGroup");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaiePPointages)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("fk_Paie_P_POINTAGE_idUser");
            });

            modelBuilder.Entity<PaiePPointageLigne>(entity =>
            {
                entity.HasKey(e => e.IdPointageLigne).HasName("PK__Paie_P_P__4F9C0CAD1A5A5B15");

                entity.ToTable("Paie_P_POINTAGE_LIGNE");

                entity.Property(e => e.IdPointageLigne).HasColumnName("idPointageLigne");
                entity.Property(e => e.HeureSupp).HasColumnName("heureSupp");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdPointage).HasColumnName("idPointage");
                entity.Property(e => e.Kgs).HasColumnName("kgs");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaiePPointageLignes)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("fk_Paie_P_POINTAGE_LIGNE_idEmploye");

                entity.HasOne(d => d.IdPointageNavigation).WithMany(p => p.PaiePPointageLignes)
                    .HasForeignKey(d => d.IdPointage)
                    .HasConstraintName("fk_Paie_P_POINTAGE_LIGNE_idPointage");
            });

            modelBuilder.Entity<PaieZLogDatum>(entity =>
            {
                entity.HasKey(e => e.IdLogData).HasName("PK__Paie_Z_L__A49937F43BE3FFFF");

                entity.ToTable("Paie_Z_LogData");

                entity.Property(e => e.IdLogData).HasColumnName("idLogData");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateTimeRecord)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTimeRecord");
                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdUserDevice).HasColumnName("idUserDevice");
                entity.Property(e => e.TimeRecord).HasColumnName("timeRecord");
                entity.Property(e => e.UniqueId)
                    .HasMaxLength(100)
                    .HasColumnName("uniqueId");

                entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.PaieZLogData)
                    .HasForeignKey(d => d.IdEmploye)
                    .HasConstraintName("FK__Paie_Z_Lo__idEmp__53A266AC");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieZLogData)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_Z_Lo__idGro__54968AE5");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieZLogData)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_Z_Lo__idUse__567ED357");

                entity.HasOne(d => d.IdUserDeviceNavigation).WithMany(p => p.PaieZLogData)
                    .HasForeignKey(d => d.IdUserDevice)
                    .HasConstraintName("FK__Paie_Z_Lo__idUse__558AAF1E");
            });

            modelBuilder.Entity<PaieZPlanning>(entity =>
            {
                entity.HasKey(e => e.IdPlanning).HasName("PK__Paie_Z_P__B185E000B4197857");

                entity.ToTable("Paie_Z_Planning");

                entity.Property(e => e.IdPlanning).HasColumnName("idPlanning");
                entity.Property(e => e.CheckPause).HasColumnName("checkPause");
                entity.Property(e => e.HeureDepartA).HasColumnName("heureDepartA");
                entity.Property(e => e.HeureDepartDe).HasColumnName("heureDepartDe");
                entity.Property(e => e.HeurePauseA).HasColumnName("heurePauseA");
                entity.Property(e => e.HeurePauseDe).HasColumnName("heurePauseDe");
                entity.Property(e => e.HeureSortie).HasColumnName("heureSortie");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NomPlanning)
                    .HasMaxLength(500)
                    .HasColumnName("nomPlanning");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieZPlannings)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_Z_Pl__idGro__5772F790");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieZPlannings)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_Z_Pl__idUse__58671BC9");
            });

            modelBuilder.Entity<PaieZUserDevice>(entity =>
            {
                entity.HasKey(e => e.IdUserDevice).HasName("PK__Paie_Z_U__65DA88BCEC24D13B");

                entity.ToTable("Paie_Z_UserDevice");

                entity.Property(e => e.IdUserDevice).HasColumnName("idUserDevice");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.EnrolNumber).HasColumnName("enrolNumber");
                entity.Property(e => e.IdDevice).HasColumnName("idDevice");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");
                entity.Property(e => e.PasswordU)
                    .HasMaxLength(100)
                    .HasColumnName("passwordU");

                entity.HasOne(d => d.IdDeviceNavigation).WithMany(p => p.PaieZUserDevices)
                    .HasForeignKey(d => d.IdDevice)
                    .HasConstraintName("FK__Paie_Z_Us__idDev__595B4002");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieZUserDevices)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_Z_Us__idGro__5A4F643B");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieZUserDevices)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_Z_Us__idUse__5B438874");
            });

            modelBuilder.Entity<PaieZZktdevice>(entity =>
            {
                entity.HasKey(e => e.IdDevice).HasName("PK__Paie_Z_Z__FB43DB0429D0A54F");

                entity.ToTable("Paie_Z_ZKTDevices");

                entity.Property(e => e.IdDevice).HasColumnName("idDevice");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IpDevice)
                    .HasMaxLength(200)
                    .HasColumnName("ipDevice");
                entity.Property(e => e.MachingNumber).HasColumnName("machingNumber");
                entity.Property(e => e.NameDevice)
                    .HasMaxLength(500)
                    .HasColumnName("nameDevice");
                entity.Property(e => e.PortDevice).HasColumnName("portDevice");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PaieZZktdevices)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__Paie_Z_ZK__idGro__5C37ACAD");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PaieZZktdevices)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Paie_Z_ZK__idUse__5D2BD0E6");
            });

            modelBuilder.Entity<RReglement>(entity =>
            {
                entity.HasKey(e => e.IdReglement).HasName("PK__r_Reglem__DB4C7B8E33384D86");

                entity.ToTable("r_Reglement");

                entity.Property(e => e.IdReglement).HasColumnName("idReglement");
                entity.Property(e => e.Banque)
                    .HasMaxLength(100)
                    .HasColumnName("banque");
                entity.Property(e => e.CodeType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codeType");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateEcheanche)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEcheanche");
                entity.Property(e => e.DateReglement)
                    .HasColumnType("datetime")
                    .HasColumnName("dateReglement");
                entity.Property(e => e.EtatReg)
                    .HasMaxLength(100)
                    .HasColumnName("etatReg");
                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdEntet).HasColumnName("idEntet");
                entity.Property(e => e.IdEntetFish).HasColumnName("idEntetFish");
                entity.Property(e => e.IdFournisseur).HasColumnName("idFournisseur");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.IdTreso).HasColumnName("idTreso");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Info)
                    .HasMaxLength(200)
                    .HasColumnName("info");
                entity.Property(e => e.Montant)
                    .HasColumnType("money")
                    .HasColumnName("montant");
                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .HasColumnName("nom");
                entity.Property(e => e.NumCheque)
                    .HasMaxLength(100)
                    .HasColumnName("numCheque");
                entity.Property(e => e.NumReglement).HasColumnName("numReglement");

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__r_Regleme__idCli__5E1FF51F");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__r_Regleme__idDos__5F141958");

                entity.HasOne(d => d.IdEntetNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdEntet)
                    .HasConstraintName("FK__r_Regleme__idEnt__60083D91");

                entity.HasOne(d => d.IdEntetFishNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdEntetFish)
                    .HasConstraintName("fk_reglement_fish_entet");

                entity.HasOne(d => d.IdFournisseurNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdFournisseur)
                    .HasConstraintName("FK__r_Regleme__idFou__60FC61CA");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__r_Regleme__idGro__61F08603");

                entity.HasOne(d => d.IdModRglmNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdModRglm)
                    .HasConstraintName("FK__r_Regleme__idMod__62E4AA3C");

                entity.HasOne(d => d.IdTresoNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdTreso)
                    .HasConstraintName("FK__r_Regleme__idTre__63D8CE75");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.RReglements)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__r_Regleme__idUse__64CCF2AE");
            });

            modelBuilder.Entity<RReglementInFille>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("r_ReglementInFille");

                entity.Property(e => e.IdFille).HasColumnName("idFille");
                entity.Property(e => e.IdReglement).HasColumnName("idReglement");

                entity.HasOne(d => d.IdFilleNavigation).WithMany()
                    .HasForeignKey(d => d.IdFille)
                    .HasConstraintName("FK__r_Regleme__idFil__66B53B20");

                entity.HasOne(d => d.IdReglementNavigation).WithMany()
                    .HasForeignKey(d => d.IdReglement)
                    .HasConstraintName("FK__r_Regleme__idReg__67A95F59");
            });

            modelBuilder.Entity<SDossier>(entity =>
            {
                entity.HasKey(e => e.IdDossier).HasName("PK__s_Dossie__43081945B4A81825");

                entity.ToTable("s_Dossier");

                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.Activite)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Adresse)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Cnss)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Complement)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Cp)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_creation");
                entity.Property(e => e.DateExeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateExeEnd");
                entity.Property(e => e.DateExeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("dateExeStart");
                entity.Property(e => e.DomainName)
                    .HasMaxLength(500)
                    .HasColumnName("domainName");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.EntetDossier)
                    .HasMaxLength(500)
                    .HasColumnName("Entet_dossier");
                entity.Property(e => e.Fix)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Ice)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.Iff)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Logo)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.NomDossier)
                    .HasMaxLength(100)
                    .HasColumnName("Nom_dossier");
                entity.Property(e => e.Patente)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Pays).HasMaxLength(100);
                entity.Property(e => e.PiedDossier)
                    .HasMaxLength(500)
                    .HasColumnName("Pied_dossier");
                entity.Property(e => e.Rc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Region).HasMaxLength(100);
                entity.Property(e => e.Sitee)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.StyleDossier)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Style_dossier");
                entity.Property(e => e.Tele)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Ville).HasMaxLength(100);
                entity.Property(e => e.WooClientKey).HasColumnName("wooClientKey");
                entity.Property(e => e.WooClientSecret).HasColumnName("wooClientSecret");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.SDossiers)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_Dossier__idGro__689D8392");
            });

            modelBuilder.Entity<SEmailsSetting>(entity =>
            {
                entity.HasKey(e => e.IdEsettings).HasName("PK__s_Emails__3CB665854665DFA7");

                entity.ToTable("s_EmailsSettings");

                entity.Property(e => e.IdEsettings).HasColumnName("idESettings");
                entity.Property(e => e.CheckSmtp).HasColumnName("checkSMTP");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.FromNameSm)
                    .HasMaxLength(500)
                    .HasColumnName("fromNameSm");
                entity.Property(e => e.HostIm)
                    .HasMaxLength(200)
                    .HasColumnName("hostIm");
                entity.Property(e => e.HostSm)
                    .HasMaxLength(200)
                    .HasColumnName("hostSm");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.PasswordIm)
                    .HasMaxLength(50)
                    .HasColumnName("passwordIm");
                entity.Property(e => e.PasswordSm)
                    .HasMaxLength(50)
                    .HasColumnName("passwordSm");
                entity.Property(e => e.PortIm).HasColumnName("portIm");
                entity.Property(e => e.PortSm).HasColumnName("portSm");
                entity.Property(e => e.UrlAttach)
                    .HasMaxLength(500)
                    .HasColumnName("urlAttach");
                entity.Property(e => e.UrlServer)
                    .HasMaxLength(500)
                    .HasColumnName("urlServer");
                entity.Property(e => e.UsernameIm)
                    .HasMaxLength(500)
                    .HasColumnName("usernameIm");
                entity.Property(e => e.UsernameSm)
                    .HasMaxLength(500)
                    .HasColumnName("usernameSm");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.SEmailsSettings)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_EmailsS__idGro__6991A7CB");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.SEmailsSettings)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__s_EmailsS__idUse__6A85CC04");
            });

            modelBuilder.Entity<SFille>(entity =>
            {
                entity.HasKey(e => e.IdFille).HasName("PK__s_Fille__9670A138AD82BE04");

                entity.ToTable("s_Fille");

                entity.Property(e => e.IdFille).HasColumnName("idFille");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.NameFile).HasColumnName("nameFile");
                entity.Property(e => e.PathFile).HasColumnName("pathFile");
                entity.Property(e => e.SizeFile).HasColumnName("sizeFile");
                entity.Property(e => e.TypeFile).HasColumnName("typeFile");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.SFilles)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_Fille__idGroup__6B79F03D");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.SFilles)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__s_Fille__idUser__6C6E1476");
            });

            modelBuilder.Entity<SGroupUser>(entity =>
            {
                entity.HasKey(e => e.IdGroup).HasName("PK__s_GroupU__E0CF5D24B3FE570F");

                entity.ToTable("s_GroupUsers");

                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DescGroup)
                    .HasMaxLength(50)
                    .HasColumnName("descGroup");
            });

            modelBuilder.Entity<SLiaisonUser>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("s_LiaisonUsers");

                entity.Property(e => e.IdDepot).HasColumnName("idDepot");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdTreso).HasColumnName("idTreso");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdVille).HasColumnName("idVille");

                entity.HasOne(d => d.IdDepotNavigation).WithMany()
                    .HasForeignKey(d => d.IdDepot)
                    .HasConstraintName("FK__s_Liaison__idDep__6D6238AF");

                entity.HasOne(d => d.IdPaysNavigation).WithMany()
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("FK__s_Liaison__idPay__6E565CE8");

                entity.HasOne(d => d.IdTresoNavigation).WithMany()
                    .HasForeignKey(d => d.IdTreso)
                    .HasConstraintName("FK__s_Liaison__idTre__6F4A8121");

                entity.HasOne(d => d.IdUserNavigation).WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__s_Liaison__idUse__703EA55A");

                entity.HasOne(d => d.IdVilleNavigation).WithMany()
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK__s_Liaison__idVil__7132C993");
            });

            modelBuilder.Entity<SMenu>(entity =>
            {
                entity.HasKey(e => e.IdMenu).HasName("PK__s_Menu__C26AF483482986C3");

                entity.ToTable("s_Menu");

                entity.Property(e => e.IdMenu).HasColumnName("idMenu");
                entity.Property(e => e.CodeMenu)
                    .HasMaxLength(100)
                    .HasColumnName("codeMenu");
                entity.Property(e => e.DataModel)
                    .HasMaxLength(200)
                    .HasColumnName("dataModel");
                entity.Property(e => e.NomMenu)
                    .HasMaxLength(200)
                    .HasColumnName("nomMenu");
                entity.Property(e => e.PhotoMenu)
                    .HasMaxLength(200)
                    .HasColumnName("photoMenu");
            });

            modelBuilder.Entity<SMenuInstall>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("s_MenuInstall");

                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdMenu).HasColumnName("idMenu");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");

                entity.HasOne(d => d.IdGroupNavigation).WithMany()
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_MenuIns__idGro__7226EDCC");

                entity.HasOne(d => d.IdMenuNavigation).WithMany()
                    .HasForeignKey(d => d.IdMenu)
                    .HasConstraintName("FK__s_MenuIns__idMen__731B1205");

                entity.HasOne(d => d.IdUserNavigation).WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__s_MenuIns__idUse__740F363E");
            });

            modelBuilder.Entity<SMenuSub>(entity =>
            {
                entity.HasKey(e => e.IdSubMenu).HasName("PK__s_MenuSu__7821D1082CBCB38C");

                entity.ToTable("s_MenuSub");

                entity.Property(e => e.IdSubMenu).HasColumnName("idSubMenu");
                entity.Property(e => e.CodeMenu)
                    .HasMaxLength(100)
                    .HasColumnName("codeMenu");
                entity.Property(e => e.NamePrincipale)
                    .HasMaxLength(250)
                    .HasColumnName("namePrincipale");
                entity.Property(e => e.NomSubMenu)
                    .HasMaxLength(200)
                    .HasColumnName("nomSubMenu");
            });

            modelBuilder.Entity<SMenuSubInstall>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("s_MenuSubInstall");

                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdSubMenu).HasColumnName("idSubMenu");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");

                entity.HasOne(d => d.IdGroupNavigation).WithMany()
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_MenuSub__idGro__75035A77");

                entity.HasOne(d => d.IdSubMenuNavigation).WithMany()
                    .HasForeignKey(d => d.IdSubMenu)
                    .HasConstraintName("FK__s_MenuSub__idSub__75F77EB0");

                entity.HasOne(d => d.IdUserNavigation).WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__s_MenuSub__idUse__76EBA2E9");
            });

            modelBuilder.Entity<SRole>(entity =>
            {
                entity.HasKey(e => e.IdRole).HasName("PK__s_Roles__E5045C546FDECAAF");

                entity.ToTable("s_Roles");

                entity.Property(e => e.IdRole).HasColumnName("idRole");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DeleteRole).HasColumnName("deleteRole");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.ImprimerRole).HasColumnName("imprimerRole");
                entity.Property(e => e.InsertRole).HasColumnName("insertRole");
                entity.Property(e => e.NameRole).HasColumnName("nameRole");
                entity.Property(e => e.SelectAll).HasColumnName("selectALL");
                entity.Property(e => e.SelectArticles).HasColumnName("selectArticles");
                entity.Property(e => e.SelectByUser).HasColumnName("selectByUser");
                entity.Property(e => e.SelectDoc).HasColumnName("selectDoc");
                entity.Property(e => e.UpdateRole).HasColumnName("updateRole");
                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.SRoles)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_Roles__idGroup__77DFC722");

                entity.HasMany(d => d.IdUsers).WithMany(p => p.IdRoles)
                    .UsingEntity<Dictionary<string, object>>(
                        "SUserRole",
                        r => r.HasOne<SUser>().WithMany()
                            .HasForeignKey("IdUser")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__s_UserRol__idUse__7CA47C3F"),
                        l => l.HasOne<SRole>().WithMany()
                            .HasForeignKey("IdRole")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__s_UserRol__idRol__7BB05806"),
                        j =>
                        {
                            j.HasKey("IdRole", "IdUser").HasName("PK__s_UserRo__D67520CC0F857492");
                            j.ToTable("s_UserRoles");
                            j.IndexerProperty<int>("IdRole").HasColumnName("idRole");
                            j.IndexerProperty<string>("IdUser").HasColumnName("idUser");
                        });
            });

            modelBuilder.Entity<SSetting>(entity =>
            {
                entity.HasKey(e => e.IdSettings).HasName("PK__s_Settin__C7066F18CFD5BD87");

                entity.ToTable("s_Settings");

                entity.Property(e => e.IdSettings).HasColumnName("idSettings");
                entity.Property(e => e.CurrencyFormat).HasColumnName("currencyFormat");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.QteFormat).HasColumnName("qteFormat");
                entity.Property(e => e.SubDepot).HasColumnName("subDepot");
                entity.Property(e => e.TtcCheck).HasColumnName("ttcCheck");
                entity.Property(e => e.TvaCheck).HasColumnName("tvaCheck");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.SSettings)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_Setting__idGro__78D3EB5B");
            });

            modelBuilder.Entity<SUser>(entity =>
            {
                entity.HasKey(e => e.IdUser).HasName("PK__s_Users__3717C9821D916FB4");

                entity.ToTable("s_Users");

                entity.Property(e => e.IdUser).HasColumnName("idUser");
                entity.Property(e => e.AdresseUser)
                    .HasMaxLength(200)
                    .HasColumnName("adresseUser");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.EmailUser)
                    .HasMaxLength(200)
                    .HasColumnName("emailUser");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLoginDate");
                entity.Property(e => e.NomUser)
                    .HasMaxLength(200)
                    .HasColumnName("nomUser");
                entity.Property(e => e.OutLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("outLoginDate");
                entity.Property(e => e.PasswordUser).HasColumnName("passwordUser");
                entity.Property(e => e.TeleUser)
                    .HasMaxLength(200)
                    .HasColumnName("teleUser");
                entity.Property(e => e.TokenLogin).HasColumnName("tokenLogin");
                entity.Property(e => e.TypeAdmin).HasColumnName("typeAdmin");
                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .HasColumnName("userName");
                entity.Property(e => e.UserPhoto).HasColumnName("userPhoto");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.SUsers)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__s_Users__idGroup__7D98A078");

                entity.HasMany(d => d.IdDossiers).WithMany(p => p.IdUsers)
                    .UsingEntity<Dictionary<string, object>>(
                        "SUserDossier",
                        r => r.HasOne<SDossier>().WithMany()
                            .HasForeignKey("IdDossier")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__s_UserDos__idDos__79C80F94"),
                        l => l.HasOne<SUser>().WithMany()
                            .HasForeignKey("IdUser")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__s_UserDos__idUse__7ABC33CD"),
                        j =>
                        {
                            j.HasKey("IdUser", "IdDossier").HasName("PK__s_UserDo__732748166511DB00");
                            j.ToTable("s_UserDossier");
                            j.IndexerProperty<string>("IdUser").HasColumnName("idUser");
                            j.IndexerProperty<int>("IdDossier").HasColumnName("idDossier");
                        });
            });

            modelBuilder.Entity<SbCreationBarCode>(entity =>
            {
                entity.HasKey(e => e.IdCreation).HasName("PK__sb_Creat__FA6C5830232E1A42");

                entity.ToTable("sb_CreationBarCode");

                entity.Property(e => e.IdCreation).HasColumnName("idCreation");
                entity.Property(e => e.CodeType)
                    .HasMaxLength(250)
                    .HasColumnName("codeType");
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");
                entity.Property(e => e.DimensionH).HasColumnName("dimensionH");
                entity.Property(e => e.DimensionW).HasColumnName("dimensionW");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Meta).HasColumnName("meta");
                entity.Property(e => e.VBarHeight).HasColumnName("vBarHeight");
                entity.Property(e => e.VBarWidth).HasColumnName("vBarWidth");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.SbCreationBarCodes)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__sb_Creati__idDos__7E8CC4B1");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.SbCreationBarCodes)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__sb_Creati__idGro__7F80E8EA");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.SbCreationBarCodes)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__sb_Creati__idUse__00750D23");
            });

            modelBuilder.Entity<ScCalendar>(entity =>
            {
                entity.HasKey(e => e.IdCalendar).HasName("PK__sc_calen__B35CADE53E6CEB56");

                entity.ToTable("sc_calendar");

                entity.Property(e => e.IdCalendar).HasColumnName("idCalendar");
                entity.Property(e => e.BgColor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bgColor");
                entity.Property(e => e.BorderColor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("borderColor");
                entity.Property(e => e.Checked).HasColumnName("checked");
                entity.Property(e => e.Color)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("color");
                entity.Property(e => e.DragBgColor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dragBgColor");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.ScCalendars)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__sc_calend__idGro__0169315C");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.ScCalendars)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__sc_calend__idUse__025D5595");
            });

            modelBuilder.Entity<ScSchedule>(entity =>
            {
                entity.HasKey(e => e.IdSchedule).HasName("PK__sc_sched__5717CA9456DDDB20");

                entity.ToTable("sc_schedule");

                entity.Property(e => e.IdSchedule).HasColumnName("idSchedule");
                entity.Property(e => e.Body).HasColumnName("body");
                entity.Property(e => e.Endd)
                    .HasColumnType("datetime")
                    .HasColumnName("endd");
                entity.Property(e => e.HeureEndd).HasColumnName("heureEndd");
                entity.Property(e => e.HeureStart).HasColumnName("heureStart");
                entity.Property(e => e.IdCalendar).HasColumnName("idCalendar");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IsAllday).HasColumnName("isAllday");
                entity.Property(e => e.IsPrivate).HasColumnName("isPrivate");
                entity.Property(e => e.NomTier)
                    .HasMaxLength(500)
                    .HasColumnName("nomTier");
                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");
                entity.Property(e => e.Title).HasColumnName("title");

                entity.HasOne(d => d.IdCalendarNavigation).WithMany(p => p.ScSchedules)
                    .HasForeignKey(d => d.IdCalendar)
                    .HasConstraintName("FK__sc_schedu__idCal__035179CE");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.ScSchedules)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__sc_schedu__idGro__04459E07");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.ScSchedules)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__sc_schedu__idUse__0539C240");
            });

            modelBuilder.Entity<TClient>(entity =>
            {
                entity.HasKey(e => e.IdClient).HasName("PK__t_Client__A6A610D4B1A3F292");

                entity.ToTable("t_Client");

                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.AdresseClient)
                    .HasMaxLength(200)
                    .HasColumnName("adresseClient");
                entity.Property(e => e.Autorizacion).HasColumnName("autorizacion");
                entity.Property(e => e.BanqueClient)
                    .HasMaxLength(50)
                    .HasColumnName("banqueClient");
                entity.Property(e => e.CategorieClt)
                    .HasMaxLength(500)
                    .HasColumnName("categorieClt");
                entity.Property(e => e.CinClient)
                    .HasMaxLength(50)
                    .HasColumnName("cinClient");
                entity.Property(e => e.CnssClient)
                    .HasMaxLength(50)
                    .HasColumnName("cnssClient");
                entity.Property(e => e.CodeClient)
                    .HasMaxLength(50)
                    .HasColumnName("codeClient");
                entity.Property(e => e.ContratClient).HasColumnName("contratClient");
                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");
                entity.Property(e => e.Distributeur).HasColumnName("distributeur");
                entity.Property(e => e.EmailClient)
                    .HasMaxLength(250)
                    .HasColumnName("emailClient");
                entity.Property(e => e.FixClient)
                    .HasMaxLength(250)
                    .HasColumnName("fixClient");
                entity.Property(e => e.FrmJuridiqueClient)
                    .HasMaxLength(50)
                    .HasColumnName("frmJuridiqueClient");
                entity.Property(e => e.IceClient)
                    .HasMaxLength(50)
                    .HasColumnName("iceClient");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdVille).HasColumnName("idVille");
                entity.Property(e => e.Incoterms).HasColumnName("incoterms");
                entity.Property(e => e.NifClient)
                    .HasMaxLength(50)
                    .HasColumnName("nifClient");
                entity.Property(e => e.NomClient)
                    .HasMaxLength(200)
                    .HasColumnName("nomClient");
                entity.Property(e => e.OrigineContact)
                    .HasMaxLength(500)
                    .HasColumnName("origineContact");
                entity.Property(e => e.PatenteClient)
                    .HasMaxLength(50)
                    .HasColumnName("patenteClient");
                entity.Property(e => e.PostalClient)
                    .HasMaxLength(50)
                    .HasColumnName("postalClient");
                entity.Property(e => e.PotentielClt)
                    .HasMaxLength(500)
                    .HasColumnName("potentielClt");
                entity.Property(e => e.Propriete).HasColumnName("propriete");
                entity.Property(e => e.RibClient)
                    .HasMaxLength(50)
                    .HasColumnName("ribClient");
                entity.Property(e => e.SiegeClient)
                    .HasMaxLength(50)
                    .HasColumnName("siegeClient");
                entity.Property(e => e.Siteweb).HasColumnName("siteweb");
                entity.Property(e => e.SoldAutoriseClient)
                    .HasColumnType("money")
                    .HasColumnName("soldAutoriseClient");
                entity.Property(e => e.TeleClient)
                    .HasMaxLength(250)
                    .HasColumnName("teleClient");
                entity.Property(e => e.TypeClient)
                    .HasMaxLength(250)
                    .HasColumnName("typeClient");
                entity.Property(e => e.VendeurClient).HasColumnName("vendeurClient");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.TClients)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__t_Client__idGrou__062DE679");

                entity.HasOne(d => d.IdPaysNavigation).WithMany(p => p.TClients)
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("FK__t_Client__idPays__08162EEB");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TClients)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__t_Client__idUser__09FE775D");

                entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.TClients)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK__t_Client__idVill__0BE6BFCF");
            });

            modelBuilder.Entity<TClientCredit>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("t_ClientCredit");

                entity.Property(e => e.Credit)
                    .HasColumnType("money")
                    .HasColumnName("credit");
                entity.Property(e => e.IdClient).HasColumnName("idClient");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");

                entity.HasOne(d => d.IdClientNavigation).WithMany()
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__t_ClientC__idCli__0DCF0841");

                entity.HasOne(d => d.IdDossierNavigation).WithMany()
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__t_ClientC__idDos__0EC32C7A");
            });

            modelBuilder.Entity<TFournisseur>(entity =>
            {
                entity.HasKey(e => e.IdFournisseur).HasName("PK__t_Fourni__9850876A0EADB6B4");

                entity.ToTable("t_Fournisseur");

                entity.Property(e => e.IdFournisseur).HasColumnName("idFournisseur");
                entity.Property(e => e.AdresseFournisseur)
                    .HasMaxLength(200)
                    .HasColumnName("adresseFournisseur");
                entity.Property(e => e.BanqueFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("banqueFournisseur");
                entity.Property(e => e.CategorieFr)
                    .HasMaxLength(500)
                    .HasColumnName("categorieFR");
                entity.Property(e => e.CinFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("cinFournisseur");
                entity.Property(e => e.CnssFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("cnssFournisseur");
                entity.Property(e => e.CodeFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("codeFournisseur");
                entity.Property(e => e.ContratFournisseur).HasColumnName("contratFournisseur");
                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");
                entity.Property(e => e.EmailFournisseur)
                    .HasMaxLength(250)
                    .HasColumnName("emailFournisseur");
                entity.Property(e => e.FixFournisseur)
                    .HasMaxLength(250)
                    .HasColumnName("fixFournisseur");
                entity.Property(e => e.Fournisseur).HasColumnName("fournisseur");
                entity.Property(e => e.FrmJuridiqueFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("frmJuridiqueFournisseur");
                entity.Property(e => e.IceFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("iceFournisseur");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdPays).HasColumnName("idPays");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.IdVille).HasColumnName("idVille");
                entity.Property(e => e.NifFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("nifFournisseur");
                entity.Property(e => e.NomFournisseur)
                    .HasMaxLength(200)
                    .HasColumnName("nomFournisseur");
                entity.Property(e => e.OrigineContactFr)
                    .HasMaxLength(500)
                    .HasColumnName("origineContactFR");
                entity.Property(e => e.PatenteFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("patenteFournisseur");
                entity.Property(e => e.PostalFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("postalFournisseur");
                entity.Property(e => e.PotentielFr)
                    .HasMaxLength(500)
                    .HasColumnName("potentielFR");
                entity.Property(e => e.RibFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("ribFournisseur");
                entity.Property(e => e.SiegeFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("siegeFournisseur");
                entity.Property(e => e.SitewebFr).HasColumnName("sitewebFr");
                entity.Property(e => e.SoldAutoriseFournisseur)
                    .HasColumnType("money")
                    .HasColumnName("soldAutoriseFournisseur");
                entity.Property(e => e.SousTraitance).HasColumnName("sous_traitance");
                entity.Property(e => e.TeleFournisseur)
                    .HasMaxLength(250)
                    .HasColumnName("teleFournisseur");
                entity.Property(e => e.TypeFournisseur)
                    .HasMaxLength(250)
                    .HasColumnName("typeFournisseur");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.TFournisseurs)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__t_Fournis__idGro__0FB750B3");

                entity.HasOne(d => d.IdPaysNavigation).WithMany(p => p.TFournisseurs)
                    .HasForeignKey(d => d.IdPays)
                    .HasConstraintName("FK__t_Fournis__idPay__10AB74EC");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TFournisseurs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__t_Fournis__idUse__119F9925");

                entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.TFournisseurs)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK__t_Fournis__idVil__1293BD5E");
            });

            modelBuilder.Entity<TFournisseurCredit>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("t_FournisseurCredit");

                entity.Property(e => e.Credit)
                    .HasColumnType("money")
                    .HasColumnName("credit");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdFournisseur).HasColumnName("idFournisseur");

                entity.HasOne(d => d.IdDossierNavigation).WithMany()
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__t_Fournis__idDos__1387E197");

                entity.HasOne(d => d.IdFournisseurNavigation).WithMany()
                    .HasForeignKey(d => d.IdFournisseur)
                    .HasConstraintName("FK__t_Fournis__idFou__147C05D0");
            });

            modelBuilder.Entity<TSalarie>(entity =>
            {
                entity.HasKey(e => e.IdSalarie).HasName("PK__t_salari__A5800341ABBD796C");

                entity.ToTable("t_salarie");

                entity.Property(e => e.IdSalarie).HasColumnName("idSalarie");
                entity.Property(e => e.Age).HasColumnName("age");
                entity.Property(e => e.NomSalarie)
                    .IsUnicode(false)
                    .HasColumnName("nomSalarie");
                entity.Property(e => e.Post)
                    .IsUnicode(false)
                    .HasColumnName("post");
                entity.Property(e => e.PrenomSalarie)
                    .IsUnicode(false)
                    .HasColumnName("prenomSalarie");
                entity.Property(e => e.Salaire).HasColumnName("salaire");
            });

            modelBuilder.Entity<TrTresorerieEntet>(entity =>
            {
                entity.HasKey(e => e.IdTresoEntet).HasName("PK__tr_Treso__FEA43A3ACFADC22A");

                entity.ToTable("tr_TresorerieEntet");

                entity.Property(e => e.IdTresoEntet).HasColumnName("idTresoEntet");
                entity.Property(e => e.Banque)
                    .HasMaxLength(150)
                    .HasColumnName("banque");
                entity.Property(e => e.CodeType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codeType");
                entity.Property(e => e.DateEcheanche)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEcheanche");
                entity.Property(e => e.DateTresoEntet)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTresoEntet");
                entity.Property(e => e.DescTresoEntet)
                    .HasMaxLength(300)
                    .HasColumnName("descTresoEntet");
                entity.Property(e => e.EtatDoc)
                    .HasMaxLength(50)
                    .HasColumnName("etatDoc");
                entity.Property(e => e.IdDossier).HasColumnName("idDossier");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdModRglm).HasColumnName("idModRglm");
                entity.Property(e => e.IdService).HasColumnName("idService");
                entity.Property(e => e.IdTreso).HasColumnName("idTreso");
                entity.Property(e => e.IdTreso2).HasColumnName("idTreso_2");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.Montant)
                    .HasColumnType("money")
                    .HasColumnName("montant");
                entity.Property(e => e.NumCheque)
                    .HasMaxLength(150)
                    .HasColumnName("numCheque");
                entity.Property(e => e.NumTresoEntet).HasColumnName("numTresoEntet");

                entity.HasOne(d => d.IdDossierNavigation).WithMany(p => p.TrTresorerieEntets)
                    .HasForeignKey(d => d.IdDossier)
                    .HasConstraintName("FK__tr_Tresor__idDos__15702A09");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.TrTresorerieEntets)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__tr_Tresor__idGro__16644E42");

                entity.HasOne(d => d.IdModRglmNavigation).WithMany(p => p.TrTresorerieEntets)
                    .HasForeignKey(d => d.IdModRglm)
                    .HasConstraintName("FK__tr_Tresor__idMod__1758727B");

                entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.TrTresorerieEntets)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("FK__tr_Tresor__idSer__184C96B4");

                entity.HasOne(d => d.IdTresoNavigation).WithMany(p => p.TrTresorerieEntetIdTresoNavigations)
                    .HasForeignKey(d => d.IdTreso)
                    .HasConstraintName("FK__tr_Tresor__idTre__1940BAED");

                entity.HasOne(d => d.IdTreso2Navigation).WithMany(p => p.TrTresorerieEntetIdTreso2Navigations)
                    .HasForeignKey(d => d.IdTreso2)
                    .HasConstraintName("FK__tr_Tresor__idTre__1A34DF26");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TrTresorerieEntets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__tr_Tresor__idUse__1B29035F");
            });

            modelBuilder.Entity<UUniteMesure>(entity =>
            {
                entity.HasKey(e => e.IdUnite).HasName("PK__u_UniteM__91C8610CE18BAC6D");

                entity.ToTable("u_UniteMesure");

                entity.Property(e => e.IdUnite).HasColumnName("idUnite");
                entity.Property(e => e.DescUnite)
                    .HasMaxLength(100)
                    .HasColumnName("descUnite");
                entity.Property(e => e.IdGroup).HasColumnName("idGroup");
                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("idUser");
                entity.Property(e => e.PrcpUnite).HasColumnName("prcpUnite");

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.UUniteMesures)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__u_UniteMe__idGro__1C1D2798");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UUniteMesures)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__u_UniteMe__idUse__1D114BD1");
            });


        }



    }

}
