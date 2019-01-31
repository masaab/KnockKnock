using Algorithms.Abstract;
using Xunit;

namespace Algorithms.UnitTest
{
    public class TrangleTypeTest
    {
        [Theory]
        [InlineData(5, 5, 5, TriangleTypes.Equilateral)]
        [InlineData(5, 5, 6, TriangleTypes.Isosceles)]
        [InlineData(5, 6, 7, TriangleTypes.Scalene)]

        public void TestTriangleType(long a, long b , long c, TriangleTypes expectedTrinagleTypes)
        {
            //Arrange
            var trinagleType = new TrinagleType();

            //Act
            var asctualTrinagleTypes = trinagleType.GetTriangleType(a, b, c);

            //Assert
            Assert.Equal(expectedTrinagleTypes, asctualTrinagleTypes);
        }

        [Theory]
        [InlineData(5, 1, 4,TriangleTypes.Error)]
        [InlineData(1, 2, 5,TriangleTypes.Error)]
        [InlineData(2, 5, 1, TriangleTypes.Error)]
        [InlineData(-2, -5, -1, TriangleTypes.Error)]
        public void TestNotEqualTriangleType(long a, long b, long c, TriangleTypes expectedTrinagleTypes)
        {
            //Arrange
            var trinagleType = new TrinagleType();

            //Act
            var asctualTrinagleTypes = trinagleType.GetTriangleType(a, b, c);

            //Assert
            Assert.Equal(expectedTrinagleTypes, asctualTrinagleTypes);

        }
    }
}
