




using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Unit4.CollectionsLib;

namespace Dx_Ball
{

    public partial class Game : Form
    // ������� �����
    {
        Graphics gr;
        Board boardGame;
        Paddle pdl;
        Ball bal;
        Blocks bls;
        Node<Blocks> pos;
        int x, y, Xkv, Ykv, life, score;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        // ����� �����
        {
            gr = CreateGraphics();

        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            gr = CreateGraphics();
            boardGame = new Board(gr); // ����� ��� ����
            pdl = boardGame.GetKv();// ���
            bal = boardGame.GetBall();//����

            label3.Text = "Score=" + boardGame.GetScore().ToString();
            label4.Text = "Life=" + boardGame.GetLife().ToString();
            timer1.Start();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // �� ��� �����                     �� ��� ����
            if (boardGame.GetLife() > 0 && !(boardGame.Getlist().IsEmpty()))
            {
                gr = CreateGraphics();
                boardGame.GetKv().PainPaddle(gr); //���� ����
                Xkv = boardGame.GetKv().GetXpaddle(); //���� ���� ���� 

                bal.DrawBall(gr);
                x = bal.GetXball();
                y = bal.GetYball();
                //����� ����
                bal.DelBall(gr);
                bal.MoveBall();
                x = bal.GetXball();
                y = bal.GetYball();
                bal.DrawBall(gr);
                if (y >= 608 || x <= 50 || y <= 3 || x >= 780) //�� ���� ����� ����� ����� �� ��� ����
                {
                    bal.ChangeDir();
                    if (y >= 608)
                    {
                        timer1.Stop();
                        boardGame.GetLife();
                        life = boardGame.GetLife();
                        life--;//����� ���� �� ��� �����
                        boardGame.SetLife(life);
                        label4.Text = "Life=" + boardGame.GetLife().ToString();
                        pdl.DelPafd(gr);
                        pdl.SetXpaddle(452);
                        pdl.SetYpaddle(607);
                        pdl.PainPaddle(gr);
                        bal.DelBall(gr);
                        bal.SetXball(485);
                        bal.SetYball(450);
                        bal.SetDir(4);
                        bal.DrawBall(gr);
                        timer1.Start();
                    }
                }
                if ((x >= Xkv) && (x < Xkv + 70) && (y + 30 >= Ykv) && (y + 30 <= Ykv + 4))
                {//����� ����� �� ���� ����
                    bal.ChangeDir();
                    if (bal.GetDir() == 7) bal.ChangeDir();//����� ��� �� ����� ����� ���� ������
                    x = bal.GetXball();
                    y = bal.GetYball();

                }



                pos = boardGame.Getlist().GetFirst();
                bls = pos.GetInfo();

                while (pos != null)
                {
                    score = boardGame.GetScore();
                    bls = pos.GetInfo();
                    //���� �� ������ ��� ����� �����
                    if (((bls.GetX() <= x) && (x <= bls.GetX() + 50)) && ((bls.GetY() <= y) && (y <= bls.GetY() + 30)))
                    {
                        //��� �����
                        bls = pos.GetInfo();
                        bls.DellBlock(gr);
                        if (bls.isbonus())
                            score += 50;//�� ���� ����� ���� ���� 50
                        else
                        {
                            //���� �����
                            bls.DellBlock(gr); //����� ������ �����
                            pos = boardGame.Getlist().Remove(pos); //����� ����� �������
                            score += 10;
                        }
                        boardGame.SetScore(score);
                        label3.Text = "Score=" + boardGame.GetScore().ToString();
                        bal.ChangeDir();
                        x = bal.GetXball();
                        y = bal.GetYball();

                    }
                    else
                        pos = pos.GetNext();
                }
            }


            else
            {
            }

            
   }
        



        private void Game_KeyDown(object sender, KeyEventArgs e)
        {

            int moving;
            moving = e.KeyValue;

            Xkv = pdl.GetXpaddle();
            Ykv = boardGame.GetKv().GetYpaddle();// ������ �� ����
            if (moving == 37)
            {//�����
                Xkv -= 5;
                if (Xkv <= 20) Xkv += 5;

            }
            if (moving == 39)
            {//�����
                Xkv += 5;
                if (Xkv >= 900) Xkv -= 5;

            }
            pdl.DelPafd(gr);
            pdl.SetXpaddle(Xkv);
            pdl.PainPaddle(gr);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)//����� �� ����� newgame
        {
            Game a = new Game();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//����� �� ����� exit
        {
            this.Close();
        }
    }
}


       

      

       
      



    

