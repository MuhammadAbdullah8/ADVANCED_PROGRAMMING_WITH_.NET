using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminhotelreviewDTO
    {
        public int id { get; set; }
        [Required]
        public string review { get; set; }
        public DateTime time { get; set; }
        public string reviewinfo { get; set; }

        public int hotelpostinfoid { get; set; }

        public string reviewdby { get; set; }  

    }
}
