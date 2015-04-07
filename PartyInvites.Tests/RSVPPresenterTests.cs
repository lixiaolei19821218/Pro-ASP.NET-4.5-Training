using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartyInvites.Models.Repository;
using PartyInvites.Models;
using System.Collections.Generic;
using PartyInvites.Presenters;
using PartyInvites.Presenters.Results;
using System.Linq;

namespace PartyInvites.Tests
{
    [TestClass]
    public class RSVPPresenterTests
    {
        class MockRepository : IRepository
        {
            private List<GuestResponse> mockData = new List<GuestResponse> {
                new GuestResponse {Name = "Person1", WillAttend = true},
                new GuestResponse {Name = "Person2", WillAttend = false},
            };
            public IEnumerable<GuestResponse> GetAllResponses()
            {
                return mockData;
            }
            public void AddResponse(GuestResponse response)
            {
                mockData.Add(response);
            }
        }

        [TestMethod]
        public void Adds_Object_To_Repository()
        {
            // Arrange
            IRepository repo = new MockRepository();
            IPresenter<GuestResponse> target = new RSVPPresenter { repository = repo };
            GuestResponse dataObject = new GuestResponse { Name = "TEST", WillAttend = true };
            // Act
            IResult result = target.GetResult(dataObject);
            // Assert
            Assert.AreEqual(repo.GetAllResponses().Count(), 3);
            Assert.AreEqual(repo.GetAllResponses().Last().Name, "TEST");
            Assert.AreEqual(repo.GetAllResponses().Last().WillAttend, true);
        }

        [TestMethod]
        public void Handles_WillAttend_Values()
        {
            // Arrange
            IRepository repo = new MockRepository();
            IPresenter<GuestResponse> target = new RSVPPresenter { repository = repo };
            bool?[] values = { true, false, null };
            // Act & Assert
            foreach (bool? testValue in values)
            {
                GuestResponse dataObject =
                new GuestResponse { Name = "TEST", WillAttend = testValue };
                IResult result = target.GetResult(dataObject);
                Assert.IsInstanceOfType(result, typeof(RedirectResult));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Handles_WillAttend_Null_Values()
        {
            // Arrange
            IRepository repo = new MockRepository();
            IPresenter<GuestResponse> target = new RSVPPresenter { repository = repo };
            // Act
            GuestResponse dataObject
            = new GuestResponse { Name = "TEST", WillAttend = null };
            IResult result = target.GetResult(dataObject);
            
        }
    }
}
