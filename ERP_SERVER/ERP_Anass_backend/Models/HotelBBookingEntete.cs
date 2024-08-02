using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class HotelBBookingEntete
{
    public int IdBookingEntete { get; set; }

    public DateTime? BookingInDate { get; set; }

    public DateTime? BookingOutDate { get; set; }

    public int? TtNbGuest { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdClient { get; set; }

    public bool? CheckIn { get; set; }

    public DateTime? CheckInDate { get; set; }

    public bool? CheckOut { get; set; }

    public DateTime? CheckOutDate { get; set; }

    public string? Message { get; set; }

    public string? Comment { get; set; }

    public bool? Cancel { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public int? IdDossier { get; set; }

    public int? NumBooking { get; set; }

    public int? NbNights { get; set; }

    public string? InfoClients { get; set; }

    public decimal? TotalEnteteHt { get; set; }

    public decimal? TotalEnteteTtc { get; set; }

    public decimal? TotalEnteteUnPaye { get; set; }

    public virtual ICollection<HotelBBookingExtra> HotelBBookingExtras { get; set; } = new List<HotelBBookingExtra>();

    public virtual ICollection<HotelBBookingInvite> HotelBBookingInvites { get; set; } = new List<HotelBBookingInvite>();

    public virtual ICollection<HotelBBookingLigne> HotelBBookingLignes { get; set; } = new List<HotelBBookingLigne>();

    public virtual ICollection<HotelBBookingPayment> HotelBBookingPayments { get; set; } = new List<HotelBBookingPayment>();

    public virtual TClient? IdClientNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
