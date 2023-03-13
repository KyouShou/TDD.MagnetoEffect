using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TDD.MagnetoEffect.Tests
{
    internal class MagnetoEffectTest
    {
        MagnetoEffect _magnetoEffect;
        Point _beforePoint;
        Point _afterPoint;

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
            Given_Mouse_Was_At(49, 50);

            When_Check();

            Assert.AreEqual(_beforePoint, _afterPoint);
        }

        [Test]
        public void One_Near_Anchor()
        {
            Given_Anchor_Is(50, 50);

            Given_Mouse_Was_At(49, 50);

            When_Check();

            Then_Mouse_New_Position_Is(50, 50);
        }

        [Test]
        public void One_Far_Anchor()
        {
            Given_Anchor_Is(1, 1);

            Given_Mouse_Was_At(49, 50);

            When_Check();

            Then_Mouse_New_Position_Is(49, 50);
        }


        [Test]
        public void Two_Far_Anchor()
        {
            Given_Anchor_Is(50, 50);
            Given_Anchor_Is(0, 0);

            Given_Mouse_Was_At(49, 50);

            When_Check();

            Then_Mouse_New_Position_Is(50, 50);
        }

        private void Given_Mouse_Was_At(int x, int y)
        {
            _beforePoint = new Point(x, y);
        }

        private void Given_Anchor_Is(int x, int y)
        {
            _magnetoEffect.AddAnchor(new Point(x, y));
        }

        private void When_Check()
        {
            _afterPoint = _magnetoEffect.Check(_beforePoint);
        }

        private void Then_Mouse_New_Position_Is(int x, int y)
        {
            Assert.AreEqual(new Point(x, y), _afterPoint);
        }
    }
}
