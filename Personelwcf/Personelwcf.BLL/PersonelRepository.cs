using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Personelwcf.DAL;
namespace Personelwcf.BLL
{
  
    public class PersonelRepository
    {
        PersonelDBEntities db = new PersonelDBEntities();

        public void Ekle(tblPersonel item)
        {
            db.tblPersonel.Add(item);
            db.SaveChanges();
        }

        public List<tblPersonel> Listele()
        {
            return db.tblPersonel.ToList();
        }
      
        public void guncelle(tblPersonel item)
        {
            tblPersonel guncellenen = db.tblPersonel.Find(item.PersonelId);
            db.Entry(guncellenen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
        public void Sil(int itemId)
        {
            tblPersonel silinen = db.tblPersonel.Find(itemId);
            db.tblPersonel.Remove(silinen);
            db.SaveChanges();
        }

        public tblPersonel Sec(int id)
        {
            return db.tblPersonel.Find(id);
        }
    }
}
