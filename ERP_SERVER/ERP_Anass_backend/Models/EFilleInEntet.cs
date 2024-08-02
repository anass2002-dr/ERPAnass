using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class EFilleInEntet
{
    public int? IdFille { get; set; }

    public int? IdEntet { get; set; }

    public virtual EEntet? IdEntetNavigation { get; set; }

    public virtual SFille? IdFilleNavigation { get; set; }
}
