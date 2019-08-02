using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTest;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GetAllTest()
        {
            var repository = new TestRepository<TestStoreable>();

            var result = repository.All();

            Assert.IsInstanceOf<IEnumerable<TestStoreable>>(result);
        }

        [Test]
        public void SaveTest()
        {
            var repository = new TestRepository<TestStoreable>();

            var objectToAdd = new TestStoreable { Id = 1, Name = "AddTest", Description = "Test for adding data" };

            repository.Save(objectToAdd);

            var result = repository.All();

            Assert.IsTrue(result.Contains(objectToAdd));
        }

        [Test]
        public void DeleteTest()
        {
            var repository = new TestRepository<TestStoreable>();

            var objectToAdd = new TestStoreable { Id = 1, Name = "DeleteTest", Description = "Test for deleting data" };

            repository.Save(objectToAdd);

            repository.Delete(1);

            var result = repository.All();

            Assert.IsFalse(result.Contains(objectToAdd));
        }

        [Test]
        public void FindByIdTest()
        {
            var repository = new TestRepository<TestStoreable>();

            var objectToAdd = new TestStoreable { Id = 1, Name = "FindByIdTest", Description = "Test to Find data by Id" };

            repository.Save(objectToAdd);

            var result = repository.FindById(1);

            Assert.AreEqual(objectToAdd, result);
        }
    }
}