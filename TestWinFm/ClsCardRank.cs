using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinFm
{


    public class ClsCardRank
    {
        const int RANKNUM = 301;

        private String [,] RankInfo = new string [RANKNUM, 2];

        // ClsCardRank 클래스 생성자 (카드랭크 세팅)
        public ClsCardRank()
        {
            RankInfo[0, 0] = "AKQJT"; RankInfo[0, 1] = "로얄스트레이트플레쉬(AKQJT)";
            RankInfo[1, 0] = "KQJT9"; RankInfo[1, 1] = "스트레이트플레쉬(KQJT9)";
            RankInfo[2, 0] = "QJT98"; RankInfo[2, 1] = "스트레이트플레쉬(QJT98)";
            RankInfo[3, 0] = "JT987"; RankInfo[3, 1] = "스트레이트플레쉬(JT987)";
            RankInfo[4, 0] = "T9876"; RankInfo[4, 1] = "스트레이트플레쉬(T9876)";
            RankInfo[5, 0] = "98765"; RankInfo[5, 1] = "스트레이트플레쉬(98765)";
            RankInfo[6, 0] = "87654"; RankInfo[6, 1] = "스트레이트플레쉬(87654)";
            RankInfo[7, 0] = "76543"; RankInfo[7, 1] = "스트레이트플레쉬(76543)";
            RankInfo[8, 0] = "65432"; RankInfo[8, 1] = "스트레이트플레쉬(65432)";
            RankInfo[9, 0] = "5432A"; RankInfo[9, 1] = "스트레이트플레쉬(5432A)";
            RankInfo[10, 0] = "AAAA"; RankInfo[10, 1] = "포카드(AAAA)";
            RankInfo[11, 0] = "KKKK"; RankInfo[11, 1] = "포카드(KKKK)";
            RankInfo[12, 0] = "QQQQ"; RankInfo[12, 1] = "포카드(QQQQ)";
            RankInfo[13, 0] = "JJJJ"; RankInfo[13, 1] = "포카드(JJJJ)";
            RankInfo[14, 0] = "TTTT"; RankInfo[14, 1] = "포카드(TTTT)";
            RankInfo[15, 0] = "9999"; RankInfo[15, 1] = "포카드(9999)";
            RankInfo[16, 0] = "8888"; RankInfo[16, 1] = "포카드(8888)";
            RankInfo[17, 0] = "7777"; RankInfo[17, 1] = "포카드(7777)";
            RankInfo[18, 0] = "6666"; RankInfo[18, 1] = "포카드(6666)";
            RankInfo[19, 0] = "5555"; RankInfo[19, 1] = "포카드(5555)";
            RankInfo[20, 0] = "4444"; RankInfo[20, 1] = "포카드(4444)";
            RankInfo[21, 0] = "3333"; RankInfo[21, 1] = "포카드(3333)";
            RankInfo[22, 0] = "2222"; RankInfo[22, 1] = "포카드(2222)";
            RankInfo[23, 0] = "AAAKK"; RankInfo[23, 1] = "풀하우스(AAAKK)";
            RankInfo[24, 0] = "AAAQQ"; RankInfo[24, 1] = "풀하우스(AAAQQ)";
            RankInfo[25, 0] = "AAAJJ"; RankInfo[25, 1] = "풀하우스(AAAJJ)";
            RankInfo[26, 0] = "AAATT"; RankInfo[26, 1] = "풀하우스(AAATT)";
            RankInfo[27, 0] = "AAA99"; RankInfo[27, 1] = "풀하우스(AAA99)";
            RankInfo[28, 0] = "AAA88"; RankInfo[28, 1] = "풀하우스(AAA88)";
            RankInfo[29, 0] = "AAA77"; RankInfo[29, 1] = "풀하우스(AAA77)";
            RankInfo[30, 0] = "AAA66"; RankInfo[30, 1] = "풀하우스(AAA66)";
            RankInfo[31, 0] = "AAA55"; RankInfo[31, 1] = "풀하우스(AAA55)";
            RankInfo[32, 0] = "AAA44"; RankInfo[32, 1] = "풀하우스(AAA44)";
            RankInfo[33, 0] = "AAA33"; RankInfo[33, 1] = "풀하우스(AAA33)";
            RankInfo[34, 0] = "AAA22"; RankInfo[34, 1] = "풀하우스(AAA22)";
            RankInfo[35, 0] = "KKKAA"; RankInfo[35, 1] = "풀하우스(KKKAA)";
            RankInfo[36, 0] = "KKKQQ"; RankInfo[36, 1] = "풀하우스(KKKQQ)";
            RankInfo[37, 0] = "KKKJJ"; RankInfo[37, 1] = "풀하우스(KKKJJ)";
            RankInfo[38, 0] = "KKKTT"; RankInfo[38, 1] = "풀하우스(KKKTT)";
            RankInfo[39, 0] = "KKK99"; RankInfo[39, 1] = "풀하우스(KKK99)";
            RankInfo[40, 0] = "KKK88"; RankInfo[40, 1] = "풀하우스(KKK88)";
            RankInfo[41, 0] = "KKK77"; RankInfo[41, 1] = "풀하우스(KKK77)";
            RankInfo[42, 0] = "KKK66"; RankInfo[42, 1] = "풀하우스(KKK66)";
            RankInfo[43, 0] = "KKK55"; RankInfo[43, 1] = "풀하우스(KKK55)";
            RankInfo[44, 0] = "KKK44"; RankInfo[44, 1] = "풀하우스(KKK44)";
            RankInfo[45, 0] = "KKK33"; RankInfo[45, 1] = "풀하우스(KKK33)";
            RankInfo[46, 0] = "KKK22"; RankInfo[46, 1] = "풀하우스(KKK22)";
            RankInfo[47, 0] = "QQQAA"; RankInfo[47, 1] = "풀하우스(QQQAA)";
            RankInfo[48, 0] = "QQQKK"; RankInfo[48, 1] = "풀하우스(QQQKK)";
            RankInfo[49, 0] = "QQQJJ"; RankInfo[49, 1] = "풀하우스(QQQJJ)";
            RankInfo[50, 0] = "QQQTT"; RankInfo[50, 1] = "풀하우스(QQQTT)";
            RankInfo[51, 0] = "QQQ99"; RankInfo[51, 1] = "풀하우스(QQQ99)";
            RankInfo[52, 0] = "QQQ88"; RankInfo[52, 1] = "풀하우스(QQQ88)";
            RankInfo[53, 0] = "QQQ77"; RankInfo[53, 1] = "풀하우스(QQQ77)";
            RankInfo[54, 0] = "QQQ66"; RankInfo[54, 1] = "풀하우스(QQQ66)";
            RankInfo[55, 0] = "QQQ55"; RankInfo[55, 1] = "풀하우스(QQQ55)";
            RankInfo[56, 0] = "QQQ44"; RankInfo[56, 1] = "풀하우스(QQQ44)";
            RankInfo[57, 0] = "QQQ33"; RankInfo[57, 1] = "풀하우스(QQQ33)";
            RankInfo[58, 0] = "QQQ22"; RankInfo[58, 1] = "풀하우스(QQQ22)";
            RankInfo[59, 0] = "JJJAA"; RankInfo[59, 1] = "풀하우스(JJJAA)";
            RankInfo[60, 0] = "JJJKK"; RankInfo[60, 1] = "풀하우스(JJJKK)";
            RankInfo[61, 0] = "JJJQQ"; RankInfo[61, 1] = "풀하우스(JJJQQ)";
            RankInfo[62, 0] = "JJJTT"; RankInfo[62, 1] = "풀하우스(JJJTT)";
            RankInfo[63, 0] = "JJJ99"; RankInfo[63, 1] = "풀하우스(JJJ99)";
            RankInfo[64, 0] = "JJJ88"; RankInfo[64, 1] = "풀하우스(JJJ88)";
            RankInfo[65, 0] = "JJJ77"; RankInfo[65, 1] = "풀하우스(JJJ77)";
            RankInfo[66, 0] = "JJJ66"; RankInfo[66, 1] = "풀하우스(JJJ66)";
            RankInfo[67, 0] = "JJJ55"; RankInfo[67, 1] = "풀하우스(JJJ55)";
            RankInfo[68, 0] = "JJJ44"; RankInfo[68, 1] = "풀하우스(JJJ44)";
            RankInfo[69, 0] = "JJJ33"; RankInfo[69, 1] = "풀하우스(JJJ33)";
            RankInfo[70, 0] = "JJJ22"; RankInfo[70, 1] = "풀하우스(JJJ22)";
            RankInfo[71, 0] = "TTTAA"; RankInfo[71, 1] = "풀하우스(TTTAA)";
            RankInfo[72, 0] = "TTTKK"; RankInfo[72, 1] = "풀하우스(TTTKK)";
            RankInfo[73, 0] = "TTTQQ"; RankInfo[73, 1] = "풀하우스(TTTQQ)";
            RankInfo[74, 0] = "TTTJJ"; RankInfo[74, 1] = "풀하우스(TTTJJ)";
            RankInfo[75, 0] = "TTT99"; RankInfo[75, 1] = "풀하우스(TTT99)";
            RankInfo[76, 0] = "TTT88"; RankInfo[76, 1] = "풀하우스(TTT88)";
            RankInfo[77, 0] = "TTT77"; RankInfo[77, 1] = "풀하우스(TTT77)";
            RankInfo[78, 0] = "TTT66"; RankInfo[78, 1] = "풀하우스(TTT66)";
            RankInfo[79, 0] = "TTT55"; RankInfo[79, 1] = "풀하우스(TTT55)";
            RankInfo[80, 0] = "TTT44"; RankInfo[80, 1] = "풀하우스(TTT44)";
            RankInfo[81, 0] = "TTT33"; RankInfo[81, 1] = "풀하우스(TTT33)";
            RankInfo[82, 0] = "TTT22"; RankInfo[82, 1] = "풀하우스(TTT22)";
            RankInfo[83, 0] = "999AA"; RankInfo[83, 1] = "풀하우스(999AA)";
            RankInfo[84, 0] = "999KK"; RankInfo[84, 1] = "풀하우스(999KK)";
            RankInfo[85, 0] = "999QQ"; RankInfo[85, 1] = "풀하우스(999QQ)";
            RankInfo[86, 0] = "999JJ"; RankInfo[86, 1] = "풀하우스(999JJ)";
            RankInfo[87, 0] = "999TT"; RankInfo[87, 1] = "풀하우스(999TT)";
            RankInfo[88, 0] = "99988"; RankInfo[88, 1] = "풀하우스(99988)";
            RankInfo[89, 0] = "99977"; RankInfo[89, 1] = "풀하우스(99977)";
            RankInfo[90, 0] = "99966"; RankInfo[90, 1] = "풀하우스(99966)";
            RankInfo[91, 0] = "99955"; RankInfo[91, 1] = "풀하우스(99955)";
            RankInfo[92, 0] = "99944"; RankInfo[92, 1] = "풀하우스(99944)";
            RankInfo[93, 0] = "99933"; RankInfo[93, 1] = "풀하우스(99933)";
            RankInfo[94, 0] = "99922"; RankInfo[94, 1] = "풀하우스(99922)";
            RankInfo[95, 0] = "888AA"; RankInfo[95, 1] = "풀하우스(888AA)";
            RankInfo[96, 0] = "888KK"; RankInfo[96, 1] = "풀하우스(888KK)";
            RankInfo[97, 0] = "888QQ"; RankInfo[97, 1] = "풀하우스(888QQ)";
            RankInfo[98, 0] = "888JJ"; RankInfo[98, 1] = "풀하우스(888JJ)";
            RankInfo[99, 0] = "888TT"; RankInfo[99, 1] = "풀하우스(888TT)";
            RankInfo[100, 0] = "88899"; RankInfo[100, 1] = "풀하우스(88899)";
            RankInfo[101, 0] = "88888"; RankInfo[101, 1] = "풀하우스(88888)";
            RankInfo[102, 0] = "88866"; RankInfo[102, 1] = "풀하우스(88866)";
            RankInfo[103, 0] = "88855"; RankInfo[103, 1] = "풀하우스(88855)";
            RankInfo[104, 0] = "88844"; RankInfo[104, 1] = "풀하우스(88844)";
            RankInfo[105, 0] = "88833"; RankInfo[105, 1] = "풀하우스(88833)";
            RankInfo[106, 0] = "88822"; RankInfo[106, 1] = "풀하우스(88822)";
            RankInfo[107, 0] = "777AA"; RankInfo[107, 1] = "풀하우스(777AA)";
            RankInfo[108, 0] = "777KK"; RankInfo[108, 1] = "풀하우스(777KK)";
            RankInfo[109, 0] = "777QQ"; RankInfo[109, 1] = "풀하우스(777QQ)";
            RankInfo[110, 0] = "777JJ"; RankInfo[110, 1] = "풀하우스(777JJ)";
            RankInfo[111, 0] = "777TT"; RankInfo[111, 1] = "풀하우스(777TT)";
            RankInfo[112, 0] = "77799"; RankInfo[112, 1] = "풀하우스(77799)";
            RankInfo[113, 0] = "77788"; RankInfo[113, 1] = "풀하우스(77788)";
            RankInfo[114, 0] = "77777"; RankInfo[114, 1] = "풀하우스(77777)";
            RankInfo[115, 0] = "77755"; RankInfo[115, 1] = "풀하우스(77755)";
            RankInfo[116, 0] = "77744"; RankInfo[116, 1] = "풀하우스(77744)";
            RankInfo[117, 0] = "77733"; RankInfo[117, 1] = "풀하우스(77733)";
            RankInfo[118, 0] = "77722"; RankInfo[118, 1] = "풀하우스(77722)";
            RankInfo[119, 0] = "666AA"; RankInfo[119, 1] = "풀하우스(666AA)";
            RankInfo[120, 0] = "666KK"; RankInfo[120, 1] = "풀하우스(666KK)";
            RankInfo[121, 0] = "666QQ"; RankInfo[121, 1] = "풀하우스(666QQ)";
            RankInfo[122, 0] = "666JJ"; RankInfo[122, 1] = "풀하우스(666JJ)";
            RankInfo[123, 0] = "666TT"; RankInfo[123, 1] = "풀하우스(666TT)";
            RankInfo[124, 0] = "66699"; RankInfo[124, 1] = "풀하우스(66699)";
            RankInfo[125, 0] = "66688"; RankInfo[125, 1] = "풀하우스(66688)";
            RankInfo[126, 0] = "66677"; RankInfo[126, 1] = "풀하우스(66677)";
            RankInfo[127, 0] = "66666"; RankInfo[127, 1] = "풀하우스(66666)";
            RankInfo[128, 0] = "66655"; RankInfo[128, 1] = "풀하우스(66655)";
            RankInfo[129, 0] = "66633"; RankInfo[129, 1] = "풀하우스(66633)";
            RankInfo[130, 0] = "66622"; RankInfo[130, 1] = "풀하우스(66622)";
            RankInfo[131, 0] = "555AA"; RankInfo[131, 1] = "풀하우스(555AA)";
            RankInfo[132, 0] = "555KK"; RankInfo[132, 1] = "풀하우스(555KK)";
            RankInfo[133, 0] = "555QQ"; RankInfo[133, 1] = "풀하우스(555QQ)";
            RankInfo[134, 0] = "555JJ"; RankInfo[134, 1] = "풀하우스(555JJ)";
            RankInfo[135, 0] = "555TT"; RankInfo[135, 1] = "풀하우스(555TT)";
            RankInfo[136, 0] = "55599"; RankInfo[136, 1] = "풀하우스(55599)";
            RankInfo[137, 0] = "55588"; RankInfo[137, 1] = "풀하우스(55588)";
            RankInfo[138, 0] = "55577"; RankInfo[138, 1] = "풀하우스(55577)";
            RankInfo[139, 0] = "55566"; RankInfo[139, 1] = "풀하우스(55566)";
            RankInfo[140, 0] = "55544"; RankInfo[140, 1] = "풀하우스(55544)";
            RankInfo[141, 0] = "55533"; RankInfo[141, 1] = "풀하우스(55533)";
            RankInfo[142, 0] = "55522"; RankInfo[142, 1] = "풀하우스(55522)";
            RankInfo[143, 0] = "444AA"; RankInfo[143, 1] = "풀하우스(444AA)";
            RankInfo[144, 0] = "444KK"; RankInfo[144, 1] = "풀하우스(444KK)";
            RankInfo[145, 0] = "444QQ"; RankInfo[145, 1] = "풀하우스(444QQ)";
            RankInfo[146, 0] = "444JJ"; RankInfo[146, 1] = "풀하우스(444JJ)";
            RankInfo[147, 0] = "444TT"; RankInfo[147, 1] = "풀하우스(444TT)";
            RankInfo[148, 0] = "44499"; RankInfo[148, 1] = "풀하우스(44499)";
            RankInfo[149, 0] = "44488"; RankInfo[149, 1] = "풀하우스(44488)";
            RankInfo[150, 0] = "44477"; RankInfo[150, 1] = "풀하우스(44477)";
            RankInfo[151, 0] = "44466"; RankInfo[151, 1] = "풀하우스(44466)";
            RankInfo[152, 0] = "44455"; RankInfo[152, 1] = "풀하우스(44455)";
            RankInfo[153, 0] = "44444"; RankInfo[153, 1] = "풀하우스(44444)";
            RankInfo[154, 0] = "44422"; RankInfo[154, 1] = "풀하우스(44422)";
            RankInfo[155, 0] = "333AA"; RankInfo[155, 1] = "풀하우스(333AA)";
            RankInfo[156, 0] = "333KK"; RankInfo[156, 1] = "풀하우스(333KK)";
            RankInfo[157, 0] = "333QQ"; RankInfo[157, 1] = "풀하우스(333QQ)";
            RankInfo[158, 0] = "333JJ"; RankInfo[158, 1] = "풀하우스(333JJ)";
            RankInfo[159, 0] = "333TT"; RankInfo[159, 1] = "풀하우스(333TT)";
            RankInfo[160, 0] = "33399"; RankInfo[160, 1] = "풀하우스(33399)";
            RankInfo[161, 0] = "33388"; RankInfo[161, 1] = "풀하우스(33388)";
            RankInfo[162, 0] = "33377"; RankInfo[162, 1] = "풀하우스(33377)";
            RankInfo[163, 0] = "33366"; RankInfo[163, 1] = "풀하우스(33366)";
            RankInfo[164, 0] = "33355"; RankInfo[164, 1] = "풀하우스(33355)";
            RankInfo[165, 0] = "33344"; RankInfo[165, 1] = "풀하우스(33344)";
            RankInfo[166, 0] = "33322"; RankInfo[166, 1] = "풀하우스(33322)";
            RankInfo[167, 0] = "222AA"; RankInfo[167, 1] = "풀하우스(222AA)";
            RankInfo[168, 0] = "222KK"; RankInfo[168, 1] = "풀하우스(222KK)";
            RankInfo[169, 0] = "222QQ"; RankInfo[169, 1] = "풀하우스(222QQ)";
            RankInfo[170, 0] = "222JJ"; RankInfo[170, 1] = "풀하우스(222JJ)";
            RankInfo[171, 0] = "222TT"; RankInfo[171, 1] = "풀하우스(222TT)";
            RankInfo[172, 0] = "22299"; RankInfo[172, 1] = "풀하우스(22299)";
            RankInfo[173, 0] = "22288"; RankInfo[173, 1] = "풀하우스(22288)";
            RankInfo[174, 0] = "22277"; RankInfo[174, 1] = "풀하우스(22277)";
            RankInfo[175, 0] = "22266"; RankInfo[175, 1] = "풀하우스(22266)";
            RankInfo[176, 0] = "22255"; RankInfo[176, 1] = "풀하우스(22255)";
            RankInfo[177, 0] = "22244"; RankInfo[177, 1] = "풀하우스(22244)";
            RankInfo[178, 0] = "22233"; RankInfo[178, 1] = "풀하우스(22233)";
            RankInfo[179, 0] = "SSSSS"; RankInfo[179, 1] = "플래쉬(SSSSS)";
            RankInfo[180, 0] = "HHHHH"; RankInfo[180, 1] = "플래쉬(HHHHH)";
            RankInfo[181, 0] = "DDDDD"; RankInfo[181, 1] = "플래쉬(DDDDD)";
            RankInfo[182, 0] = "CCCCC"; RankInfo[182, 1] = "플래쉬(CCCCC)";
            RankInfo[183, 0] = "AKQJT"; RankInfo[183, 1] = "스트레이트(AKQJT)";
            RankInfo[184, 0] = "KQJT9"; RankInfo[184, 1] = "스트레이트(KQJT9)";
            RankInfo[185, 0] = "QJT98"; RankInfo[185, 1] = "스트레이트(QJT98)";
            RankInfo[186, 0] = "JT987"; RankInfo[186, 1] = "스트레이트(JT987)";
            RankInfo[187, 0] = "T9876"; RankInfo[187, 1] = "스트레이트(T9876)";
            RankInfo[188, 0] = "98765"; RankInfo[188, 1] = "스트레이트(98765)";
            RankInfo[189, 0] = "87654"; RankInfo[189, 1] = "스트레이트(87654)";
            RankInfo[190, 0] = "76543"; RankInfo[190, 1] = "스트레이트(76543)";
            RankInfo[191, 0] = "65432"; RankInfo[191, 1] = "스트레이트(65432)";
            RankInfo[192, 0] = "5432A"; RankInfo[192, 1] = "스트레이트(5432A)";
            RankInfo[193, 0] = "AAA"; RankInfo[193, 1] = "트리플(AAA)";
            RankInfo[194, 0] = "KKK"; RankInfo[194, 1] = "트리플(KKK)";
            RankInfo[195, 0] = "QQQ"; RankInfo[195, 1] = "트리플(QQQ)";
            RankInfo[196, 0] = "JJJ"; RankInfo[196, 1] = "트리플(JJJ)";
            RankInfo[197, 0] = "TTT"; RankInfo[197, 1] = "트리플(TTT)";
            RankInfo[198, 0] = "999"; RankInfo[198, 1] = "트리플(999)";
            RankInfo[199, 0] = "888"; RankInfo[199, 1] = "트리플(888)";
            RankInfo[200, 0] = "777"; RankInfo[200, 1] = "트리플(777)";
            RankInfo[201, 0] = "666"; RankInfo[201, 1] = "트리플(666)";
            RankInfo[202, 0] = "555"; RankInfo[202, 1] = "트리플(555)";
            RankInfo[203, 0] = "444"; RankInfo[203, 1] = "트리플(444)";
            RankInfo[204, 0] = "333"; RankInfo[204, 1] = "트리플(333)";
            RankInfo[205, 0] = "222"; RankInfo[205, 1] = "트리플(222)";
            RankInfo[206, 0] = "AAKK"; RankInfo[206, 1] = "투페어(AAKK)";
            RankInfo[207, 0] = "AAQQ"; RankInfo[207, 1] = "투페어(AAQQ)";
            RankInfo[208, 0] = "AAJJ"; RankInfo[208, 1] = "투페어(AAJJ)";
            RankInfo[209, 0] = "AATT"; RankInfo[209, 1] = "투페어(AATT)";
            RankInfo[210, 0] = "AA99"; RankInfo[210, 1] = "투페어(AA99)";
            RankInfo[211, 0] = "AA88"; RankInfo[211, 1] = "투페어(AA88)";
            RankInfo[212, 0] = "AA77"; RankInfo[212, 1] = "투페어(AA77)";
            RankInfo[213, 0] = "AA66"; RankInfo[213, 1] = "투페어(AA66)";
            RankInfo[214, 0] = "AA55"; RankInfo[214, 1] = "투페어(AA55)";
            RankInfo[215, 0] = "AA44"; RankInfo[215, 1] = "투페어(AA44)";
            RankInfo[216, 0] = "AA33"; RankInfo[216, 1] = "투페어(AA33)";
            RankInfo[217, 0] = "AA22"; RankInfo[217, 1] = "투페어(AA22)";
            RankInfo[218, 0] = "KKQQ"; RankInfo[218, 1] = "투페어(KKQQ)";
            RankInfo[219, 0] = "KKJJ"; RankInfo[219, 1] = "투페어(KKJJ)";
            RankInfo[220, 0] = "KKTT"; RankInfo[220, 1] = "투페어(KKTT)";
            RankInfo[221, 0] = "KK99"; RankInfo[221, 1] = "투페어(KK99)";
            RankInfo[222, 0] = "KK88"; RankInfo[222, 1] = "투페어(KK88)";
            RankInfo[223, 0] = "KK77"; RankInfo[223, 1] = "투페어(KK77)";
            RankInfo[224, 0] = "KK66"; RankInfo[224, 1] = "투페어(KK66)";
            RankInfo[225, 0] = "KK55"; RankInfo[225, 1] = "투페어(KK55)";
            RankInfo[226, 0] = "KK44"; RankInfo[226, 1] = "투페어(KK44)";
            RankInfo[227, 0] = "KK33"; RankInfo[227, 1] = "투페어(KK33)";
            RankInfo[228, 0] = "KK22"; RankInfo[228, 1] = "투페어(KK22)";
            RankInfo[229, 0] = "QQJJ"; RankInfo[229, 1] = "투페어(QQJJ)";
            RankInfo[230, 0] = "QQTT"; RankInfo[230, 1] = "투페어(QQTT)";
            RankInfo[231, 0] = "QQ99"; RankInfo[231, 1] = "투페어(QQ99)";
            RankInfo[232, 0] = "QQ88"; RankInfo[232, 1] = "투페어(QQ88)";
            RankInfo[233, 0] = "QQ77"; RankInfo[233, 1] = "투페어(QQ77)";
            RankInfo[234, 0] = "QQ66"; RankInfo[234, 1] = "투페어(QQ66)";
            RankInfo[235, 0] = "QQ55"; RankInfo[235, 1] = "투페어(QQ55)";
            RankInfo[236, 0] = "QQ44"; RankInfo[236, 1] = "투페어(QQ44)";
            RankInfo[237, 0] = "QQ33"; RankInfo[237, 1] = "투페어(QQ33)";
            RankInfo[238, 0] = "QQ22"; RankInfo[238, 1] = "투페어(QQ22)";
            RankInfo[239, 0] = "JJTT"; RankInfo[239, 1] = "투페어(JJTT)";
            RankInfo[240, 0] = "JJ99"; RankInfo[240, 1] = "투페어(JJ99)";
            RankInfo[241, 0] = "JJ88"; RankInfo[241, 1] = "투페어(JJ88)";
            RankInfo[242, 0] = "JJ77"; RankInfo[242, 1] = "투페어(JJ77)";
            RankInfo[243, 0] = "JJ66"; RankInfo[243, 1] = "투페어(JJ66)";
            RankInfo[244, 0] = "JJ55"; RankInfo[244, 1] = "투페어(JJ55)";
            RankInfo[245, 0] = "JJ44"; RankInfo[245, 1] = "투페어(JJ44)";
            RankInfo[246, 0] = "JJ33"; RankInfo[246, 1] = "투페어(JJ33)";
            RankInfo[247, 0] = "JJ22"; RankInfo[247, 1] = "투페어(JJ22)";
            RankInfo[248, 0] = "TT99"; RankInfo[248, 1] = "투페어(TT99)";
            RankInfo[249, 0] = "TT88"; RankInfo[249, 1] = "투페어(TT88)";
            RankInfo[250, 0] = "TT77"; RankInfo[250, 1] = "투페어(TT77)";
            RankInfo[251, 0] = "TT66"; RankInfo[251, 1] = "투페어(TT66)";
            RankInfo[252, 0] = "TT55"; RankInfo[252, 1] = "투페어(TT55)";
            RankInfo[253, 0] = "TT44"; RankInfo[253, 1] = "투페어(TT44)";
            RankInfo[254, 0] = "TT33"; RankInfo[254, 1] = "투페어(TT33)";
            RankInfo[255, 0] = "TT22"; RankInfo[255, 1] = "투페어(TT22)";
            RankInfo[256, 0] = "9988"; RankInfo[256, 1] = "투페어(9988)";
            RankInfo[257, 0] = "9977"; RankInfo[257, 1] = "투페어(9977)";
            RankInfo[258, 0] = "9966"; RankInfo[258, 1] = "투페어(9966)";
            RankInfo[259, 0] = "9955"; RankInfo[259, 1] = "투페어(9955)";
            RankInfo[260, 0] = "9944"; RankInfo[260, 1] = "투페어(9944)";
            RankInfo[261, 0] = "9933"; RankInfo[261, 1] = "투페어(9933)";
            RankInfo[262, 0] = "9922"; RankInfo[262, 1] = "투페어(9922)";
            RankInfo[263, 0] = "7766"; RankInfo[263, 1] = "투페어(7766)";
            RankInfo[264, 0] = "7755"; RankInfo[264, 1] = "투페어(7755)";
            RankInfo[265, 0] = "7744"; RankInfo[265, 1] = "투페어(7744)";
            RankInfo[266, 0] = "7733"; RankInfo[266, 1] = "투페어(7733)";
            RankInfo[267, 0] = "7722"; RankInfo[267, 1] = "투페어(7722)";
            RankInfo[268, 0] = "6655"; RankInfo[268, 1] = "투페어(6655)";
            RankInfo[269, 0] = "6644"; RankInfo[269, 1] = "투페어(6644)";
            RankInfo[270, 0] = "6633"; RankInfo[270, 1] = "투페어(6633)";
            RankInfo[271, 0] = "6622"; RankInfo[271, 1] = "투페어(6622)";
            RankInfo[272, 0] = "4433"; RankInfo[272, 1] = "투페어(4433)";
            RankInfo[273, 0] = "4422"; RankInfo[273, 1] = "투페어(4422)";
            RankInfo[274, 0] = "3322"; RankInfo[274, 1] = "투페어(3322)";
            RankInfo[275, 0] = "AA"; RankInfo[275, 1] = "원페어(AA)";
            RankInfo[276, 0] = "KK"; RankInfo[276, 1] = "원페어(KK)";
            RankInfo[277, 0] = "QQ"; RankInfo[277, 1] = "원페어(QQ)";
            RankInfo[278, 0] = "JJ"; RankInfo[278, 1] = "원페어(JJ)";
            RankInfo[279, 0] = "TT"; RankInfo[279, 1] = "원페어(TT)";
            RankInfo[280, 0] = "99"; RankInfo[280, 1] = "원페어(99)";
            RankInfo[281, 0] = "88"; RankInfo[281, 1] = "원페어(88)";
            RankInfo[282, 0] = "77"; RankInfo[282, 1] = "원페어(77)";
            RankInfo[283, 0] = "66"; RankInfo[283, 1] = "원페어(66)";
            RankInfo[284, 0] = "55"; RankInfo[284, 1] = "원페어(55)";
            RankInfo[285, 0] = "44"; RankInfo[285, 1] = "원페어(44)";
            RankInfo[286, 0] = "33"; RankInfo[286, 1] = "원페어(33)";
            RankInfo[287, 0] = "22"; RankInfo[287, 1] = "원페어(22)";
            RankInfo[288, 0] = "A"; RankInfo[288, 1] = "하이카드(A)";
            RankInfo[289, 0] = "K"; RankInfo[289, 1] = "하이카드(K)";
            RankInfo[290, 0] = "Q"; RankInfo[290, 1] = "하이카드(Q)";
            RankInfo[291, 0] = "J"; RankInfo[291, 1] = "하이카드(J)";
            RankInfo[292, 0] = "T"; RankInfo[292, 1] = "하이카드(T)";
            RankInfo[293, 0] = "9"; RankInfo[293, 1] = "하이카드(9)";
            RankInfo[294, 0] = "8"; RankInfo[294, 1] = "하이카드(8)";
            RankInfo[295, 0] = "7"; RankInfo[295, 1] = "하이카드(7)";
            RankInfo[296, 0] = "6"; RankInfo[296, 1] = "하이카드(6)";
            RankInfo[297, 0] = "5"; RankInfo[297, 1] = "하이카드(5)";
            RankInfo[298, 0] = "4"; RankInfo[298, 1] = "하이카드(4)";
            RankInfo[299, 0] = "3"; RankInfo[299, 1] = "하이카드(3)";
            RankInfo[300, 0] = "2"; RankInfo[300, 1] = "하이카드(2)";
        }
        


        // 카드랭크 체크하여 리턴
        public string Check(String strParams)
        {
            String SearchRank = "", RetRank = "";
            SearchRank = strParams.Substring(1, 1);
            SearchRank = SearchRank + strParams.Substring(3, 1);
            SearchRank = SearchRank + strParams.Substring(5, 1);
            SearchRank = SearchRank + strParams.Substring(7, 1);
            SearchRank = SearchRank + strParams.Substring(9, 1);
            SearchRank = SearchRank + strParams.Substring(11, 1);
            SearchRank = SearchRank + strParams.Substring(13, 1);

            for (int iCnt=0; iCnt < RANKNUM; iCnt++)
            {
                if (SearchRank.IndexOf(RankInfo[iCnt, 0]) != -1)
                {
                    //RetRank = iCnt.ToString();
                    RetRank = RankInfo[iCnt, 1];
                    break;
                }
            }            
            return RetRank;
        }

        // 카드값 정렬
        public string SortCode(String strParams)
        {
            //int[] SortArry = new int[SortArrySize];
            //for (int iCnt = 0; iCnt < SortArrySize; iCnt++) SortArry[iCnt] = 0;

            // 전달받은 카드(코드)값 배열크기 및 초기화 (순서 = 무늬,숫자)
            int SortArrySize = strParams.Length / 2;
            String[] strTemp = new String[2] { "", "" };                       
            String[,] strSortArry = new String[SortArrySize, 2];
            for (int iCnt = 0; iCnt < SortArrySize; iCnt++) { strSortArry[iCnt, 0] = ""; strSortArry[iCnt, 1] = ""; }

            // 전달받은 카드(코드)값 배열에 저장            
            for (int iCnt = 0; iCnt < SortArrySize; iCnt++)
            {
                strSortArry[iCnt, 0] = strParams.Substring(iCnt * 2, 1);                        // 카드 코드값 중 무늬코드
                strSortArry[iCnt, 1] = _ChangeToValue(strParams.Substring((iCnt * 2) + 1, 1));  // 카드 코드값 중 숫자코드                
            }           
            
            // 카드(코드)값 갯수 만큼 루프 돌면서 정렬
            for (int iLoop = 0; iLoop < SortArrySize - 1; iLoop++)
            {
                for (int iCnt = 0; iCnt < SortArrySize - 1; iCnt++)
                {
                    if (Convert.ToInt16(strSortArry[iCnt, 1]) < Convert.ToInt16(strSortArry[iCnt + 1, 1]))  // 내림차순 정렬
                    {
                        strTemp[0] = strSortArry[iCnt, 0];
                        strTemp[1] = strSortArry[iCnt, 1];

                        strSortArry[iCnt, 0] = strSortArry[iCnt + 1, 0];
                        strSortArry[iCnt, 1] = strSortArry[iCnt + 1, 1];

                        strSortArry[iCnt + 1, 0] = strTemp[0];
                        strSortArry[iCnt + 1, 1] = strTemp[1];
                    }
                }                
            }

            // 정렬된 카드값(숫자)-배열 코드로 변환하여 리턴
            String retParam = "";
            for (int iCnt = 0; iCnt < SortArrySize; iCnt++) retParam = retParam + strSortArry[iCnt, 0] + _ChangeToCode(strSortArry[iCnt, 1]);
            return retParam;
        }

        

        // 카드코드 > 숫자 치환 overload -----------------------------------------------------------------------
        private string _ChangeToValue(string strParam)
        {
            String retStr = strParam;

            switch (strParam)
            {
                case "A": retStr = "14"; break;
                case "K": retStr = "13"; break;
                case "Q": retStr = "12"; break;
                case "J": retStr = "11"; break;
                case "T": retStr = "10"; break;
            }
            return retStr;
        }

        // 카드숫자 > 코드 치환 overload
        private string _ChangeToCode(String strParam)
        {
            String retStr = strParam;

            switch (strParam)
            {
                case "14": retStr = "A"; break;
                case "13": retStr = "K"; break;
                case "12": retStr = "Q"; break;
                case "11": retStr = "J"; break;
                case "10": retStr = "T"; break;
            }

            return retStr;
        }
    }


}
