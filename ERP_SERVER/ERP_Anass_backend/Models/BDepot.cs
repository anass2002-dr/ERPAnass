using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BDepot
{
    public int IdDepot { get; set; }

    public string? NomDepot { get; set; }

    public string? AdressDepot { get; set; }

    public bool? PrcpDepot { get; set; }

    public int? IdVille { get; set; }

    public int? IdPays { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<BDepotSup> BDepotSups { get; set; } = new List<BDepotSup>();

    public virtual ICollection<EEntet> EEntetIdDepot2Navigations { get; set; } = new List<EEntet>();

    public virtual ICollection<EEntet> EEntetIdDepotNavigations { get; set; } = new List<EEntet>();

    public virtual ICollection<FOrdreLine> FOrdreLines { get; set; } = new List<FOrdreLine>();

    public virtual ICollection<FOrdre> FOrdres { get; set; } = new List<FOrdre>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual BVille? IdVilleNavigation { get; set; }

    public virtual ICollection<PPo> PPos { get; set; } = new List<PPo>();
}
