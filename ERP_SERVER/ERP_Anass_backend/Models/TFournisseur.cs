using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class TFournisseur
{
    public int IdFournisseur { get; set; }

    public string? CodeFournisseur { get; set; }

    public string? NomFournisseur { get; set; }

    public string? AdresseFournisseur { get; set; }

    public string? PostalFournisseur { get; set; }

    public string? IceFournisseur { get; set; }

    public string? CnssFournisseur { get; set; }

    public string? NifFournisseur { get; set; }

    public string? PatenteFournisseur { get; set; }

    public string? SiegeFournisseur { get; set; }

    public string? BanqueFournisseur { get; set; }

    public string? RibFournisseur { get; set; }

    public decimal? SoldAutoriseFournisseur { get; set; }

    public string? FrmJuridiqueFournisseur { get; set; }

    public string? EmailFournisseur { get; set; }

    public string? TeleFournisseur { get; set; }

    public string? FixFournisseur { get; set; }

    public string? TypeFournisseur { get; set; }

    public bool? ContratFournisseur { get; set; }

    public bool? Fournisseur { get; set; }

    public bool? SousTraitance { get; set; }

    public DateTime? Createdate { get; set; }

    public int? IdVille { get; set; }

    public int? IdPays { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public string? CinFournisseur { get; set; }

    public string? PotentielFr { get; set; }

    public string? CategorieFr { get; set; }

    public string? OrigineContactFr { get; set; }

    public string? SitewebFr { get; set; }

    public virtual ICollection<EEntet> EEntets { get; set; } = new List<EEntet>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual BVille? IdVilleNavigation { get; set; }

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();
}
