using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BModRglm
{
    public int IdModRglm { get; set; }

    public string? NomModRglm { get; set; }

    public string? CategModRglm { get; set; }

    public decimal? Timbre { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual ICollection<EEntet> EEntets { get; set; } = new List<EEntet>();

    public virtual ICollection<HotelBBookingPayment> HotelBBookingPayments { get; set; } = new List<HotelBBookingPayment>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PTicketReg> PTicketRegs { get; set; } = new List<PTicketReg>();

    public virtual ICollection<PaieEEmploye> PaieEEmployes { get; set; } = new List<PaieEEmploye>();

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();

    public virtual ICollection<TrTresorerieEntet> TrTresorerieEntets { get; set; } = new List<TrTresorerieEntet>();
}
