using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BVille
{
    public int IdVille { get; set; }

    public string? NomVille { get; set; }

    public int? IdGroup { get; set; }

    public int? IdPays { get; set; }

    public virtual ICollection<BDepot> BDepots { get; set; } = new List<BDepot>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual BPay? IdPaysNavigation { get; set; }

    public virtual ICollection<PaieEEmploye> PaieEEmployes { get; set; } = new List<PaieEEmploye>();

    public virtual ICollection<TClient> TClients { get; set; } = new List<TClient>();

    public virtual ICollection<TFournisseur> TFournisseurs { get; set; } = new List<TFournisseur>();
}
