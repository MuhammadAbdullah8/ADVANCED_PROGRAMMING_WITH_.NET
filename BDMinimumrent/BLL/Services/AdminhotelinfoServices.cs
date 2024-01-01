using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminhotelinfoServices
    {
        public static List<AdminhotelinfoDTO> Get()
        {
            var data = DataAccessFactory.AdminhotelinfoData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Adminhotelinfo, AdminhotelinfoDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminhotelinfoDTO>>(data);
            return mapped;


        }
        public static AdminhotelinfoDTO Get(int id)
        {
            var data = DataAccessFactory.AdminhotelinfoData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Adminhotelinfo, AdminhotelinfoDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminhotelinfoDTO>(data);
            return mapped;
        }
        public static AdminhotelinforeviewDTO GetwithComments(int id)
        {
            var data = DataAccessFactory.AdminhotelinfoData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Adminhotelinfo, AdminhotelinforeviewDTO>();
                c.CreateMap<Adminhotelreview, AdminhotelreviewDTO>();
                c.CreateMap<Adminhotelrent, AdminhotelrentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminhotelinforeviewDTO>(data);
            return mapped;
        }
    }
}
