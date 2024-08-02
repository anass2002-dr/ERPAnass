using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class EEmail
{
    public int IdEmail { get; set; }

    public string? To { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public string? Uid { get; set; }

    public string? Folder { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? DateEmail { get; set; }

    public string? Attachements { get; set; }

    public bool? Seen { get; set; }

    public string? FromName { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<SFille> IdFilles { get; set; } = new List<SFille>();
}
