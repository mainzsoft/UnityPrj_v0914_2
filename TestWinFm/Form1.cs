using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace TestWinFm
{


    public partial class Form1 : Form
    {
        public ClsCard myCard = new ClsCard();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCard.Suff();
            myCard.MappingTx(DellerTx, "CARD");
            myCard.MappingTx(GameTx, "GAME");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCard.MappingLB(CommunityLB, "FLOP");
            myCard.MappingLB(CommunityLB, "TURN");
            myCard.MappingLB(CommunityLB, "RIVR");

            myCard.MappingLB(label1, 1);
            myCard.MappingLB(label2, 2);
            myCard.MappingLB(label3, 3);
            myCard.MappingLB(label4, 4);
            myCard.MappingLB(label5, 5);
            myCard.MappingLB(label6, 6);
            myCard.MappingLB(label7, 7);
            myCard.MappingLB(label8, 8);
            myCard.MappingLB(label9, 9);

            myCard.PlayerCal(1); textBox1.Text = myCard.pCard[0, 3];
            myCard.PlayerCal(2); textBox2.Text = myCard.pCard[1, 3];
            myCard.PlayerCal(3); textBox3.Text = myCard.pCard[2, 3];
            myCard.PlayerCal(4); textBox4.Text = myCard.pCard[3, 3];
            myCard.PlayerCal(5); textBox5.Text = myCard.pCard[4, 3];
            myCard.PlayerCal(6); textBox6.Text = myCard.pCard[5, 3];
            myCard.PlayerCal(7); textBox7.Text = myCard.pCard[6, 3];
            myCard.PlayerCal(8); textBox8.Text = myCard.pCard[7, 3];
            myCard.PlayerCal(9); textBox9.Text = myCard.pCard[8, 3];             
        }
    }


}
