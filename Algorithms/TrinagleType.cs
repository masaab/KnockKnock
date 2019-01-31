using Algorithms.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class TrinagleType : ITriangleType
    {
        public TriangleTypes GetTriangleType(long sideA, long sideB, long sideC)
        {
            const int IsosceleTriangleValue = 2;
            const int ScaleneTriangleValue = 3;

            
            
            List<long> sideCollection = new List<long> { sideA, sideB, sideC };
            if (isTriangleValid(sideCollection))
            {
                if (sideCollection.Distinct().Count() == IsosceleTriangleValue)
                    return TriangleTypes.Isosceles;
                if (sideCollection.Distinct().Count() == ScaleneTriangleValue)
                    return TriangleTypes.Scalene;
            }
            else
            {
                
                return TriangleTypes.Error;
            }

            return TriangleTypes.Equilateral;
        }

        //Side lengths do not adhere to the triangle inequality theorem.
        //Which states that the sum of the side lengths of any 2 sides of a triangle must exceed the length of the third side
        private bool isTriangleValid(List<long> triangleSides)
        {
            var item = triangleSides.Select((value, index) => new { value, index }).OrderByDescending(_ => _.value).ToList();

            long largestTriangleSide = item[0].value;
            long Sumof2TrinagleSides = item.Skip(1).Sum(a => a.value);

            return Sumof2TrinagleSides > largestTriangleSide ? true : false;
        }

    }
}
