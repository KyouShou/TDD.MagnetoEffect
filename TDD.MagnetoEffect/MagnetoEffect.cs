using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            var nearestAnchor = FindNearestAnchor(point);
            var distanceBetweenNearestAnchor = CalculateDistance(nearestAnchor , point);

            if (distanceBetweenNearestAnchor <= 5)
            {
                return nearestAnchor;
            }
            else
            {
                return point;
            }
        }

        public void AddAnchor(Point newAnchor)
        {
            _anchorList.Add(newAnchor);
        }

        private Point FindNearestAnchor(Point point)
        {
            var nearestAnchor = _anchorList[0];
            var nearestDistance = CalculateDistance(_anchorList[0],  point);

            foreach (var anchor in _anchorList)
            {
                double distance = CalculateDistance(anchor, point);

                if (distance <= nearestDistance)
                {
                    nearestAnchor = anchor;
                }
            }

            return nearestAnchor;
        }

        private double CalculateDistance(Point firsrPoint, Point secondPoint)
        {
            var squareOfDistance = Math.Pow(firsrPoint.X - secondPoint.X, 2) + Math.Pow(firsrPoint.Y - secondPoint.Y, 2);

            return Math.Pow(squareOfDistance , 0.5);
        }
    }
}
