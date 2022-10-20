using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroGM.Test
{
    public class Circle : DrawObject
    {
        public Point _center { get; private set; }
        public int _radius { get; private set; }

        public Circle(int x1, int y1, int radius)
        {
            _center = new Point(x1,y1);
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle at ({_center.x}, {_center.y}), radius = {_radius}");
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
            throw new NotImplementedException();
        }

        public override void isRect(DrawObject intersectObj)
        {
            throw new NotImplementedException();
        }
    }
}
