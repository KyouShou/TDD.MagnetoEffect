using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MagnetoEffect
{
    public class MagnetoEffect
    {
        private Point _anchor;

        public Point Check(Point point)
        {
            if (_anchor.IsEmpty)
            {
                return point;
            }

            if (IsFarFromAnchor(point))
            {
                return point;
            }

            return _anchor;
        }

        public void AddAnchor(Point newAnchor)
        {
            this._anchor = newAnchor;
        }

        private bool IsFarFromAnchor(Point point)
        {
            return Math.Pow(_anchor.X - point.X, 2) + Math.Pow(_anchor.Y - point.Y, 2) > Math.Pow(5, 2);
        }

    }
}
