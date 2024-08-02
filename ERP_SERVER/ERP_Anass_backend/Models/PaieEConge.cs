using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieEConge
{
    public int IdConge { get; set; }

    public int? IdEmploye { get; set; }

    public int? Annee { get; set; }

    public int? NumberMonths { get; set; }

    public double? JConsommes { get; set; }

    public double? JCongeN1 { get; set; }

    public double? JCongeN { get; set; }

    public double? JRestes { get; set; }

    public int? IdDossier { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
