using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class ABateau
{
    public int IdBateau { get; set; }

    public int? IdArticle { get; set; }

    public int? IdClient { get; set; }

    public double? DimensionX { get; set; }

    public double? DimensionY { get; set; }

    public decimal? PrixM { get; set; }

    public bool? CheckCollaboration { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public bool? Valider { get; set; }

    public bool? Clotur { get; set; }

    public virtual AArticle? IdArticleNavigation { get; set; }

    public virtual TClient? IdClientNavigation { get; set; }
}
