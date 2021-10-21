using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void Add(Person person)
        {
            _personDal.Insert(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }

        public Person GetByID(int id)
        {
            return _personDal.GetByID(id);
        }

        public List<Person> GetList()
        {
            return _personDal.GetListAll();
        }

        public void Update(Person person)
        {
            _personDal.Update(person);
        }
    }
}
