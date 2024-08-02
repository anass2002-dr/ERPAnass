using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class SEmailsSetting
{
    public int IdEsettings { get; set; }

    public string? UrlServer { get; set; }

    public string? UrlAttach { get; set; }

    public string? HostSm { get; set; }

    public string? UsernameSm { get; set; }

    public string? PasswordSm { get; set; }

    public int? PortSm { get; set; }

    public string? FromNameSm { get; set; }

    public bool? CheckSmtp { get; set; }

    public string? HostIm { get; set; }

    public string? UsernameIm { get; set; }

    public string? PasswordIm { get; set; }

    public int? PortIm { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
