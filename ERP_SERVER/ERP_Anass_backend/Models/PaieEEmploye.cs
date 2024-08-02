using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieEEmploye
{
    public int IdEmploye { get; set; }

    public string? NomEmployee { get; set; }

    public string? PrenomEmployee { get; set; }

    public string? Matricule { get; set; }

    public string? Titre { get; set; }

    public string? CinEmployee { get; set; }

    public string? Nationalite { get; set; }

    public DateTime? DateNaissance { get; set; }

    public string? SitFamiliale { get; set; }

    public int? NbEnfants { get; set; }

    public string? LieuNaissance { get; set; }

    public int? Abattement { get; set; }

    public string? Email { get; set; }

    public string? Adresse { get; set; }

    public string? Observation { get; set; }

    public DateTime? CreateDate { get; set; }

    public int IdGroup { get; set; }

    public string IdUser { get; set; } = null!;

    public int? IdNiveau { get; set; }

    public int? IdCategorie { get; set; }

    public int? IdDepartement { get; set; }

    public int? IdFonction { get; set; }

    public DateTime? DateEntree { get; set; }

    public DateTime? DateSortie { get; set; }

    public bool? CheckSortie { get; set; }

    public string? TypePaie { get; set; }

    public string? TypeSalarie { get; set; }

    public decimal? SalaireBase { get; set; }

    public string? NumCarte { get; set; }

    public bool? CheckPointage { get; set; }

    public bool? SalaireFix { get; set; }

    public string? Banque { get; set; }

    public string? NumCompte { get; set; }

    public string? Recharge { get; set; }

    public string? TraiteAssurVie { get; set; }

    public DateTime? DateAssurVie { get; set; }

    public double? PlafondAssurVie { get; set; }

    public string? TraiteAssurRetraite { get; set; }

    public DateTime? DateAssurRetraite { get; set; }

    public double? PlafondAssurRetraite { get; set; }

    public string? Photo { get; set; }

    public int? IdVille { get; set; }

    public int? IdModRglm { get; set; }

    public string? Genre { get; set; }

    public string? EmpCadre { get; set; }

    public int? IdUserDevice { get; set; }

    public int? IdPlanning { get; set; }

    public string? Telephone { get; set; }

    public string? BusStation { get; set; }

    public string? NumDeclareEmp { get; set; }

    public double? PrixKgs { get; set; }

    public double? PrixHeurSup { get; set; }

    public double? PrixParHeur { get; set; }

    public virtual PaieICategorie? IdCategorieNavigation { get; set; }

    public virtual PaieIDepartement? IdDepartementNavigation { get; set; }

    public virtual PaieIFonction? IdFonctionNavigation { get; set; }

    public virtual SGroupUser IdGroupNavigation { get; set; } = null!;

    public virtual BModRglm? IdModRglmNavigation { get; set; }

    public virtual PaieINiveau? IdNiveauNavigation { get; set; }

    public virtual PaieZPlanning? IdPlanningNavigation { get; set; }

    public virtual PaieZUserDevice? IdUserDeviceNavigation { get; set; }

    public virtual SUser IdUserNavigation { get; set; } = null!;

    public virtual BVille? IdVilleNavigation { get; set; }

    public virtual ICollection<PaieCCotisation> PaieCCotisations { get; set; } = new List<PaieCCotisation>();

    public virtual ICollection<PaieCalculAvance> PaieCalculAvances { get; set; } = new List<PaieCalculAvance>();

    public virtual ICollection<PaieCalculBulletinLigne> PaieCalculBulletinLignes { get; set; } = new List<PaieCalculBulletinLigne>();

    public virtual ICollection<PaieCalculConge> PaieCalculConges { get; set; } = new List<PaieCalculConge>();

    public virtual ICollection<PaieCalculEntete> PaieCalculEntetes { get; set; } = new List<PaieCalculEntete>();

    public virtual ICollection<PaieEConge> PaieEConges { get; set; } = new List<PaieEConge>();

    public virtual ICollection<PaieEContrat> PaieEContrats { get; set; } = new List<PaieEContrat>();

    public virtual ICollection<PaieEPret> PaieEPrets { get; set; } = new List<PaieEPret>();

    public virtual ICollection<PaiePPointageLigne> PaiePPointageLignes { get; set; } = new List<PaiePPointageLigne>();

    public virtual ICollection<PaieZLogDatum> PaieZLogData { get; set; } = new List<PaieZLogDatum>();
}
