using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class EEntet
{
    public int IdEntet { get; set; }

    public int? NumFactur { get; set; }

    public string? RefFactur { get; set; }

    public DateTime? DateEntet { get; set; }

    public DateTime? DateEcheanche { get; set; }

    public string? Nom { get; set; }

    public string? Info { get; set; }

    public bool? Valider { get; set; }

    public bool? Clotur { get; set; }

    public decimal? TtTtc { get; set; }

    public decimal? TtHt { get; set; }

    public decimal? TtTva { get; set; }

    public decimal? TtRemis { get; set; }

    public decimal? TtMargeCmup { get; set; }

    public decimal? TtMargePxAcha { get; set; }

    public decimal? TtTauxMargeCmup { get; set; }

    public decimal? TtTauxMargePxAcha { get; set; }

    public bool? Timbre { get; set; }

    public decimal? TtNet { get; set; }

    public decimal? Avance { get; set; }

    public string? EtatDoc { get; set; }

    public string? NumCheq { get; set; }

    public decimal? RemiseGlobal { get; set; }

    public bool? TeypGlobal { get; set; }

    public bool? Tva { get; set; }

    public bool? Ttc { get; set; }

    public string? Obs { get; set; }

    public bool? CheckExpiration { get; set; }

    public string? Meta { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdModRglm { get; set; }

    public int? IdDepot { get; set; }

    public int? IdDepot2 { get; set; }

    public int? IdClient { get; set; }

    public int? IdFournisseur { get; set; }

    public string? CodeType { get; set; }

    public int? IdDossier { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdVendeur { get; set; }

    public string? Terms { get; set; }

    public string? MetaImpression { get; set; }

    public string? ProprieteClient { get; set; }

    public string? TypeLigne { get; set; }

    public DateTime? DateValidation { get; set; }

    public bool? CheckCopierVers { get; set; }

    public int? IdFamille { get; set; }

    public int? IdDestinataire { get; set; }

    public string? NomDestinataire { get; set; }

    public string? Truck { get; set; }

    public double? TauxPlastique { get; set; }

    public double? SumNetWeight { get; set; }

    public double? SumUnitePrice { get; set; }

    public double? ChangeDh { get; set; }

    public string? CertificatEuro { get; set; }

    public string? LotePf { get; set; }

    public string? MtPremier { get; set; }

    public int? NumeroTaux { get; set; }

    public string? Lote { get; set; }

    public double? TauxGalce { get; set; }

    public bool? InternationalCheck { get; set; }

    public double? PesoBruto { get; set; }

    public double? MateriaPrima { get; set; }

    public double? PesoNetoEscurido { get; set; }

    public double? PesoNeto { get; set; }

    public int? IdEntetS { get; set; }

    public string? ExpeditoPPlt { get; set; }

    public DateOnly? FechaPPlt { get; set; }

    public string? FacturePPlt { get; set; }

    public double? QuantitePPlt { get; set; }

    public string? ExpeditoLpPlt { get; set; }

    public DateOnly? FechaLpPlt { get; set; }

    public string? FactureLpPlt { get; set; }

    public double? QuantiteLpPlt { get; set; }

    public string? DetlpPlt { get; set; }

    public virtual ICollection<EEntetLign> EEntetLigns { get; set; } = new List<EEntetLign>();

    public virtual TClient? IdClientNavigation { get; set; }

    public virtual BDepot? IdDepot2Navigation { get; set; }

    public virtual BDepot? IdDepotNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual AFamille? IdFamilleNavigation { get; set; }

    public virtual TFournisseur? IdFournisseurNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BModRglm? IdModRglmNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();
}
