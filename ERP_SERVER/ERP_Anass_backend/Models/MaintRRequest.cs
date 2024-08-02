using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class MaintRRequest
{
    public int IdRequest { get; set; }

    public int? NumRequest { get; set; }

    public string? NomRequest { get; set; }

    public string? EtatRequest { get; set; }

    public string? TypeMaint { get; set; }

    public string? DescMaint { get; set; }

    public string? LieuMaint { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdDossier { get; set; }

    public int? IdTeam { get; set; }

    public int? IdEquipement { get; set; }

    public string? ProgressType { get; set; }

    public int? PositionOrdre { get; set; }

    public DateTime? DateRequest { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual MaintAEquipement? IdEquipementNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual MaintSTeam? IdTeamNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
