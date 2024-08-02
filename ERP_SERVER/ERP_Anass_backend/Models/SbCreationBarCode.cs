using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SbCreationBarCode
{
    public int IdCreation { get; set; }

    public double? DimensionW { get; set; }

    public double? DimensionH { get; set; }

    public double? VBarWidth { get; set; }

    public double? VBarHeight { get; set; }

    public string? Meta { get; set; }

    public string? CodeType { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdDossier { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SDossier? IdDossierNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
