using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminhotelinfoDTO
    {
        public int id { get; set; }
        [Required]
        public string info { get; set; }
        [Required]
        public string Hoteldescription { get; set; }
        [Required]
        public string Hotelpostinfo { get; set; }
        [Required]
        public DateTime Datetime { get; set; }
    }
}
