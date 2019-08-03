using System;
using System.Collections.Generic;

namespace TechTest
{
    public class TestRepository<T>: IRepository<T> where T : IStoreable
    {
        private List<T> testEntities;

        public TestRepository()
        {
            testEntities = new List<T>();
        }

        public IEnumerable<T> All()
        {
            return testEntities;
        }

        public void Save(T item)
        {
            testEntities.Add(item);
        }

        public void Delete(IComparable id)
        {
            var entityToDelete = testEntities.Find(e => e.Id.Equals(id));
            testEntities.Remove(entityToDelete);
        }

        public T FindById(IComparable id)
        {
            return testEntities.Find(e => e.Id.Equals(id));
        }
    }
}
