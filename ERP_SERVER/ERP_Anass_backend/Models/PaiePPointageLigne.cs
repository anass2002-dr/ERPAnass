using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaiePPointageLigne
{
    public int IdPointageLigne { get; set; }

    public int? IdEmploye { get; set; }

    public TimeOnly? HeureEntree { get; set; }

    public TimeOnly? HeureSortire { get; set; }

    public double? Kgs { get; set; }

    public int? IdPointage { get; set; }

    public int? HeureSupp { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual PaiePPointage? IdPointageNavigation { get; set; }
}
