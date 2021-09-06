using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Personelwcf.DAL;

namespace Personelwcf.WCF
{

    public class Service1 : IService1
    {
        PersonelDBEntities db = new PersonelDBEntities();
        
        public List<Persons> Listele()
        {
            return db.tblPersonel.Select(x => new Persons
            {
                PerId=x.PersonelId,
                perAdi=x.Adi,
                PerSoyadi=x.Soyadi,
                DogTarihi=x.DogumTarihi,
                Maasi=x.Maas,
                ili=x.iller.ilAdi,
                ilcesi=x.ilceler.ilce,
                DepartmanAdi=x.Adi,
                resimyolu = x.pResim,
                resimImage = x.ResimImage
            }).ToList();
        }
    }
}
