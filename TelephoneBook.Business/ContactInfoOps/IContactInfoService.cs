using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Entity;

namespace TelephoneBook.Business.ContactInfoOps
{
    public interface IContactInfoService
    {
        void Add(ContactInfo entity);
        ContactInfo Find(Guid id);
        List<ContactInfo> GetAll();
        void Update(ContactInfo entity);
        void Delete(ContactInfo entity);
    }
}
