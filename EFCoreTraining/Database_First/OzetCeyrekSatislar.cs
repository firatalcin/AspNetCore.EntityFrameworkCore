using System;
using System.Collections.Generic;

namespace Database_First;

public partial class OzetCeyrekSatislar
{
    public DateTime? SevkTarihi { get; set; }

    public int SatisId { get; set; }

    public decimal? Subtotal { get; set; }
}
