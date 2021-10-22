using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact : IEntity
    {
        [Key]
        public int ContactId { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
