using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        void Add(Contact contact);
        void Delete(Contact contact);
        void Update(Contact contact);
        List<Contact> GetList();
        Contact GetByID(int id);
    }
}
