using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Adminhotelinfo
    {
        public int id { get; set; }
        [Required]
        public string info { get; set; }

        [Required]
        public string Hoteldescription { get; set; }

        [ForeignKey("Adminhotelrent")]
        public string Hotelpostinfo { get; set; }
        public DateTime Datetime { get; set; }

        public virtual Adminhotelrent Adminhotelrent { get; set; }

        public virtual ICollection<Adminhotelreview> Adminhotelreviews { get; set; }
        public Adminhotelinfo()
        {
            Adminhotelreviews = new List<Adminhotelreview>();
        }

        public static explicit operator bool(Adminhotelinfo v)
        {
            throw new NotImplementedException();
        }
    }
}
