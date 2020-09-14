using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TestWinFm
{

    public class ClsCard
    {
        /*public string[] dCard = new string[52] {"♠2","♠3","♠4","♠5","♠6","♠7","♠8","♠9","♠T","♠J","♠Q","♠K","♠A",
                                                "♥2","♥3","♥4","♥5","♥6","♥7","♥8","♥9","♥T","♥J","♥Q","♥K","♥A",
                                                "◆2","◆3","◆4","◆5","◆6","◆7","◆8","◆9","◆T","◆J","◆Q","◆K","◆A",
                                                "♣2","♣3","♣4","♣5","♣6","♣7","♣8","♣9","♣T","♣J","♣Q","♣K","♣A"}; */
        public string[] dCard = new string[52] {"S2","S3","S4","S5","S6","S7","S8","S9","ST","SJ","SQ","SK","SA",
                                                "H2","H3","H4","H5","H6","H7","H8","H9","HT","HJ","HQ","HK","HA",
                                                "D2","D3","D4","D5","D6","D7","D8","D9","DT","DJ","DQ","DK","DA",
                                                "C2","C3","C4","C5","C6","C7","C8","C9","CT","CJ","CQ","CK","CA"};
        //public string[,] gCard = new string[23, 2];  // 딜러카드(dCard)로부터 총23장으로 게임진행, Index0(무늬), Index1(숫자)
        public string[,] pCard = new string[ 9, 4];  // 플레이어(최대9명), 
                                                     // Index(0)카드내용 커뮤니티카드5장 + 핸드카드2장
                                                     // Index(1)카드내용 무늬만따로7개
                                                     // Index(2)카드내용 숫자만따로7개
                                                     // Index(3)카드메이드 결과
        

        // 게임카드 중 특정순서의 값 불러오기
        private string _GetgCard(int gCardNum)
        {
            //return gCard[gCardNum - 1, 0] + gCard[gCardNum - 1, 1];
        }
        // 게임카드 중 특정순서의 값 넣기
        private void _SetgCard(int gCardNum, string strTemp)
        {
            //gCard[gCardNum - 1, 0] = strTemp.Substring(0, 1);
            //gCard[gCardNum - 1, 1] = strTemp.Substring(1, 1);
        }
        // 문자열 카드그림 치환
        private string _Replace(string StrTemp)
        {
            string retTemp = "";
            retTemp = StrTemp.Replace("S", "♠");
            retTemp = retTemp.Replace("H", "♥");
            retTemp = retTemp.Replace("D", "◆");
            retTemp = retTemp.Replace("C", "♣");
            retTemp = retTemp.Replace("T", "10");
            return retTemp;
        }

        //프레이어카드 클리어
        private void Clear()
        {
            for(int iCnt=0; iCnt<=8; iCnt++)
                for(int jCnt = 0; jCnt <= 3; jCnt++)
                    pCard[iCnt, jCnt] = "";
        }

        // 딜러카드 섞기 > 게임카드로 18장+5장=23장 복제(무늬와 숫자나누어서..)
        public void Suff()
        {
            string StrTemp = "";
               int intTemp = 0;
            Random myRandom = new Random();

            Clear();  //플레이어카드 클리어

            // 총52개카드 섞기 > 딜러카드 만들후 > 플레이어카드 만들기
            for (int iCnt = 0; iCnt <= dCard.Length - 1; iCnt++)
            {
                intTemp = myRandom.Next(iCnt, dCard.Length - 1);
                StrTemp = dCard[iCnt];
                dCard[iCnt] = dCard[intTemp];
                dCard[intTemp] = StrTemp;
            }
            //for (int iCnt = 0; iCnt <= 22; iCnt++) _SetgCard(iCnt + 1, dCard[iCnt]);

            // 플레이어카드 만들기 - 베이스(커뮤니티)카드5장 + 핸드카드2장
            StrTemp = dCard[0] + dCard[1] + dCard[2] + dCard[3] + dCard[4];
            pCard[0, 0] = StrTemp + dCard[5]  + dCard[6]; 
            pCard[1, 0] = StrTemp + dCard[7]  + dCard[8];
            pCard[2, 0] = StrTemp + dCard[9]  + dCard[10];
            pCard[3, 0] = StrTemp + dCard[11] + dCard[12];
            pCard[4, 0] = StrTemp + dCard[13] + dCard[14];
            pCard[5, 0] = StrTemp + dCard[15] + dCard[16];
            pCard[6, 0] = StrTemp + dCard[17] + dCard[18];
            pCard[7, 0] = StrTemp + dCard[19] + dCard[20];
            pCard[8, 0] = StrTemp + dCard[21] + dCard[22];
            // 플레이어카드 만들기 - 무늬만 저장
            StrTemp = dCard[0].Substring(0, 1) + dCard[1].Substring(0, 1) + dCard[2].Substring(0, 1) + dCard[3].Substring(0, 1) + dCard[4].Substring(0, 1);
            pCard[0, 1] = StrTemp + dCard[5].Substring(0, 1) + dCard[6].Substring(0, 1);
            pCard[1, 1] = StrTemp + dCard[7].Substring(0, 1) + dCard[8].Substring(0, 1);
            pCard[2, 1] = StrTemp + dCard[9].Substring(0, 1) + dCard[10].Substring(0, 1);
            pCard[3, 1] = StrTemp + dCard[11].Substring(0, 1) + dCard[12].Substring(0, 1);
            pCard[4, 1] = StrTemp + dCard[13].Substring(0, 1) + dCard[14].Substring(0, 1);
            pCard[5, 1] = StrTemp + dCard[15].Substring(0, 1) + dCard[16].Substring(0, 1);
            pCard[6, 1] = StrTemp + dCard[17].Substring(0, 1) + dCard[18].Substring(0, 1);
            pCard[7, 1] = StrTemp + dCard[19].Substring(0, 1) + dCard[20].Substring(0, 1);
            pCard[8, 1] = StrTemp + dCard[21].Substring(0, 1) + dCard[22].Substring(0, 1);
            // 플레이어카드 만들기 - 숫자만 저장
            StrTemp = dCard[0].Substring(1, 1) + dCard[1].Substring(1, 1) + dCard[2].Substring(1, 1) + dCard[3].Substring(1, 1) + dCard[4].Substring(1, 1);
            pCard[0, 2] = StrTemp + dCard[5].Substring(1, 1) + dCard[6].Substring(1, 1);
            pCard[1, 2] = StrTemp + dCard[7].Substring(1, 1) + dCard[8].Substring(1, 1);
            pCard[2, 2] = StrTemp + dCard[9].Substring(1, 1) + dCard[10].Substring(1, 1);
            pCard[3, 2] = StrTemp + dCard[11].Substring(1, 1) + dCard[12].Substring(1, 1);
            pCard[4, 2] = StrTemp + dCard[13].Substring(1, 1) + dCard[14].Substring(1, 1);
            pCard[5, 2] = StrTemp + dCard[15].Substring(1, 1) + dCard[16].Substring(1, 1);
            pCard[6, 2] = StrTemp + dCard[17].Substring(1, 1) + dCard[18].Substring(1, 1);
            pCard[7, 2] = StrTemp + dCard[19].Substring(1, 1) + dCard[20].Substring(1, 1);
            pCard[8, 2] = StrTemp + dCard[21].Substring(1, 1) + dCard[22].Substring(1, 1);
        }


        // 플레이어카드 족보계산
        public void PlayerCal(int PlayerNum)  //특정플레이어카드 족보계산
        {
            int NumofPlayer = PlayerNum - 1;
            //int CheckCardPic = 0;   // Count of (♠)(♥)(◆)(♣)
            int[] CheckCardNum = new int[13];  //Index0(A), Index1(2), Index2(3), Index3(4), Index4(5), Index5(6), Index6(7), Index7(8), Index8(9), Index9(10), 
                                               //Index10(J),Index11(Q),Index12(K)                    

            // 플래쉬 체크                                               
            if (pCard[NumofPlayer, 1].Replace("S", "").Length <= 2) pCard[NumofPlayer, 3] = "SF/";
            if (pCard[NumofPlayer, 1].Replace("H", "").Length <= 2) pCard[NumofPlayer, 3] = "HF/";
            if (pCard[NumofPlayer, 1].Replace("D", "").Length <= 2) pCard[NumofPlayer, 3] = "DF/";
            if (pCard[NumofPlayer, 1].Replace("C", "").Length <= 2) pCard[NumofPlayer, 3] = "CF/";           
            
            // 원페어,투페어,트리플,포커,풀하우스 체크하기 위한 전처리
            for (int iCnt = 0; iCnt <= 6; iCnt++)
            {
                string CharTemp = pCard[NumofPlayer, 2].Substring(iCnt, 1);
                switch (CharTemp) {
                    case "A": CheckCardNum[0]++; break;  // 숫자A가 몇개있나
                    case "2": CheckCardNum[1]++; break;  // 숫자2가 몇개있나
                    case "3": CheckCardNum[2]++; break;  // 숫자3가 몇개있나
                    case "4": CheckCardNum[3]++; break;  // 숫자4가 몇개있나
                    case "5": CheckCardNum[4]++; break;  // 숫자5가 몇개있나
                    case "6": CheckCardNum[5]++; break;  // 숫자6가 몇개있나
                    case "7": CheckCardNum[6]++; break;  // 숫자7가 몇개있나
                    case "8": CheckCardNum[7]++; break;  // 숫자8가 몇개있나
                    case "9": CheckCardNum[8]++; break;  // 숫자9가 몇개있나
                    case "T": CheckCardNum[9]++; break;  // 숫자10T가 몇개있나
                    case "J": CheckCardNum[10]++; break; // 숫자11J가 몇개있나
                    case "Q": CheckCardNum[11]++; break; // 숫자12Q가 몇개있나
                    case "K": CheckCardNum[12]++; break; // 숫자13K가 몇개있나                    
                }
            }
            
            // 원페어,트리플,포커 체크
            for (int iCnt = 0; iCnt <= 12; iCnt++)
            {
                if (CheckCardNum[iCnt] == 4) pCard[NumofPlayer, 3] = pCard[NumofPlayer, 3] + (iCnt + 1).ToString() + "F/";
                if (CheckCardNum[iCnt] == 3) pCard[NumofPlayer, 3] = pCard[NumofPlayer, 3] + (iCnt + 1).ToString() + "T/";
                if (CheckCardNum[iCnt] == 2) pCard[NumofPlayer, 3] = pCard[NumofPlayer, 3] + (iCnt + 1).ToString() + "O/";
            }
            
            
        }

        


        // 핸드카드 나누어 주기 (플레이어별로 2장씩)
        public void DellingHand()
        { }

        // 플럽(커뮤니티)카드 바닥에 깔기 (최초 3장)
        public void DellingFlop()
        { }

        // 턴(커뮤니티)카드 바닥에 깔기 (최초3장 + 1장)
        public void DellingTurn()
        { }

        // 리버(커뮤니티)카드 바닥에 깔기 (최초3장 +1장 + 1장 = 총5장)
        public void DellingRiver()
        { }


        // 카드매핑 override, 커뮤니티카드/턴카드/리버카드 매핑
        public void MappingTx(TextBox MappingTx, string MappingMethod)
        {
            switch (MappingMethod)
            {
                case "CARD": MappingTx.Text = ""; for (int iCnt = 0; iCnt <= dCard.Length - 1; iCnt++) MappingTx.Text = MappingTx.Text + " " + dCard[iCnt]; break;
                case "GAME": MappingTx.Text = ""; for (int iCnt = 0; iCnt <= 5; iCnt++) MappingTx.Text = MappingTx.Text + " " + dCard[iCnt]; break;

                case "FLOP": MappingTx.Text = _Replace(dCard[0]) + " " + _Replace(dCard[1]) + " " + _Replace(dCard[2]); break;  // 딜러카드 1,2,3번째 3장
                case "TURN": MappingTx.Text = MappingTx.Text + " " + _Replace(dCard[3]); break;  // 딜러카드 4번째
                case "RIVR": MappingTx.Text = MappingTx.Text + " " + _Replace(dCard[4]); break;  // 딜러카드 5번째
            }
        }

        // 카드매핑 override, 플레이어카드 매핑
        public void MappingTx(TextBox MappingTx, int PlayerTurn)
        {
            MappingTx.Text = _Replace(pCard[PlayerTurn - 1, 0].Substring(10, 4));
        }

        // 카드매핑 override, 커뮤니티카드/턴카드/리버카드 매핑
        public void MappingLB(Label MappingLB, string MappingMethod)
        {
            switch (MappingMethod)
            {
                case "FLOP": MappingLB.Text = _Replace(dCard[0]) + " " + _Replace(dCard[1]) + " " + _Replace(dCard[2]); break;  // 딜러카드 1,2,3번째 3장
                case "TURN": MappingLB.Text = MappingLB.Text + " " + _Replace(dCard[3]); break;  // 딜러카드 4번째
                case "RIVR": MappingLB.Text = MappingLB.Text + " " + _Replace(dCard[4]); break;  // 딜러카드 5번째
            }
        }

        // 카드매핑 override, 플레이어카드 매핑
        public void MappingLB(Label MappingLB, int PlayerTurn)
        {
            MappingLB.Text = _Replace(pCard[PlayerTurn - 1, 0].Substring(10, 4));
        }
    }


};


