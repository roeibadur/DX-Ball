using System;
using Unit4.CollectionsLib;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dx_Ball
{
    class Board
    {
        private int Life = 3; //חיים
        private int Score = 0; //ניקוד
        private List<Blocks> lb; //רשימה של לבנים
        private Ball bl; //כדור
        private Paddle kv; //פדל
        private Node<Blocks> pos;
        public Board(Graphics g) // פעולה בונה
        // בונה רשימת לבנים, מאתחלת משטח+כדור ומציירת את לוח המשחק
        {
            lb = new List<Blocks>();
            pos = lb.GetFirst();
            Blocks box;
            int x = 120; //אתחול גרפי של הלוח
            int y = 200;
            Score = 0;
            Life = 3;
            Color c=Color.Black;
            box = new Blocks(x, y, c);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i == 0 || i == 6)
                        c = Color.Red;            //קביעת הצבע לשורה

                    if (i == 1 || i == 5 || i == 7)
                        c = Color.Magenta;
                      
                    if (i == 2 || i == 4 || i == 8)
                        c = Color.Pink;
               
                    if(i==3||i==9)
                        c=Color.Purple;
                                               //לא מיצר לבנים בקצוות 
                               
                    if((i==0||i==9)&&j>4&&j<15)
                        box = new Blocks(x, y,c);       //יוצר לבנה בגודל X,Y
                    if ((i==1||i==8) && j > 1 && j < 18)
                        box = new Blocks(x, y, c);
                     if((i==2||i==7)&&j>0&&j<19)
                         box = new Blocks(x, y, c);
                    if(i>=3&&i<7)
                         box = new Blocks(x, y, c);
                     if (((i+1) + (j+1)) % 5 == 2)
                     {
                         box.setColor(Color.Yellow);
                         if (i == 0 && j == 0)
                             box.setColor( Color.Black);
                     }

                    pos = lb.Insert(pos, box); // מצייר לבנה ומכניס אותה לרשימה
                    x += 31;
                }
                x = 120;
                y += 16;
            }


            Drawlist(g);
            bl = new Ball(); // יוצר עצם כדור
            bl.DrawBall(g); // מצייר אותו
            kv = new Paddle(); // עצם פדל
            kv.PainPaddle(g);// מצייר פדל
        }
        // הצגת חיים וניקוד
        public int GetLife()//פעולה המחזירה את החיים
        {
            return Life;
        }
        public int GetScore()//פעולה המחזירה את הניקוד
        {
            return Score;
        }
        public List<Blocks> Getlist()//פעולה המחזירה רשימה של לבנים
        {
            return lb;
        }
        public Paddle GetKv()//פעולה המחזירה את המשטח
        {
            return kv;
        }
        public Ball GetBall()//פעולה המחזירה את הכדור
        {
            return bl;
        }
        public void SetLife(int l)//פעולה המשנה את כמות החיים
        {
            Life = l;
        }
        public void SetScore(int s)// פעולה המשנה את הניקוד
        {
            Score = s;
        }

        public void Drawlist(Graphics g)//פעולה המציירת רשימה של לבנים
        {
            pos = lb.GetFirst();
            while (pos != null)
            {
                pos.GetInfo().PaintBlocks(g);
                pos = pos.GetNext();
            }
        }

    }
}
