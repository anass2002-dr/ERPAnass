using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCalculConge
{
    public int IdCng { get; set; }

    public int? IdEmploye { get; set; }

    public DateTime? PeriodeDebut { get; set; }

    public DateTime? PeriodeFin { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public int? IdDossier { get; set; }

    public int? NbJours { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
