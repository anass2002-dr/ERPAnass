using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FishTypeFamaille
{
    public long IdTypeFamaille { get; set; }

    public string? TypeFamaille { get; set; }

    public int IdGroup { get; set; }

    public virtual ICollection<AFamille> AFamilles { get; set; } = new List<AFamille>();

    public virtual ICollection<FishFamille> FishFamilles { get; set; } = new List<FishFamille>();

    public virtual SGroupUser IdGroupNavigation { get; set; } = null!;
}
