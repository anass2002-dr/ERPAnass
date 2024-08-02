using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieEPret
{
    public int IdPret { get; set; }

    public decimal? Reliquant { get; set; }

    public decimal? MontantTotal { get; set; }

    public int? NbEcheance { get; set; }

    public decimal? MontantEcheance { get; set; }

    public decimal? MontantDernierEcheance { get; set; }

    public DateTime? DateEcheanceD { get; set; }

    public DateTime? DateEcheanceF { get; set; }

    public string? CodeRubrique { get; set; }

    public string? Observation { get; set; }

    public int? IdEmploye { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
