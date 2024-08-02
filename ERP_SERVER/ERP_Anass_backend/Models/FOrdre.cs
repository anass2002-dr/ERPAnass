using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FOrdre
{
    public int IdOrdre { get; set; }

    public int? NumOrdre { get; set; }

    public double? QteOrdre { get; set; }

    public decimal? TtHt { get; set; }

    public DateTime? DatePlanification { get; set; }

    public DateTime? DateEndPlanification { get; set; }

    public int? PositionOrdre { get; set; }

    public string? ProgressType { get; set; }

    public int? IdDepot { get; set; }

    public int? IdSupDepot { get; set; }

    public int? IdFabrication { get; set; }

    public int? IdArticle { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdDossier { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Valider { get; set; }

    public int? NumberPerson { get; set; }

    public virtual ICollection<FOrdreLine> FOrdreLines { get; set; } = new List<FOrdreLine>();

    public virtual AArticle? IdArticleNavigation { get; set; }

    public virtual BDepot? IdDepotNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual FFabrication? IdFabricationNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BDepotSup? IdSupDepotNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
