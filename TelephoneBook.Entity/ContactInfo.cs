using System;
using TelephoneBook.Core.Entity.Abstract;

namespace TelephoneBook.Entity
{
    public class ContactInfo : IEntity
    {
        public ContactInfo()
        {

        }
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string InfoContext { get; set; }
        public Guid PersonId { get; set; }
        public virtual Person Person { get; set; }
    }

}
