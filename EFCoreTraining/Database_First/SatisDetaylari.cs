using System;
using System.Collections.Generic;

namespace Database_First;

public partial class SatisDetaylari
{
    public int SatisId { get; set; }

    public int UrunId { get; set; }

    public decimal BirimFiyati { get; set; }

    public short Miktar { get; set; }

    public float İndirim { get; set; }

    public virtual Satislar Satis { get; set; } = null!;

    public virtual Urunler Urun { get; set; } = null!;
}
