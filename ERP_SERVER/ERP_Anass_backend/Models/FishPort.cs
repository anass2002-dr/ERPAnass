using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FishPort
{
    public int IdPort { get; set; }

    public string? NomPort { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public virtual ICollection<FishEntet> FishEntets { get; set; } = new List<FishEntet>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
