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
        private int Life = 3; //����
        private int Score = 0; //�����
        private List<Blocks> lb; //����� �� �����
        private Ball bl; //����
        private Paddle kv; //���
        private Node<Blocks> pos;
        public Board(Graphics g) // ����� ����
        // ���� ����� �����, ������ ����+���� ������� �� ��� �����
        {
            lb = new List<Blocks>();
            pos = lb.GetFirst();
            Blocks box;
            int x = 120; //����� ���� �� ����
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
                        c = Color.Red;            //����� ���� �����

                    if (i == 1 || i == 5 || i == 7)
                        c = Color.Magenta;
                      
                    if (i == 2 || i == 4 || i == 8)
                        c = Color.Pink;
               
                    if(i==3||i==9)
                        c=Color.Purple;
                                               //�� ���� ����� ������ 
                               
                    if((i==0||i==9)&&j>4&&j<15)
                        box = new Blocks(x, y,c);       //���� ���� ����� X,Y
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

                    pos = lb.Insert(pos, box); // ����� ���� ������ ���� ������
                    x += 31;
                }
                x = 120;
                y += 16;
            }


            Drawlist(g);
            bl = new Ball(); // ���� ��� ����
            bl.DrawBall(g); // ����� ����
            kv = new Paddle(); // ��� ���
            kv.PainPaddle(g);// ����� ���
        }
        // ���� ���� ������
        public int GetLife()//����� ������� �� �����
        {
            return Life;
        }
        public int GetScore()//����� ������� �� ������
        {
            return Score;
        }
        public List<Blocks> Getlist()//����� ������� ����� �� �����
        {
            return lb;
        }
        public Paddle GetKv()//����� ������� �� �����
        {
            return kv;
        }
        public Ball GetBall()//����� ������� �� �����
        {
            return bl;
        }
        public void SetLife(int l)//����� ����� �� ���� �����
        {
            Life = l;
        }
        public void SetScore(int s)// ����� ����� �� ������
        {
            Score = s;
        }

        public void Drawlist(Graphics g)//����� ������� ����� �� �����
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
