using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SRole
{
    public int IdRole { get; set; }

    public string? NameRole { get; set; }

    public bool? InsertRole { get; set; }

    public bool? UpdateRole { get; set; }

    public bool? DeleteRole { get; set; }

    public bool? SelectByUser { get; set; }

    public bool? SelectAll { get; set; }

    public bool? SelectDoc { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdGroup { get; set; }

    public bool? ImprimerRole { get; set; }

    public bool? Valider { get; set; }

    public bool? SelectArticles { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual ICollection<SUser> IdUsers { get; set; } = new List<SUser>();
}
