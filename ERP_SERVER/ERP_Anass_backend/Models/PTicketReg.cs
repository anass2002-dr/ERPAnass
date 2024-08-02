using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PTicketReg
{
    public int IdPaiment { get; set; }

    public int? IdTicket { get; set; }

    public int? IdModRglm { get; set; }

    public decimal? Mantant { get; set; }

    public virtual BModRglm? IdModRglmNavigation { get; set; }

    public virtual PTicket? IdTicketNavigation { get; set; }
}
