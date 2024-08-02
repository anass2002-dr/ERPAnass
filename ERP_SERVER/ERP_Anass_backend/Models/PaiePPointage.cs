using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaiePPointage
{
    public int IdPointage { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public string? Mois { get; set; }

    public string? DescrPointage { get; set; }

    public int? NumPointage { get; set; }

    public int? IdDossier { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaiePPointageLigne> PaiePPointageLignes { get; set; } = new List<PaiePPointageLigne>();
}
