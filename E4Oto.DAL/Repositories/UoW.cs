using E4Oto.DAL.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4Oto.DAL.Repositories
{
    public class UoW : IUoW
    {
        private readonly E4Oto.Data.Models.E4OtoServisContext _context;
        public UoW(E4Oto.Data.Models.E4OtoServisContext context)
        {
            _context = context;
            Musteriler = new MusterilerRepo(_context);
            MusteriAraclari = new  MusteriAraclariRepo(_context);
            AramaDetaylari = new  AramaDetaylariRepo(_context);
            Aramalar = new  AramalarRepo(_context);
            Danismanlar = new  DanismanlarRepo(_context);
            DosyaDurumlari = new  DosyaDurumlariRepo(_context);
            Operatorler = new  OperatorlerRepo(_context);
            Randevular = new  RandevularRepo(_context);
            RandevuSebepleri = new  RandevuSebepleriRepo(_context);
            Sonuclar = new  SonuclarRepo(_context); 
        }

        public MusterilerRepo Musteriler { get;  }

        public MusteriAraclariRepo MusteriAraclari { get; }

        public AramaDetaylariRepo AramaDetaylari { get; }

        public AramalarRepo Aramalar { get; }

        public DanismanlarRepo Danismanlar { get; }

        public DosyaDurumlariRepo DosyaDurumlari { get; }

        public OperatorlerRepo Operatorler { get; }

        public RandevularRepo Randevular { get; }

        public RandevuSebepleriRepo RandevuSebepleri { get; }

        public SonuclarRepo Sonuclar { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
