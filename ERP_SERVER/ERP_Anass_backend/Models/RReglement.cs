using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class RReglement
{
    public int IdReglement { get; set; }

    public int? NumReglement { get; set; }

    public DateTime? DateReglement { get; set; }

    public string? Banque { get; set; }

    public string? NumCheque { get; set; }

    public DateTime? DateEcheanche { get; set; }

    public string? Nom { get; set; }

    public string? Info { get; set; }

    public string? EtatReg { get; set; }

    public int? IdModRglm { get; set; }

    public int? IdTreso { get; set; }

    public int? IdClient { get; set; }

    public int? IdFournisseur { get; set; }

    public string? CodeType { get; set; }

    public string? IdUser { get; set; }

    public int? IdDossier { get; set; }

    public int? IdEntet { get; set; }

    public int? IdGroup { get; set; }

    public decimal? Montant { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdEntetFish { get; set; }

    public virtual TClient? IdClientNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual FishEntet? IdEntetFishNavigation { get; set; }

    public virtual EEntet? IdEntetNavigation { get; set; }

    public virtual TFournisseur? IdFournisseurNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BModRglm? IdModRglmNavigation { get; set; }

    public virtual BTresorerie? IdTresoNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
