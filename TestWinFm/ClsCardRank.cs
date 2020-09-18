using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinFm
{


    public class ClsCardRank
    {

        private String [,] RankInfo = new string [300, 2]; 

        /*/ ClsCardRank 클래스 생성자 (카드랭크 세팅)
        public ClsCardRank()
        { 
            RankInfo[0, 0] = "AKQJT";
            RankInfo[1, 0] = "KQJT9";
            RankInfo[2, 0] = "QJT98";
            RankInfo[3, 0] = "JT987";
            RankInfo[4, 0] = "T9876";
            RankInfo[5, 0] = "98765";
            RankInfo[6, 0] = "87654";
            RankInfo[7, 0] = "76543";
            RankInfo[8, 0] = "65432";
            RankInfo[9, 0] = "5432A";

            RankInfo[10, 0] = "AAAA";
            RankInfo[11, 0] = "KKKK";
            RankInfo[12, 0] = "QQQQ";
            RankInfo[13, 0] = "TTTT";
            RankInfo[14, 0] = "9999";
            RankInfo[15, 0] = "8888";
            RankInfo[16, 0] = "7777";
            RankInfo[17, 0] = "6666";
            RankInfo[18, 0] = "5555";
            RankInfo[19, 0] = "4444";

            RankInfo[20, 0] = "3333";
            RankInfo[21, 0] = "2222";

            RankInfo[22, 0] = "";
            RankInfo[23, 0] = "";
            RankInfo[24, 0] = "";
            RankInfo[25, 0] = "";
            RankInfo[26, 0] = "";
            RankInfo[27, 0] = "";
            RankInfo[28, 0] = "";
            RankInfo[29, 0] = "";

            RankInfo[30, 0] = "";
            RankInfo[31, 0] = "";
            RankInfo[32, 0] = "";
            RankInfo[33, 0] = "";
            RankInfo[34, 0] = "";
            RankInfo[35, 0] = "";
            RankInfo[36, 0] = "";
            RankInfo[37, 0] = "";
            RankInfo[38, 0] = "";
            RankInfo[39, 0] = "";

            RankInfo[40, 0] = "";
            RankInfo[41, 0] = "";
            RankInfo[42, 0] = "";
            RankInfo[43, 0] = "";
            RankInfo[44, 0] = "";
            RankInfo[45, 0] = "";
            RankInfo[46, 0] = "";
            RankInfo[47, 0] = "";
            RankInfo[48, 0] = "";
            RankInfo[49, 0] = "";

            RankInfo[50, 0] = "";
            RankInfo[51, 0] = "";
            RankInfo[52, 0] = "";
            RankInfo[53, 0] = "";
            RankInfo[54, 0] = "";
            RankInfo[55, 0] = "";
            RankInfo[56, 0] = "";
            RankInfo[57, 0] = "";
            RankInfo[58, 0] = "";
            RankInfo[59, 0] = "";

            RankInfo[60, 0] = "";
            RankInfo[61, 0] = "";
            RankInfo[62, 0] = "";
            RankInfo[63, 0] = "";
            RankInfo[64, 0] = "";
            RankInfo[65, 0] = "";
            RankInfo[66, 0] = "";
            RankInfo[67, 0] = "";
            RankInfo[68, 0] = "";
            RankInfo[69, 0] = "";

            RankInfo[70, 0] = "";
            RankInfo[71, 0] = "";
            RankInfo[72, 0] = "";
            RankInfo[73, 0] = "";
            RankInfo[74, 0] = "";
            RankInfo[75, 0] = "";
            RankInfo[76, 0] = "";
            RankInfo[77, 0] = "";
            RankInfo[78, 0] = "";
            RankInfo[79, 0] = "";

            RankInfo[80, 0] = "";
            RankInfo[81, 0] = "";
            RankInfo[82, 0] = "";
            RankInfo[83, 0] = "";
            RankInfo[84, 0] = "";
            RankInfo[85, 0] = "";
            RankInfo[86, 0] = "";
            RankInfo[87, 0] = "";
            RankInfo[88, 0] = "";
            RankInfo[89, 0] = "";

            RankInfo[90, 0] = "";
            RankInfo[91, 0] = "";
            RankInfo[92, 0] = "";
            RankInfo[93, 0] = "";
            RankInfo[94, 0] = "";
            RankInfo[95, 0] = "";
            RankInfo[96, 0] = "";
            RankInfo[97, 0] = "";
            RankInfo[98, 0] = "";
            RankInfo[99, 0] = "";

            RankInfo[100, 0] = "";
            RankInfo[101, 0] = "";
            RankInfo[102, 0] = "";
            RankInfo[103, 0] = "";
            RankInfo[104, 0] = "";
            RankInfo[105, 0] = "";
            RankInfo[106, 0] = "";
            RankInfo[107, 0] = "";
            RankInfo[108, 0] = "";
            RankInfo[109, 0] = "";

            RankInfo[110, 0] = "";
            RankInfo[111, 0] = "";
            RankInfo[112, 0] = "";
            RankInfo[113, 0] = "";
            RankInfo[114, 0] = "";
            RankInfo[115, 0] = "";
            RankInfo[116, 0] = "";
            RankInfo[117, 0] = "";
            RankInfo[118, 0] = "";
            RankInfo[119, 0] = "";

            RankInfo[120, 0] = "";
            RankInfo[121, 0] = "";
            RankInfo[122, 0] = "";
            RankInfo[123, 0] = "";
            RankInfo[124, 0] = "";
            RankInfo[125, 0] = "";
            RankInfo[126, 0] = "";
            RankInfo[127, 0] = "";
            RankInfo[128, 0] = "";
            RankInfo[129, 0] = "";

            RankInfo[130, 0] = "";
            RankInfo[131, 0] = "";
            RankInfo[132, 0] = "";
            RankInfo[133, 0] = "";
            RankInfo[134, 0] = "";
            RankInfo[135, 0] = "";
            RankInfo[136, 0] = "";
            RankInfo[137, 0] = "";
            RankInfo[138, 0] = "";
            RankInfo[139, 0] = "";

            RankInfo[140, 0] = "";
            RankInfo[141, 0] = "";
            RankInfo[142, 0] = "";
            RankInfo[143, 0] = "";
            RankInfo[144, 0] = "";
            RankInfo[145, 0] = "";
            RankInfo[146, 0] = "";
            RankInfo[147, 0] = "";
            RankInfo[148, 0] = "";
            RankInfo[149, 0] = "";

            RankInfo[150, 0] = "";
            RankInfo[151, 0] = "";
            RankInfo[152, 0] = "";
            RankInfo[153, 0] = "";
            RankInfo[154, 0] = "";
            RankInfo[155, 0] = "";
            RankInfo[156, 0] = "";
            RankInfo[157, 0] = "";
            RankInfo[158, 0] = "";
            RankInfo[159, 0] = "";

            RankInfo[160, 0] = "";
            RankInfo[161, 0] = "";
            RankInfo[162, 0] = "";
            RankInfo[163, 0] = "";
            RankInfo[164, 0] = "";
            RankInfo[165, 0] = "";
            RankInfo[166, 0] = "";
            RankInfo[167, 0] = "";
            RankInfo[168, 0] = "";
            RankInfo[169, 0] = "";

            RankInfo[170, 0] = "";
            RankInfo[171, 0] = "";
            RankInfo[172, 0] = "";
            RankInfo[173, 0] = "";
            RankInfo[174, 0] = "";
            RankInfo[175, 0] = "";
            RankInfo[176, 0] = "";
            RankInfo[177, 0] = "";
            RankInfo[178, 0] = "";
            RankInfo[179, 0] = "";

            RankInfo[180, 0] = "";
            RankInfo[181, 0] = "";
            RankInfo[182, 0] = "";
            RankInfo[183, 0] = "";
            RankInfo[184, 0] = "";
            RankInfo[185, 0] = "";
            RankInfo[186, 0] = "";
            RankInfo[187, 0] = "";
            RankInfo[188, 0] = "";
            RankInfo[189, 0] = "";

            RankInfo[190, 0] = "";
            RankInfo[191, 0] = "";
            RankInfo[192, 0] = "";
            RankInfo[193, 0] = "";
            RankInfo[194, 0] = "";
            RankInfo[195, 0] = "";
            RankInfo[196, 0] = "";
            RankInfo[197, 0] = "";
            RankInfo[198, 0] = "";
            RankInfo[199, 0] = "";

            RankInfo[200, 0] = "";
            RankInfo[201, 0] = "";
            RankInfo[202, 0] = "";
            RankInfo[203, 0] = "";
            RankInfo[204, 0] = "";
            RankInfo[205, 0] = "";
            RankInfo[206, 0] = "";
            RankInfo[207, 0] = "";
            RankInfo[208, 0] = "";
            RankInfo[209, 0] = "";

            RankInfo[210, 0] = "";
            RankInfo[211, 0] = "";
            RankInfo[212, 0] = "";
            RankInfo[213, 0] = "";
            RankInfo[214, 0] = "";
            RankInfo[215, 0] = "";
            RankInfo[216, 0] = "";
            RankInfo[217, 0] = "";
            RankInfo[218, 0] = "";
            RankInfo[219, 0] = "";

            RankInfo[220, 0] = "";
            RankInfo[221, 0] = "";
            RankInfo[222, 0] = "";
            RankInfo[223, 0] = "";
            RankInfo[224, 0] = "";
            RankInfo[225, 0] = "";
            RankInfo[226, 0] = "";
            RankInfo[227, 0] = "";
            RankInfo[228, 0] = "";
            RankInfo[229, 0] = "";

            RankInfo[230, 0] = "";
            RankInfo[231, 0] = "";
            RankInfo[232, 0] = "";
            RankInfo[233, 0] = "";
            RankInfo[234, 0] = "";
            RankInfo[235, 0] = "";
            RankInfo[236, 0] = "";
            RankInfo[237, 0] = "";
            RankInfo[238, 0] = "";
            RankInfo[239, 0] = "";

            RankInfo[240, 0] = "";
            RankInfo[241, 0] = "";
            RankInfo[242, 0] = "";
            RankInfo[243, 0] = "";
            RankInfo[244, 0] = "";
            RankInfo[245, 0] = "";
            RankInfo[246, 0] = "";
            RankInfo[247, 0] = "";
            RankInfo[248, 0] = "";
            RankInfo[249, 0] = "";

            RankInfo[250, 0] = "";
            RankInfo[251, 0] = "";
            RankInfo[252, 0] = "";
            RankInfo[253, 0] = "";
            RankInfo[254, 0] = "";
            RankInfo[255, 0] = "";
            RankInfo[256, 0] = "";
            RankInfo[257, 0] = "";
            RankInfo[258, 0] = "";
            RankInfo[259, 0] = "";

            RankInfo[260, 0] = "";
            RankInfo[261, 0] = "";
            RankInfo[262, 0] = "";
            RankInfo[263, 0] = "";
            RankInfo[264, 0] = "";
            RankInfo[265, 0] = "";
            RankInfo[266, 0] = "";
            RankInfo[267, 0] = "";
            RankInfo[268, 0] = "";
            RankInfo[269, 0] = "";

            RankInfo[270, 0] = "";
            RankInfo[271, 0] = "";
            RankInfo[272, 0] = "";
            RankInfo[273, 0] = "";
            RankInfo[274, 0] = "";
            RankInfo[275, 0] = "";
            RankInfo[276, 0] = "";
            RankInfo[277, 0] = "";
            RankInfo[278, 0] = "";
            RankInfo[279, 0] = "";

            RankInfo[280, 0] = "";
            RankInfo[281, 0] = "";
            RankInfo[282, 0] = "";
            RankInfo[283, 0] = "";
            RankInfo[284, 0] = "";
            RankInfo[285, 0] = "";
            RankInfo[286, 0] = "";
            RankInfo[287, 0] = "";
            RankInfo[288, 0] = "";
            RankInfo[289, 0] = "";

            RankInfo[290, 0] = "";
            RankInfo[291, 0] = "";
            RankInfo[292, 0] = "";
            RankInfo[293, 0] = "";
            RankInfo[294, 0] = "";
            RankInfo[295, 0] = "";
            RankInfo[296, 0] = "";
            RankInfo[297, 0] = "";
            RankInfo[298, 0] = "";
            RankInfo[299, 0] = "";
        }
        */
        // 카드랭크 체크하여 리턴
        public string check()
        {
            return "";
        }

        // 카드값 정렬
        public string _sort(String strParam)
        {
            // 전달받은 카드값(코드) 배열에 저장
            int[] SortArry = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            for (int iCnt = 0; iCnt < strParam.Length; iCnt++) SortArry[iCnt] = _change(strParam.Substring(iCnt));  // 카드 코드값>숫자값으로 치환
            
            // 카드값(코드)갯수 만큼 루프 돌면서 정렬
            for (int iLoop = 0; iLoop < strParam.Length; iLoop++)
            {
                for (int iCnt=0; iCnt < strParam.Length; iCnt++)
                {
                    int intTemp = 0;
                    if (SortArry[iCnt] < SortArry[iCnt + 1])  // 내림차순 정렬
                    {
                        intTemp = SortArry[iCnt];
                        SortArry[iCnt] = SortArry[iCnt + 1];
                        SortArry[iCnt] = intTemp;
                    }
                }                
            }

            // 정렬된 카드값(숫자)-배열 코드로 변환하여 리턴
            String retParam = "";
            for (int iCnt = 0; iCnt < strParam.Length; iCnt++) retParam = retParam + _change(SortArry[iCnt]);
            return retParam;
        }

        // 카드코드 > 숫자 치환 overload
        private int _change(string strParam)
        {
            switch(strParam)
            {
                case "A": strParam.Replace("A", "14"); break;
                case "K": strParam.Replace("K", "13"); break;
                case "Q": strParam.Replace("Q", "12"); break;
                case "J": strParam.Replace("J", "11"); break;
                case "T": strParam.Replace("T", "10"); break;                
            }            
            
            return Int32.Parse(strParam);
        }

        // 카드숫자 > 코드 치환 overload
        private string _change(int intParam)
        {
            String retStr = "";

            switch (intParam)
            {
                case 14: retStr = "A"; break;
                case 13: retStr = "K"; break;
                case 12: retStr = "Q"; break;
                case 11: retStr = "J"; break;
                case 10: retStr = "T"; break;
            }

            return retStr;
        }

    }


}
