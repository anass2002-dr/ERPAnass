using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelSRoomType
{
    public int IdRoomType { get; set; }

    public string? NameRoomType { get; set; }

    public string? DescRoomType { get; set; }

    public int? NbGuests { get; set; }

    public int? MaxNbGuests { get; set; }

    public int? PriceModel { get; set; }

    public decimal? PrixLouerHt { get; set; }

    public int? IdTaxeLouer { get; set; }

    public decimal? PrixVenteTtc { get; set; }

    public int? SortOrder { get; set; }

    public string? ObjectType { get; set; }

    public string? PhotoRoomType { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual ICollection<HotelBBookingLigne> HotelBBookingLignes { get; set; } = new List<HotelBBookingLigne>();

    public virtual ICollection<HotelSUnit> HotelSUnits { get; set; } = new List<HotelSUnit>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BTaxe? IdTaxeLouerNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
