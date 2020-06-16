using System.Drawing;
using TicTacToe.Properties;

namespace TicTacToe
{
    class DrawGraphics
    {
        private Rectangle _geom;
        private int _state; // 0 1 -1
        private static readonly int S = 400;




        public void Reset()
        {
            _state = 0;
        }
        public bool PlayerA()
        { return _state == 1; }
        public bool PlayerB()
        { return _state == -1; }



        public DrawGraphics(int tx, int ty, int w)
        {
            _geom = new Rectangle(tx, ty, 150, 150);
            _state = 0;
        }


        public bool PointInRect(Point p)
        {

            bool r = _geom.Contains(p);
            return r;
        }



        public void Desiner(ref Graphics g)
        {

            Pen pen = new Pen(Color.Transparent, 5);

            g.DrawRectangle(pen, _geom);

        }

        public void DessinerX_Black(ref Graphics g)
        {
            if (_state == 0)
            {
                Point ulCorner = new Point(_geom.Left + 25, _geom.Top + 25);

                g.DrawImage(Resources.X_Uncolored, ulCorner);

                _state = 1;
            }
        }

        public void DessinerO_Black(ref Graphics g)
        {
            if (_state == 0)
            {
                Point ulCorner = new Point(_geom.Left + 25, _geom.Top + 25);

                g.DrawImage(Resources.O_Uncolored, ulCorner);

                _state = -1;
            }

        }







        public void DessinerX(ref Graphics g)
        {

            Point ulCorner = new Point(_geom.Left + 25, _geom.Top + 25);

            g.DrawImage(Resources.X, ulCorner);

        }

        public void DessinerO(ref Graphics g)
        {

            Point ulCorner = new Point(_geom.Left + 25, _geom.Top + 25);

            g.DrawImage(Resources.O, ulCorner);

            _state = -1;

        }



        public int GridValue()
        {
            int gridVal = _state;
            return gridVal;
        }
    }
}
