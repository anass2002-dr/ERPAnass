using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class MaintAEquipement
{
    public int IdEquipement { get; set; }

    public string? ModeleEquipement { get; set; }

    public string? NumeroSerie { get; set; }

    public decimal? CoutEquipement { get; set; }

    public DateTime? DateGarantie { get; set; }

    public DateTime? DateEffet { get; set; }

    public int? IdLign { get; set; }

    public int? IdArticle { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual AArticle? IdArticleNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual EEntetLign? IdLignNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<MaintRRequest> MaintRRequests { get; set; } = new List<MaintRRequest>();
}
