using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class RReglementInFille
{
    public int? IdFille { get; set; }

    public int? IdReglement { get; set; }

    public virtual SFille? IdFilleNavigation { get; set; }

    public virtual RReglement? IdReglementNavigation { get; set; }
}
