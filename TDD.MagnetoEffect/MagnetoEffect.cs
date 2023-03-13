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
            else
            {
                return _anchor;
            }
        }

        public void AddAnchor(Point newAnchor)
        {
            this._anchor = newAnchor;
        }

    }
}
