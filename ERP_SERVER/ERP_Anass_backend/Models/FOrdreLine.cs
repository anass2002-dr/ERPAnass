using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FOrdreLine
{
    public int IdOrdreLine { get; set; }

    public double? QteOrdreLine { get; set; }

    public decimal? Cmup { get; set; }

    public decimal? TtHt { get; set; }

    public string? TypeOrdre { get; set; }

    public int? ValStock { get; set; }

    public int? IdLignArticle { get; set; }

    public int? IdOrdre { get; set; }

    public int? IdDepot { get; set; }

    public int? IdSupDepot { get; set; }

    public int? IdDossier { get; set; }

    public virtual BDepot? IdDepotNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual AArticle? IdLignArticleNavigation { get; set; }

    public virtual FOrdre? IdOrdreNavigation { get; set; }

    public virtual BDepotSup? IdSupDepotNavigation { get; set; }
}
