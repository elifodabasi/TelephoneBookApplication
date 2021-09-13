using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneBook.Business.PersonOps;
using TelephoneBook.Entity;
using TelephoneBookAPI.Controllers;
using Xunit;

namespace TelephoneBook.Test
{

    public class PersonTest 
    {
       
        private List<Person> persons;

        private readonly PersonController _personController;

        private readonly Mock<IPersonService> _mockRepo;

        public PersonTest()
        {
            _mockRepo = new Mock<IPersonService>();
           _personController = new PersonController(_mockRepo.Object);
        }
        [Fact]
        public async Task AddPersonTest()
        {

            //var newPerson= new Guid("e98a2570-92e7-435e-a289-e5702987fa89");

            //_mockRepo.Setup(repo => repo.Add(It.IsAny<Person>()));

            //var result = await _personController.Add(persons.First());

            //_mockRepo.Verify(repo => repo.Add(It.IsAny<Person>()), Times.Once);

            //Assert.Equal(persons.First().Id, newPerson);

        }

        [Fact]
        public async void GetAllPerson_Test()
        {

            var result = await _personController.GetAll();

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async void FindPerson_Test()
        {
            //var id = new Guid("e98a2570-92e7-435e-a289-e5702987fa8e");
            //var person = persons.First(x => x.Id == id);

            //Assert.IsType<OkObjectResult>(person);

      

        }
    }
}
