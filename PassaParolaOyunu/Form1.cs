using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassaParolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int QuestionNo = 0, TrueQuestion = 0, FalseQuestion = 0;

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessAnswer();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            btnAnswer.Enabled = false;
            btnAnswer.ForeColor = Color.Gray;
            btnAnswer.Text = "Enter tuşu devam ediniz >>";
            ProcessAnswer();
        }

        void ProcessAnswer()
        {
            if (QuestionNo > 0)
            {
                CheckAnswer();
            }
            else
            {
                NextQuestion();
            }
        }

        void CheckAnswer()
        {
            Button currentButton = null;
            string correctAnswer = string.Empty;

            switch (QuestionNo)
            {
                case 1:
                    currentButton = btnA;
                    correctAnswer = "akdeniz";
                    break;
                case 2:
                    currentButton = btnB;
                    correctAnswer = "baba";
                    break;
                case 3:
                    currentButton = btnC;
                    correctAnswer = "ceyhan";
                    break;
                case 4:
                    currentButton = btnD;
                    correctAnswer = "diyarbakır";
                    break;
                case 5:
                    currentButton = btnE;
                    correctAnswer = "edirne";
                    break;
                case 6:
                    currentButton = btnF;
                    correctAnswer = "fransa";
                    break;
                case 7:
                    currentButton = btnG;
                    correctAnswer = "gesi";
                    break;
                case 8:
                    currentButton = btnH;
                    correctAnswer = "hollanda";
                    break;
                case 9:
                    currentButton = btnI;
                    correctAnswer = "ısparta";
                    break;
                case 10:
                    currentButton = btnJ;
                    correctAnswer = "jean";
                    break;
                case 11:
                    currentButton = btnK;
                    correctAnswer = "kötü";
                    break;
                case 12:
                    currentButton = btnL;
                    correctAnswer = "leyla";
                    break;
                case 13:
                    currentButton = btnM;
                    correctAnswer = "mala";
                    break;
                case 14:
                    currentButton = btnN;
                    correctAnswer = "ney";
                    break;
                case 15:
                    currentButton = btnO;
                    correctAnswer = "osman";
                    break;
                case 16:
                    currentButton = btnP;
                    correctAnswer = "pırasa";
                    break;
                case 17:
                    currentButton = btnR;
                    correctAnswer = "ray";
                    break;
                case 18:
                    currentButton = btnS;
                    correctAnswer = "sakal";
                    break;
                case 19:
                    currentButton = btnT;
                    correctAnswer = "top";
                    break;
                case 20:
                    currentButton = btnU;
                    correctAnswer = "uçak";
                    break;
                case 21:
                    currentButton = btnV;
                    correctAnswer = "van kedisi";
                    break;
                case 22:
                    currentButton = btnY;
                    correctAnswer = "yaprak";
                    break;
                case 23:
                    currentButton = btnZ;
                    correctAnswer = "zekat";
                    break;
                case 24:
                    currentButton = btnX;
                    correctAnswer = "xamarin";
                    break;
            }

            if (tbAnswer.Text.Trim().ToLower() == correctAnswer)
            {
                currentButton.BackColor = Color.GreenYellow;
                TrueQuestion++;
                lblTrue.Text = TrueQuestion.ToString();
                lblStation.Text = "Doğru cevap";
            }
            else
            {
                currentButton.BackColor = Color.Red;
                FalseQuestion++;
                lblFalse.Text = FalseQuestion.ToString();
                lblStation.Text = "Hatalı cevap";
            }

            tbAnswer.Clear();

            if (QuestionNo == 24) 
            {
                MessageBox.Show($"Tebrikler! Oyun bitti.\n Doğru sayınız : {TrueQuestion}\n Yanlış Sayısı : {FalseQuestion}", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
            else
            {
                NextQuestion();
            }
        }

        void NextQuestion()
        {
            QuestionNo++;
            this.Text = "Soru - " + QuestionNo.ToString();

            switch (QuestionNo)
            {
                case 1:
                    richQuestion.Text = "Türkiye'nin Güney kısmındaki kıyı bölgesi?";
                    btnA.BackColor = Color.SkyBlue;
                    break;
                case 2:
                    richQuestion.Text = "Evin reisi kimdir?";
                    btnB.BackColor = Color.SkyBlue;
                    break;
                case 3:
                    richQuestion.Text = "Adanada bulunan bir nehir?";
                    btnC.BackColor = Color.SkyBlue;
                    break;
                case 4:
                    richQuestion.Text = "Karpuz ile ünlü ilimiz hangisidir?";
                    btnD.BackColor = Color.SkyBlue;
                    break;
                case 5:
                    richQuestion.Text = "Yunanistan ile sınır olan ilimiz hangisidir?";
                    btnE.BackColor = Color.SkyBlue;
                    break;
                case 6:
                    richQuestion.Text = "Eyfel Kulesi hangi ülkede bulunur?";
                    btnF.BackColor = Color.SkyBlue;
                    break;
                case 7:
                    richQuestion.Text = "... bağlarında dolanıyorum\r\nYitirdim yârimi, aman aranıyorum\r\nYitirdim yârimi, aman aranıyorum\n\n şarkısında noktalı yere gelecek kelime nedir?";
                    btnG.BackColor = Color.SkyBlue;
                    break;
                case 8:
                    richQuestion.Text = "Dünyadaki yüz ölçümü Konya ilimiz kadar olup da tarım olarak en gelişmiş ülke hangisidir?";
                    btnH.BackColor = Color.SkyBlue;
                    break;
                case 9:
                    richQuestion.Text = "Gülleri ile meşhur ilimiz hangisidir?";
                    btnI.BackColor = Color.SkyBlue;
                    break;
                case 10:
                    richQuestion.Text = "Kot kelimesinin ingilizce karşılığı endir?";
                    btnJ.BackColor = Color.SkyBlue;
                    break;
                case 11:
                    richQuestion.Text = "İyi olmayan birine ne denir?";
                    btnK.BackColor = Color.SkyBlue;
                    break;
                case 12:
                    richQuestion.Text = "Mecnun'un sevip de kavuşamadığı karakterin ismi nedir?";
                    btnL.BackColor = Color.SkyBlue;
                    break;
                case 13:
                    richQuestion.Text = "\"Hiç bir işe yarama zaten. Anca inşaatta ... vur\" cümlesinde vurulması gereken nedir?";
                    btnM.BackColor = Color.SkyBlue;
                    break;
                case 14:
                    richQuestion.Text = "Dini musikisinde en çok kullanılan üflemeli çalgı müzik aleti nedir?";
                    btnN.BackColor = Color.SkyBlue;
                    break;
                case 15:
                    richQuestion.Text = "\"Yediğin paralar nerdeler ...\" noktalı yere gelecek isim nedir?";
                    btnO.BackColor = Color.SkyBlue;
                    break;
                case 16:
                    richQuestion.Text = "Temel Reis'in yiyip de kuvvet aldığı bitki nedir?";
                    btnP.BackColor = Color.SkyBlue;
                    break;
                case 17:
                    richQuestion.Text = "Trenlerin üzerinde gittiği yollara ne denir?";
                    btnR.BackColor = Color.SkyBlue;
                    break;
                case 18:
                    richQuestion.Text = "Ergenlik çağından sonra erkeklerde çene altında yeşerekn kıllara verilen isim nedir?";
                    btnS.BackColor = Color.SkyBlue;
                    break;
                case 19:
                    richQuestion.Text = "İlk okulda bize öğretilen Ali neyi tutuyordu. 3 harli bir kelime ile yaz?";
                    btnT.BackColor = Color.SkyBlue;
                    break;
                case 20:
                    richQuestion.Text = "Hava yolunda genellikle yolcu taşımak için kullanılan hava taşıtı nedir?";
                    btnU.BackColor = Color.SkyBlue;
                    break;
                case 21:
                    richQuestion.Text = "Türkiyedeki en büyük gölün ismi nedir?";
                    btnV.BackColor = Color.SkyBlue;
                    break;
                case 22:
                    richQuestion.Text = "Ağaçların kışın dökmüş olduğu bitki nedir?";
                    btnY.BackColor = Color.SkyBlue;
                    break;
                case 23:
                    richQuestion.Text = "İslam dininde parası olan bir kişinin islamın şartlarından yapması gereken görevlerden biridir.";
                    btnZ.BackColor = Color.SkyBlue;
                    break;
                case 24:
                    richQuestion.Text = "Microsoft'un C# dili kullanılarak mobil programlama kodlama framework'üne ne isim verilir.?";
                    btnX.BackColor = Color.SkyBlue;
                    break;
                default:
                    break;
            }
        }

        void ResetGame()
        {
            QuestionNo = 0;
            TrueQuestion = 0;
            FalseQuestion = 0;
            lblTrue.Text = "0";
            lblFalse.Text = "0";
            tbAnswer.Clear();
            richQuestion.Clear();
        }
    }
}
