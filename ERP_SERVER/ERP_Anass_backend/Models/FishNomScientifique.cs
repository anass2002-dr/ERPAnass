using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FishNomScientifique
{
    public long IdNomScientifique { get; set; }

    public string? NomScientifique { get; set; }

    public int IdGroup { get; set; }

    public virtual ICollection<AFamille> AFamilles { get; set; } = new List<AFamille>();

    public virtual ICollection<FishFamille> FishFamilles { get; set; } = new List<FishFamille>();

    public virtual SGroupUser IdGroupNavigation { get; set; } = null!;
}
