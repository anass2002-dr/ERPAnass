using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class ETypeDoc
{
    public string CodeType { get; set; } = null!;

    public int IdDossier { get; set; }

    public int? NumFacture { get; set; }

    public string? NomFacture { get; set; }

    public string? DescType { get; set; }

    public int? ValStock { get; set; }

    public int? ValCmup { get; set; }

    public int? ValFifo { get; set; }

    public int? ValLifo { get; set; }

    public int? ValCaisse { get; set; }

    public int? CodeClFr { get; set; }

    public bool? CalculMarge { get; set; }

    public virtual SDossier IdDossierNavigation { get; set; } = null!;
}
