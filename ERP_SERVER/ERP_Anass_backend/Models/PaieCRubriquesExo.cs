using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCRubriquesExo
{
    public int IdExo { get; set; }

    public string? CodeExo { get; set; }

    public string? LibelleExo { get; set; }

    public DateTime? CreateDate { get; set; }
}
