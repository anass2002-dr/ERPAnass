using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FishFamille
{
    public int IdFamille { get; set; }

    public string? CdeFao { get; set; }

    public string? Marchandises { get; set; }

    public long? IdNomScientifique { get; set; }

    public long? IdTypeFamaille { get; set; }

    public int? IdPays { get; set; }

    public string? IdUser { get; set; }

    public int IdGroup { get; set; }

    public virtual SGroupUser IdGroupNavigation { get; set; } = null!;

    public virtual FishNomScientifique? IdNomScientifiqueNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual FishTypeFamaille? IdTypeFamailleNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
