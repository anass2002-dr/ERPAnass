using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SMenuInstall
{
    public int? IdMenu { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SMenu? IdMenuNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
