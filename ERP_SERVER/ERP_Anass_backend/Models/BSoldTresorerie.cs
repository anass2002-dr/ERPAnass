using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BSoldTresorerie
{
    public int IdTreso { get; set; }

    public int IdDossier { get; set; }

    public decimal? SoldTresorerie { get; set; }

    public virtual SDossier IdDossierNavigation { get; set; } = null!;

    public virtual BTresorerie IdTresoNavigation { get; set; } = null!;
}
