using E4Oto.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4Oto.DAL.Bussiness
{
    public interface IUoW : IDisposable
    {
       MusterilerRepo Musteriler { get; }
        MusteriAraclariRepo MusteriAraclari { get; }
        AramaDetaylariRepo AramaDetaylari { get; }
        AramalarRepo Aramalar { get; }
        DanismanlarRepo Danismanlar { get; }
        DosyaDurumlariRepo DosyaDurumlari { get; }
        OperatorlerRepo Operatorler { get; }
        RandevularRepo Randevular { get; }
        RandevuSebepleriRepo RandevuSebepleri { get; }
        SonuclarRepo Sonuclar { get; } 
        int Complete();
    }
}
