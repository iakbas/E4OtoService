using E4Oto.DAL.Bussiness;
using E4Oto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4Oto.DAL.Repositories
{
    public class MusterilerRepo : GenericRepository<E4Oto.Data.Models.Musteriler>
    {
        public MusterilerRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        } 
    }
    public class MusteriAraclariRepo : GenericRepository<E4Oto.Data.Models.MusteriAraclari>
    {
        public MusteriAraclariRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class AramaDetaylariRepo : GenericRepository<E4Oto.Data.Models.AramaDetaylari>
    {
        public AramaDetaylariRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class AramalarRepo : GenericRepository<E4Oto.Data.Models.Aramalar>
    {
        public AramalarRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class DanismanlarRepo : GenericRepository<E4Oto.Data.Models.Danismanlar>
    {
        public DanismanlarRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class DosyaDurumlariRepo : GenericRepository<E4Oto.Data.Models.DosyaDurumlari>
    {
        public DosyaDurumlariRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class OperatorlerRepo : GenericRepository<E4Oto.Data.Models.Operatorler>
    {
        public OperatorlerRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class RandevularRepo : GenericRepository<E4Oto.Data.Models.Randevular>
    {
        public RandevularRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class RandevuSebepleriRepo : GenericRepository<E4Oto.Data.Models.RandevuSebepleri>
    {
        public RandevuSebepleriRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    public class SonuclarRepo : GenericRepository<E4Oto.Data.Models.Sonuclar>
    {
        public SonuclarRepo(E4Oto.Data.Models.E4OtoServisContext context)
            : base(context)
        {

        }
    }
    
}
