using System;
using System.Collections.Generic;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class Danismanlar
    {
        public Danismanlar()
        {
            Randevulars = new HashSet<Randevular>();
        }

        public int Id { get; set; }
        public string Kodu { get; set; }
        public string Unvani { get; set; }

        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
