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
        private String[]  CommCard   = new String[5];        // 커뮤니티카드 [5장] 
        private String[,] PlayerCard = new String[9, 2];  // 플레이어(1~9)카드 [카드2장 각각의 코드값]
        private String[,] PlayerCardRank = new String[9, 1];  // 플레이어(1~9)순위 [첫번째 소팅된카드코드값 저장, 두번째 카드랭크값 저장 이후 다시생각]
        


        // 카드클리어 (커뮤니티,플레이어,랭크-저장소) ----------------------------------------------------------
        public void _Clear()
        {
            for (int iCnt=0; iCnt<9; iCnt++)
            {
                if (iCnt < 5) CommCard[iCnt] = "";  // 커뮤니티카드 저장소 Clear
                PlayerCard[iCnt, 0] = "";           // 플레이어카드 1/2장  Clear 
                PlayerCard[iCnt, 1] = "";           // 플레이어카드 2/2장  Clear
                PlayerCardRank[iCnt, 0] = "";       // 플레이어카드결과(족보내용) Clear
            }                
        }

        // 카드값(코드)변환 (카드코드 > 카드그림숫자)
        public string _ChangeToPic(string strParam)
        {
            string retParam = "";
            retParam = strParam.Replace("S", "♠");  // 파라메터가 (한개)카드코드 또는 (여러개)카드코드 처리 가능함
            retParam = retParam.Replace("H", "♥");
            retParam = retParam.Replace("D", "◆");
            retParam = retParam.Replace("C", "♣");
            retParam = retParam.Replace("T", "10");
            return retParam;

        }

        // 카드값(코드)변환 (카드코드 > 카드숫자)
        public int _ChangeToNum(string strParam)
        {
            if (strParam.Length == 2) strParam = strParam.Substring(1, 1);
            switch (strParam)
            {
                case "A": strParam.Replace("A", "14"); break;
                case "K": strParam.Replace("K", "13"); break;
                case "Q": strParam.Replace("Q", "12"); break;
                case "J": strParam.Replace("J", "11"); break;
                case "T": strParam.Replace("T", "10"); break;
            }

            return Int32.Parse(strParam);
        }




        // 카드섞기 (섞은 이후 call distribution )  -------------------------------------------------------------
        public void Suff()
        {
            string strTemp = "";
            int intTemp = 0;
            Random myRandom = new Random();

            _Clear();  //카드관련 저장소 Clear

            for (int iCnt=0; iCnt<Card.Length; iCnt++)
            {
                intTemp = myRandom.Next(iCnt, Card.Length - 1);   // 순서~최대순서 사이에 랜덤값 발생
                strTemp = Card[iCnt];        // (첫번째~)저장소 카드코드 임시저장
                Card[iCnt] = Card[intTemp];  // (첫번째~)저장소에 (랜덤값)저장소 카드코드 저장
                Card[intTemp] = strTemp;     // (랜던값)저장소에 임시저장된 카드코드 저장
            }

            Distribution();
        }

        
        // 카드분배 > 일괄처리 ----------------------------------------------------------------------------------
        public void Distribution()
        {
            // 플레이어카드 (1번~9번플레이어) 배분
            for (int iCnt = 1; iCnt < 10; iCnt++)
            {
                int intTemp = (iCnt - 1) * 2;
                PlayerCard[iCnt - 1, 0] = Card[intTemp];
                PlayerCard[iCnt - 1, 1] = Card[intTemp + 1];
            }

            // 커뮤니티카드 - 플럽,턴,리버 배분
            CommCard[0] = Card[18];
            CommCard[1] = Card[19];
            CommCard[2] = Card[20];
            CommCard[3] = Card[21];
            CommCard[4] = Card[22];
        }




        // 카드값(코드) 반환(총2장카드코드) > intParam = 플레이어번호 -------------------------------------------
        public string PlayerHand(int iPlayerNum)
        {
            return PlayerCard[iPlayerNum - 1, 0]+ PlayerCard[iPlayerNum - 1, 1]; 
        }
        // 카드값(코드) 반환(1장카드코드) > inParam 플레이어번호, iPlayerCardNum 플레이어 카드순서번호
        public string PlayerHand(int iPlayerNum, int iPlayerCardNum)
        {
            return PlayerCard[iPlayerNum - 1, iPlayerCardNum - 1];
        }
        // 카드값(실질숫자값) 반환(1장카드숫자값) > intParam 플레이어번호, iPlayerCardNum 플레이어 카드순서번호
        public int PlayerHandValue(int iPlayerNum, int iPlayerCardNum)
        {
            return _ChangeToNum(PlayerCard[iPlayerNum - 1, iPlayerCardNum - 1]);
        }
     


        // 카드값(코드) 반환 > 커뮤니티(플럽 #1/3 3장) -----------------------------------------------------------
        public string CommunityFlop()
        {
            return CommCard[0] + CommCard[1] + CommCard[2];
        }
        // 카드값(코드) 반환 > 커뮤니티(플럽순서번호에 따른 코드값 1장)
        public string CommunityFlop(int iCommunityCardNum)
        {
            return CommCard[iCommunityCardNum - 1];
        }
        // 카드값(실질숫자값) 반환
        public int CommunityFlopValue(int iCommunityCardNum)
        {
            return _ChangeToNum(CommCard[iCommunityCardNum - 1]);
        }

        // 카드값(코드) 반환 > 커뮤니티(턴 #2/3 1장)
        public string CommunityTurn()
        {
            return CommCard[3];
        }
        // 카드값(실질숫자값) 반환
        public int CommunityTurnValue()
        {
            return _ChangeToNum(CommCard[3]);
        }

        // 카드값(코드) 반환 > 커뮤니티(리버 #3/3 1장)
        public string CommunityRiver()
        {
            return CommCard[4];
        }
        // 카드값(실질숫자값) 반환
        public int CommunityRiverValue()
        {
            return _ChangeToNum(CommCard[4]);
        }
        

        // 카드값(코드) 반환 > 내보내기 --------------------------------------------------------------------------
        public string GetCard(string strParam)
        {
            string retCard = "";
            switch(strParam)
            {
                case "Player1": retCard = PlayerCard[0, 0] + PlayerCard[0, 1]; break;
                case "Player2": retCard = PlayerCard[1, 0] + PlayerCard[1, 1]; break;
                case "Player3": retCard = PlayerCard[2, 0] + PlayerCard[2, 1]; break;
                case "Player4": retCard = PlayerCard[3, 0] + PlayerCard[3, 1]; break;
                case "Player5": retCard = PlayerCard[4, 0] + PlayerCard[4, 1]; break;
                case "Player6": retCard = PlayerCard[5, 0] + PlayerCard[5, 1]; break;
                case "Player7": retCard = PlayerCard[6, 0] + PlayerCard[6, 1]; break;
                case "Player8": retCard = PlayerCard[7, 0] + PlayerCard[7, 1]; break;
                case "Player9": retCard = PlayerCard[8, 0] + PlayerCard[8, 1]; break;

                case "Player11": retCard = PlayerCard[0, 0]; break;
                case "Player21": retCard = PlayerCard[1, 0]; break;
                case "Player31": retCard = PlayerCard[2, 0]; break;
                case "Player41": retCard = PlayerCard[3, 0]; break;
                case "Player51": retCard = PlayerCard[4, 0]; break;
                case "Player61": retCard = PlayerCard[5, 0]; break;
                case "Player71": retCard = PlayerCard[6, 0]; break;
                case "Player81": retCard = PlayerCard[7, 0]; break;
                case "Player91": retCard = PlayerCard[8, 0]; break;

                case "Player12": retCard = PlayerCard[0, 1]; break;
                case "Player22": retCard = PlayerCard[1, 1]; break;
                case "Player32": retCard = PlayerCard[2, 1]; break;
                case "Player42": retCard = PlayerCard[3, 1]; break;
                case "Player52": retCard = PlayerCard[4, 1]; break;
                case "Player62": retCard = PlayerCard[5, 1]; break;
                case "Player72": retCard = PlayerCard[6, 1]; break;
                case "Player82": retCard = PlayerCard[7, 1]; break;
                case "Player92": retCard = PlayerCard[8, 1]; break;

                case "Comm1": retCard = CommCard[0]; break;
                case "Comm2": retCard = CommCard[1]; break;
                case "Comm3": retCard = CommCard[2]; break;
                case "Comm4": retCard = CommCard[3]; break;
                case "Comm5": retCard = CommCard[4]; break;
            }
            return retCard;
        }






        // 카드값 매핑 overload ----------------------------------------------------------------------------------
        public void CardMapping(Label mapplingLB)
        {
            mapplingLB.Text = "";
            for(int iCnt=0; iCnt<Card.Length; iCnt++) mapplingLB.Text = mapplingLB.Text + " " + _ChangeToPic(Card[iCnt]);
        }

        // 카드값 매핑 overload
        public void CardMapping(TextBox mappingTx)
        {
            mappingTx.Clear();
            for (int iCnt = 0; iCnt < Card.Length; iCnt++) mappingTx.Text = mappingTx.Text + " " + _ChangeToPic(Card[iCnt]);
        }
            
        

    }

};



