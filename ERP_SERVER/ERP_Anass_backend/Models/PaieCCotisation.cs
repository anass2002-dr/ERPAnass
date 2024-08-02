using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCCotisation
{
    public int IdCotisation { get; set; }

    public int? CodeCotis { get; set; }

    public string? LibelleCotis { get; set; }

    public double? PartSalariel { get; set; }

    public double? PrestationSoc { get; set; }

    public double? AllFamilial { get; set; }

    public double? FormationProf { get; set; }

    public double? Plafond { get; set; }

    public double? CotisationPatr { get; set; }

    public double? TauxPenalite { get; set; }

    public double? TauxMajoration1 { get; set; }

    public double? TauxMajorationAutres { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdEmploye { get; set; }

    public string? TypeCoti { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
