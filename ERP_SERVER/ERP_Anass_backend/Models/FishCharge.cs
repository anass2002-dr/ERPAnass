using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FishCharge
{
    public int IdCharge { get; set; }

    public int? IdEntet { get; set; }

    public int? IdService { get; set; }

    public double? Cout { get; set; }

    public int IdGroup { get; set; }

    public virtual SGroupUser IdGroupNavigation { get; set; } = null!;

    public virtual BService? IdServiceNavigation { get; set; }
}
