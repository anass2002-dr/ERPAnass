using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class ScCalendar
{
    public int IdCalendar { get; set; }

    public string? Name { get; set; }

    public bool? Checked { get; set; }

    public string? Color { get; set; }

    public string? BgColor { get; set; }

    public string? BorderColor { get; set; }

    public string? DragBgColor { get; set; }

    public string? IdUser { get; set; }

    public int? IdGroup { get; set; }

    public virtual SGroupUser? IdGroupNavigation { get; set; }

    public virtual SUser? IdUserNavigation { get; set; }

    public virtual ICollection<ScSchedule> ScSchedules { get; set; } = new List<ScSchedule>();
}
