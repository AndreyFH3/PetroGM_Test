using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroGM.Test
{
    public abstract class DrawObject
    {

        public abstract void Draw();

        public abstract void Intersect(DrawObject intersectObj);

        public abstract void isRect(DrawObject intersectObj);
        public abstract void isLine(DrawObject intersectObj);
        public abstract void isCircle(DrawObject intersectObj);
        public abstract void isPoint(DrawObject intersectObj);
    }
}
