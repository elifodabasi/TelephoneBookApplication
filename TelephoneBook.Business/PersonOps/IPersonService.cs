using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Entity;

namespace TelephoneBook.Business.PersonOps
{
    public interface IPersonService
    {
        void Add(Person entity);
        Person Find(Guid id);
        List<Person> GetAll();
        void Update(Person entity);
        void Delete(Person entity);
    }
}
