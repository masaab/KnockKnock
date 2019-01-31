using System;

namespace Algorithms.Abstract
{
    public enum TriangleTypes { Equilateral , Isosceles , Scalene,Error }

    public interface ITriangleType
    {
        TriangleTypes GetTriangleType(long sideA, long sideB, long sideC);
    }
}
