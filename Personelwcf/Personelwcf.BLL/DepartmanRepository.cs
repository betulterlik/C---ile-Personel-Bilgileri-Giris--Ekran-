using Personelwcf.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelwcf.BLL
{
   public class DepartmanRepository
    {
        PersonelDBEntities db = new PersonelDBEntities();
        public void DepartmanEkle(Departman item)
        {
            db.Departman.Add(item);
            db.SaveChanges();
        }

        public List<Departman> DepartmanListele()
        {
            return db.Departman.ToList();
        }
        public void Sil(int itemId)
        {
            Departman silinen = db.Departman.Find(itemId);
            db.Departman.Remove(silinen);
            db.SaveChanges();

        }
    }
}
