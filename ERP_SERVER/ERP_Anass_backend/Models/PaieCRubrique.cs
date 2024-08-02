using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCRubrique
{
    public int IdRubrique { get; set; }

    public int? CodeRubrique { get; set; }

    public string? LibelleRubrique { get; set; }

    public string? CodeExo { get; set; }

    public bool? Imposable { get; set; }

    public bool? Positive { get; set; }

    public double? Valeur { get; set; }

    public double? Taux { get; set; }

    public double? TauxPenalite { get; set; }

    public double? TauxMajoration1 { get; set; }

    public double? TauxMajorationAutres { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
