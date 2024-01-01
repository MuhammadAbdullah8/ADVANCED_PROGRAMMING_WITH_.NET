using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminhotelinfoRepo : Repo, IRepo<Adminhotelinfo, int, bool>
    {
        public bool Create(Adminhotelinfo obj)
        {
            db.Adminhotelinfo.Add(obj);
            if (db.SaveChanges() > 0) return (bool)obj;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Adminhotelinfo.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Adminhotelinfo> Read()
        {
            return db.Adminhotelinfo.ToList();
        }

        public Adminhotelinfo Read(int id)
        {
            return db.Adminhotelinfo.Find(id);
        }

        public bool Update(Adminhotelinfo obj)
        {
            var ex = Read(obj.HotelName);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
