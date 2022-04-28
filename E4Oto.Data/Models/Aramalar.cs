using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class Aramalar
    {
        public Aramalar()
        {
            AramaDetaylaris = new HashSet<AramaDetaylari>();
            Randevulars = new HashSet<Randevular>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Saat { get; set; }
        public int? MusteriId { get; set; }
        public int? AracId { get; set; }
        public int? OperatorId { get; set; }

        public virtual MusteriAraclari Arac { get; set; }
        public virtual Musteriler Musteri { get; set; }
        public virtual Operatorler Operator { get; set; }
        public virtual ICollection<AramaDetaylari> AramaDetaylaris { get; set; }
        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
