using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class Musteriler
    {
        public Musteriler()
        {
            Aramalars = new HashSet<Aramalar>();
            MusteriAraclaris = new HashSet<MusteriAraclari>();
            Randevulars = new HashSet<Randevular>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string Unvani { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
        public string Adres3 { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }

        public virtual ICollection<Aramalar> Aramalars { get; set; }
        public virtual ICollection<MusteriAraclari> MusteriAraclaris { get; set; }
        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
