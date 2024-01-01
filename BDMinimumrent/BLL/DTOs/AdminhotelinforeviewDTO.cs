using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminhotelinforeviewDTO : AdminhotelinfoDTO
    {

        public List<AdminhotelreviewDTO> Adminhotelreviews { get; set; }
       public AdminhotelrentDTO Adminhotelrent { get; set; }
        public AdminhotelinforeviewDTO()
        {
            Adminhotelreviews = new List<AdminhotelreviewDTO>();
        
        }

    }
}
