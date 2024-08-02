using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class FFabrication
{
    public int IdFabrication { get; set; }

    public int? IdArticle { get; set; }

    public string? Reference { get; set; }

    public string? Info { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<FFabricationLign> FFabricationLigns { get; set; } = new List<FFabricationLign>();

    public virtual ICollection<FOrdre> FOrdres { get; set; } = new List<FOrdre>();

    public virtual AArticle? IdArticleNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
