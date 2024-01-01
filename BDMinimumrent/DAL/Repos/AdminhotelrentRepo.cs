using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminhotelrentRepo : Repo, IRepo<Adminhotelrent, string, Adminhotelrent>
    {
        public Adminhotelrent Create(Adminhotelrent obj)
        {
            db.Adminhotelrents.Add(obj);
            if(db.SaveChanges()>0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Adminhotelrents.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Adminhotelrent> Read()
        {
            return db.Adminhotelrents.ToList();   
        }

        public Adminhotelrent Read(string id)
        {
            return db.Adminhotelrents.Find(id);
        }

        public Adminhotelrent Update(Adminhotelrent obj)
        {
            var ex = Read(obj.HotelName);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
