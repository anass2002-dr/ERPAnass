using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelSEquipement
{
    public int? IdRoomType { get; set; }

    public string? ValeurEquip { get; set; }

    public string? TextEquip { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual HotelSRoomType? IdRoomTypeNavigation { get; set; }
}
