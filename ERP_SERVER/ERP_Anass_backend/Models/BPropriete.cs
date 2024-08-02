using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BPropriete
{
    public int IdPropriete { get; set; }

    public string? NomPropriete { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
