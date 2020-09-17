using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TestWinFm
{

    public class ClsCard
    {
        const String DELLER_CARD    = "card";
        const String COMMUNITY_CARD_FULP1 = "comm";
        const String COMMUNITY_CARD_FULP2 = "comm";
        const String COMMUNITY_CARD_FULP3 = "comm";
        const String COMMUNITY_CARD_TURN = "comm";
        const String COMMUNITY_CARD_RIVER = "comm";
        const String PLAYER1_CARD = "play1";
        const String PLAYER2_CARD = "play2";
        const String PLAYER3_CARD = "play3";
        const String PLAYER4_CARD = "play4";
        const String PLAYER5_CARD = "play5";
        const String PLAYER6_CARD = "play6";
        const String PLAYER7_CARD = "play7";
        const String PLAYER8_CARD = "play8";
        const String PLAYER9_CARD = "play9";



        private String[] Card = new String[52] {"S2","S3","S4","S5","S6","S7","S8","S9","ST","SJ","SQ","SK","SA",
                                               "H2","H3","H4","H5","H6","H7","H8","H9","HT","HJ","HQ","HK","HA",
                                               "D2","D3","D4","D5","D6","D7","D8","D9","DT","DJ","DQ","DK","DA",
                                               "C2","C3","C4","C5","C6","C7","C8","C9","CT","CJ","CQ","CK","CA"};
        private String[] SortCommCard = new String[5];
        private String[,] SortPlayerCard = new String[9, 2];
        private string[,] PlayerCardRank = new String[9, 1];


        // 카드클리어 (커뮤니티,플레이어,랭크-저장소) ----------------------------------------------------------
        public void _clear()
        {
            for (int iCnt=0; iCnt<9; iCnt++)
            {
                if (iCnt < 5) SortCommCard[iCnt] = "";  // 커뮤니티카드 저장소 Clear
                SortPlayerCard[iCnt, 0] = "";           // 플레이어카드 1/2장  Clear 
                SortPlayerCard[iCnt, 1] = "";           // 플레이어카드 2/2장  Clear
                PlayerCardRank[iCnt, 0] = "";           // 플레이어카드결과(족보내용) Clear
            }
                
        }

        // 카드표현변환 (카드코드 = 카드그림숫자)
        public string _change(string strParam)
        {
            string retParam = "";
            retParam = strParam.Replace("S", "♠");  // 파라메터가 (한개)카드코드 또는 (여러개)카드코드 처리 가능함
            retParam = retParam.Replace("H", "♥");
            retParam = retParam.Replace("D", "◆");
            retParam = retParam.Replace("C", "♣");
            retParam = retParam.Replace("T", "10");
            return retParam;

        }

        // 카드섞기 --------------------------------------------------------------------------------------------
        public void suff()
        {
            string strTemp = "";
            int intTemp = 0;
            Random myRandom = new Random();

            _clear();  //카드관련 저장소 Clear

            for (int iCnt=0; iCnt<Card.Length; iCnt++)
            {
                intTemp = myRandom.Next(iCnt, Card.Length - 1);   // 순서~최대순서 사이에 랜덤값 발생
                strTemp = Card[iCnt];        // (첫번째~)저장소 카드코드 임시저장
                Card[iCnt] = Card[intTemp];  // (첫번째~)저장소에 (랜덤값)저장소 카드코드 저장
                Card[intTemp] = strTemp;     // (랜던값)저장소에 임시저장된 카드코드 저장
            }

            distributionCard();
        }

        // 카드분배 > 일괄처리 ----------------------------------------------------------------------------------
        public void distributionCard()
        {
            for (int iCnt = 1; iCnt < 10; iCnt++) distributionPlayerHand(iCnt);  // 플레이어핸드
            distributionCommFlop();   // 커뮤니티-플럽 #1/3
            distributionCommTurn();   // 커뮤니티-턴   #2/3
            distributionCommRiver();  // 커뮤니티-리버 #3/3
        }

        // 카드분배 > 플레이어핸드 : intParam = 플레이어번호
        public void distributionPlayerHand(int intParam)
        {
            int intTemp = (intParam - 1) * 2;
            SortPlayerCard[intParam - 1, 0] = Card[intTemp];
            SortPlayerCard[intParam - 1, 1] = Card[intTemp + 1];
        }

        // 카드분배 > 커뮤니티(플럽 #1/3)
        public void distributionCommFlop()
        {
            SortCommCard[0] = Card[18];
            SortCommCard[1] = Card[19];
            SortCommCard[2] = Card[20];
        }
        
        // 카드분배 > 커뮤니티(턴 #2/3)
        public void distributionCommTurn()
        {
            SortCommCard[3] = Card[21];
        }

        // 카드분배 > 커뮤니티(리버 #3/3)
        public void distributionCommRiver()
        {
            SortCommCard[4] = Card[22];
        }


        // 카드값 내보내기 -------------------------------------------------------------------------------------
        public string GetCard(string strParam)
        {
            string retCard = "";
            switch(strParam)
            {
                case "Player1": retCard = SortPlayerCard[0, 0] + SortPlayerCard[0, 1]; break;
                case "Player2": retCard = SortPlayerCard[1, 0] + SortPlayerCard[1, 1]; break;
                case "Player3": retCard = SortPlayerCard[2, 0] + SortPlayerCard[2, 1]; break;
                case "Player4": retCard = SortPlayerCard[3, 0] + SortPlayerCard[3, 1]; break;
                case "Player5": retCard = SortPlayerCard[4, 0] + SortPlayerCard[4, 1]; break;
                case "Player6": retCard = SortPlayerCard[5, 0] + SortPlayerCard[5, 1]; break;
                case "Player7": retCard = SortPlayerCard[6, 0] + SortPlayerCard[6, 1]; break;
                case "Player8": retCard = SortPlayerCard[7, 0] + SortPlayerCard[7, 1]; break;
                case "Player9": retCard = SortPlayerCard[8, 0] + SortPlayerCard[8, 1]; break;

                case "Player11": retCard = SortPlayerCard[0, 0]; break;
                case "Player21": retCard = SortPlayerCard[1, 0]; break;
                case "Player31": retCard = SortPlayerCard[2, 0]; break;
                case "Player41": retCard = SortPlayerCard[3, 0]; break;
                case "Player51": retCard = SortPlayerCard[4, 0]; break;
                case "Player61": retCard = SortPlayerCard[5, 0]; break;
                case "Player71": retCard = SortPlayerCard[6, 0]; break;
                case "Player81": retCard = SortPlayerCard[7, 0]; break;
                case "Player91": retCard = SortPlayerCard[8, 0]; break;

                case "Player12": retCard = SortPlayerCard[0, 1]; break;
                case "Player22": retCard = SortPlayerCard[1, 1]; break;
                case "Player32": retCard = SortPlayerCard[2, 1]; break;
                case "Player42": retCard = SortPlayerCard[3, 1]; break;
                case "Player52": retCard = SortPlayerCard[4, 1]; break;
                case "Player62": retCard = SortPlayerCard[5, 1]; break;
                case "Player72": retCard = SortPlayerCard[6, 1]; break;
                case "Player82": retCard = SortPlayerCard[7, 1]; break;
                case "Player92": retCard = SortPlayerCard[8, 1]; break;

                case "Comm1": retCard = SortCommCard[0]; break;
                case "Comm2": retCard = SortCommCard[1]; break;
                case "Comm3": retCard = SortCommCard[2]; break;
                case "Comm4": retCard = SortCommCard[3]; break;
                case "Comm5": retCard = SortCommCard[4]; break;
            }
            return retCard;
        }


        // 카드값 매핑 override --------------------------------------------------------------------------------
        public void CardMapping(Label mapplingLB)
        {
            mapplingLB.Text = "";
            for(int iCnt=0; iCnt<Card.Length; iCnt++) mapplingLB.Text = mapplingLB.Text + " " + _change(Card[iCnt]);
        }

        // 카드값 매핑 override
        public void CardMapping(TextBox mappingTx)
        {
            mappingTx.Clear();
            for (int iCnt = 0; iCnt < Card.Length; iCnt++) mappingTx.Text = mappingTx.Text + " " + _change(Card[iCnt]);
        }
            
        

    }

};



