using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Core.DataAccess.EntityFramework;
using TelephoneBook.Entity;

namespace TelephoneBook.DataAccess.EntityFramework.PersonDal
{
    public class EfPersonDal : EfRepositoryBase<Person, EfDbContext>, IPersonDal
    {
    }
}
