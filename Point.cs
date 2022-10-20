using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroGM.Test
{
    public class Point : DrawObject
    {
        public int x { get; private set;}
        public int y { get; private set;}

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            Console.WriteLine($"point at ({x}, {y})");
        }

        public override void Intersect(DrawObject intersectObj)
        {
            if(intersectObj == this)
            {
                return;
            }
            switch(intersectObj)
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
            Circle circle = intersectObj as Circle;
            if(circle == null)
            {
                Console.WriteLine("Object is null");
                return;
            }
            int xPoint = x - circle._center.x;
            int yPoint = y - circle._center.y;

            if(xPoint * xPoint + yPoint * yPoint <= circle._radius * circle._radius)
            {
                Console.WriteLine($"Point and cirtcle have intersection at ({x},{y})");
            }
            else
            {
                Console.WriteLine($"Point and cirtcle have not intersection");
            }
        }

        public override void isLine(DrawObject intersectObj)
        {
            Line line = intersectObj as Line;
            if(line == null)
            {
                Console.WriteLine("Object is null");
                return;
            }

            if(x >= line._startPoint.x && x <= line._startPoint.x || y >= line._endPoint.y && y >= line._startPoint.y)
            {
                Console.WriteLine($"Point and line have intersection at ({x},{y})");
            }
            else
            {
                Console.WriteLine("Point and line have not intersection");
            }

        }

        public override void isPoint(DrawObject intersectObj)
        {
            Point p = intersectObj as Point;
            if (p == null)
            {
                Console.WriteLine("Object is Null");
                return;
            }
            if (p.y == y && p.x ==y) 
            {
                Console.WriteLine($"Points have intersection at ({x}, {y})");
            }
            else
            {
                Console.WriteLine($"Points have not intersection");
            }
        }

        public override void isRect(DrawObject intersectObj)
        {
            Rect rect = intersectObj as Rect;
            if(rect == null)
            {
                Console.WriteLine("Object is Null");
                return;
            }

            if (x >= rect._startPoint.x && x <= rect._endPoint.x && y >= rect._startPoint.y &&  y <= rect._endPoint.y)
            {
                Console.WriteLine($"Point and rect have intersection ({x},{y})");
            }
            else if (x <= rect._startPoint.x && x >= rect._endPoint.x && y <= rect._startPoint.y && y >= rect._endPoint.y)
            {
                Console.WriteLine($"Point and rect have intersection ({x},{y})");
            }
            else 
            {
                Console.WriteLine($"Point and rect have not intersection");
            }
        }
    }
}
