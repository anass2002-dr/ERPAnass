using System;
using System.Collections.Generic;

namespace testdb.Models;

public partial class AArticleInFille
{
    public int? IdFille { get; set; }

    public int? IdArticle { get; set; }

    public virtual AArticle? IdArticleNavigation { get; set; }

    public virtual SFille? IdFilleNavigation { get; set; }
}
