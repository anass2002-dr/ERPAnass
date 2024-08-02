using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class EEntetLign
{
    public int IdLign { get; set; }

    public int? IdEntet { get; set; }

    public int? IdArticle { get; set; }

    public string? RefArticle { get; set; }

    public string? DescLign { get; set; }

    public double? QteLign { get; set; }

    public decimal? PrixTtc { get; set; }

    public decimal? PrixHt { get; set; }

    public decimal? LgnTtc { get; set; }

    public decimal? LgnHt { get; set; }

    public decimal? LgnRemise { get; set; }

    public decimal? LgnTva { get; set; }

    public decimal? LgnCmup { get; set; }

    public decimal? LgnMargeCmup { get; set; }

    public decimal? LgnMargePxAcha { get; set; }

    public decimal? LgnTauxMargeCmup { get; set; }

    public decimal? LgnTauxMargePxAcha { get; set; }

    public int? ValStock { get; set; }

    public int? ValCmup { get; set; }

    public DateTime? DateExpiration { get; set; }

    public string? Meta { get; set; }

    public string? LgnUnite { get; set; }

    public string? LgnUrgence { get; set; }

    public int? IdSupDepot { get; set; }

    public int? IdSupDepot2 { get; set; }

    public string? IdUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? LgnValeurCmup { get; set; }

    public decimal? LgnValeurPxAcha { get; set; }

    public decimal? LgnPxAcha { get; set; }

    public double? LastQte { get; set; }

    public string? DateLigne { get; set; }

    public int? SortOrder { get; set; }

    public double? PackageEmvase { get; set; }

    public double? GrossWeight { get; set; }

    public double? DrainedNetWeight { get; set; }

    public double? NetWeight { get; set; }

    public string? FrozenDate { get; set; }

    public string? Lote { get; set; }

    public string? DuaLigne { get; set; }

    public string? LotePfLigne { get; set; }

    public double? PesoNetoLigne { get; set; }

    public DateOnly? DateCongelationLigne { get; set; }

    public string? CodePdFini { get; set; }

    public double? QtebyDua { get; set; }

    public double? SinAgua { get; set; }

    public virtual AArticle? IdArticleNavigation { get; set; }

    public virtual EEntet? IdEntetNavigation { get; set; }

    public virtual BDepotSup? IdSupDepot2Navigation { get; set; }

    public virtual BDepotSup? IdSupDepotNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<MaintAEquipement> MaintAEquipements { get; set; } = new List<MaintAEquipement>();
}
