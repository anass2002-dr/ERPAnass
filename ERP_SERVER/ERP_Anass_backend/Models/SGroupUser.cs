using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SGroupUser
{
    public int IdGroup { get; set; }

    public string? DescGroup { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<AArticle> AArticles { get; set; } = new List<AArticle>();

    public virtual ICollection<AFamille> AFamilles { get; set; } = new List<AFamille>();

    public virtual ICollection<BDepotSup> BDepotSups { get; set; } = new List<BDepotSup>();

    public virtual ICollection<BDepot> BDepots { get; set; } = new List<BDepot>();

    public virtual ICollection<BModRglm> BModRglms { get; set; } = new List<BModRglm>();

    public virtual ICollection<BPay> BPays { get; set; } = new List<BPay>();

    public virtual ICollection<BPropriete> BProprietes { get; set; } = new List<BPropriete>();

    public virtual ICollection<BService> BServices { get; set; } = new List<BService>();

    public virtual ICollection<BTaxe> BTaxes { get; set; } = new List<BTaxe>();

    public virtual ICollection<BTresorerie> BTresoreries { get; set; } = new List<BTresorerie>();

    public virtual ICollection<BVille> BVilles { get; set; } = new List<BVille>();

    public virtual ICollection<DDepartement> DDepartements { get; set; } = new List<DDepartement>();

    public virtual ICollection<EEmail> EEmails { get; set; } = new List<EEmail>();

    public virtual ICollection<EEntet> EEntets { get; set; } = new List<EEntet>();

    public virtual ICollection<FFabrication> FFabrications { get; set; } = new List<FFabrication>();

    public virtual ICollection<FOrdre> FOrdres { get; set; } = new List<FOrdre>();

    public virtual ICollection<FishCharge> FishCharges { get; set; } = new List<FishCharge>();

    public virtual ICollection<FishEntet> FishEntets { get; set; } = new List<FishEntet>();

    public virtual ICollection<FishFamille> FishFamilles { get; set; } = new List<FishFamille>();

    public virtual ICollection<FishNomScientifique> FishNomScientifiques { get; set; } = new List<FishNomScientifique>();

    public virtual ICollection<FishPort> FishPorts { get; set; } = new List<FishPort>();

    public virtual ICollection<FishTypeFamaille> FishTypeFamailles { get; set; } = new List<FishTypeFamaille>();

    public virtual ICollection<HotelBBookingEntete> HotelBBookingEntetes { get; set; } = new List<HotelBBookingEntete>();

    public virtual ICollection<HotelSCategorie> HotelSCategories { get; set; } = new List<HotelSCategorie>();

    public virtual ICollection<HotelSExtra> HotelSExtras { get; set; } = new List<HotelSExtra>();

    public virtual ICollection<HotelSRoomType> HotelSRoomTypes { get; set; } = new List<HotelSRoomType>();

    public virtual ICollection<MaintAEquipement> MaintAEquipements { get; set; } = new List<MaintAEquipement>();

    public virtual ICollection<MaintRRequest> MaintRRequests { get; set; } = new List<MaintRRequest>();

    public virtual ICollection<MaintSTeam> MaintSTeams { get; set; } = new List<MaintSTeam>();

    public virtual ICollection<PCaissier> PCaissiers { get; set; } = new List<PCaissier>();

    public virtual ICollection<PPo> PPos { get; set; } = new List<PPo>();

    public virtual ICollection<PaieCCotisation> PaieCCotisations { get; set; } = new List<PaieCCotisation>();

    public virtual ICollection<PaieCRubrique> PaieCRubriques { get; set; } = new List<PaieCRubrique>();

    public virtual ICollection<PaieCVariable> PaieCVariables { get; set; } = new List<PaieCVariable>();

    public virtual ICollection<PaieCalculAvance> PaieCalculAvances { get; set; } = new List<PaieCalculAvance>();

    public virtual ICollection<PaieCalculBulletin> PaieCalculBulletins { get; set; } = new List<PaieCalculBulletin>();

    public virtual ICollection<PaieCalculConge> PaieCalculConges { get; set; } = new List<PaieCalculConge>();

    public virtual ICollection<PaieCalculGrpEntete> PaieCalculGrpEntetes { get; set; } = new List<PaieCalculGrpEntete>();

    public virtual ICollection<PaieEConge> PaieEConges { get; set; } = new List<PaieEConge>();

    public virtual ICollection<PaieEContrat> PaieEContrats { get; set; } = new List<PaieEContrat>();

    public virtual ICollection<PaieEEmploye> PaieEEmployes { get; set; } = new List<PaieEEmploye>();

    public virtual ICollection<PaieEPret> PaieEPrets { get; set; } = new List<PaieEPret>();

    public virtual ICollection<PaieICategorie> PaieICategories { get; set; } = new List<PaieICategorie>();

    public virtual ICollection<PaieIDepartement> PaieIDepartements { get; set; } = new List<PaieIDepartement>();

    public virtual ICollection<PaieIFonction> PaieIFonctions { get; set; } = new List<PaieIFonction>();

    public virtual ICollection<PaieINiveau> PaieINiveaus { get; set; } = new List<PaieINiveau>();

    public virtual ICollection<PaieIProfilContrat> PaieIProfilContrats { get; set; } = new List<PaieIProfilContrat>();

    public virtual ICollection<PaieITauxFraisProf> PaieITauxFraisProfs { get; set; } = new List<PaieITauxFraisProf>();

    public virtual ICollection<PaiePPointage> PaiePPointages { get; set; } = new List<PaiePPointage>();

    public virtual ICollection<PaieZLogDatum> PaieZLogData { get; set; } = new List<PaieZLogDatum>();

    public virtual ICollection<PaieZPlanning> PaieZPlannings { get; set; } = new List<PaieZPlanning>();

    public virtual ICollection<PaieZUserDevice> PaieZUserDevices { get; set; } = new List<PaieZUserDevice>();

    public virtual ICollection<PaieZZktdevice> PaieZZktdevices { get; set; } = new List<PaieZZktdevice>();

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();

    public virtual ICollection<SDossier> SDossiers { get; set; } = new List<SDossier>();

    public virtual ICollection<SEmailsSetting> SEmailsSettings { get; set; } = new List<SEmailsSetting>();

    public virtual ICollection<SFille> SFilles { get; set; } = new List<SFille>();

    public virtual ICollection<SRole> SRoles { get; set; } = new List<SRole>();

    public virtual ICollection<SSetting> SSettings { get; set; } = new List<SSetting>();

    public virtual ICollection<SUser> SUsers { get; set; } = new List<SUser>();

    public virtual ICollection<SbCreationBarCode> SbCreationBarCodes { get; set; } = new List<SbCreationBarCode>();

    public virtual ICollection<ScCalendar> ScCalendars { get; set; } = new List<ScCalendar>();

    public virtual ICollection<ScSchedule> ScSchedules { get; set; } = new List<ScSchedule>();

    public virtual ICollection<TClient> TClients { get; set; } = new List<TClient>();

    public virtual ICollection<TFournisseur> TFournisseurs { get; set; } = new List<TFournisseur>();

    public virtual ICollection<TrTresorerieEntet> TrTresorerieEntets { get; set; } = new List<TrTresorerieEntet>();

    public virtual ICollection<UUniteMesure> UUniteMesures { get; set; } = new List<UUniteMesure>();
}
