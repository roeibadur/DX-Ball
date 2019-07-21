using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dx_Ball
{
    class Paddle //משטח
    {
        private int Xpaddle;//מיקום ה x של המשטח
        private int Ypaddle;//מיקום הy של המשטח
        public Paddle()
        {
            Xpaddle = 452;
            Ypaddle = 607;

        }
        public int GetXpaddle()//פעולה המחזירה את מיקום הx של המשטח 
        {
            return Xpaddle;
        }
        public int GetYpaddle()//פעולה המחזירה את מיקום הty של המשטח
        {
            return Ypaddle;
        }
        public void SetXpaddle(int X) //פעולה המשנה את מיקום הx של המשטח
        {
            Xpaddle = X;
        }
        public void SetYpaddle(int y)//פעולה המשנה את מיקום הy של המשטח
        {
            Ypaddle = y;
        }
        public void PainPaddle(Graphics g) //ציור המשטח
        {
            SolidBrush br = new SolidBrush(Color.Cyan);
            Pen p = new Pen(br, 4);
            g.DrawLine(p, Xpaddle, Ypaddle, Xpaddle + 100, Ypaddle);
        }
        public void DelPafd(Graphics g) //מחיקת במשטח
        // נעשה על ידי צביע בצבע הרקע
        {
            SolidBrush br = new SolidBrush(Color.Black);
            Pen p = new Pen(br, 4);
            g.DrawLine(p, Xpaddle, Ypaddle, Xpaddle + 100, Ypaddle);
        }

    }
}
