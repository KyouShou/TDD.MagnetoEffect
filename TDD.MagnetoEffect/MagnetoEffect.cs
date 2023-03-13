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
        private List<Point> _anchorList;

        public MagnetoEffect()
        {
            _anchorList = new List<Point>();
        }

        public Point Check(Point point)
        {

            if (_anchorList.Count == 0)
            {
                return point;
            }

            foreach (var anchor in _anchorList)
            {
                double distance = Math.Pow(anchor.X - point.X, 2) + Math.Pow(anchor.Y - point.Y, 2);

                if (distance <= Math.Pow(5, 2))
                {
                    return anchor;
                }
            }

            return point;
        }

        public void AddAnchor(Point newAnchor)
        {
            _anchorList.Add(newAnchor);
        }
    }
}
