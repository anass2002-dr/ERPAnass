using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class TSalarie
{
    public int IdSalarie { get; set; }

    public string? NomSalarie { get; set; }

    public string? PrenomSalarie { get; set; }

    public int? Age { get; set; }

    public string? Post { get; set; }

    public double? Salaire { get; set; }

    public DateOnly? DateEntree { get; set; }
}
