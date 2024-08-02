using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCalculGrpEntete
{
    public int IdGrpEnt { get; set; }

    public int? NumPaie { get; set; }

    public DateTime? DatePaie { get; set; }

    public bool? Valider { get; set; }

    public bool? Cloturer { get; set; }

    public int? Mois { get; set; }

    public DateTime? PeriodeD { get; set; }

    public DateTime? PeriodeF { get; set; }

    public int? IdDossier { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? DescPaie { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieCalculEntete> PaieCalculEntetes { get; set; } = new List<PaieCalculEntete>();
}
