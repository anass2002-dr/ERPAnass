using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieITauxFraisProf
{
    public int IdTaux { get; set; }

    public string? CodeTaux { get; set; }

    public string? LibelleTaux { get; set; }

    public double? Taux { get; set; }

    public double? Plafond { get; set; }

    public string? RefTaux { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
