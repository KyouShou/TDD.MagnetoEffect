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

            Assert.AreEqual(before , after);
        }

    }
}
