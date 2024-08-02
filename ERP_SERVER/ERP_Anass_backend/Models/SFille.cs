using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SFille
{
    public int IdFille { get; set; }

    public string? NameFile { get; set; }

    public string? PathFile { get; set; }

    public string? TypeFile { get; set; }

    public string? SizeFile { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieEContrat> IdContrats { get; set; } = new List<PaieEContrat>();

    public virtual ICollection<EEmail> IdEmails { get; set; } = new List<EEmail>();
}
