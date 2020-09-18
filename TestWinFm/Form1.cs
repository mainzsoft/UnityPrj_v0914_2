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


    public partial class MainFm : Form
    {

        // -----------------------------------------------------------------------------------------------------
        public ClsCard     myCard = new ClsCard();
        public ClsCardRank myRank = new ClsCardRank();


        // 카드이미지 매핑
        public void MappingCardImg(PictureBox mappingPicBox, string strParam)
        {
            Bitmap ObjCardImg = new Bitmap(Properties.Resources.SA);            

            switch (strParam)
            {
                case "OO": ObjCardImg = Properties.Resources.OO; break;

                case "SA": ObjCardImg = Properties.Resources.SA; break;
                case "S2": ObjCardImg = Properties.Resources.S2; break;
                case "S3": ObjCardImg = Properties.Resources.S3; break;
                case "S4": ObjCardImg = Properties.Resources.S4; break;
                case "S5": ObjCardImg = Properties.Resources.S5; break;
                case "S6": ObjCardImg = Properties.Resources.S6; break;
                case "S7": ObjCardImg = Properties.Resources.S7; break;
                case "S8": ObjCardImg = Properties.Resources.S8; break;
                case "S9": ObjCardImg = Properties.Resources.S9; break;
                case "ST": ObjCardImg = Properties.Resources.ST; break;
                case "SJ": ObjCardImg = Properties.Resources.SJ; break;
                case "SQ": ObjCardImg = Properties.Resources.SQ; break;
                case "SK": ObjCardImg = Properties.Resources.SK; break;

                case "HA": ObjCardImg = Properties.Resources.HA; break;
                case "H2": ObjCardImg = Properties.Resources.H2; break;
                case "H3": ObjCardImg = Properties.Resources.H3; break;
                case "H4": ObjCardImg = Properties.Resources.H4; break;
                case "H5": ObjCardImg = Properties.Resources.H5; break;
                case "H6": ObjCardImg = Properties.Resources.H6; break;
                case "H7": ObjCardImg = Properties.Resources.H7; break;
                case "H8": ObjCardImg = Properties.Resources.H8; break;
                case "H9": ObjCardImg = Properties.Resources.H9; break;
                case "HT": ObjCardImg = Properties.Resources.HT; break;
                case "HJ": ObjCardImg = Properties.Resources.HJ; break;
                case "HQ": ObjCardImg = Properties.Resources.HQ; break;
                case "HK": ObjCardImg = Properties.Resources.HK; break;

                case "DA": ObjCardImg = Properties.Resources.DA; break;                
                case "D2": ObjCardImg = Properties.Resources.D2; break;
                case "D3": ObjCardImg = Properties.Resources.D3; break;
                case "D4": ObjCardImg = Properties.Resources.D4; break;
                case "D5": ObjCardImg = Properties.Resources.D5; break;
                case "D6": ObjCardImg = Properties.Resources.D6; break;
                case "D7": ObjCardImg = Properties.Resources.D7; break;
                case "D8": ObjCardImg = Properties.Resources.D8; break;
                case "D9": ObjCardImg = Properties.Resources.D9; break;
                case "DT": ObjCardImg = Properties.Resources.DT; break;
                case "DJ": ObjCardImg = Properties.Resources.DJ; break;
                case "DQ": ObjCardImg = Properties.Resources.DQ; break;
                case "DK": ObjCardImg = Properties.Resources.DK; break;

                case "CA": ObjCardImg = Properties.Resources.CA; break;
                case "C2": ObjCardImg = Properties.Resources.C2; break;
                case "C3": ObjCardImg = Properties.Resources.C3; break;                
                case "C4": ObjCardImg = Properties.Resources.C4; break;
                case "C5": ObjCardImg = Properties.Resources.C5; break;
                case "C6": ObjCardImg = Properties.Resources.C6; break;
                case "C7": ObjCardImg = Properties.Resources.C7; break;
                case "C8": ObjCardImg = Properties.Resources.C8; break;
                case "C9": ObjCardImg = Properties.Resources.C9; break;
                case "CT": ObjCardImg = Properties.Resources.CT; break;
                case "CJ": ObjCardImg = Properties.Resources.CJ; break;
                case "CQ": ObjCardImg = Properties.Resources.CQ; break;
                case "CK": ObjCardImg = Properties.Resources.CK; break;
            }

            mappingPicBox.Image = ObjCardImg;
        }




        public MainFm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        // 카드섞기
        private void button1_Click(object sender, EventArgs e)
        {
            myCard.Suff();
            myCard.CardMapping(DellerTx);

            MappingCardImg(UserCardImg11, "OO");
            MappingCardImg(UserCardImg12, "OO");
            MappingCardImg(UserCardImg21, "OO");
            MappingCardImg(UserCardImg22, "OO");
            MappingCardImg(UserCardImg31, "OO");
            MappingCardImg(UserCardImg32, "OO");
            MappingCardImg(UserCardImg41, "OO");
            MappingCardImg(UserCardImg42, "OO");
            MappingCardImg(UserCardImg51, "OO");
            MappingCardImg(UserCardImg52, "OO");
            MappingCardImg(UserCardImg61, "OO");
            MappingCardImg(UserCardImg62, "OO");
            MappingCardImg(UserCardImg71, "OO");
            MappingCardImg(UserCardImg72, "OO");
            MappingCardImg(UserCardImg81, "OO");
            MappingCardImg(UserCardImg82, "OO");
            MappingCardImg(UserCardImg91, "OO");
            MappingCardImg(UserCardImg92, "OO");

            MappingCardImg(CommCard1, "OO");
            MappingCardImg(CommCard2, "OO");
            MappingCardImg(CommCard3, "OO");
            MappingCardImg(CommCard4, "OO");
            MappingCardImg(CommCard5, "OO");
        }

        // 플레이어 핸드
        private void button2_Click(object sender, EventArgs e)
        {
            //MappingCardImg(UserCardImg11, myCard.GetCard("Player11"));
            //MappingCardImg(UserCardImg12, myCard.GetCard("Player12"));

            MappingCardImg(UserCardImg11, myCard.PlayerHand(1, 1));
            MappingCardImg(UserCardImg12, myCard.PlayerHand(1, 2));

            MappingCardImg(UserCardImg21, myCard.GetCard("Player21"));
            MappingCardImg(UserCardImg22, myCard.GetCard("Player22"));

            MappingCardImg(UserCardImg31, myCard.GetCard("Player31"));
            MappingCardImg(UserCardImg32, myCard.GetCard("Player32"));

            MappingCardImg(UserCardImg41, myCard.GetCard("Player41"));
            MappingCardImg(UserCardImg42, myCard.GetCard("Player42"));

            MappingCardImg(UserCardImg51, myCard.GetCard("Player51"));
            MappingCardImg(UserCardImg52, myCard.GetCard("Player52"));

            MappingCardImg(UserCardImg61, myCard.GetCard("Player61"));
            MappingCardImg(UserCardImg62, myCard.GetCard("Player62"));

            MappingCardImg(UserCardImg71, myCard.GetCard("Player71"));
            MappingCardImg(UserCardImg72, myCard.GetCard("Player72"));

            MappingCardImg(UserCardImg81, myCard.GetCard("Player81"));
            MappingCardImg(UserCardImg82, myCard.GetCard("Player82"));

            MappingCardImg(UserCardImg91, myCard.GetCard("Player91"));
            MappingCardImg(UserCardImg92, myCard.GetCard("Player92"));
        }

        // 커뮤니티 플럽
        private void button3_Click(object sender, EventArgs e)
        {
            MappingCardImg(CommCard1, myCard.CommunityFlop(1));
            MappingCardImg(CommCard2, myCard.CommunityFlop(2));
            MappingCardImg(CommCard3, myCard.CommunityFlop(3));            
        }

        // 커뮤니티 턴
        private void button4_Click(object sender, EventArgs e)
        {
            MappingCardImg(CommCard4, myCard.CommunityTurn());
        }

        // 커뮤니티 리버
        private void button5_Click(object sender, EventArgs e)
        {
            MappingCardImg(CommCard5, myCard.CommunityRiver());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = 
        }
    }


}
