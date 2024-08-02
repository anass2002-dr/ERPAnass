using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BService
{
    public int IdService { get; set; }

    public string? NomService { get; set; }

    public string? DescService { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual ICollection<FishCharge> FishCharges { get; set; } = new List<FishCharge>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<TrTresorerieEntet> TrTresorerieEntets { get; set; } = new List<TrTresorerieEntet>();
}
