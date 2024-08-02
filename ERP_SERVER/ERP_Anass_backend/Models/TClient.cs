using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class TClient
{
    public int IdClient { get; set; }

    public string? CodeClient { get; set; }

    public string? NomClient { get; set; }

    public string? AdresseClient { get; set; }

    public string? PostalClient { get; set; }

    public string? IceClient { get; set; }

    public string? CnssClient { get; set; }

    public string? NifClient { get; set; }

    public string? PatenteClient { get; set; }

    public string? SiegeClient { get; set; }

    public string? BanqueClient { get; set; }

    public string? RibClient { get; set; }

    public decimal? SoldAutoriseClient { get; set; }

    public string? FrmJuridiqueClient { get; set; }

    public string? EmailClient { get; set; }

    public string? TeleClient { get; set; }

    public string? FixClient { get; set; }

    public string? TypeClient { get; set; }

    public bool? ContratClient { get; set; }

    public bool? VendeurClient { get; set; }

    public bool? Distributeur { get; set; }

    public DateTime? Createdate { get; set; }

    public int? IdVille { get; set; }

    public int? IdPays { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public string? CinClient { get; set; }

    public string? PotentielClt { get; set; }

    public string? CategorieClt { get; set; }

    public string? OrigineContact { get; set; }

    public string? Siteweb { get; set; }

    public string? Propriete { get; set; }

    public string? Incoterms { get; set; }

    public string? Autorizacion { get; set; }

    public virtual ICollection<ABateau> ABateaus { get; set; } = new List<ABateau>();

    public virtual ICollection<EEntet> EEntets { get; set; } = new List<EEntet>();

    public virtual ICollection<FishEntet> FishEntets { get; set; } = new List<FishEntet>();

    public virtual ICollection<HotelBBookingEntete> HotelBBookingEntetes { get; set; } = new List<HotelBBookingEntete>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual BVille? IdVilleNavigation { get; set; }

    public virtual ICollection<PPo> PPos { get; set; } = new List<PPo>();

    public virtual ICollection<PTicket> PTickets { get; set; } = new List<PTicket>();

    public virtual ICollection<RReglement> RReglements { get; set; } = new List<RReglement>();
}
