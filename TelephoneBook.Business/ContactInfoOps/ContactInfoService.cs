using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DataAccess.EntityFramework.ContactInfoDal;
using TelephoneBook.Entity;

namespace TelephoneBook.Business.ContactInfoOps
{
    public class ContactInfoService : IContactInfoService
    {
        IContactInfoDal _contactInfoDal;
        public ContactInfoService(IContactInfoDal contactInfoDal)
        {
            _contactInfoDal = contactInfoDal;
        }

        public void Add(ContactInfo entity)
        {
            _contactInfoDal.Add(entity);
        }

        public void Delete(ContactInfo entity)
        {
            _contactInfoDal.Delete(entity);

        }

        public ContactInfo Find(Guid id)
        {
            return _contactInfoDal.Find(x => x.Id == id);
        }

        public List<ContactInfo> GetAll()
        {
            return _contactInfoDal.GetAll();

        }

        public void Update(ContactInfo entity)
        {
            _contactInfoDal.Update(entity);

        }
    }
}
