using System;
using System.Collections.Generic;

namespace Database_First;

public partial class SehirlereGoreMusteriVeTedarikciler
{
    public string? Sehir { get; set; }

    public string SirketAdi { get; set; } = null!;

    public string? MusteriAdi { get; set; }

    public string Relationship { get; set; } = null!;
}
