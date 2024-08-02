using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BDepotSup
{
    public int IdSupDepot { get; set; }

    public string? NomSupDepot { get; set; }

    public bool? PrcpSupDepot { get; set; }

    public string? InfoSupDepot { get; set; }

    public int? IdDepot { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? TypeSupDepot { get; set; }

    public string? CouloirX { get; set; }

    public string? RayonY { get; set; }

    public string? Hauteur { get; set; }

    public string? CodeBare { get; set; }

    public virtual ICollection<EEntetLign> EEntetLignIdSupDepot2Navigations { get; set; } = new List<EEntetLign>();

    public virtual ICollection<EEntetLign> EEntetLignIdSupDepotNavigations { get; set; } = new List<EEntetLign>();

    public virtual ICollection<FOrdreLine> FOrdreLines { get; set; } = new List<FOrdreLine>();

    public virtual ICollection<FOrdre> FOrdres { get; set; } = new List<FOrdre>();

    public virtual BDepot? IdDepotNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
