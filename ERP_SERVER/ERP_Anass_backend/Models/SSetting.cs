using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SSetting
{
    public int IdSettings { get; set; }

    public string? CurrencyFormat { get; set; }

    public string? QteFormat { get; set; }

    public bool? TvaCheck { get; set; }

    public bool? TtcCheck { get; set; }

    public bool? SubDepot { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }
}
