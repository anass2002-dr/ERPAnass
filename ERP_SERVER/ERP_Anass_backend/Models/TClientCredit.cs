using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class TClientCredit
{
    public int? IdClient { get; set; }

    public int? IdDossier { get; set; }

    public decimal? Credit { get; set; }

    public virtual TClient? IdClientNavigation { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }
}
