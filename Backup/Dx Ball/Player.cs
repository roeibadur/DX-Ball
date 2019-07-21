using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dx_Ball
{
    class Paddle //����
    {
        private int Xpaddle;
        private int Ypaddle;
        public Paddle()
        {
            Xpaddle = 452;
            Ypaddle = 607;

        }
        public int GetXpaddle()
        {
            return Xpaddle;
        }
        public int GetYpaddle()
        {
            return Ypaddle;
        }
        public void SetXpaddle(int X) //���� �����
        {
            Xpaddle = X;
        }
        public void SetYpaddle(int y)
        {
            Ypaddle = y;
        }
        public void PainPaddle(Graphics g) //���� �����
        {
            SolidBrush br = new SolidBrush(Color.Cyan);
            Pen p = new Pen(br, 4);
            g.DrawLine(p, Xpaddle, Ypaddle, Xpaddle + 100, Ypaddle);
        }
        public void DelPafd(Graphics g) //����� �����
        // ���� �� ��� ���� ���� ����
        {
            SolidBrush br = new SolidBrush(Color.Black);
            Pen p = new Pen(br, 4);
            g.DrawLine(p, Xpaddle, Ypaddle, Xpaddle + 100, Ypaddle);
        }

    }
}
