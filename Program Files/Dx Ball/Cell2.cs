using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Dx_Ball
{
    class Cell2
    {
        private int x, y;
        private bool status;
        Image pic;

         public Cell2()
        {
            x = 0;
            y = 0;
            status = false;
            pic = Image.FromFile("images/malben2.jpg");
            
                                    
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void Setstatus()
        {
            this.status = true;
        }             
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public bool Getstatus()
        {
            return this.status;
        }
        public void Setpic(Image pic)
        {
            this.pic = pic;
        }
        public Image Getpic()
        {
            return this.pic;
        }
        public void PaintField(Graphics g)
        {
            Point p=new Point(x,y);
            g.DrawImage(pic, p);
            
        }
    }
}
