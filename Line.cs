using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroGM.Test
{
    public class Line : DrawObject
    {
        public Point _startPoint { get; private set; }
        public Point _endPoint { get; private set; }

        public Line(int x1, int y1, int x2, int y2)
        {
            _startPoint = new Point(x1, y1);
            _endPoint = new Point(x2, y2);
        }
        public override void Draw()
        {
            Console.WriteLine($"Line at ({_startPoint.x}, {_startPoint.y}), ({_endPoint.x}, {_endPoint.y})");
        }

        public override void Intersect(DrawObject intersectObj)
        {
            if (intersectObj == this)
            {
                return;
            }
            switch (intersectObj)
            {
                case Circle:
                    isCircle(intersectObj);
                    break;

                case Rect:
                    isRect(intersectObj);
                    break;

                case Line:
                    isLine(intersectObj);
                    break;

                case Point:
                    isPoint(intersectObj);
                    break;

                case null:
                    Console.WriteLine("Object is null!");
                    break;
            }
        }
        public override void isCircle(DrawObject intersectObj)
        {
            throw new NotImplementedException();
        }

        public override void isLine(DrawObject intersectObj)
        {
            throw new NotImplementedException();
        }

        public override void isPoint(DrawObject intersectObj)
        {
            Point p = intersectObj as Point;

        }

        public override void isRect(DrawObject intersectObj)
        {
            throw new NotImplementedException();
        }
    }
}
