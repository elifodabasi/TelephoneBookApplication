using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Business.ContactInfoOps;
using TelephoneBook.Entity;
using TelephoneBookAPI.Controllers;
using Xunit;

namespace TelephoneBook.Test
{
  public class ContactInfoTest
    {
        private List<ContactInfo> contactInfos;

        private readonly ContactInfoController _contactInfoController;

        private readonly Mock<IContactInfoService> _mockRepo;

        public ContactInfoTest()
        {
            _mockRepo = new Mock<IContactInfoService>();
            _contactInfoController = new ContactInfoController(_mockRepo.Object);
        }


        [Fact]
        public async void GetAllContactInfo_Test()
        {

            var result = await _contactInfoController.GetAll();

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async void FindContactInfo_Test()
        {
    

        }

    }

  
}

