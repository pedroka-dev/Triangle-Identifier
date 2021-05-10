using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleIdentifier.ConsoleApp.Domain
{
    class Triangle
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
            if (!isValidTriangle())
                return "Invalid triangle";
            else if (isEquilateral())
                return "Equilateral";
            else if (isIsoceles())
                return "Isoceles";
            else
                return "Escalene";
        }

        private bool isValidTriangle()
        {
            return sideX < sideY + sideZ && sideY < sideX + sideZ && sideZ < sideX + sideY;
        }

        private bool isEquilateral()
        {
            return sideX == sideY && sideY == sideZ && sideX == sideZ;
        }

        private bool isIsoceles()
        {
            return sideX == sideY || sideY == sideZ || sideX == sideZ;
        }

        public float SideX { get => sideX; }
        public float SideY { get => sideY; }
        public float SideZ { get => sideZ; }
    }
}
