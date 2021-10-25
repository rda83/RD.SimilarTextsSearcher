using Xunit;
using RD.SimilarTextsSearcher.Models;

namespace RD.SimilarTextsSearcher.Tests
{
    public class InputDataShould
    {
        [Fact]
        [Trait("Category", "Text")]
        public void NotEmptyHash()
        {
            var sut = new InputData();
            sut.Text1 = "test text";
            Assert.True(!string.IsNullOrEmpty(sut.Text1valueMD5));
            Assert.True(string.IsNullOrEmpty(sut.Text2valueMD5));
        }
    }
}
