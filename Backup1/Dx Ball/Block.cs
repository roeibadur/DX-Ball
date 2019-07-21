using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dx_Ball
{
    class Blocks //לבנה
    {
        private int x;//מיקום הלבנה בציר ה x
        private int y;//מיקום הלבנה בציר הy
        private Color color;//צבע הלבנה
        private bool bonus;//בונוס
        


        public Blocks(int x, int y, Color c) //פעולה בונה
        {
            this.x = x;
            this.y = y;
            this.color = c;
            this.bonus = false;
            
        }
        public int GetX()//פעולה המחזירה את מיקום הלבנה על ציר הx 
        {
            return x;
        }
        public int GetY()//פעולה המחזירה את מיקום הלבנה על ציר הY
        {
            return y;
        }
        public Color getColor()//פעולה המחזירה את צבע הלבנה
        {
            return color;

        }
        public void setColor(Color c)//פעולה המשנה את צבע הלבנה
        {
            this.color = c;
        }
        public void setBonus()//פעולה המשנה את הבונוס
        {
            this.bonus = true;
        }
        public bool isbonus()//פעולה המחזירה את הבונוס
        {
            return bonus;
        }

        public void PaintBlocks(Graphics gr) //ציור הלבנה
        {
            SolidBrush br;
            br = new SolidBrush(color);
            Pen pn = new Pen(br, 2);
            Rectangle r = new Rectangle(x, y, 30, 15);
            gr.FillRectangle(br, r);
        }


        public void DellBlock(Graphics g)//פעולה המוחקת לבנה
        {
            SolidBrush brush1 = new SolidBrush(Color.Black);
            Rectangle rectangle1 = new Rectangle(x, y, 30, 15);
            g.FillRectangle(brush1, rectangle1);

        }


    }
}