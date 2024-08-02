using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieCalculLigneRubrique
{
    public int IdLigne { get; set; }

    public int? IdEntete { get; set; }

    public int? IdRubrique { get; set; }

    public int? IdCotisation { get; set; }

    public int? IdPret { get; set; }

    public int? CodeRubrique { get; set; }

    public string? LibelleRubrique { get; set; }

    public decimal? Base { get; set; }

    public double? Taux { get; set; }

    public decimal? Gains { get; set; }

    public decimal? Retenues { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Position { get; set; }

    public int? Valeur { get; set; }

    public string? TypeRubrique { get; set; }

    public virtual PaieCalculEntete? IdEnteteNavigation { get; set; }
}
