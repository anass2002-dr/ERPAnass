using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieZPlanning
{
    public int IdPlanning { get; set; }

    public string? NomPlanning { get; set; }

    public TimeOnly? HeureDepartDe { get; set; }

    public TimeOnly? HeureDepartA { get; set; }

    public TimeOnly? HeurePauseDe { get; set; }

    public TimeOnly? HeurePauseA { get; set; }

    public TimeOnly? HeureSortie { get; set; }

    public bool? CheckPause { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieEEmploye> PaieEEmployes { get; set; } = new List<PaieEEmploye>();
}
