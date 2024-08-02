using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PCaissier
{
    public int IdCaissier { get; set; }

    public string? NameCaissier { get; set; }

    public string? PassCaissier { get; set; }

    public bool? AdminCaissier { get; set; }

    public bool? AvoirCheck { get; set; }

    public bool? PrixCheck { get; set; }

    public bool? RemCheck { get; set; }

    public bool? FermerCheck { get; set; }

    public bool? ArchiveChecke { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public bool? AnulatinTicket { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PSession> PSessionCaissierCloseNavigations { get; set; } = new List<PSession>();

    public virtual ICollection<PSession> PSessionCaissierOpenNavigations { get; set; } = new List<PSession>();

    public virtual ICollection<PTicket> PTickets { get; set; } = new List<PTicket>();
}
