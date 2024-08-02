using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PPo
{
    public int IdPos { get; set; }

    public string? TokenPos { get; set; }

    public string? NamePos { get; set; }

    public string? TitrePos { get; set; }

    public string? SouTitrePos { get; set; }

    public string? MsgPos { get; set; }

    public bool? CheckEmail { get; set; }

    public string? EmailSend { get; set; }

    public bool? CheckOpenSession { get; set; }

    public int? IdTreso { get; set; }

    public int? IdDepot { get; set; }

    public int? ClientDivers { get; set; }

    public int? IdDossier { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public virtual TClient? ClientDiversNavigation { get; set; }

    public virtual BDepot? IdDepotNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BTresorerie? IdTresoNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PSession> PSessions { get; set; } = new List<PSession>();
}
