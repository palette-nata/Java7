using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIPaint.Paint
{
    internal class Canvas
    {
        List<IElement> figureList;

        public void SetHelloWorld()
        {
            figureList = new List<IElement>();
            Text text = new Text("Hello, World!");
            text.Position = new Point { x = 36, y = 5 };
            figureList.Add(text);

            Line line = new Line('░', 45, Orientation.Horizontal);
            line.Position = new Point { x = 36, y = 8 };
            figureList.Add(line);
        }
        public void AddFigure(IElement figure)
        {
            figureList.Add(figure);
        }
        public void Draw()
        {
            figureList.ForEach(a => a.Draw());
        }

        public void SaveToFile(string filename)
        {

        }
        public void LoadFromFile(string filename)
        {
            figureList = new List<IElement>();
        }

    }
}
