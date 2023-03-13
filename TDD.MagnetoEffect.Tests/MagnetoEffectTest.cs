using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MagnetoEffect.Tests
{
    internal class MagnetoEffectTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void No_Anchor()
        {
            MagnetoEffect magnetoEffect = new MagnetoEffect();

            Point before = new Point(49, 50);

            Point after = magnetoEffect.Check(before);

            Assert.AreEqual(before, after);
        }

        [Test]
        public void One_Near_Anchor()
        {
            MagnetoEffect magnetoEffect = new MagnetoEffect();
            magnetoEffect.AddAnchor(new Point(50, 50));

            Point before = new Point(49, 50);

            Point after = magnetoEffect.Check(before);

            Assert.AreEqual(new Point(50, 50), after);
        }

    }
}
