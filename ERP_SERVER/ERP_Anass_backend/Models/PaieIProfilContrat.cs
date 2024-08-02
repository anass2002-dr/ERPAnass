using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieIProfilContrat
{
    public int IdProfil { get; set; }

    public string? NomProfil { get; set; }

    public bool? PartSalariel { get; set; }

    public bool? AllFamiliel { get; set; }

    public bool? FormationProf { get; set; }

    public bool? CotisationPatr { get; set; }

    public bool? IR { get; set; }

    public double? PlafondIr { get; set; }

    public string? TypeProfil { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieEContrat> PaieEContrats { get; set; } = new List<PaieEContrat>();
}
