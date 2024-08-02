using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PSession
{
    public int IdSession { get; set; }

    public int? IdPos { get; set; }

    public DateTime? DateOpen { get; set; }

    public int? CaissierOpen { get; set; }

    public decimal? SoldeOpen { get; set; }

    public DateTime? DateClose { get; set; }

    public int? CaissierClose { get; set; }

    public decimal? SoldeClose { get; set; }

    public bool? Closed { get; set; }

    public decimal? TotalCaissier { get; set; }

    public virtual PCaissier? CaissierCloseNavigation { get; set; }

    public virtual PCaissier? CaissierOpenNavigation { get; set; }

    public virtual PPo? IdPosNavigation { get; set; }

    public virtual ICollection<PTicket> PTickets { get; set; } = new List<PTicket>();
}
