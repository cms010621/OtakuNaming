using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        string months;
        string days;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void day27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void day24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void day22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (month1.Checked)
                months = "츠키노(달의)";
            else if (month2.Checked)
                months = "아이노(사랑의)";
            else if (month3.Checked)
                months = "소라노(하늘의)";
            else if (month4.Checked)
                months = "미즈노(물의)";
            else if (month5.Checked)
                months = "하나노(꽃의)";
            else if (month6.Checked)
                months = "우츄-우노(우주의)";
            else if (month7.Checked)
                months = "타이요오노(태양의)";
            else if (month8.Checked)
                months = "호시노(별의)";
            else if (month9.Checked)
                months = "오오모리노(숲의)";
            else if (month10.Checked)
                months = "카케노(그림자의)";
            else if (month11.Checked)
                months = "텐노(천국의)";
            else if (month12.Checked)
                months = "유키노(눈의)";


            if (day1.Checked)
                days = "카케라(파편)";
            else if (day2.Checked)
                days = "텐시(천사)";
            else if (day3.Checked)
                days = "나미다(눈물)";
            else if (day4.Checked)
                days = "차카시(증거)";
            else if (day5.Checked)
                days = "유메(꿈)";
            else if (day6.Checked)
                days = "코코로(마음)";
            else if (day7.Checked)
                days = "시즈쿠(물방울)";
            else if (day8.Checked)
                days = "요-오세이(요정)";
            else if (day9.Checked)
                days = "온가쿠(음악)";
            else if (day10.Checked)
                days = "히카리(빛)";
            else if (day11.Checked)
                days = "사메(상어)";
            else if (day12.Checked)
                days = "켓쇼오(결정)";
            else if (day13.Checked)
                days = "사사야키(속삭임)";
            else if (day14.Checked)
                days = "오츠케(신탁)";
            else if (day15.Checked)
                days = "오마지나이(주문)";
            else if (day16.Checked)
                days = "이츠와리(사기꾼)";
            else if (day17.Checked)
                days = "이노리(기도)";
            else if (day18.Checked)
                days = "네코(고양이)";
            else if (day19.Checked)
                days = "미치시루베(안내자)";
            else if (day20.Checked)
                days = "쿠마(곰)";
            else if (day21.Checked)
                days = "호고샤(보호자)";
            else if (day21.Checked)
                days = "마호(마법)";
            else if (day22.Checked)
                days = "타카라(보물)";
            else if (day23.Checked)
                days = "타마시이(영혼)";
            else if (day24.Checked)
                days = "요오카이(여괴)";
            else if (day25.Checked)
                days = "키츠네(여우)";
            else if (day26.Checked)
                days = "오오카미(늑대)";
            else if (day27.Checked)
                days = "츠바사(날개)";
            else if (day28.Checked)
                days = "오미야게(선물)";
            else if (day29.Checked)
                days = "카이토오(괴도)";
            else if (day30.Checked)
                days = "히카이샤(지배자)";
            else if (day31.Checked)
                days = "카케라(파편)";

            MessageBox.Show(months+" "+days,"결과");
        }
    }
}
