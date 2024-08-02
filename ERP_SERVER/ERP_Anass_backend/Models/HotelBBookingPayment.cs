using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelBBookingPayment
{
    public int IdBookingPayment { get; set; }

    public int? IdBookingEntete { get; set; }

    public string? Comment { get; set; }

    public int? IdModRglm { get; set; }

    public decimal? Montant { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? DatePayment { get; set; }

    public virtual HotelBBookingEntete? IdBookingEnteteNavigation { get; set; }

    public virtual BModRglm? IdModRglmNavigation { get; set; }
}
