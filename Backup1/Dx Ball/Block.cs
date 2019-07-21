using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dx_Ball
{
    class Blocks //����
    {
        private int x;//����� ����� ���� � x
        private int y;//����� ����� ���� �y
        private Color color;//��� �����
        private bool bonus;//�����
        


        public Blocks(int x, int y, Color c) //����� ����
        {
            this.x = x;
            this.y = y;
            this.color = c;
            this.bonus = false;
            
        }
        public int GetX()//����� ������� �� ����� ����� �� ��� �x 
        {
            return x;
        }
        public int GetY()//����� ������� �� ����� ����� �� ��� �Y
        {
            return y;
        }
        public Color getColor()//����� ������� �� ��� �����
        {
            return color;

        }
        public void setColor(Color c)//����� ����� �� ��� �����
        {
            this.color = c;
        }
        public void setBonus()//����� ����� �� ������
        {
            this.bonus = true;
        }
        public bool isbonus()//����� ������� �� ������
        {
            return bonus;
        }

        public void PaintBlocks(Graphics gr) //���� �����
        {
            SolidBrush br;
            br = new SolidBrush(color);
            Pen pn = new Pen(br, 2);
            Rectangle r = new Rectangle(x, y, 30, 15);
            gr.FillRectangle(br, r);
        }


        public void DellBlock(Graphics g)//����� ������ ����
        {
            SolidBrush brush1 = new SolidBrush(Color.Black);
            Rectangle rectangle1 = new Rectangle(x, y, 30, 15);
            g.FillRectangle(brush1, rectangle1);

        }


    }
}