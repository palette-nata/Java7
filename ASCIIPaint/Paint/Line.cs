using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIPaint.Paint
{
    internal class Line : Figure
    {
        readonly char lineChar;
        readonly int length = 0;
        Orientation orientation;
        public Point Position { get; set; }
        public Line(char ch, int length, Orientation orientation)
        {
            this.lineChar = ch;
            this.length = length;
            this.orientation = orientation;
        }
        
        public override void Draw()
        {
            var position = Position;
            Console.SetCursorPosition(Position.x, Position.y);
            if (orientation == Orientation.Horizontal)
            {
                for(int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(position.x, position.y);
                    Console.Write(lineChar);
                    position.x++;
                }
            } else if (orientation == Orientation.Vertical)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(position.x, position.y);
                    Console.Write(lineChar);
                    position.y++;
                }
            }
        }

   
    }
}
