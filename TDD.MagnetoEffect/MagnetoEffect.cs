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
                double distance = CalculateDistance(anchor , point);

                if (distance <= 5)
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
        private double CalculateDistance(Point firsrPoint, Point secondPoint)
        {
            var squareOfDistance = Math.Pow(firsrPoint.X - secondPoint.X, 2) + Math.Pow(firsrPoint.Y - secondPoint.Y, 2);

            return Math.Pow(squareOfDistance , 0.5);
        }
    }
}
