using System;
using System.Collections.Generic;

namespace Database_First;

public partial class Bolge
{
    public int BolgeId { get; set; }

    public string BolgeTanimi { get; set; } = null!;

    public virtual ICollection<Bolgeler> Bolgelers { get; set; } = new List<Bolgeler>();
}
