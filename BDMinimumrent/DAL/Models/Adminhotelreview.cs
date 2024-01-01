using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Adminhotelreview
    {
        public int id { get; set; }
        [Required]
        public string review { get; set; }


        public DateTime time { get; set; }

        [ForeignKey("Adminhotelrent")]
        public string reviewinfo { get; set; }

        [ForeignKey("Adminhotelinfo")]
        public int hotelpostinfoid { get; set; }

        public string reviewdby { get; set; }

        public virtual Adminhotelinfo Adminhotelinfo { get; set; }
        public virtual Adminhotelrent Adminhotelrent { get; set; }

        public static explicit operator bool(Adminhotelreview v)
        {
            throw new NotImplementedException();
        }
    }
}
