using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCalculAvance
{
    public int IdAvance { get; set; }

    public int? IdEmploye { get; set; }

    public DateTime? DateAvance { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? Montant { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public bool? Cloturer { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
