using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingEF.DataAccess;

namespace TestingEF.Tests
{
    [TestClass]
    public class TechiesUnitTest
    {
        private TechiesDbContext _context;
        [TestInitialize]
        public void Initialize()
        {
            _context = new TechiesDbContext(Effort.DbConnectionFactory.CreateTransient());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetById_throwException_whenIdDoesnExists()
        {
            //Arrange
            var techies = new Techies(_context);
            var fakeId = 5;
            
            //Act
            var a = techies.GetTechieById(fakeId);

            //Assert
            Assert.Fail("This test need to raise an exception.");
        }
    }
}
