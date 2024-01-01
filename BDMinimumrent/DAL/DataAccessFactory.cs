using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Adminhotelinfo, int, bool> AdminhotelinfoData() 
        {
            return new AdminhotelinfoRepo();
        }
        public static IRepo<Adminhotelreview, int, bool> AdminhotelreviewData()
        {
            return new AdminhotelreviewRepo();
        }
        public static IRepo<Adminhotelrent, string, Adminhotelrent> AdminhotelrentData()
        {
            return new AdminhotelrentRepo();
        }
    }
}
