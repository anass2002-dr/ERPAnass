using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class EArtDepot
{
    public int? IdArticle { get; set; }

    public int? IdDepot { get; set; }

    public int? IdSupDepot { get; set; }

    public double? QteDepot { get; set; }

    public decimal? Cmup { get; set; }

    public decimal? LastPrix { get; set; }

    public decimal? FirstPrix { get; set; }

    public int? IdDossier { get; set; }

    public virtual BDepot? IdDepotNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual BDepotSup? IdSupDepotNavigation { get; set; }
}
