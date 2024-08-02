using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PModRglm
{
    public int? IdModRglm { get; set; }

    public int? IdPos { get; set; }

    public bool? Defaults { get; set; }

    public virtual BModRglm? IdModRglmNavigation { get; set; }

    public virtual PPo? IdPosNavigation { get; set; }
}
