using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BTresorerie
{
    public int IdTreso { get; set; }

    public string? NameTreso { get; set; }

    public decimal? SoldAutoriseTreso { get; set; }

    public decimal? CherfTreso { get; set; }

    public bool? DefaultTreso { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public string? AdresseTreso { get; set; }

    public string? RibTreso { get; set; }

    public virtual ICollection<BSoldTresorerie> BSoldTresoreries { get; set; } = new List<BSoldTresorerie>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PPo> PPos { get; set; } = new List<PPo>();

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();

    public virtual ICollection<TrTresorerieEntet> TrTresorerieEntetIdTreso2Navigations { get; set; } = new List<TrTresorerieEntet>();

    public virtual ICollection<TrTresorerieEntet> TrTresorerieEntetIdTresoNavigations { get; set; } = new List<TrTresorerieEntet>();
}
