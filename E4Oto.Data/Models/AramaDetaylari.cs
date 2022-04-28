using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class AramaDetaylari
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool? TeklifiVerildi { get; set; }
        public DateTime? TeklifHatirlatmaTarihi { get; set; }
        public double? Fiyat { get; set; }
        public bool? RandevuAlindi { get; set; }
        public DateTime? RandevuTarihi { get; set; }
        public string RandevuDanismani { get; set; }
        public string RandevuNedeni { get; set; }
        public bool? BaskaServis { get; set; }
        public bool? BaskaServisYetkiliMi { get; set; }
        public int? AramaId { get; set; }
        public int? Sonuc { get; set; }
        public int? DosyaDurumu { get; set; }

        public virtual Aramalar Arama { get; set; }
        public virtual DosyaDurumlari DosyaDurumuNavigation { get; set; }
        public virtual Sonuclar SonucNavigation { get; set; }
    }
}
