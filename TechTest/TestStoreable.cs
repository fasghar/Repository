using System;

namespace TechTest
{
    public class TestStoreable : IStoreable
    {

        public IComparable Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
