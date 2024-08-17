using System;
using System.Collections.Generic;

namespace Database_First;

public partial class Bolgeler
{
    public string TerritoryId { get; set; } = null!;

    public string TerritoryTanimi { get; set; } = null!;

    public int BolgeId { get; set; }

    public virtual Bolge Bolge { get; set; } = null!;

    public virtual ICollection<Personeller> Personels { get; set; } = new List<Personeller>();
}
