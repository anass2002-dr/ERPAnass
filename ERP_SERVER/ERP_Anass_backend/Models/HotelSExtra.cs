using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelSExtra
{
    public int IdExtras { get; set; }

    public string? ExtrasName { get; set; }

    public string? DescExtras { get; set; }

    public decimal? PrixHt { get; set; }

    public int? IdTaxeExtras { get; set; }

    public decimal? PrixTtc { get; set; }

    public int? SortExtras { get; set; }

    public string? QteMax { get; set; }

    public string? PhotoExtras { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual ICollection<HotelBBookingExtra> HotelBBookingExtras { get; set; } = new List<HotelBBookingExtra>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BTaxe? IdTaxeExtrasNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
