using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelSUnit
{
    public int IdUnit { get; set; }

    public string? UnitName { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdRoomType { get; set; }

    public string? IdUser { get; set; }

    public virtual ICollection<HotelBBookingLigne> HotelBBookingLignes { get; set; } = new List<HotelBBookingLigne>();

    public virtual HotelSRoomType? IdRoomTypeNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
