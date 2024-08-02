using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelBBookingLigne
{
    public int IdBookingLigne { get; set; }

    public int? IdBookingEntete { get; set; }

    public int? IdRoomType { get; set; }

    public int? IdUnit { get; set; }

    public int? Guests { get; set; }

    public decimal? PrixTtc { get; set; }

    public decimal? PrixHt { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? PriceModel { get; set; }

    public decimal? TtprixTtc { get; set; }

    public decimal? TtprixHt { get; set; }

    public int? LgnTva { get; set; }

    public string? IdUser { get; set; }

    public virtual HotelBBookingEntete? IdBookingEnteteNavigation { get; set; }

    public virtual HotelSRoomType? IdRoomTypeNavigation { get; set; }

    public virtual HotelSUnit? IdUnitNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
