using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class Randevular
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public int? BaslangicSaat { get; set; }
        public DateTime? BitisTarih { get; set; }
        public int? BitisSaat { get; set; }
        public int? MusteriId { get; set; }
        public int? AracId { get; set; }
        public int? AramaId { get; set; }
        public bool? CarsaIslendiMi { get; set; }
        public bool? SmsAldiMi { get; set; }
        public int? DanismanId { get; set; }

        public virtual MusteriAraclari Arac { get; set; }
        public virtual Aramalar Arama { get; set; }
        public virtual Danismanlar Danisman { get; set; }
        public virtual Musteriler Musteri { get; set; }
    }
}
