using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class TrTresorerieEntet
{
    public int IdTresoEntet { get; set; }

    public int? NumTresoEntet { get; set; }

    public DateTime? DateTresoEntet { get; set; }

    public DateTime? DateEcheanche { get; set; }

    public string? Banque { get; set; }

    public string? NumCheque { get; set; }

    public string? EtatDoc { get; set; }

    public decimal? Montant { get; set; }

    public string? DescTresoEntet { get; set; }

    public string? CodeType { get; set; }

    public int? IdModRglm { get; set; }

    public int? IdTreso { get; set; }

    public int? IdTreso2 { get; set; }

    public int? IdService { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdDossier { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BModRglm? IdModRglmNavigation { get; set; }

    public virtual BService? IdServiceNavigation { get; set; }

    public virtual BTresorerie? IdTreso2Navigation { get; set; }

    public virtual BTresorerie? IdTresoNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
