using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class MaintSTeam
{
    public int IdTeam { get; set; }

    public string? NomTeam { get; set; }

    public string? TypeTeam { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<MaintRRequest> MaintRRequests { get; set; } = new List<MaintRRequest>();
}
