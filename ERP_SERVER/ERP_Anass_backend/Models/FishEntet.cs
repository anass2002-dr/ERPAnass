using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FishEntet
{
    public int IdEntet { get; set; }

    public int? NumFactur { get; set; }

    public string? RefFacture { get; set; }

    public int? IdFournisseur { get; set; }

    public DateOnly? DateEntet { get; set; }

    public int? IdPays { get; set; }

    public string? Etat { get; set; }

    public int? IdFamille { get; set; }

    public double? StockEntree { get; set; }

    public double? StockTaxable { get; set; }

    public double? TotalAchat { get; set; }

    public double? Pm { get; set; }

    public double? TotalCharges { get; set; }

    public double? Comission { get; set; }

    public int? IdDossier { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdClient { get; set; }

    public string? CodeType { get; set; }

    public int? IdPort { get; set; }

    public double? KgRec { get; set; }

    public bool? Valider { get; set; }

    public string? EtatDoc { get; set; }

    public bool? Clotur { get; set; }

    public string? Barco { get; set; }

    public double? TotalCais { get; set; }

    public double? TotalPn { get; set; }

    public string? Lote { get; set; }

    public string? Dua { get; set; }

    public DateOnly? DateCongele { get; set; }

    public int? IdEntetS { get; set; }

    public string? NumBonPlt { get; set; }

    public double? QuantitePlt { get; set; }

    public string? FacturNumPlt { get; set; }

    public string? DuaPlt { get; set; }

    public DateOnly? DatePlt { get; set; }

    public string? NumBonLPlt { get; set; }

    public double? QuantiteLPlt { get; set; }

    public DateOnly? DateLPlt { get; set; }

    public string? FacturNumLPlt { get; set; }

    public string? DuaLPlt { get; set; }

    public string? LoteLPlt { get; set; }

    public virtual ICollection<FishEntetLign> FishEntetLigns { get; set; } = new List<FishEntetLign>();

    public virtual TClient? IdClientNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual AFamille? IdFamilleNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual FishPort? IdPortNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();
}
