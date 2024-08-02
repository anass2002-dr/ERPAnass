using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class DDepartement
{
    public int IdDepartement { get; set; }

    public string? NomDepartement { get; set; }

    public string? DescDepartement { get; set; }

    public int IdGroup { get; set; }

    public string IdUser { get; set; } = null!;

    public virtual SGroupUser IdGroupNavigation { get; set; } = null!;

    public virtual SUser IdUserNavigation { get; set; } = null!;
}
