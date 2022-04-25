using System;
using System.Collections.Generic;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class Sonuclar
    {
        public Sonuclar()
        {
            AramaDetaylaris = new HashSet<AramaDetaylari>();
        }

        public int Id { get; set; }
        public string Kodu { get; set; }
        public string Tanimi { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<AramaDetaylari> AramaDetaylaris { get; set; }
    }
}
