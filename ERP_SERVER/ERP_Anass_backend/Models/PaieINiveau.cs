﻿using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieINiveau
{
    public int IdNiveau { get; set; }

    public string? NomNiveau { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieEEmploye> PaieEEmployes { get; set; } = new List<PaieEEmploye>();
}
