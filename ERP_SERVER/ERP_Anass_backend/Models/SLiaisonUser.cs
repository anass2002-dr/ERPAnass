using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SLiaisonUser
{
    public string? IdUser { get; set; }

    public int? IdDepot { get; set; }

    public int? IdTreso { get; set; }

    public int? IdVille { get; set; }

    public int? IdPays { get; set; }

    public virtual BDepot? IdDepotNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual BTresorerie? IdTresoNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual BVille? IdVilleNavigation { get; set; }
}
