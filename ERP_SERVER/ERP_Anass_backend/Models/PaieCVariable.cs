using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCVariable
{
    public int IdVariable { get; set; }

    public string? CodeVar { get; set; }

    public string? LibelleVar { get; set; }

    public decimal? ValeurVar { get; set; }

    public bool? PropreSal { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
