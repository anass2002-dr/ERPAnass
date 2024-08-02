using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class BPay
{
    public int IdPays { get; set; }

    public string? NomPays { get; set; }

    public int? IdGroup { get; set; }

    public virtual ICollection<AFamille> AFamilles { get; set; } = new List<AFamille>();

    public virtual ICollection<BDepot> BDepots { get; set; } = new List<BDepot>();

    public virtual ICollection<BVille> BVilles { get; set; } = new List<BVille>();

    public virtual ICollection<FishEntet> FishEntets { get; set; } = new List<FishEntet>();

    public virtual ICollection<FishFamille> FishFamilles { get; set; } = new List<FishFamille>();

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual ICollection<TClient> TClients { get; set; } = new List<TClient>();

    public virtual ICollection<TFournisseur> TFournisseurs { get; set; } = new List<TFournisseur>();
}
