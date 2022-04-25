using System;
using System.Collections.Generic;

#nullable disable

namespace E4Oto.Data.Models
{
    public partial class Operatorler
    {
        public Operatorler()
        {
            Aramalars = new HashSet<Aramalar>();
        }

        public int Id { get; set; }
        public string Kodu { get; set; }
        public string Unvani { get; set; }
        public DateTime? IseGirisTarihi { get; set; }

        public virtual ICollection<Aramalar> Aramalars { get; set; }
    }
}
