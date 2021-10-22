using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfPersonDal : GenericRepository<Person>, IPersonDal
    {
        //public List<Person> GetListWithCategory()
        //{
        //    using (var c = new Context())
        //    {
        //        return c.Persons.Include(x => x.Contact).ToList();
        //    }

        //}
        //public List<PersonDetailDto> GetPersonDetails()
        //{
        //    using (Context context = new Context())
        //    {
        //        var result = from p in context.Persons
        //                     join c in context.Contacts
        //                     on p.PersonId equals c.ContactId
        //                     select new PersonDetailDto
        //                     {
        //                         PersonName = p.PersonName,
        //                         PersonSurName = p.PersonSurName,
        //                         PhoneNumber = c.PhoneNumber,
        //                         Email = c.EMail
        //                     };
        //        return result.ToList();
        //        //Servisi yaz
        //    }
        //}
    }
}
