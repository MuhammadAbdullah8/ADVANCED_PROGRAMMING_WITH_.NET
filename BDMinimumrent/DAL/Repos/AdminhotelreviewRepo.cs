using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos 
{
    internal class AdminhotelreviewRepo : Repo, IRepo<Adminhotelreview, int, bool>
    {
        public bool Create(Adminhotelreview obj)
        {
            db.Adminhotelreviews.Add(obj);
            if (db.SaveChanges() > 0) return (bool) obj;
            return false;
          
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Adminhotelreviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Adminhotelreview> Read(Adminhotelreview obj)
        {
            return db.Adminhotelreviews.ToList();
        }

        public Adminhotelreview Read(int id)
        {
            return db.Adminhotelreviews.Find(id);
        }

        public List<Adminhotelreview> Read()
        {
            throw new NotImplementedException();
        }

        public Adminhotelreview Update(Adminhotelreview obj)
        {
          var ex = Read(obj);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        bool IRepo<Adminhotelreview, int, bool>.Update(Adminhotelreview obj)
        {
            throw new NotImplementedException();
        }
    }
}
