using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelBBookingExtra
{
    public int IdBookingExtra { get; set; }

    public int? IdBookingEntete { get; set; }

    public int? IdExtras { get; set; }

    public string? Description { get; set; }

    public int? Qte { get; set; }

    public decimal? PrixExtra { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? TotalExtras { get; set; }

    public virtual HotelBBookingEntete? IdBookingEnteteNavigation { get; set; }

    public virtual HotelSExtra? IdExtrasNavigation { get; set; }
}
