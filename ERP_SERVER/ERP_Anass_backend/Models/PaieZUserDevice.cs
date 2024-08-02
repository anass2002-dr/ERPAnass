using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieZUserDevice
{
    public int IdUserDevice { get; set; }

    public int? EnrolNumber { get; set; }

    public string? Name { get; set; }

    public string? PasswordU { get; set; }

    public int? IdDevice { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public virtual PaieZZktdevice? IdDeviceNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieEEmploye> PaieEEmployes { get; set; } = new List<PaieEEmploye>();

    public virtual ICollection<PaieZLogDatum> PaieZLogData { get; set; } = new List<PaieZLogDatum>();
}
