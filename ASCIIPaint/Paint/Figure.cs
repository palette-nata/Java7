using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIPaint.Paint
{
    public abstract class Figure : IElement
    {
        Point? IElement.Position { get; set; }
        public abstract void Draw();
    }
}
