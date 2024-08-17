using System;
using System.Collections.Generic;

namespace Database_First;

public partial class Urunler
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public int? TedarikciId { get; set; }

    public int? KategoriId { get; set; }

    public string? BirimdekiMiktar { get; set; }

    public decimal? BirimFiyati { get; set; }

    public short? HedefStokDuzeyi { get; set; }

    public short? YeniSatis { get; set; }

    public short? EnAzYenidenSatisMikatari { get; set; }

    public bool Sonlandi { get; set; }

    public virtual Kategoriler? Kategori { get; set; }

    public virtual ICollection<SatisDetaylari> SatisDetaylaris { get; set; } = new List<SatisDetaylari>();

    public virtual Tedarikciler? Tedarikci { get; set; }
}
