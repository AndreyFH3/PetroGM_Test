using PetroGM.Test;

namespace PetroGM_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);

            p.Intersect(new Point(1,1));
            p.Intersect(new Point(1,2));

            p.Intersect(new Circle(0,0,3));
            p.Intersect(new Circle(15,20,1));

            p.Intersect(new Line(1, 2, 1, 5));
            p.Intersect(new Line(3, 2, 4, 5));

            p.Intersect(new Rect(-3, -3, 3, 3));
            p.Intersect(new Rect(3, 3, -3, -3));
            Console.ReadKey();
        }
    }
}