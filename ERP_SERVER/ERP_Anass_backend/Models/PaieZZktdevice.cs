using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class PaieZZktdevice
{
    public int IdDevice { get; set; }

    public string? NameDevice { get; set; }

    public string? IpDevice { get; set; }

    public int? PortDevice { get; set; }

    public int? MachingNumber { get; set; }

    public int? IdGroup { get; set; }

    public string? IdUser { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<PaieZUserDevice> PaieZUserDevices { get; set; } = new List<PaieZUserDevice>();
}
