using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class Danismanlar
    {
        public Danismanlar()
        {
            Randevulars = new HashSet<Randevular>();
        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Kodu { get; set; }
        public string Unvani { get; set; }

        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
