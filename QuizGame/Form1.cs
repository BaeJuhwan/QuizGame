using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> theQuestions;
        public List<string> theSelect1;
        public List<string> theSelect2;
        public List<string> theSelect3;
        public List<string> theSelect4;
        public List<int> theAnswer;
        private void Form1_Load(object sender, EventArgs e)
        {
            theQuestions = new List<string>();
            theSelect1 = new List<string>();
            theSelect2 = new List<string>();
            theSelect3 = new List<string>();
            theSelect4 = new List<string>();
            theAnswer = new List<int>();

            theQuestions.Add("다음 중 표준어가 아닌것은?");
            theSelect1.Add("윗목");
            theSelect2.Add("윗돈");
            theSelect3.Add("위층");
            theSelect4.Add("웃옷");
            theAnswer.Add(2);

            theQuestions.Add("옥수수-강냉이");
            theSelect1.Add("친구-벗");
            theSelect2.Add("보조개-볼우물");
            theSelect3.Add("매니저-관리인");
            theSelect4.Add("소금-염화나트륨");
            theAnswer.Add(2);

            theQuestions.Add("다음 중 표준어인 것은?");
            theSelect1.Add("담쟁이덩쿨");
            theSelect2.Add("벌러지");
            theSelect3.Add("푸줏관");
            theSelect4.Add("고까옷");
            theAnswer.Add(4);

            theQuestions.Add("표기와 발음이 옳지 않는 것은?");
            theSelect1.Add("웃옷[우돋]");
            theSelect2.Add("윗잇몸[위딛몸]");
            theSelect3.Add("윗변[윋뼌]");
            theSelect4.Add("웃돈[욷똔]");
            theAnswer.Add(2);

            tName.Text = theQuestions[0];
            btn001.Text = theSelect1[0];
            btn002.Text = theSelect2[0];
            btn003.Text = theSelect3[0];
            btn004.Text = theSelect4[0];

            theCurrentIndex = 0;
            theScore = 0;
        }
        int theCurrentIndex;
        int theScore;
        private void btn001_Click(object sender, EventArgs e)
        {
            if(theCurrentIndex >= theQuestions.Count)
            {
                return;
            }
            if(theAnswer[theCurrentIndex] == 1)
            {
                theScore += 100;
            }
            theCurrentIndex++;
            if(theCurrentIndex >= theQuestions.Count)
            {
                tName.Text = String.Format("모든 문제를 다 풀었습니다. {0}점", theScore);
            }
            else
            {
                tName.Text = theQuestions[theCurrentIndex];
                btn001.Text = theSelect1[theCurrentIndex];
                btn002.Text = theSelect2[theCurrentIndex];
                btn003.Text = theSelect3[theCurrentIndex];
                btn004.Text = theSelect4[theCurrentIndex];

            }
        }
        private void ViewQusetion(int aSelect)
        {
            if(theAnswer[theCurrentIndex] == aSelect)
            {
                theScore += 100;
            }
            theCurrentIndex++;
            if (theCurrentIndex >= theQuestions.Count)
            {
                tName.Text = String.Format("모든 문제를 다 풀었습니다.{0}점", theScore);
            }
            else
            {
                tName.Text = theQuestions[theCurrentIndex];
                btn001.Text = theSelect1[theCurrentIndex];
                btn002.Text = theSelect2[theCurrentIndex];
                btn003.Text = theSelect3[theCurrentIndex];
                btn004.Text = theSelect4[theCurrentIndex];

            }
        }
        private void btn002_Click(object sender, EventArgs e)
        {
            if(theCurrentIndex >= theQuestions.Count)
            {
                return;
            }
            ViewQusetion(2);
        }

        private void btn003_Click(object sender, EventArgs e)
        {
            if (theCurrentIndex >= theQuestions.Count)
            {
                return;
            }
            ViewQusetion(3);
        }

        private void btn004_Click(object sender, EventArgs e)
        {
            if (theCurrentIndex >= theQuestions.Count)
            {
                return;
            }
            ViewQusetion(4);
        }
    }
}
