using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonService
    {
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);
        List<Person> GetList();
        Person GetByID(int id);
    }
}
