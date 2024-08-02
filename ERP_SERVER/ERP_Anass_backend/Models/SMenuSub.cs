using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SMenuSub
{
    public int IdSubMenu { get; set; }

    public string? NomSubMenu { get; set; }

    public string? CodeMenu { get; set; }

    public string? NamePrincipale { get; set; }
}
