using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleIdentifier.ConsoleApp.Domain;

namespace TriangleIdentifier.UnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void Should_ReturnEquilateral_When_AllEqualAndValidSmallNumbers()
        {
            Triangle triangle = new Triangle(3, 3, 3);
            Assert.AreEqual("Equilateral", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnEquilateral_When_AllEqualAndValidBigNumbers()
        {
            Triangle triangle = new Triangle(100000, 100000, 100000);
            Assert.AreEqual("Equilateral", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnIsoceles_When_OneDifferentAndValidSmallNumbers()
        {
            Triangle triangle = new Triangle(3, 2, 3);
            Assert.AreEqual("Isoceles", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnIsoceles_When_OneDifferentAndValidBigNumbers()
        {
            Triangle triangle = new Triangle(300000, 300000, 400000); ;
            Assert.AreEqual("Isoceles", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnEscalene_When_AllDifferentAndValidSmallNumbers()
        {
            Triangle triangle = new Triangle(3, 2, 4);
            Assert.AreEqual("Escalene", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnEscalene_When_AllDifferentAndValidBigNumbers()
        {
            Triangle triangle = new Triangle(300000, 350000, 400000);
            Assert.AreEqual("Escalene", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnInvalidTriangle_When_SideIsBiggerThanSums()
        {
            Triangle triangle = new Triangle(1, 1000, 96);
            Assert.AreEqual("Invalid triangle", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnInvalidTriangle_When_SideIsEqualToSums()
        {
            Triangle triangle = new Triangle(1, 2, 3);
            Assert.AreEqual("Invalid triangle", triangle.IdentifyTriangleType());
        }

        [TestMethod]
        public void Should_ReturnInvalidTriangle_When_SideIsNegative()
        {
            Triangle triangle = new Triangle(-1, 1, 1);
            Assert.AreEqual("Invalid triangle", triangle.IdentifyTriangleType());
        }
    }
}
