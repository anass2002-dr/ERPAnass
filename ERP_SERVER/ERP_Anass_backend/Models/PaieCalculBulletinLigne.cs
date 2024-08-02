using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCalculBulletinLigne
{
    public int IdBulletinLigne { get; set; }

    public int? IdBulletin { get; set; }

    public int? IdEmploye { get; set; }

    public double? SalaireBase { get; set; }

    public double? TotalPrixSupp { get; set; }

    public int? NbHeurSup { get; set; }

    public double? TotalKgs { get; set; }

    public double? TotalPrixKgs { get; set; }

    public double? SalaireTotal { get; set; }

    public int? NbJours { get; set; }

    public int? Nbconge { get; set; }

    public int? NombreHeurs { get; set; }

    public virtual PaieCalculBulletin? IdBulletinNavigation { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }
}
