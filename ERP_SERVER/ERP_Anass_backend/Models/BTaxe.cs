using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BTaxe
{
    public int IdTaxe { get; set; }

    public string? NomTaxe { get; set; }

    public string? TypeTaxe { get; set; }

    public int? CauxTaxe { get; set; }

    public DateTime? Createdate { get; set; }

    public int? IdGroup { get; set; }

    public virtual ICollection<AArticle> AArticleIdTaxeAchatNavigations { get; set; } = new List<AArticle>();

    public virtual ICollection<AArticle> AArticleIdTaxeVenteNavigations { get; set; } = new List<AArticle>();

    public virtual ICollection<HotelSExtra> HotelSExtras { get; set; } = new List<HotelSExtra>();

    public virtual ICollection<HotelSRoomType> HotelSRoomTypes { get; set; } = new List<HotelSRoomType>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }
}
