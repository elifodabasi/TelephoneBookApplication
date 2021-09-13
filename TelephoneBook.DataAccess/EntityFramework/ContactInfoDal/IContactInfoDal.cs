using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Core.DataAccess;
using TelephoneBook.Entity;

namespace TelephoneBook.DataAccess.EntityFramework.ContactInfoDal
{
    public interface IContactInfoDal : IEntityRepository<ContactInfo>
    {
    }
}
