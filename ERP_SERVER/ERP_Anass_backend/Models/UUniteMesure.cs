using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class UUniteMesure
{
    public int IdUnite { get; set; }

    public string? DescUnite { get; set; }

    public int? IdGroup { get; set; }

    public bool? PrcpUnite { get; set; }

    public string? IdUser { get; set; }

    public virtual ICollection<AArticle> AArticles { get; set; } = new List<AArticle>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
