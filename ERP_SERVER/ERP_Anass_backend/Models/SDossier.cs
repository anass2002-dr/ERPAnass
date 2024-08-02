using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SDossier
{
    public int IdDossier { get; set; }

    public string? NomDossier { get; set; }

    public string? Activite { get; set; }

    public string? Adresse { get; set; }

    public string? Complement { get; set; }

    public string? Cp { get; set; }

    public string? Region { get; set; }

    public string? Ville { get; set; }

    public string? Pays { get; set; }

    public string? Fix { get; set; }

    public string? Sitee { get; set; }

    public string? Tele { get; set; }

    public string? Email { get; set; }

    public string? Cnss { get; set; }

    public string? Patente { get; set; }

    public string? Iff { get; set; }

    public string? Rc { get; set; }

    public string? Ice { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? EntetDossier { get; set; }

    public string? PiedDossier { get; set; }

    public string? StyleDossier { get; set; }

    public string? Logo { get; set; }

    public string? DomainName { get; set; }

    public string? WooClientKey { get; set; }

    public string? WooClientSecret { get; set; }

    public DateTime? DateExeStart { get; set; }

    public DateTime? DateExeEnd { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Objectif { get; set; }

    public int? IdGroup { get; set; }

    public virtual ICollection<BSoldTresorerie> BSoldTresoreries { get; set; } = new List<BSoldTresorerie>();

    public virtual ICollection<EEntet> EEntets { get; set; } = new List<EEntet>();

    public virtual ICollection<ETypeDoc> ETypeDocs { get; set; } = new List<ETypeDoc>();

    public virtual ICollection<FOrdreLine> FOrdreLines { get; set; } = new List<FOrdreLine>();

    public virtual ICollection<FOrdre> FOrdres { get; set; } = new List<FOrdre>();

    public virtual ICollection<FishEntet> FishEntets { get; set; } = new List<FishEntet>();

    public virtual ICollection<HotelBBookingEntete> HotelBBookingEntetes { get; set; } = new List<HotelBBookingEntete>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual ICollection<MaintRRequest> MaintRRequests { get; set; } = new List<MaintRRequest>();

    public virtual ICollection<PPo> PPos { get; set; } = new List<PPo>();

    public virtual ICollection<PaieCalculBulletin> PaieCalculBulletins { get; set; } = new List<PaieCalculBulletin>();

    public virtual ICollection<PaieCalculConge> PaieCalculConges { get; set; } = new List<PaieCalculConge>();

    public virtual ICollection<PaieCalculGrpEntete> PaieCalculGrpEntetes { get; set; } = new List<PaieCalculGrpEntete>();

    public virtual ICollection<PaieEConge> PaieEConges { get; set; } = new List<PaieEConge>();

    public virtual ICollection<PaiePPointage> PaiePPointages { get; set; } = new List<PaiePPointage>();

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();

    public virtual ICollection<SbCreationBarCode> SbCreationBarCodes { get; set; } = new List<SbCreationBarCode>();

    public virtual ICollection<TrTresorerieEntet> TrTresorerieEntets { get; set; } = new List<TrTresorerieEntet>();

    public virtual ICollection<SUser> IdUsers { get; set; } = new List<SUser>();
}
