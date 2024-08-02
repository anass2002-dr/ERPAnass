using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class ScSchedule
{
    public int IdSchedule { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }

    public bool? IsAllday { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Endd { get; set; }

    public bool? IsPrivate { get; set; }

    public string? NomTier { get; set; }

    public int? IdCalendar { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public TimeOnly? HeureStart { get; set; }

    public TimeOnly? HeureEndd { get; set; }

    public virtual ScCalendar? IdCalendarNavigation { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }
}
