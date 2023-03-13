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
        MagnetoEffect _magnetoEffect;

        [SetUp]
        public void Setup()
        {
            _magnetoEffect = new MagnetoEffect();
        }

        [TearDown]
        public void End()
        {
            _magnetoEffect = null;
        }

        [Test]
        public void No_Anchor()
        {          
            Point before = new Point(49, 50);

            Point after = _magnetoEffect.Check(before);

            Assert.AreEqual(before, after);
        }

        [Test]
        public void One_Near_Anchor()
        {
            _magnetoEffect.AddAnchor(new Point(50, 50));

            Point before = new Point(49, 50);

            Point after = _magnetoEffect.Check(before);

            Assert.AreEqual(new Point(50, 50), after);
        }
    }
}
