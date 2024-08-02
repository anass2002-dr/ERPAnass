using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PFamille
{
    public int? IdPos { get; set; }

    public int? IdFamille { get; set; }

    public virtual AFamille? IdFamilleNavigation { get; set; }

    public virtual PPo? IdPosNavigation { get; set; }
}
