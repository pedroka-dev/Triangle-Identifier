
namespace TriangleIdentifier.ConsoleApp.Domain
{
    public class Triangle
    {
        private float sideX;
        private float sideY;
        private float sideZ;

        public Triangle(float sideX, float sideY, float sideZ)
        {
            this.sideX = sideX;
            this.sideY = sideY;
            this.sideZ = sideZ;
        }

        public string IdentifyTriangleType()
        {
            if (!IsValidTriangle())
                return "Invalid triangle";
            else if (IsEquilateral())
                return "Equilateral";
            else if (IsIsoceles())
                return "Isoceles";
            else
                return "Escalene";
        }

        private bool IsValidTriangle()
        {
            return sideX < sideY + sideZ && sideY < sideX + sideZ && sideZ < sideX + sideY;
        }

        private bool IsEquilateral()
        {
            return sideX == sideY && sideY == sideZ && sideX == sideZ;
        }

        private bool IsIsoceles()
        {
            return sideX == sideY || sideY == sideZ || sideX == sideZ;
        }

        public float SideX { get => sideX; }
        public float SideY { get => sideY; }
        public float SideZ { get => sideZ; }
    }
}
