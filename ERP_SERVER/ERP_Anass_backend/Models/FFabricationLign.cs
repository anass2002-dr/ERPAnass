using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FFabricationLign
{
    public int IdLignFab { get; set; }

    public int? IdFabrication { get; set; }

    public int? IdLignArticle { get; set; }

    public double? QteFabrication { get; set; }

    public double? QteLignFabrication { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual FFabrication? IdFabricationNavigation { get; set; }

    public virtual AArticle? IdLignArticleNavigation { get; set; }
}
