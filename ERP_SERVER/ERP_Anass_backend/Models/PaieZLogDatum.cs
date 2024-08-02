using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieZLogDatum
{
    public int IdLogData { get; set; }

    public int? IdUserDevice { get; set; }

    public DateTime? DateTimeRecord { get; set; }

    public string? UniqueId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public TimeOnly? TimeRecord { get; set; }

    public int? IdEmploye { get; set; }

    public virtual PaieEEmploye? IdEmployeNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual PaieZUserDevice? IdUserDeviceNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
