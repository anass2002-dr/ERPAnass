using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelBFilleInBookingEntete
{
    public int? IdFille { get; set; }

    public int? IdBookingEntete { get; set; }

    public virtual HotelBBookingEntete? IdBookingEnteteNavigation { get; set; }

    public virtual SFille? IdFilleNavigation { get; set; }
}
