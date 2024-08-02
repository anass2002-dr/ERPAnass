using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class MaintSMember
{
    public int IdMember { get; set; }

    public int? IdEmploye { get; set; }

    public int? IdFournisseur { get; set; }

    public int? IdTeam { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual TFournisseur? IdFournisseurNavigation { get; set; }

    public virtual MaintSTeam? IdTeamNavigation { get; set; }
}
