using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PTicket
{
    public int IdTicket { get; set; }

    public int? NumTicket { get; set; }

    public decimal? Total { get; set; }

    public DateTime? DateCreation { get; set; }

    public int? IdCaissier { get; set; }

    public bool? IsCancel { get; set; }

    public DateTime? DateCancel { get; set; }

    public bool? IsClosed { get; set; }

    public int? IdSession { get; set; }

    public int? IdClient { get; set; }

    public virtual PCaissier? IdCaissierNavigation { get; set; }

    public virtual TClient? IdClientNavigation { get; set; }

    public virtual PSession? IdSessionNavigation { get; set; }

    public virtual ICollection<PTicketLigne> PTicketLignes { get; set; } = new List<PTicketLigne>();

    public virtual ICollection<PTicketReg> PTicketRegs { get; set; } = new List<PTicketReg>();
}
