using System;
using Xunit;
using PersonRepository.Interface;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CSVRepository repo = new CSVRepository();
            var expected = repo.GetPeople();
            Assert.NotNull(expected);
            
        }
    }
}
