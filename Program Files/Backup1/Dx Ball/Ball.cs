using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dx_Ball
{
    class Ball //כדור
    {
        private int Xball;//מיקום הכדור על ציר הx
        private int Yball;//מיקום הכדור על ציר הy
        private int dir;//כיוון הכדור
        public Ball() //פעולה בונה
        {
            this.Xball = 485;
            this.Yball = 450;
            this.dir = 4;
        }
        public int GetXball()//פעולה המחזירה את מיקום ה-x של הכדור
        {
            return Xball;
        }
        public int GetYball()//פעולה המחזירה את מיקום הy של הכדור
        {
            return Yball;
        }
        public int GetDir()//פעולה המחזירה את כיוון הכדור
        {
            return dir;
        }
        public void SetXball(int x)//פעולה המשנה את מיקום הx של הכדור
        {
            Xball = x;
        }

        public void SetYball(int y)//פעולה המשנה את מיקום הy של כדור
        {
            Yball = y;
        }
        public void SetDir(int Dir)// פעולה המשנה את כיוון הכדור
        {
            dir = Dir;
        }
        public void DrawBall(Graphics g) // פעולה המציירת כדור
        {
            SolidBrush br = new SolidBrush(Color.Red);
            Rectangle r = new Rectangle(Xball, Yball, 20, 20);
            g.FillPie(br, r, 0, 360);
        }
        public void DelBall(Graphics g)//פעולה המוחקת את בכדור
        {
            SolidBrush br = new SolidBrush(Color.Black);
            Rectangle r = new Rectangle(Xball, Yball, 20, 20);
            g.FillPie(br, r, 0, 360);


        }
        public void MoveBall() //תזוזזת הכדור
        {
            switch (dir)
            {
                case 1:
                    Xball += 4;
                    Yball -= 4;
                    break;
                case 2:
                    Xball += 4;
                    Yball += 4;
                    break;
                case 3:
                    Xball -= 4;
                    Yball += 4;
                    break;
                case 4:
                    Xball -= 4;
                    Yball -= 4;
                    break;
                case 5:

                    Yball -= 4;
                    break;
                case 6:
                    Xball += 4;

                    break;

                case 7:

                    Yball += 4;
                    break;
                case 8:
                    Xball -= 4;

                    break;
            }
        }
        public void ChangeDir() // שינוי כיוון תזוזת הכדור
        {
            switch (dir)
            {
                case 1:
                    SetDir(2);
                    break;

                case 2:
                    SetDir(8);
                    break;

                case 3:
                    SetDir(6);
                    break;

                case 4:
                    SetDir(1);
                    break;

                case 5:
                    SetDir(3);
                    break;

                case 6:
                    SetDir(7);
                    break;

                case 7:
                    SetDir(4);
                    break;

                case 8:
                    SetDir(5);
                    break;

            }
        }




    }
}
