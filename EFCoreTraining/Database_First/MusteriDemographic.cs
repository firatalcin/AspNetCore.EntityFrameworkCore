using System;
using System.Collections.Generic;

namespace Database_First;

public partial class MusteriDemographic
{
    public string MusteriTypeId { get; set; } = null!;

    public string? MusteriDesc { get; set; }

    public virtual ICollection<Musteriler> Musteris { get; set; } = new List<Musteriler>();
}
