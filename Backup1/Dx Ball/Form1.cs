using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dx_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       

        private void button5_Click(object sender, EventArgs e)//����� �� ����� ������
        {
            switch (MessageBox.Show("��� ��� ���� ������� ����?", "Dx-Ball", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: MessageBox.Show("���� ���� ������", "���");
                    this.Close();
                    break;
                case DialogResult.No:
                    MessageBox.Show("���� ������ �����", "����", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)//����� �� ����� �������
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)//����� �� ����� ���� ����
        {
            Game a = new Game();
            a.Show();
        }

       

    }
}