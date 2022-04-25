using System;
using System.Collections.Generic;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class MusteriAraclari
    {
        public MusteriAraclari()
        {
            Aramalars = new HashSet<Aramalar>();
            Randevulars = new HashSet<Randevular>();
        }

        public int Id { get; set; }
        public string SasiNo { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string MotorNo { get; set; }
        public string AracTanimi { get; set; }
        public string Renk { get; set; }
        public DateTime? SonServisTarihi { get; set; }
        public string Seri { get; set; }
        public decimal? Km { get; set; }
        public int? TrafigeCikis { get; set; }
        public int? MusteriId { get; set; }

        public virtual Musteriler Musteri { get; set; }
        public virtual ICollection<Aramalar> Aramalars { get; set; }
        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
