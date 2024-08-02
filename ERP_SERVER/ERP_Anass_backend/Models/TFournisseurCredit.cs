using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class TFournisseurCredit
{
    public int? IdFournisseur { get; set; }

    public int? IdDossier { get; set; }

    public decimal? Credit { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual TFournisseur? IdFournisseurNavigation { get; set; }
}
