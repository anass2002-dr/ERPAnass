using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class AArticle
{
    public int IdArticle { get; set; }

    public string? RefArticle { get; set; }

    public string? CodeBareArticle { get; set; }

    public string? NomArticle { get; set; }

    public string? DescArticle { get; set; }

    public bool? FavorisArticle { get; set; }

    public string? PhotoArticle { get; set; }

    public bool? AchatArticle { get; set; }

    public bool? VenteArticle { get; set; }

    public bool? LocationArticle { get; set; }

    public string? TypeArticle { get; set; }

    public decimal? PrixAchatHt { get; set; }

    public decimal? PrixAchatHt1 { get; set; }

    public decimal? PrixAchatTtc { get; set; }

    public decimal? PrixAchatTtc1 { get; set; }

    public decimal? PrixVenteHt { get; set; }

    public decimal? PrixVenteHt1 { get; set; }

    public decimal? PrixVenteTtc { get; set; }

    public decimal? PrixVenteTtc1 { get; set; }

    public decimal? PrixlocationHt { get; set; }

    public decimal? PrixlocationTtc { get; set; }

    public string? ClassmentArticle { get; set; }

    public double? StkMinArticle { get; set; }

    public bool? WooArticle { get; set; }

    public int? IdWooProducts { get; set; }

    public string? MetaWooArticle { get; set; }

    public string? MetaArticle { get; set; }

    public double? PourCentArticle { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdFamille { get; set; }

    public int? IdTaxeAchat { get; set; }

    public int? IdTaxeVente { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public double? QteBox { get; set; }

    public bool? CheckDureDevie { get; set; }

    public string? StateDureDevie { get; set; }

    public int? DureDevie { get; set; }

    public decimal? PrixVenteHt2 { get; set; }

    public decimal? PrixVenteTtc2 { get; set; }

    public bool? CheckBateau { get; set; }

    public string? MesureArticle { get; set; }

    public int? IdUnite { get; set; }

    public bool? CheckMaintenance { get; set; }

    public int? CodePdFini { get; set; }

    public bool? PdFini { get; set; }

    public virtual ICollection<ABateau> ABateaus { get; set; } = new List<ABateau>();

    public virtual ICollection<EEntetLign> EEntetLigns { get; set; } = new List<EEntetLign>();

    public virtual ICollection<FFabricationLign> FFabricationLigns { get; set; } = new List<FFabricationLign>();

    public virtual ICollection<FFabrication> FFabrications { get; set; } = new List<FFabrication>();

    public virtual ICollection<FOrdreLine> FOrdreLines { get; set; } = new List<FOrdreLine>();

    public virtual ICollection<FOrdre> FOrdres { get; set; } = new List<FOrdre>();

    public virtual AFamille? IdFamilleNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BTaxe? IdTaxeAchatNavigation { get; set; }

    public virtual BTaxe? IdTaxeVenteNavigation { get; set; }

    public virtual UUniteMesure? IdUniteNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<MaintAEquipement> MaintAEquipements { get; set; } = new List<MaintAEquipement>();

    public virtual ICollection<PTicketLigne> PTicketLignes { get; set; } = new List<PTicketLigne>();
}
