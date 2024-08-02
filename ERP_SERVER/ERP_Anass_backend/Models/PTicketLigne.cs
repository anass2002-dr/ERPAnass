using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PTicketLigne
{
    public int IdLigne { get; set; }

    public int? IdTicket { get; set; }

    public DateTime? DateCreation { get; set; }

    public int? Idproduct { get; set; }

    public decimal? Price { get; set; }

    public string? Umvente { get; set; }

    public int? Qte { get; set; }

    public double? Rem { get; set; }

    public decimal? Total { get; set; }

    public bool? CheckVenduGrand { get; set; }

    public virtual PTicket? IdTicketNavigation { get; set; }

    public virtual AArticle? IdproductNavigation { get; set; }
}
