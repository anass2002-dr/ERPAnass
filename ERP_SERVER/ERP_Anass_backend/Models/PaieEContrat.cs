using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieEContrat
{
    public int IdContrat { get; set; }

    public string? NumContrat { get; set; }

    public DateTime? DateContrat { get; set; }

    public int? IdProfil { get; set; }

    public DateTime? PeriodeD { get; set; }

    public DateTime? PeriodeF { get; set; }

    public string? ObservationC { get; set; }

    public int? IdEmploye { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual PaieIProfilContrat? IdProfilNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<SFille> IdFilles { get; set; } = new List<SFille>();
}
