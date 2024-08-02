using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCalculEntete
{
    public int IdEntete { get; set; }

    public int? IdEmploye { get; set; }

    public int? IdGrpEnt { get; set; }

    public decimal? SalaireBase { get; set; }

    public decimal? TotalBrut { get; set; }

    public DateTime? CreateDate { get; set; }

    public double? JoursTravail { get; set; }

    public double? HS0 { get; set; }

    public double? HS25 { get; set; }

    public double? HS50 { get; set; }

    public double? HS100 { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual PaieCalculGrpEntete? IdGrpEntNavigation { get; set; }

    public virtual ICollection<PaieCalculLigneRubrique> PaieCalculLigneRubriques { get; set; } = new List<PaieCalculLigneRubrique>();
}
