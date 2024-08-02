using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FishEntetLign
{
    public int IdLign { get; set; }

    public int? IdEntet { get; set; }

    public int? IdFamille { get; set; }

    public string? DescLign { get; set; }

    public string? Calibre { get; set; }

    public double? Quantite { get; set; }

    public double? Prix { get; set; }

    public double? PrixTotal { get; set; }

    public string? CodePlt { get; set; }

    public double? Pn { get; set; }

    public double? Cais { get; set; }

    public double? CaisInvt { get; set; }

    public double? Pninvt { get; set; }

    public virtual FishEntet? IdEntetNavigation { get; set; }

    public virtual AFamille? IdFamilleNavigation { get; set; }
}
