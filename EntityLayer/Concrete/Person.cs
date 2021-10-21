using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Person : IEntity
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurName { get; set; }
        public string CompanyName { get; set; }
        
        public int ContactId { get; set; }
        public Contact contact { get; set; }

    }
}
