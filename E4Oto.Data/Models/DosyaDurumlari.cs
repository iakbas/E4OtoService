using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class DosyaDurumlari
    {
        public DosyaDurumlari()
        {
            AramaDetaylaris = new HashSet<AramaDetaylari>();
        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Kodu { get; set; }
        public string Tanimi { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<AramaDetaylari> AramaDetaylaris { get; set; }
    }
}
