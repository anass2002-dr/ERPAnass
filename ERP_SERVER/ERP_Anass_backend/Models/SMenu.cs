using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SMenu
{
    public int IdMenu { get; set; }

    public string? CodeMenu { get; set; }

    public string? NomMenu { get; set; }

    public string? PhotoMenu { get; set; }

    public string? DataModel { get; set; }
}
