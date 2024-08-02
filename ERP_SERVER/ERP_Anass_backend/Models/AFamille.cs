using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class AFamille
{
    public int IdFamille { get; set; }

    public string? NomFamille { get; set; }

    public string? DesFamille { get; set; }

    public string? PhotoFamille { get; set; }

    public bool? WooFamille { get; set; }

    public int? ParentId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdWooCategories { get; set; }

    public long? IdTypeFamaille { get; set; }

    public long? IdNomScientifique { get; set; }

    public string? CdeFao { get; set; }

    public int? IdPays { get; set; }

    public virtual ICollection<AArticle> AArticles { get; set; } = new List<AArticle>();

    public virtual ICollection<EEntet> EEntets { get; set; } = new List<EEntet>();

    public virtual ICollection<FishEntetLign> FishEntetLigns { get; set; } = new List<FishEntetLign>();

    public virtual ICollection<FishEntet> FishEntets { get; set; } = new List<FishEntet>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual FishNomScientifique? IdNomScientifiqueNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual FishTypeFamaille? IdTypeFamailleNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
