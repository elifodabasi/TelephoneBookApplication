using System;
using TelephoneBook.Core.Entity.Abstract;

namespace TelephoneBook.Entity
{
    public class Person: IEntity
    {
        public Person()
        {
           
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
       
    }
}
