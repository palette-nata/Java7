using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace ASCIIPaint.Paint
{
    internal class Text : IElement
    {
        private readonly string _text;
        private readonly Dictionary<char,string> _charset;
        public Text(string text)
        {
            _text = text.ToLower();
            _charset = new Dictionary<char, string>();
            Position = new Point();
            InitCharset();
        }

        public Point Position { get; set; }

        public void Draw()
        {
            Console.SetCursorPosition(Position.x, Position.y);
            foreach (char ch  in _text)
            {
                printChar(ch);
            }
        }

        private void printChar(char ch)
        {
            var position = Console.GetCursorPosition();
            int top = position.Top;
            if (_charset.TryGetValue(ch, out var value))
            {
                foreach (var line in value.Split("\r\n")) 
                {
                    Console.SetCursorPosition(position.Left, position.Top);
                    Console.Write(line);
                    position.Top++;
                }
            }
            var lastPosition = Console.GetCursorPosition();
            Console.SetCursorPosition(lastPosition.Left+1, top);
        }
        public void MoveDown()
        {
            throw new NotImplementedException();
        }
        public void MoveLeft()
        {
            throw new NotImplementedException();
        }
        public void MoveRight()
        {
            throw new NotImplementedException();
        }
        public void MoveUp()
        {
            throw new NotImplementedException();
        }
        public void ScaleSize(double scale)
        {
            throw new NotImplementedException();
        }
        private void InitCharset()
        {
            //                         
            _charset.Clear();
            _charset.Add('a', "▄▀█\r\n█▀█");
            _charset.Add('b', "█▄▄\r\n█▄█");
            _charset.Add('c', "█▀▀\r\n█▄▄");
            _charset.Add('d', "█▀▄\r\n█▄▀");
            _charset.Add('e', "█▀▀\r\n██▄");
            _charset.Add('f', "█▀▀ \r\n█▀░");
            _charset.Add('g', "█▀▀\r\n█▄█");
            _charset.Add('h', "█░█\r\n█▀█");
            _charset.Add('i', "█ \r\n█ ");
            _charset.Add('j', "░░█ \r\n█▄█ ");
            _charset.Add('k', "█▄▀ \r\n█░█");
            _charset.Add('l', "█░░\r\n█▄▄");
            _charset.Add('m', "█▀▄▀█\r\n█░▀░█");
            _charset.Add('n', "█▄░█\r\n█░▀█");
            _charset.Add('o', "█▀█\r\n█▄█");
            _charset.Add('p', "█▀█\r\n█▀▀");
            _charset.Add('q', "█▀█\r\n▀▀█");
            _charset.Add('r', "█▀█\r\n█▀▄");
            _charset.Add('s', "█▀\r\n▄█");
            _charset.Add('t', "▀█▀\r\n░█░");
            _charset.Add('u', "█░█\r\n█▄█");
            _charset.Add('v', "█░█\r\n▀▄▀");
            _charset.Add('w', "█░█░█\r\n▀▄▀▄▀");
            _charset.Add('x', "▀▄▀\r\n█░█");
            _charset.Add('y', "█▄█\r\n░█░");
            _charset.Add('z', "▀█\r\n█▄");
            _charset.Add(' ', " \r\n ");
        }
    }
}
