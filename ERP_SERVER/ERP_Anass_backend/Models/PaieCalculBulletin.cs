using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCalculBulletin
{
    public int IdBulletin { get; set; }

    public int? NumBulletin { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? PeriodeD { get; set; }

    public DateTime? PeriodeF { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdDossier { get; set; }

    public bool? Valider { get; set; }

    public string? DescPaie { get; set; }

    public bool? Cloturer { get; set; }

    public int? Mois { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieCalculBulletinLigne> PaieCalculBulletinLignes { get; set; } = new List<PaieCalculBulletinLigne>();
}
