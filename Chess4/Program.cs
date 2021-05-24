using System;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            King N = new King(4, 4);
            Console.WriteLine(N.Turn(5, 5));
            Queen Q = new Queen(1, 1);
            Console.WriteLine(Q.Turn(2, 2));
            Bishop B = new Bishop(4, 4);
            Console.WriteLine(B.Turn(4, 5));
            Knight K = new Knight(1, 1);
            Console.WriteLine(K.Turn(2, 3));
            Rook R = new Rook(4, 4);
            Console.WriteLine(R.Turn(5, 5));
        }
        class Figure
        {
            protected int x1;
            protected int y1;
            public Figure(int x, int y)
            {
                this.x1 = x;
                this.y1 = y;
            }
            public virtual bool Turn(int x2, int y2)
            {
                return false;
            }

        }
        class King : Figure
        {
            public King(int x1, int y1) : base(x1, y1)
            {
            }
            public override bool Turn(int x2, int y2)
            {
                if (((x1 - x2 == 1 || x1 - x2 == -1 || x1 - x2 == 0) && (y1 - y2 == 1 || y1 - y2 == -1 || y1 - y2 == 0)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Queen : Figure
        {
            public Queen(int x1, int y1) : base(x1, y1)
            {
            }
            public override bool Turn(int x2, int y2)
            {
                if ((Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1 || x1 == x2 || y1 == y2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Bishop : Figure
        {
            public Bishop(int x1, int y1) : base(x1, y1)
            {
            }
            public override bool Turn(int x2, int y2)
            {
                if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Knight : Figure
        {
            public Knight(int x1, int y1) : base(x1, y1)
            {
            }
            public override bool Turn(int x2, int y2)
            {
                if ((Math.Abs(x1 - x2)) == 1 && (Math.Abs(y1 - y2)) == 2 || (Math.Abs(x1 - x2)) == 2 && (Math.Abs(y1 - y2)) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Rook : Figure
        {
            public Rook(int x1, int y1) : base(x1, y1)
            {
            }
            public override bool Turn(int x2, int y2)
            {
                if (x1 == x2 || y1 == y2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
