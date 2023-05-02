using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIPaint.Paint
{
    internal interface IElement
    {
        Point Position { get; set; }
        void Draw();
        void MoveLeft() { Position.x--; }
        void MoveRight() { Position.x++; }
        void MoveUp() { Position.y--; }
        void MoveDown() { Position.y++; }
    }
}
