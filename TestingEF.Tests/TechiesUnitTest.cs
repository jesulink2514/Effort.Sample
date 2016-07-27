using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingEF.DataAccess;
using System.IO;

namespace TestingEF.Tests
{
    [TestClass]
    public class TechiesUnitTest
    {
        private TechiesDbContext _context;
        [TestInitialize]
        public void Initialize()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "SampleData");
            var loader = new Effort.DataLoaders.CsvDataLoader(path);
            _context = new TechiesDbContext(Effort.DbConnectionFactory.CreateTransient(loader));
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

        [TestMethod]
        public void GetById_returnsEnity_whenItExists()
        {
            //Arrange
            var techies = new Techies(_context);
            var realId = 2;
            
            //Act
            var techie = techies.GetTechieById(realId);

            //Assert
            Assert.IsNotNull(techie);
            Assert.AreEqual(techie.Id, realId);
        }
    }
}
