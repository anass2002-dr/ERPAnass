using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelBBookingInvite
{
    public int IdBookingInvite { get; set; }

    public string? NomInvite { get; set; }

    public string? PrenomInvite { get; set; }

    public string? CinInvite { get; set; }

    public int? AgeInvite { get; set; }

    public string? SexeInvite { get; set; }

    public string? Nationalite { get; set; }

    public int? IdBookingEntete { get; set; }

    public virtual HotelBBookingEntete? IdBookingEnteteNavigation { get; set; }
}
