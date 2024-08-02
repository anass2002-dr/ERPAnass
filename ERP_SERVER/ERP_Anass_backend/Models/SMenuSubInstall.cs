using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SMenuSubInstall
{
    public int? IdSubMenu { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SMenuSub? IdSubMenuNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
