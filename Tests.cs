using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestWorkForAvito_library
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void Triangle_Perimeter()
        {
            double a = 6;
            double b = 8;
            double c = 10;
            Triangle t = new Triangle(a, b, c);

            double perimeter = t.Perimeter();

            Assert.AreEqual(24, perimeter);
        }

        [Test]
        public void Triangle_Area()
        {
            double a = 6;
            double b = 8;
            double c = 10;
            Triangle t = new Triangle(a, b, c);

            double area = t.Area();

            Assert.AreEqual(24, area);
        }
    }

}
