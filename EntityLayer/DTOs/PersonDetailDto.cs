using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs
{
    public class PersonDetailDto
    {
        public int PersonId { get; set; }

        public string PersonName { get; set; }
        public string PersonSurName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
